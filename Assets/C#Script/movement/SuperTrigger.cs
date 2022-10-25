using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperTrigger : MonoBehaviour
{   
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("PlayerMovement")){
            SuperShow.instance.ToggleShop();

        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("PlayerMovement")){
            SuperShow.instance.ToggleShop();
        }
    }

}
