using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class ItemChange : MonoBehaviour
{
    [Header("Level's Changing Item")]
    public GameObject itemGood;
    public GameObject itemBad;
    [Space]
    [Header("Number Of Found Objects")]
    Text foundObjects;

    public AudioSource incorrectSound;

    public void ChangeItem()
    {
        itemBad.SetActive(true);
        itemGood.SetActive(false);
    }
    public void IncorrectItem()
    {
        incorrectSound.Play();
    }

    public void IncrementIncrease()
    {
        
    }
}
