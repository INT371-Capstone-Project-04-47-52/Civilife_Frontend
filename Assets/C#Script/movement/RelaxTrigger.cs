using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelaxTrigger : MonoBehaviour
{   
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("PlayerMovement")){
            RelaxShow.instance.ToggleShop();

        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("PlayerMovement")){
            RelaxShow.instance.ToggleShop();
        }
    }

}
