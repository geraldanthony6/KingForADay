using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeTroop : MonoBehaviour
{
    [SerializeField]private bool _isBeingDeployed;
    // Start is called before the first frame update
    void Start()
    {
        _isBeingDeployed = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(_isBeingDeployed){
            Vector2 position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(position);
            transform.position = new Vector2(worldPosition.x, worldPosition.y);
        }  
    }

    private void OnMouseDown() {
        if(_isBeingDeployed){
            Vector2 position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(position);
            transform.position = new Vector2(worldPosition.x, worldPosition.y);
            _isBeingDeployed = false;
        }
    }
}
