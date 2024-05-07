using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class CameraCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerUI ui = other.transform.GetComponent<PlayerUI>();
        if (ui)
        {
            FirstPersonController fpsc = other.transform.GetComponent<FirstPersonController>();
            fpsc.catched();
            ui.lose();
        }
    }
}
