using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro; 
public class ShopManager : MonoBehaviour
{

    public int[,] shopItems = new int[6,70];
    public int coins;
    public int energy;
    public int happy;
    public int hour;
    public int minute;
    public int moneyInBank;
    public TextMeshProUGUI CoinsTXT;
    public TextMeshProUGUI MoneyInBankTXT;
    public TextMeshProUGUI TimeTXT;
//  public Image coinsBar;
    public TextMeshProUGUI EnergyTXT;
    public TextMeshProUGUI HappyTXT;
    // public Image energyBar;
    public int maxEnergy = 500;
    public int maxHappy = 500;

    void Start()
    {
        CoinsTXT.text = coins.ToString();
        MoneyInBankTXT.text = "Money: " + moneyInBank.ToString();
        TimeTXT = hour.ToString(); + minute.ToString();
        //ID's
        //0 Restuarants
        //1 Relax
        //2 Bank
        //3 Work
        //4 Market
        //5 Shoppingmall
        //6 Home
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;
        shopItems[1, 5] = 5;
        shopItems[1, 6] = 6;
        shopItems[1, 7] = 7;
        shopItems[1, 8] = 8;
        shopItems[1, 9] = 9;
        shopItems[1, 10] = 10;
        shopItems[1, 11] = 11;
        shopItems[1, 12] = 12;
        shopItems[1, 13] = 13;
        shopItems[1, 14] = 14;
        shopItems[1, 15] = 15;
        shopItems[1, 16] = 16;
        shopItems[1, 17] = 17;
        shopItems[1, 18] = 18;
        shopItems[1, 19] = 19;
        shopItems[1, 20] = 20;
        shopItems[1, 21] = 21;
        shopItems[1, 22] = 22;
        shopItems[1, 23] = 23;
        shopItems[1, 24] = 24;
        shopItems[1, 25] = 25;
        shopItems[1, 26] = 26;
        shopItems[1, 27] = 27;
        shopItems[1, 28] = 28;
        shopItems[1, 29] = 29;
        shopItems[1, 30] = 30;
        shopItems[1, 31] = 31;
        shopItems[1, 32] = 32;
        shopItems[1, 33] = 33;
        shopItems[1, 34] = 34;
        shopItems[1, 35] = 35;
        shopItems[1, 36] = 36;
        shopItems[1, 37] = 37;
        shopItems[1, 38] = 38;
        shopItems[1, 39] = 39;
        shopItems[1, 40] = 40;
        shopItems[1, 41] = 41;
        shopItems[1, 42] = 42;
        shopItems[1, 43] = 43;
        shopItems[1, 44] = 44;
        shopItems[1, 45] = 45;
        shopItems[1, 46] = 46;
        shopItems[1, 47] = 47;
        shopItems[1, 48] = 48;
        shopItems[1, 49] = 49;
        shopItems[1, 50] = 50;
        shopItems[1, 51] = 51;
        shopItems[1, 52] = 52;
        shopItems[1, 53] = 53;
        shopItems[1, 54] = 54;
        shopItems[1, 55] = 55;
        shopItems[1, 56] = 56;
        shopItems[1, 57] = 57;
        shopItems[1, 58] = 58;
        shopItems[1, 59] = 59;
        shopItems[1, 60] = 60;


        //Price
        shopItems[2, 1] = 180;
        shopItems[2, 2] = 59;
        shopItems[2, 3] = 200;
        shopItems[2, 4] = 100;
        shopItems[2, 5] = 40;
        shopItems[2, 6] = 120;
        shopItems[2, 7] = 45;
        shopItems[2, 8] = 50;
        shopItems[2, 9] = 70;
        shopItems[2, 10] = 85;
        shopItems[2, 11] = 800;
        shopItems[2, 12] = 450;
        shopItems[2, 13] = 430;
        shopItems[2, 14] = 185;
        shopItems[2, 15] = 790;
        shopItems[2, 16] = 250;
        shopItems[2, 17] = 200;
        shopItems[2, 18] = 50;
        shopItems[2, 19] = 300;
        shopItems[2, 20] = 500;
        shopItems[2, 21] = 50;
        shopItems[2, 22] = 100;
        shopItems[2, 23] = 1000;
        shopItems[2, 24] = 50;
        shopItems[2, 25] = 100;
        shopItems[2, 26] = 1000;
        shopItems[2, 27] = 90;
        shopItems[2, 28] = 50;
        shopItems[2, 29] = 60;
        shopItems[2, 30] = 40;
        shopItems[2, 31] = 1200;
        shopItems[2, 32] = 280;
        shopItems[2, 33] = 270;
        shopItems[2, 34] = 800;
        shopItems[2, 35] = 650;
        shopItems[2, 36] = 380;
        shopItems[2, 37] = 500;
        shopItems[2, 38] = 480;
        shopItems[2, 39] = 230;
        shopItems[2, 40] = 100;
        shopItems[2, 41] = 40;
        shopItems[2, 42] = 50;
        shopItems[2, 43] = 30;
        shopItems[2, 44] = 20;
        shopItems[2, 45] = 10;
        shopItems[2, 46] = 20;
        shopItems[2, 47] = 40;
        shopItems[2, 48] = 50;
        shopItems[2, 49] = 20;
        shopItems[2, 50] = 30;
        shopItems[2, 51] = 178;
        shopItems[2, 52] = 59;
        shopItems[2, 53] = 350;
        shopItems[2, 54] = 500;
        shopItems[2, 55] = 330;
        shopItems[2, 56] = 260;
        shopItems[2, 57] = 218;
        shopItems[2, 58] = 190;
        shopItems[2, 59] = 230;
        shopItems[2, 60] = 300;


        //Energy
        shopItems[3, 1] = 300;
        shopItems[3, 2] = 40;
        shopItems[3, 3] = 460;
        shopItems[3, 4] = 200;
        shopItems[3, 5] = 25;
        shopItems[3, 6] = 240;
        shopItems[3, 7] = 40;
        shopItems[3, 8] = 65;
        shopItems[3, 9] = 130;
        shopItems[3, 10] = 185;
        shopItems[3, 11] = 5;
        shopItems[3, 12] = 15;
        shopItems[3, 13] = 30;
        shopItems[3, 14] = 35;
        shopItems[3, 15] = 30;
        shopItems[3, 16] = 50;
        shopItems[3, 17] = 25;
        shopItems[3, 18] = 10;
        shopItems[3, 19] = 20;
        shopItems[3, 20] = 50;
        shopItems[3, 21] = 40;
        shopItems[3, 22] = 10;
        shopItems[3, 23] = 20;
        shopItems[3, 24] = 20;
        shopItems[3, 25] = 10;
        shopItems[3, 26] = 30;
        shopItems[3, 27] = 20;
        shopItems[3, 28] = 20;
        shopItems[3, 29] = 40;
        shopItems[3, 30] = 10;
        shopItems[3, 31] = 290;
        shopItems[3, 32] = 70;
        shopItems[3, 33] = 80;
        shopItems[3, 34] = 150;
        shopItems[3, 35] = 130;
        shopItems[3, 36] = 60;
        shopItems[3, 37] = 84;
        shopItems[3, 38] = 150;
        shopItems[3, 39] = 45;
        shopItems[3, 40] = 35;
        shopItems[3, 41] = 30;
        shopItems[3, 42] = 40;
        shopItems[3, 43] = 50;
        shopItems[3, 44] = 30;
        shopItems[3, 45] = 20;
        shopItems[3, 46] = 40;
        shopItems[3, 47] = 50;
        shopItems[3, 48] = 20;
        shopItems[3, 49] = 10;
        shopItems[3, 50] = 40;
        shopItems[3, 51] = 10;
        shopItems[3, 52] = 10;
        shopItems[3, 53] = 10;
        shopItems[3, 54] = 10;
        shopItems[3, 55] = 10;
        shopItems[3, 56] = 10;
        shopItems[3, 57] = 10;
        shopItems[3, 58] = 10;
        shopItems[3, 60] = 10;


          //Happy
          //Restuarants
        shopItems[4, 1] = 5;
        shopItems[4, 2] = 20;
        shopItems[4, 3] = 0;
        shopItems[4, 4] = 15;
        shopItems[4, 5] = 15;
        shopItems[4, 6] = 0;
        shopItems[4, 7] = 10;
        shopItems[4, 8] = 0;
        shopItems[4, 9] = 0;
        shopItems[4, 10] = 10;
        //Relax
        shopItems[4, 11] = 65;
        shopItems[4, 12] = 30;
        shopItems[4, 13] = 60;
        shopItems[4, 14] = 35;
        shopItems[4, 15] = 50;
        shopItems[4, 16] = 40;
        shopItems[4, 17] = 30;
        shopItems[4, 18] = 10;
        shopItems[4, 19] = 60;
        shopItems[4, 20] = 50;
        shopItems[4, 21] = 10;
        shopItems[4, 22] = 20;
        shopItems[4, 23] = 30;
        shopItems[4, 24] = 15;
        shopItems[4, 25] = 20;
        shopItems[4, 26] = 10;
        shopItems[4, 27] = 10;
        shopItems[4, 28] = 20;
        shopItems[4, 29] = 30;
        shopItems[4, 30] = 15;
        shopItems[4, 31] = 240;
        shopItems[4, 32] = 80;
        shopItems[4, 33] = 40;
        shopItems[4, 34] = 210;
        shopItems[4, 35] = 50;
        shopItems[4, 36] = 75;
        shopItems[4, 37] = 0;
        shopItems[4, 38] = 130;
        shopItems[4, 39] = 0;
        shopItems[4, 40] = 10;
        shopItems[4, 41] = 20;
        shopItems[4, 42] = 40;
        shopItems[4, 43] = 20;
        shopItems[4, 44] = 30;
        shopItems[4, 45] = 20;
        shopItems[4, 46] = 40;
        shopItems[4, 47] = 20;
        shopItems[4, 48] = 45;
        shopItems[4, 49] = 20;
        shopItems[4, 50] = 40;
        shopItems[4, 51] = 2;
        shopItems[4, 52] = 3;
        shopItems[4, 53] = 5;
        shopItems[4, 54] = 6;
        shopItems[4, 55] = 4;
        shopItems[4, 56] = 4;
        shopItems[4, 57] = 4;
        shopItems[4, 58] = 4;
        shopItems[4, 59] = 3;
        shopItems[4, 60] = 5;

  //Time
        shopItems[5, 1] = 30;
        shopItems[5, 2] = 30;
        shopItems[5, 3] = 30;
        shopItems[5, 4] = 30;
        shopItems[5, 5] = 30;
        shopItems[5, 6] = 30;
        shopItems[5, 7] = 30;
        shopItems[5, 8] = 30;
        shopItems[5, 9] = 30;
        shopItems[5, 10] = 30;
        shopItems[5, 11] = 60;
        shopItems[5, 12] = 60;
        shopItems[5, 13] = 60;
        shopItems[5, 14] = 60;
        shopItems[5, 15] = 60;
        shopItems[5, 16] = 60;
        shopItems[5, 17] = 60;
        shopItems[5, 18] = 60;
        shopItems[5, 19] = 120;
        shopItems[5, 20] = 60;
        shopItems[5, 21] = 40;
        shopItems[5, 22] = 10;
        shopItems[5, 23] = 20;
        shopItems[5, 24] = 20;
        shopItems[5, 25] = 10;
        shopItems[5, 26] = 30;
        shopItems[5, 27] = 20;
        shopItems[5, 28] = 20;
        shopItems[5, 29] = 40;
        shopItems[5, 30] = 10;
        shopItems[5, 31] = 480;
        shopItems[5, 32] = 120;
        shopItems[5, 33] = 120;
        shopItems[5, 34] = 360;
        shopItems[5, 35] = 300;
        shopItems[5, 36] = 180;
        shopItems[5, 37] = 240;
        shopItems[5, 38] = 150;
        shopItems[5, 39] = 120;
        shopItems[5, 40] = 60;
        shopItems[5, 41] = 5;
        shopItems[5, 42] = 5;
        shopItems[5, 43] = 5;
        shopItems[5, 44] = 5;
        shopItems[5, 45] = 5;
        shopItems[5, 46] = 5;
        shopItems[5, 47] = 5;
        shopItems[5, 48] = 5;
        shopItems[5, 49] = 5;
        shopItems[5, 50] = 5;
        shopItems[5, 51] = 10;
        shopItems[5, 52] = 10;
        shopItems[5, 53] = 10;
        shopItems[5, 54] = 10;
        shopItems[5, 55] = 10;
        shopItems[5, 56] = 10;
        shopItems[5, 57] = 10;
        shopItems[5, 58] = 10;
        shopItems[5, 60] = 10;

        //  energy = maxEnergy;
    }

