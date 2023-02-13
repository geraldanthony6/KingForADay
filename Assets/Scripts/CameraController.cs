using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]private Camera _cam;
    [SerializeField]private float _camSpeed;
    [SerializeField]private float _maxCamSize;
    [SerializeField]private float _minCamSize;
    private int _heightCap;
    private int _sideCap;
    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal") * _camSpeed * Time.deltaTime;
        float  Vertical = Input.GetAxisRaw("Vertical") * _camSpeed * Time.deltaTime;

        transform.Translate(Horizontal, Vertical, 0);

        if(Input.GetKey(KeyCode.Q)){
            if(_cam.orthographicSize < _maxCamSize){
                _cam.orthographicSize += 1f;
            }
            
        }       

        if(Input.GetKey(KeyCode.E)){
            if(_cam.orthographicSize > _minCamSize){
                _cam.orthographicSize -= 1f;
            }
        }
    }
}
