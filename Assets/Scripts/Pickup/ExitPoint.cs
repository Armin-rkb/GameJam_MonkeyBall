using UnityEngine;
using System.Collections;

public class ExitPoint : BallCollision
{
    [SerializeField] private GameObject victoryImage;

    public override void BallHit()
    {
        base.BallHit();

        GameObject _rescueText = GameObject.Find("RescueText");
        RescueCounter _rescueScript = _rescueText.GetComponent<RescueCounter>();

        if (_rescueScript.currentPickups != _rescueScript.maxPickups)
        {
            print("Not enough people rescued!");
        }

        else
        {
            print("You Win!!");
            victoryImage.SetActive(true);
            Time.timeScale = 0;
        }
    }
}