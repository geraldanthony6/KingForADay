using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DayTimer : MonoBehaviour
{
  public static  DayTimer Instance{get; set;}

  public event EventHandler OnDayChange;

    [SerializeField]private float _gameTimer;
    [SerializeField]private TextMeshProUGUI _timerText;
    [SerializeField]private TextMeshProUGUI _dayNumberText;
    private int _dayCounter;

    private void Awake() {
      Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
      _gameTimer = 24f;  
      _dayCounter = 1;
      _dayNumberText.text = "Day: " + _dayCounter;
    }

    // Update is called once per frame
    void Update()
    {
        _gameTimer -= Time.deltaTime;
        _timerText.text = "Timer: " + (int)Mathf.Ceil(_gameTimer);

        if(_gameTimer <= 0){
          _dayCounter++;
          _dayNumberText.text = "Day: " + _dayCounter;
          OnDayChange?.Invoke(this, EventArgs.Empty);
          _gameTimer = 24f;
        }
    }
}
