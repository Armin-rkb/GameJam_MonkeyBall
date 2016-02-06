using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RescueCounter : MonoBehaviour
{
    [SerializeField] private Text rescueUIText;
    public int maxPickups;
    public int currentPickups;
	
	void Update ()
    {
        SetRescueCount();
	}

    void SetRescueCount()
    {
        rescueUIText.text = "Rescued: " + currentPickups + " / " + maxPickups;
    }
}
