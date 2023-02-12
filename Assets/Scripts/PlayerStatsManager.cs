using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStatsManager : MonoBehaviour
{
    public static PlayerStatsManager Instance{get; private set;}
    const int STARTING_GOLD_AMOUNT = 100;
    const int STARTING_BUILDING_AMOUNT = 3;
    [SerializeField]private int _goldAmount;
    [SerializeField]private int _currentBuildingAmount;
    [SerializeField]private int _currentMaxBuildingAmount;
    [SerializeField]private TextMeshProUGUI _goldText; 
    [SerializeField]private TextMeshProUGUI _buildingAmountText; 


    private void Awake() {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        _goldAmount = STARTING_GOLD_AMOUNT;
        _currentBuildingAmount = 0;
        _currentMaxBuildingAmount = STARTING_BUILDING_AMOUNT;
        _goldText.text = "Gold: " + _goldAmount;
        _buildingAmountText.text = "Buildings: " + _currentBuildingAmount + "/" + _currentMaxBuildingAmount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoldUpdate(int goldToAdd){
        _goldAmount += goldToAdd;
        _goldText.text = "Gold: " + _goldAmount;
    }

    public void BuildingAmountUpdate(){
        _currentBuildingAmount += 1;
        _buildingAmountText.text = "Buildings: " + _currentBuildingAmount + "/" + _currentMaxBuildingAmount;
    }

    public int GetCurrentBuildingAmount(){
        return _currentBuildingAmount;
    }

    public int GetCurrentMaxBuildingAmount(){
        return _currentMaxBuildingAmount;
    }
}
