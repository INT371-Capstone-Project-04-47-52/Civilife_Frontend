using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BankShow : MonoBehaviour
{
        public static BankShow instance;

        public GameObject bankUI;
        public PlayerMovement player;
        public GameObject mainUI;
      
    private void Awake() {
        if(instance == null){
            instance = this;
        }else{
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void ToggleShop(){
        bankUI.SetActive(!bankUI.activeSelf);
         mainUI.SetActive(!mainUI.activeSelf);
        
    }
   
}
