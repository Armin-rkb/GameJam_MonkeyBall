using UnityEngine;
using System.Collections;

public class BallCollision : MonoBehaviour
{
    private GameObject _ball;

    void Start()
    {
        _ball = GameObject.Find("Ball");
    }

    public virtual void BallHit()
    {
        print("BallFOund");
    }

    void OnTriggerEnter(Collider other)
    {
        if (_ball != null)
        {
            BallHit();
        }
    }
}
