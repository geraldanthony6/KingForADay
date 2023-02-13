using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalTroopHandler : MonoBehaviour
{
    public static GlobalTroopHandler Instance {get; set;}

    public event EventHandler OnMeleeTroopBought;

    [SerializeField]private List<GameObject> _troopList;
    [SerializeField]private TextMeshProUGUI _meleeTroopText;
    [SerializeField]private Button _deployMeleeTroopBtn;
    private void Awake() {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        _deployMeleeTroopBtn.onClick.AddListener(DeployMeleeTroop);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddTroop(GameObject troop){
        _troopList.Add(troop);
        _meleeTroopText.text = "x" + _troopList.Count;
    }

    public GameObject GetTroop(int index){
        return _troopList[index];
    }

    public int GetTroopListCount(){
        return _troopList.Count;
    }

    public void RemoveTroop(int index){
        _troopList.Remove(_troopList[index]);
        _meleeTroopText.text = "x" + _troopList.Count;
    }




    void DeployMeleeTroop(){
        OnMeleeTroopBought?.Invoke(this, EventArgs.Empty);
    }
}
