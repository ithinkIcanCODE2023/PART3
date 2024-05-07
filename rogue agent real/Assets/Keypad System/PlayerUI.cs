using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerUI : MonoBehaviour
{

    public GameObject GameOver;
    // Start is called before the first frame update
    void Start()
    {
       GameOver.transform.position = new Vector3(9999,9999,9999);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


    public void lose()
    {
        GameOver.transform.position = new Vector3(300, 300, 300);
    }
}
