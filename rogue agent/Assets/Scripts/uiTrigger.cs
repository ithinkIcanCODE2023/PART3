using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiTrigger : MonoBehaviour
{
    public GameObject panel; // its the panel!
    public GameObject sovietStar; //add more as needed for more objects

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           panelSwitch(panel);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            panelSwitch(sovietStar);
        }
        //these keypress things are just to test that it works, feel free to delete if you want in the future
    }
    


    public void panelSwitch(GameObject panel1)
    {
        bool isActive = panel1.activeSelf; // this just checks if its active and tores it as a bool
        panel1.SetActive(!isActive); // this should toggle it bc its like if its the opposite
        
    }
}
