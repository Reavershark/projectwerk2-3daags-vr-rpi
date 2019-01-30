using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noclip : MonoBehaviour {

    public GameObject teleportField;
    public GameObject enabledText;
    
    public void Enable()
    {
        teleportField.SetActive(true);
        
        enabledText.GetComponent<UnityEngine.UI.Text>().text = "Enabled";
    }

    public void Disable()
    {
        teleportField.SetActive(false);
        enabledText.GetComponent<UnityEngine.UI.Text>().text = "Disabled";
    }
}