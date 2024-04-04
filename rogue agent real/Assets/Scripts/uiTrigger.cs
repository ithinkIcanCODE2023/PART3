using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class uiTrigger : MonoBehaviour
{
    public TMP_Text messageText;
    public GameObject panel; // its the panel!
    public GameObject sovietStar; //add more as needed for more objects
    string text1;
    string text2;
    string text3;
    string text4;
    string text5;
    string text6;
    string text7;
    string text8;

    // Start is called before the first frame update
    void Start()
    {
        text1 = ("Good, comrade. You have broken into the facility. make sure you don’t stand out among the scientists. Search the nearby rooms for a keycard.");
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
        if (Input.GetKeyDown(KeyCode.L))
        {
            messageText.SetText(text1);
        }
    }



    public void panelSwitch(GameObject panel1)
    {
        bool isActive = panel1.activeSelf; // this just checks if its active and tores it as a bool
        panel1.SetActive(!isActive); // this should toggle it bc its like if its the opposite

    }
}