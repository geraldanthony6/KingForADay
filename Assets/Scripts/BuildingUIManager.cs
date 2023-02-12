using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BuildingUIManager : MonoBehaviour
{
    public static BuildingUIManager Instance{get; private set;}

    public event EventHandler OnShopBought;
    public event EventHandler OnBarracksBought;
    public event EventHandler OnFarmBought;
    public event EventHandler OnSpaceBought;
    [SerializeField]private Button[] _buildShopBtns;
    

    private void Awake() {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        _buildShopBtns[0].onClick.AddListener(BuildShop);
        _buildShopBtns[1].onClick.AddListener(BuildBarracks);
        _buildShopBtns[2].onClick.AddListener(BuildFarm);
        _buildShopBtns[3].onClick.AddListener(AddBuildSpace);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BuildShop(){
        Debug.Log("Select Shop Building Location");
        OnShopBought?.Invoke(this, EventArgs.Empty);
    }

    void BuildBarracks(){
        Debug.Log("Select Barracks Building Location");
        OnBarracksBought?.Invoke(this, EventArgs.Empty);
    }

    void BuildFarm(){
        Debug.Log("Select Farm Building Location");
        OnFarmBought?.Invoke(this, EventArgs.Empty);
    }

    void AddBuildSpace(){
        OnSpaceBought?.Invoke(this, EventArgs.Empty);
    }
}
