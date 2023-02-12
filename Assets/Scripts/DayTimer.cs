using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DayTimer : MonoBehaviour
{
    [SerializeField]private float _gameTimer;
    [SerializeField]private TextMeshProUGUI _timerText;
    // Start is called before the first frame update
    void Start()
    {
      _gameTimer = 24f;  
    }

    // Update is called once per frame
    void Update()
    {
        _gameTimer -= Time.deltaTime / 10f;
        _timerText.text = "Timer: " + (int)Mathf.Ceil(_gameTimer);
    }
}
