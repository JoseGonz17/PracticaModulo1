using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public int currentNumberOfCoin;

    public void GetCoins(int cointAmount)
    {
        currentNumberOfCoin += cointAmount;
        Debug.Log("Ahora tengo " + currentNumberOfCoin + " monedas");
    }
}