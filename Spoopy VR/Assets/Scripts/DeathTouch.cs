using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTouch : MonoBehaviour
{
    [Header("Game Over")]
    public GameObject deathTouch;
    public GameObject blackOut;

    private void OnTriggerEnter(Collider Death)
    {
        if (Death.gameObject.tag == "Ghost")
        {
            deathTouch.SetActive(true);
            blackOut.SetActive(false);
        }
    }
}
