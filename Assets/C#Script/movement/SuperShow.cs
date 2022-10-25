using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuperShow : MonoBehaviour
{
        public static SuperShow instance;

        public GameObject superUI;
        public GameObject mainUI;
        public PlayerMovement player;
 

    
    private void Awake() {
        if(instance == null){
            instance = this;
        }else{
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void ToggleShop(){
        superUI.SetActive(!superUI.activeSelf);
         mainUI.SetActive(!mainUI.activeSelf);
        
    }
   
}
