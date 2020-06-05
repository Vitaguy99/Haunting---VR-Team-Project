using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public GameObject ghost;
    public GameObject Player;
    public float Speed;

    void Update()
    {
        transform.position = Vector3.MoveTowards (transform.position, Player.transform.position, Speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider Coll)
    {
        if (Coll.gameObject.tag == "Looking")
        {
            Speed = 0f;
        }
    }

    private void OnTriggerExit(Collider Coll)
    {
        if (Coll.gameObject.tag == "Looking")
        {
            Speed = 2f;
        }
    }
}
