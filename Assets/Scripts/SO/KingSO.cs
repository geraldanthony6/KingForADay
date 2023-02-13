using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "KingStats", menuName = "King")]
public class KingSO : ScriptableObject
{
    public string kingName;
    public Image pucture;
    public float wealth;
    public float giving;
    public float strength;
    public float greed;
    public float glutton;
    public float coward;

    
}
