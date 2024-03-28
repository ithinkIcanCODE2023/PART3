using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipTest : MonoBehaviour
{
    public float speed = 10f;
    private float upMovement;
    public float RotateVal;
    private float sideMovement;
    private float yaw;
    private float throttle;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        upMovement = Input.GetAxis("Vertical");
        sideMovement = Input.GetAxis("Horizontal");
        throttle = Input.GetAxis("Fire1");
        yaw = Input.GetAxis("Fire2");

        rb.AddRelativeForce(Vector3.up * Time.deltaTime * speed * throttle, ForceMode.VelocityChange);
        transform.Rotate(Vector3.right * upMovement * Time.deltaTime * RotateVal, Space.Self); //rotates palane up or down
        transform.Rotate(Vector3.up * -sideMovement * Time.deltaTime * RotateVal, Space.Self); //rolls p-lane left to right
        transform.Rotate(Vector3.forward * yaw * Time.deltaTime * RotateVal, Space.Self);
    }
}
