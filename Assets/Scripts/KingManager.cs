using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingManager : MonoBehaviour
{
    public static KingManager Instance {get; set;}
    [SerializeField]private King _curKing;
    [SerializeField]private King[] _poolOfKings;

    private void Awake() {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        DayTimer.Instance.OnDayChange += DayTimer_OnDayChange;
        _curKing = _poolOfKings[UnityEngine.Random.Range(0, _poolOfKings.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public King GetCurKing(){
        return _curKing;
    }

    private void UpdateKing(){
        _curKing = _poolOfKings[UnityEngine.Random.Range(0, _poolOfKings.Length)];
    }

    private void DayTimer_OnDayChange(object sender, EventArgs e){
        UpdateKing();
    }
}
