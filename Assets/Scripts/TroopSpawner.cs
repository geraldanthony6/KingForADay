using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroopSpawner : MonoBehaviour
{
    [SerializeField]private GameObject _meleeTroopPrefab;
    // Start is called before the first frame update
    void Start()
    {
        GlobalTroopHandler.Instance.OnMeleeTroopBought += GlobalTroopHandler_OnMeleeTroopBought;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GlobalTroopHandler_OnMeleeTroopBought(object sender, EventArgs e){
        
        if(GlobalTroopHandler.Instance.GetTroopListCount() > 0){
            Instantiate(GlobalTroopHandler.Instance.GetTroop(0), transform.position, Quaternion.identity);
            GlobalTroopHandler.Instance.RemoveTroop(0);
        }

    }
}
