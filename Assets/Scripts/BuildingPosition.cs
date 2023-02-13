using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingPosition : MonoBehaviour
{
    [SerializeField]private BuildingManager _buildingManager;
    [SerializeField]private SpriteRenderer _spriteRenderer;
    [SerializeField]private Color _baseColor;
    [SerializeField]private Color _hoverColor;
    private bool _isBeingPlaced = true;
    private bool _builtOn = false;
    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.color = _baseColor;
    }

    // Update is called once per frame
    void Update()
    {
        if(_isBeingPlaced){
            Vector2 position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(position);
            transform.position = new Vector2(worldPosition.x, worldPosition.y);
        } 
    }

    private void OnMouseOver() {
        if(!_builtOn){
            _spriteRenderer.color = _hoverColor;
        }
    }

    private void OnMouseExit() {
        _spriteRenderer.color = _baseColor;
    }

    private void OnMouseDown() {
        if(BuildingManager.Instance.GetBuildingState() == BuildingManager.State.SELECTING && 
        !_builtOn && 
        !_isBeingPlaced && 
        PlayerStatsManager.Instance.GetCurrentBuildingAmount() < PlayerStatsManager.Instance.GetCurrentMaxBuildingAmount()){

            Debug.Log("Place Building");
            Instantiate(BuildingManager.Instance.GetCurrentSelectedBuilding(), transform.position, Quaternion.identity);
            _builtOn = true;
            PlayerStatsManager.Instance.GoldUpdate(-20);
            PlayerStatsManager.Instance.BuildingAmountUpdate();
            // Collider2D tmpCollider = GetComponent<BoxCollider2D>();
            // tmpCollider.enabled = false;

        } else if(BuildingManager.Instance.GetBuildingState() == BuildingManager.State.SELECTING && _builtOn){

            Debug.Log("Built On");

        } else if(!_isBeingPlaced){

            Debug.Log("Select a building");

        } else if(_isBeingPlaced){

            Vector2 position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(position);
            transform.position = new Vector2(worldPosition.x, worldPosition.y);
            _isBeingPlaced = false;

        }
    }
}
