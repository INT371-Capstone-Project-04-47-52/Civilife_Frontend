using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{

    public int[,] shopItems = new int[5,5];
    public int coins;
    public Text CoinsTXT;
   //  public Image coinsBar;
    public int energy;
    public Text energyTXT;
    // public Image energyBar;
     public int maxEnergy = 500;
    // public BarScript energyBar;

    void Start()
    {
        CoinsTXT.text = "Coins: " + coins.ToString();
       
        //ID's
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;

        //Price
        shopItems[2, 1] = 60;
        shopItems[2, 2] = 70;
        shopItems[2, 3] = 30;
        shopItems[2, 4] = 40;

        //Energy
        shopItems[3, 1] = 60;
        shopItems[3, 2] = 70;
        shopItems[3, 3] = 80;
        shopItems[3, 4] = 40;

        //  energy = maxEnergy;
    }

    public void Update()
    {
    //    energyBar.fillAmount = energy / maxEnergy;
    //   energyBar.SetEnergy(energy);
      
    }
   
    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (coins >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            coins -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
           
            CoinsTXT.text =  coins.ToString();

            energy += shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            
            energyTXT.text =  "coin" + energy.ToString();
            //   energyBar.fillAmount = energy / maxEnergy;
            // ButtonRef.GetComponent<ButtonInfo>().quantityTxt.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
            //  energyBar.SetEnergy(energy);
            
        }
        if(energy> maxEnergy){energy = maxEnergy;}
      
    }
    
}
