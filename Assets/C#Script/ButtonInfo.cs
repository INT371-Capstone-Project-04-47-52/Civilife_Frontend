using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ButtonInfo : MonoBehaviour
{

    public int ItemID;
    public Text PirceTxt;
    //public TMP_Text Name;
    
    // public Text HappyTxt;
    public GameObject ShopManager;

    void Update()
    {
        PirceTxt.text = ShopManager.GetComponent<ShopManager>().shopItems[2, ItemID].ToString();
        // Name.text = ShopManager.GetComponent<ShopManager>().shopItemsName[6, ItemID].text;
        // EnergyTxt.text = ShopManager.GetComponent<ShopManager>().shopItems[3, ItemID].ToString();
        // HappyTxt.text = ShopManager.GetComponent<ShopManager>().shopItems[4, ItemID].ToString();
        
        
    }
}
