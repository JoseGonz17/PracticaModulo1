using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : CoinCounter
{
    public GameObject puerta1, puerta2, puerta3, puerta4, puerta5;

    void Update() 
    {
        if (currentNumberOfCoins == 1)
        {
            Destroy(puerta1,0);
        }
        if (currentNumberOfCoins == 2)
        {
            Destroy(puerta2, 0);
        }
        if (currentNumberOfCoins == 3)
        {
            Destroy(puerta3, 0);
        }
        if (currentNumberOfCoins == 4)
        {
            Destroy(puerta4, 0);
        }
        if (currentNumberOfCoins == 5)
        {
            Destroy(puerta5, 0);
        }
    }


}
