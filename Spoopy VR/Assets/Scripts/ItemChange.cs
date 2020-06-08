using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemChange : MonoBehaviour
{
    public GameObject itemGood;
    public GameObject itemBad;

    public void ChangeItem()
    {
        itemBad.SetActive(true);
        itemGood.SetActive(false);
    }
}
