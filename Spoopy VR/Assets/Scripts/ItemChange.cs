using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class ItemChange : MonoBehaviour
{
    [Header("Level's Changing Item")]
    public GameObject itemGood01;
    public GameObject itemBad01;
    [Space]
    public GameObject itemGood02;
    public GameObject itemBad02;
    [Space]
    public GameObject itemGood03;
    public GameObject itemBad03;
    [Space]
    [Header("Number Of Found Objects")]
    public Text foundObjects;
    public static int scoreValue = 0;
    [Space]
    [Header("Fill Out How Many Changed Items are In The Level")]
    public int changedItems;
    [Space]
    public GameObject correctUI;
    public GameObject enviormentParent;
    public GameObject byeGhost;
    [Space]
    [Header("Sounds")]
    public AudioSource incorrectSound;

    void Update()
    {
        foundObjects.text = "0" + scoreValue;

        if (scoreValue == changedItems)
        {
            correctUI.SetActive(true);
            enviormentParent.SetActive(false);
            byeGhost.SetActive(false);
        }
    }
    public void ChangeItem()
    {
        itemBad01.SetActive(true);
        itemGood01.SetActive(false);

        itemBad02.SetActive(true);
        itemGood02.SetActive(false);

        itemBad03.SetActive(true);
        itemGood03.SetActive(false);
    }
    public void IncorrectItem()
    {
        incorrectSound.Play();
    }

    public void IncrementIncrease()
    {
        scoreValue += 1;
    }
    public void ResetIncrement()
    {
        scoreValue = 0;
    }
}
