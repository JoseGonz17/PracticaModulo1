using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthMaker : PlayerTrigger
{
    public int healthmaker = 1;

    public override void OnPlayerEnter(GameObject playerObject)
    {
        PlayerHealth health = playerObject.GetComponent<PlayerHealth>();
        health.TakeHealth(healthmaker);

    }
}
