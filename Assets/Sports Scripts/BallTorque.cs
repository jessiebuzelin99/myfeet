using UnityEngine;

public class BowlingBallController : MonoBehaviour
{
    public float torqueForce = 20f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 torque = new Vector3(vertical, 0, -horizontal) * torqueForce;

        rb.AddTorque(torque, ForceMode.Force);
    }
}