using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostRotate : MonoBehaviour
{
    public GameObject ghost;
    public GameObject Player;
    public float Speed;
    public float RotateSpeed;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, Speed * Time.deltaTime);
        transform.RotateAround(Player.transform.position, Vector3.up, RotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider Coll)
    {
        if (Coll.gameObject.tag == "Looking")
        {
            Speed = 0f;
            RotateSpeed = 0f;
        }
    }

    private void OnTriggerExit(Collider Coll)
    {
        if (Coll.gameObject.tag == "Looking")
        {
            Speed = 2f;
            RotateSpeed = 5f;
        }
    }
}
