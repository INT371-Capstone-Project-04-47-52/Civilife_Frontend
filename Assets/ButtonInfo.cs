using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{

    public int ItemID;
    public Text PirceTxt;
    public Text EnergyTxt;
    public GameObject ShopManager;

    void Update()
    {
        PirceTxt.text = ShopManager.GetComponent<ShopManager>().shopItems[2, ItemID].ToString();
        EnergyTxt.text = ShopManager.GetComponent<ShopManager>().shopItems[3, ItemID].ToString();
    }
}
