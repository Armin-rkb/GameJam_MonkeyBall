using UnityEngine;
using System.Collections;
using Leap;

public class PlayerController : MonoBehaviour
{
    private Controller controller;
    public float rotatePower;
    [SerializeField] private Rigidbody _rb;
    
    private Frame CurrentFrame
    {
        get { return (IsReady) ? controller.Frame() : null; }
    }

    private HandList Hands
    {
        get { return (CurrentFrame != null && CurrentFrame.Hands.Count > 0) ? CurrentFrame.Hands : null; }
    }

    private bool IsReady
    {
        get { return (controller != null && controller.Devices.Count > 0 && controller.IsConnected); }
    }

    void Awake ()
    {
        controller = new Controller();
	}

    void FixedUpdate()
    {
        Hand mainHand;
        if (!IsReady || Hands == null)
        {
            transform.rotation = Quaternion.Euler(Input.GetAxis("Vertical") * rotatePower, 0 * rotatePower, -Input.GetAxis("Horizontal") * rotatePower);
        }

        else
        {
            mainHand = Hands.Frontmost;
            /*
            float y = -mainHand.Direction.y * rotatePower;
            float x = -mainHand.Direction.x * rotatePower;
            float z = -mainHand.Direction.z * rotatePower;
            //Rotate the object.
            _rb.AddTorque(y, z, x);
            */
            transform.rotation = Quaternion.Euler(-mainHand.Direction.Pitch * rotatePower, -mainHand.Direction.Yaw * rotatePower, mainHand.PalmNormal.Roll * rotatePower);
        }
    }
}
