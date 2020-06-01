using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTouch : MonoBehaviour
{
    public GameObject GameOver;

    private void OnTriggerEnter(Collider Death)
    {
        if (Death.gameObject.tag == "Ghost")
        {
            GameOver.SetActive(true);
        }
    }
}
