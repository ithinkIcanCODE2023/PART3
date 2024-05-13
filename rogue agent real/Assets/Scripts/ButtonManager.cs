using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Resume;
    public GameObject Restart;
    public GameObject Quit;
    void Start()
    {
       Button resButt = Resume.GetComponent<Button>();
        resButt.onClick.AddListener(StartClick);
        Button tartButt = Restart.GetComponent<Button>();
        tartButt.onClick.AddListener(RestartClick);
        Button quitButt = Quit.GetComponent<Button>();
        tartButt.onClick.AddListener(QuitClick);

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.T))
        {
            StartClick();
        }






    }
    void StartClick()
    {
        bool isActive = Resume.activeSelf; // this just checks if its active and tores it as a bool
        Resume.SetActive(!isActive); // this should toggle it bc its like if its the opposite
        bool isActive2 = Restart.activeSelf; // this just checks if its active and tores it as a bool
        Restart.SetActive(!isActive2); // this should toggle it bc its like if its the opposite 
        bool isActive3 = Quit.activeSelf; // this just checks if its active and tores it as a bool
        Quit.SetActive(!isActive3); // this should toggle it bc its like if its the opposite 
    }
    void RestartClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void QuitClick()
    {
        Application.Quit();
    }
}
