using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseShow : MonoBehaviour
{
        public static HouseShow instance;

        public GameObject houseUI;
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
        houseUI.SetActive(!houseUI.activeSelf);
         mainUI.SetActive(!mainUI.activeSelf);
        
    }
   
}
