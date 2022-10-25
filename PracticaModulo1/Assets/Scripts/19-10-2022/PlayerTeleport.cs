using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : PlayerTrigger
{
    public Transform TargetPosition;

    public override void OnPlayerEnter(GameObject playerObject)
    {
        playerObject.transform.position = TargetPosition.position;
    }
}