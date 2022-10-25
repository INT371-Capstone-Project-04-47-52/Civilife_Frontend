using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConShow : MonoBehaviour
{
        public static ConShow instance;

        public GameObject conUI;
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
        conUI.SetActive(!conUI.activeSelf);
        mainUI.SetActive(!mainUI.activeSelf);
    
        
    }
   
}
