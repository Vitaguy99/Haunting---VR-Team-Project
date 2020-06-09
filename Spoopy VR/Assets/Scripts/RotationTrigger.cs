using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTrigger : MonoBehaviour
{
    public GameObject playerRotationTrigger;

    public GameObject findText;
    public GameObject Ghost;

    public GameObject timerOff;
    public GameObject lookOff;

    private bool lockCounter;

    void Start()
    {
        lockCounter = true;
    }

    void Update()
    {
        if (lockCounter == true)
        {
            if (playerRotationTrigger.transform.rotation.eulerAngles.y == 180)
            {
                findText.SetActive(true);
                Ghost.SetActive(true);

                timerOff.SetActive(false);
                lookOff.SetActive(false);

                lockCounter = false;

            }
        }
        
    }
}
