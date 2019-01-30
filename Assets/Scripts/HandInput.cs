using UnityEngine;
using HTC.UnityPlugin.Vive;
public class HandInput : MonoBehaviour
{
    public GameObject trackedCamera;

    private void Update()
    {
        if (ViveInput.GetPressDown(HandRole.RightHand, ControllerButton.Menu))
        {
            if (trackedCamera.activeSelf)
            {
                trackedCamera.SetActive(false);
            }
            else {
                trackedCamera.SetActive(true);
            }
        }
    }
}