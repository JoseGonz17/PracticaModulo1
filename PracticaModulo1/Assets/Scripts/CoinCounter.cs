using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : PlayerTrigger
{
    public int currentNumberOfCoins;

    public Text coinText;

    public void GetCoins(int cointAmount)
    {
        currentNumberOfCoins += cointAmount;

        if (coinText != null)
        {
            coinText.text = currentNumberOfCoins.ToString();
        }
        Debug.Log("he recogido una moneda, ahora tengo: " + currentNumberOfCoins + " monedas, necesito tener 6 para abrir la puerta negra");
    }
}
