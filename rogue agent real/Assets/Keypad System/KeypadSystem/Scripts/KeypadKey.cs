using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadKey : MonoBehaviour
{
    public string key;
    public bool card;
    public bool power;
    public GameObject[] GuardsAndCams; 
    
    public void SendKey()
    {
        if (!power)
        {
            this.transform.GetComponentInParent<KeypadController>().PasswordEntry(key);
        }
        if (card)
        {
            this.transform.position = new Vector3(0,0,0);
        }
        if (power)
        {
            RenderSettings.ambientIntensity = 0f;
            RenderSettings.reflectionIntensity = 0f;
            for (int i = 0; i < GuardsAndCams.Length; i++)
            {
                GuardMovement comp = GuardsAndCams[i].GetComponent<GuardMovement>();
                if (comp)
                {
                    comp.stopSpeed();
                } else
                {
                    GuardsAndCams[i].transform.GetChild(1).gameObject.transform.position = new Vector3(999999, 999999, 999999);
                }
            }
        }
    }
}
