using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{   
    public int maxEnergy = 500;
    public int currentEnergy;
  public BarScript energyBar;
   // public ShopManager shopManager;
    // Start is called before the first frame update
    void Start()
    {
        currentEnergy = maxEnergy;
        energyBar.SetMaxEnergy(maxEnergy);
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space)){
             BuyProduct(20);
      }
    //  else{
    //    BuyProduct(shopManager.energy);
    //   }
    
        // BuyProduct(shopManager.energy);
        // energyBar.SetEnergy(shopManager.energy/5);

    }
    void BuyProduct(int valueEnergy){
        currentEnergy -= valueEnergy;
     energyBar.SetEnergy(currentEnergy);

    }
}