    public void Update()
    {
    //    energyBar.fillAmount = energy / maxEnergy;
    //   energyBar.SetEnergy(energy);
      
    }
   
    public void BuyFood()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        GameObject player  = GameObject.FindGameObjectWithTag("Player");
        Player myplayer = (Player) player.GetComponent(typeof(Player));
        // energy = myplayer.currentEnergy;
        energy = myplayer.currentEnergy;
        happy = myplayer.currentHappy;
        coins = myplayer.currentCoins;
        moneyInBank = myplayer.currentMoneyInBank;
        time = myplayer.currentTime;
        if (coins >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            
            coins -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            
            if(coins< 0 ){ coins = 0;}
            CoinsTXT.text =  coins.ToString();

            energy += shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID];
              if(energy> maxEnergy){energy = maxEnergy;}
              if(energy< 0){energy = 0;}
         
            EnergyTXT.text = energy.ToString();

          
             happy += shopItems[4, ButtonRef.GetComponent<ButtonInfo>().ItemID];
             if(happy>maxHappy){happy = maxHappy;}
             if(happy< 0 ){ happy = 0;}
             HappyTXT.text = happy.ToString();
            // if(coins<=0){coins = 0;}
            // if(moneyInBank<=0){moneyInBank = 0;}
           time += shopItems[5, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            myplayer.SetEnergy(energy);
            myplayer.SetHappy(happy);
     
            
            
            //   energyBar.fillAmount = energy / maxEnergy;
            // ButtonRef.GetComponent<ButtonInfo>().quantityTxt.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
            // Debug.Log(myplayer.currentEnergy);
        }
       
    }
    //ฝากเงิน
       public void Deposite()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        GameObject player  = GameObject.FindGameObjectWithTag("Player");
        Player myplayer = (Player) player.GetComponent(typeof(Player));
        // energy = myplayer.currentEnergy;
        energy = myplayer.currentEnergy;
        happy = myplayer.currentHappy;
        coins = myplayer.currentCoins;
        moneyInBank = myplayer.currentMoneyInBank;


        // player.GetComponent<Player>().BuyProduct(40);
      
        if (coins >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
          
            // if(moneyInBank<=0){moneyInBank = 0;}
            moneyInBank += shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
               
              if( moneyInBank< 0){ moneyInBank = 0;}
            MoneyInBankTXT.text = moneyInBank.ToString();
           
            coins -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
               
            if(coins< 0 ){ coins = 0;}
            CoinsTXT.text =  coins.ToString();

            energy -= 10;
              if(energy> maxEnergy){energy = maxEnergy;}
              if(energy< 0){energy = 0;}
            EnergyTXT.text = energy.ToString();

          
            happy -= 0;
              if(happy>maxHappy){happy = maxHappy;}
             if(happy< 0 ){ happy = 0;}
             HappyTXT.text = happy.ToString();

            myplayer.SetEnergy(energy);
            myplayer.SetHappy(happy);
     
            
            
            //   energyBar.fillAmount = energy / maxEnergy;
            // ButtonRef.GetComponent<ButtonInfo>().quantityTxt.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
            // Debug.Log(myplayer.currentEnergy);
        }
       
    }
    //ถอนเงิน
     public void Withdraw(){
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        GameObject player  = GameObject.FindGameObjectWithTag("Player");
        Player myplayer = (Player) player.GetComponent(typeof(Player));
        // energy = myplayer.currentEnergy;
         energy = myplayer.currentEnergy;
         happy = myplayer.currentHappy;
         coins = myplayer.currentCoins;
         moneyInBank = myplayer.currentMoneyInBank;


        // player.GetComponent<Player>().BuyProduct(40);
      
        if (moneyInBank >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            // if(coins<=0){coins = 0;}
            // if(moneyInBank<=0){moneyInBank = 0;}
            moneyInBank -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            MoneyInBankTXT.text = moneyInBank.ToString();
           
            coins += shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
               
            if(coins< 0 ){ coins = 0;}
            CoinsTXT.text =  coins.ToString();

            energy -= 20;
              if(energy> maxEnergy){energy = maxEnergy;}
              if(energy< 0){energy = 0;}
            EnergyTXT.text = energy.ToString();

          
            happy += 0;
                 if(happy> maxHappy){happy = maxHappy;}
              if(happy< 0){happy = 0;}
            HappyTXT.text = happy.ToString();

       
                  
            myplayer.SetEnergy(energy);
            myplayer.SetHappy(happy);
     
            
            
            //   energyBar.fillAmount = energy / maxEnergy;
            // ButtonRef.GetComponent<ButtonInfo>().quantityTxt.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
            // Debug.Log(myplayer.currentEnergy);
        }}
         public void Pay(){
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        GameObject player  = GameObject.FindGameObjectWithTag("Player");
        Player myplayer = (Player) player.GetComponent(typeof(Player));
        // energy = myplayer.currentEnergy;
         energy = myplayer.currentEnergy;
         happy = myplayer.currentHappy;
         coins = myplayer.currentCoins;
         moneyInBank = myplayer.currentMoneyInBank;


        // player.GetComponent<Player>().BuyProduct(40);
      
        if (coins >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            // if(coins<=0){coins = 0;}
            // if(moneyInBank<=0){moneyInBank = 0;}
         
           
            coins -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
               
            if(coins< 0 ){ coins = 0;}
            CoinsTXT.text =  coins.ToString();

            energy -= 20;
              if(energy> maxEnergy){energy = maxEnergy;}
              if(energy< 0){energy = 0;}
            EnergyTXT.text = energy.ToString();

          
            happy -=  shopItems[4, ButtonRef.GetComponent<ButtonInfo>().ItemID];
                 if(happy> maxHappy){happy = maxHappy;}
              if(happy< 0){happy = 0;}
            HappyTXT.text = happy.ToString();

   
                  
            myplayer.SetEnergy(energy);
            myplayer.SetHappy(happy);
     
            
            
            //   energyBar.fillAmount = energy / maxEnergy;
            // ButtonRef.GetComponent<ButtonInfo>().quantityTxt.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
            // Debug.Log(myplayer.currentEnergy);
        }}

         public void Work(){
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        GameObject player  = GameObject.FindGameObjectWithTag("Player");
        Player myplayer = (Player) player.GetComponent(typeof(Player));
        // energy = myplayer.currentEnergy;
        energy = myplayer.currentEnergy;
        happy = myplayer.currentHappy;
        coins = myplayer.currentCoins;
        moneyInBank = myplayer.currentMoneyInBank;
      
        if (energy >= shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            
            coins += shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
               
            if(coins< 0 ){ coins = 0;}
            CoinsTXT.text =  coins.ToString();

            energy -= shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID];
              if(energy> maxEnergy){energy = maxEnergy;}
              if(energy< 0){energy = 0;}
            EnergyTXT.text = energy.ToString();

          
             happy -= shopItems[4, ButtonRef.GetComponent<ButtonInfo>().ItemID];
                  if(happy> maxHappy){happy = maxHappy;}
              if(happy< 0){happy = 0;}
             HappyTXT.text = happy.ToString();
            // if(coins<=0){coins = 0;}
            // if(moneyInBank<=0){moneyInBank = 0;}
       
            myplayer.SetEnergy(energy);
            myplayer.SetHappy(happy);
     
            
            
            //   energyBar.fillAmount = energy / maxEnergy;
            // ButtonRef.GetComponent<ButtonInfo>().quantityTxt.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
            // Debug.Log(myplayer.currentEnergy);
        }
       
    }
      public void Relax() {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        GameObject player  = GameObject.FindGameObjectWithTag("Player");
        Player myplayer = (Player) player.GetComponent(typeof(Player));
        // energy = myplayer.currentEnergy;
        energy = myplayer.currentEnergy;
        happy = myplayer.currentHappy;
        coins = myplayer.currentCoins;
        moneyInBank = myplayer.currentMoneyInBank;
      
        if (coins >= shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            
            coins -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
               
            if(coins< 0 ){ coins = 0;}
            CoinsTXT.text =  coins.ToString();

            energy -= shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID];
              if(energy> maxEnergy){energy = maxEnergy;}
              if(energy< 0){energy = 0;}
            EnergyTXT.text = energy.ToString();

          
             happy += shopItems[4, ButtonRef.GetComponent<ButtonInfo>().ItemID];
                  if(happy> maxHappy){happy = maxHappy;}
              if(happy< 0){happy = 0;}
             HappyTXT.text = happy.ToString();
            // if(coins<=0){coins = 0;}
            // if(moneyInBank<=0){moneyInBank = 0;}
          
            myplayer.SetEnergy(energy);
            myplayer.SetHappy(happy);
     
            
            
            //   energyBar.fillAmount = energy / maxEnergy;
            // ButtonRef.GetComponent<ButtonInfo>().quantityTxt.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
            // Debug.Log(myplayer.currentEnergy);
        }
       
    }
   
     public void ShoppingMarket(){
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        GameObject player  = GameObject.FindGameObjectWithTag("Player");
        Player myplayer = (Player) player.GetComponent(typeof(Player));
        // energy = myplayer.currentEnergy;
        energy = myplayer.currentEnergy;
        happy = myplayer.currentHappy;
        coins = myplayer.currentCoins;
        moneyInBank = myplayer.currentMoneyInBank;
      
        if (coins >= shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            
            coins -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
               
            if(coins< 0 ){ coins = 0;}
            CoinsTXT.text =  coins.ToString();

            energy -= shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID];
              if(energy> maxEnergy){energy = maxEnergy;}
              if(energy< 0){energy = 0;}
            EnergyTXT.text = energy.ToString();

          
             happy += shopItems[4, ButtonRef.GetComponent<ButtonInfo>().ItemID];
                  if(happy> maxHappy){happy = maxHappy;}
              if(happy< 0){happy = 0;}
             HappyTXT.text = happy.ToString();
            // if(coins<=0){coins = 0;}
            // if(moneyInBank<=0){moneyInBank = 0;}
           
            myplayer.SetEnergy(energy);
            myplayer.SetHappy(happy);
     
            
            
            //   energyBar.fillAmount = energy / maxEnergy;
            // ButtonRef.GetComponent<ButtonInfo>().quantityTxt.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
            // Debug.Log(myplayer.currentEnergy);
        }
       
    }
       public void Temple(){
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        GameObject player  = GameObject.FindGameObjectWithTag("Player");
        Player myplayer = (Player) player.GetComponent(typeof(Player));
        // energy = myplayer.currentEnergy;
        energy = myplayer.currentEnergy;
        happy = myplayer.currentHappy;
        coins = myplayer.currentCoins;
        moneyInBank = myplayer.currentMoneyInBank;
      
        if (coins >= shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            
            coins -= 40;
    
            if(coins< 0 ){ coins = 0;}
            CoinsTXT.text =  coins.ToString();

            energy -= 10;
               if(energy> maxEnergy){energy = maxEnergy;}
              if(energy< 0){energy = 0;}
            EnergyTXT.text = energy.ToString();

          
             happy += shopItems[4, ButtonRef.GetComponent<ButtonInfo>().ItemID];
              if(happy> maxHappy){happy = maxHappy;}
              if(happy< 0){happy = 0;}
             HappyTXT.text = happy.ToString();
            // if(coins<=0){coins = 0;}
 
            myplayer.SetEnergy(energy);
            myplayer.SetHappy(happy);
     
            
            
            //   energyBar.fillAmount = energy / maxEnergy;
            // ButtonRef.GetComponent<ButtonInfo>().quantityTxt.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
            // Debug.Log(myplayer.currentEnergy);
        }
       
    }
    }
    
