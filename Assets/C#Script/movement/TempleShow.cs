using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempleShow : MonoBehaviour
{
        public static TempleShow instance;

        public GameObject templeUI;
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
        templeUI.SetActive(!templeUI.activeSelf);
         mainUI.SetActive(!mainUI.activeSelf);
        
    }
   
}
