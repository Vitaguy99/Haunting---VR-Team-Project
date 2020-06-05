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
    void Update()
    {
        if (playerRotationTrigger.transform.rotation.eulerAngles.y == 180)
        {
            findText.SetActive(true);
            Ghost.SetActive(true);

            timerOff.SetActive(false);
            lookOff.SetActive(false);

        }
    }
}
