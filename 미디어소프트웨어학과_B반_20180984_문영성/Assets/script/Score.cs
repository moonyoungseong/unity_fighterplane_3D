using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text BOSS;
    static public int HP;
    void Start()
    {
        HP = 1000;
    }

    void Update()
    {
        BOSS.text="BOSS HP=" + HP;
    }
}
