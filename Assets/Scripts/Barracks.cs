using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barracks : MonoBehaviour
{
    [SerializeField]private Button _buyTroopBtn;
    [SerializeField]private GameObject _meleeTroopPrefab;
    [SerializeField]private GameObject _shopUI;
    private bool _uiOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        _buyTroopBtn.onClick.AddListener(BuyTroop);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BuyTroop(){
        GlobalTroopHandler.Instance.AddTroop(_meleeTroopPrefab);
    }

    private void OnMouseDown() {
        if(!_uiOpen){
            _shopUI.SetActive(true);
            _uiOpen = true;
        } else{
            _shopUI.SetActive(false);
            _uiOpen = false;
        }
    }
}
