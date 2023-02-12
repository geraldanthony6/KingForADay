using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelHandler : MonoBehaviour
{
    [SerializeField]private GameObject[] _panels;
    [SerializeField]private Button[] _panelBtns;
    [SerializeField]private GameObject _activePanel;
    // Start is called before the first frame update
    void Start()
    {
        _panelBtns[0].onClick.AddListener(OpenBuildPanel);
        _panelBtns[1].onClick.AddListener(OpenTroopPanel);
        _panelBtns[2].onClick.AddListener(OpenGeneralPanel);
        _panelBtns[3].onClick.AddListener(OpenGeneralPanel);
    }

    void OpenBuildPanel(){
        _panels[0].gameObject.SetActive(false);
        _panels[1].gameObject.SetActive(true);
        _activePanel = _panels[1].gameObject;
    }

    void OpenTroopPanel(){
        _panels[0].gameObject.SetActive(false);
        _panels[2].gameObject.SetActive(true);
        _activePanel = _panels[2].gameObject;
    }

    void OpenGeneralPanel(){
        _panels[0].gameObject.SetActive(true);
        _activePanel.SetActive(false);
        _activePanel = null;
    }
}
