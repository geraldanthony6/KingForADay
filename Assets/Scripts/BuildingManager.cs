using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    public static BuildingManager Instance {get; set;}

    public enum State{
        NONE,
        SELECTING,
        BUILDING
    }

    private State _curState;
    [SerializeField]private List<Transform> _buildPositionList;
    [SerializeField]private List<GameObject> _buildingList;
    [SerializeField]private GameObject _buildingPlace;
    [SerializeField]private GameObject _curBuildingSelected;
    [SerializeField]private GameObject _curSelectedBuildingPlacer;
    
    private void Awake() {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        _curState = State.NONE;
        BuildingUIManager.Instance.OnShopBought += BuildingUIManager_OnShopBought;
        BuildingUIManager.Instance.OnBarracksBought += BuildingUIManager_OnBarracksBought;
        BuildingUIManager.Instance.OnFarmBought += BuildingUIManager_OnFarmBought;
        BuildingUIManager.Instance.OnSpaceBought += BuildingUIManager_OnSpaceBought;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public State GetBuildingState(){
        return _curState;
    }

    public void SetBuildingState(State newState){
        _curState = newState;
    }

    public GameObject GetCurrentSelectedBuilding(){
        return _curBuildingSelected;
    }

    void BuildingUIManager_OnShopBought(object sender, EventArgs e){
        _curState = State.SELECTING;
        _curBuildingSelected = _buildingList[0];
    }

    void BuildingUIManager_OnBarracksBought(object sender, EventArgs e){
        _curState = State.SELECTING;
        _curBuildingSelected = _buildingList[1];
    }

    void BuildingUIManager_OnFarmBought(object sender, EventArgs e){
        _curState = State.SELECTING;
        _curBuildingSelected = _buildingList[2];
    }

    void BuildingUIManager_OnSpaceBought(object sender, EventArgs e){
        
        _curSelectedBuildingPlacer = Instantiate(_buildingPlace, transform.position, Quaternion.identity);
    }

    
}
