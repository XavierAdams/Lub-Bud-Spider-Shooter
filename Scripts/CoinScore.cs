using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour
{
    public Text coinstxt;
    public PlayerMovement coins;
    public void Start()
    {
        coins.CoinSR = 0;
    }
     void Update()
    {
        coinstxt.text = "COINS " + coins.CoinSR * 10;
    }
}
