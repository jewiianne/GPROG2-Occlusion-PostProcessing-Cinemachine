using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CameraTransition : MonoBehaviour
{
    public CinemachineVirtualCamera firstPersonCam;
    public CinemachineVirtualCamera thirdPersonCam;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (firstPersonCam.Priority > thirdPersonCam.Priority)
            {
                SetThirdPersonView();
            }
            else
            {
                SetFirstPersonView();
            }
        }
    }

        void SetFirstPersonView()
        {
            firstPersonCam.Priority = 20;
            thirdPersonCam.Priority = 10;
        }

        void SetThirdPersonView()
        {
            firstPersonCam.Priority = 10;
            thirdPersonCam.Priority = 20;
        }
}
