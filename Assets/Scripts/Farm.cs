using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm : MonoBehaviour
{
    [SerializeField]private float _foodProduced;
    [SerializeField]private float _timer;
    [SerializeField]private int _timerCooldown;
    [SerializeField]private GameObject _shopUI;
    private bool _uiOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        _timer = _timerCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        _timer -= Time.deltaTime;
        if(_timer <= 0){
            Debug.Log("Add Food");
            _timer = _timerCooldown;
        }
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
