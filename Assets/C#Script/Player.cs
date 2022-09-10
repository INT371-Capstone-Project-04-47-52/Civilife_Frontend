using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{   
    public int maxEnergy = 500;
    public int maxHappy = 500;
    public int maxCoins = 15000;
    public int currentMinute;
    public int currentHour;
    public int currentDay;
    public int currentEnergy;
    public int currentHappy;
    public int currentCoins;
    public int currentMoneyInBank;
  
    public BarScript energyBar;
    public BarScript happyBar;
   // public ShopManager shopManager;
    // Start is called before the first frame update
    void Start()
    {
        currentEnergy = maxEnergy;
        energyBar.SetMaxEnergy(maxEnergy);
        currentHappy = maxHappy;
        happyBar.SetMaxHappy(maxHappy);
        currentMinute = 0;
        currentHour = 0;
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space)){
             BuyProduct(-20);
      }
    //  else{
    //    BuyProduct(shopManager.energy);
    //   }
    
        // BuyProduct(shopManager.energy);
        // energyBar.SetEnergy(shopManager.energy/5);

    }
    public void BuyProduct(int valueEnergy){
     currentEnergy = valueEnergy;
     
    
         if(currentEnergy> maxEnergy){
            currentEnergy = maxEnergy;
         }
energyBar.SetEnergy(currentEnergy);
    }
     public void BuyProductHappy(int valueHappy){
     currentHappy = valueHappy;
    
     if(currentHappy>maxHappy){
        currentHappy = maxHappy;
         }
        happyBar.SetHappy(currentHappy);

    }

    public void SetEnergy(int valueEnergy){
        // Debug.Log(valueEnergy);
     currentEnergy = valueEnergy;
       
 if(currentEnergy>maxEnergy){
    currentEnergy = maxEnergy;
      }
         energyBar.SetEnergy(currentEnergy);
        
    }
    

    public void SetHappy(int valueHappy){
        // Debug.Log(valueEnergy);
         currentHappy = valueHappy;
        if(currentHappy>maxHappy){
      
        currentHappy = maxHappy;
       }
     happyBar.SetHappy(currentHappy);
    }

    
      public void SetMinute(int valueMinute){
        // Debug.Log(valueEnergy);
     currentMinute = valueMinute;
       
 if(currentMinute>=60){
    currentMinute = 0;
    currentHour +=1;
      }
         
        
    }
      public void SetHour(int valueHour){
        // Debug.Log(valueEnergy);
     currentHour = valueHour;
       
 if(currentHour>=24){
    currentHour = 0;
    currentDay +=1;
      }
         
        
    }
}