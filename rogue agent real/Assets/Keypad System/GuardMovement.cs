using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardMovement : MonoBehaviour
{

    public GameObject[] movepoints;

    public float speed;

    private int cur = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (speed == 0)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 50);
            return;
        }

        if (transform.position == movepoints[cur].transform.position)
        {
            cur = cur + 1;
            if (cur >= movepoints.Length)
            {
                cur = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, movepoints[cur].transform.position, speed * Time.deltaTime);
        transform.forward = movepoints[cur].transform.position - transform.position;
    }

    public void stopSpeed()
    {
        speed = 0;
    }
}
