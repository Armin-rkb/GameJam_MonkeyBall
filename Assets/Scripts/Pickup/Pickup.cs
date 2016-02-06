using UnityEngine;
using System.Collections;

public class Pickup : BallCollision
{
    public override void BallHit()
    {
        base.BallHit();
        GameObject.Find("RescueText").GetComponent<RescueCounter>().currentPickups++;
        Destroy(this.gameObject);
    }
}
