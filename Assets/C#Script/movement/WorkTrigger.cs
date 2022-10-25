using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkTrigger : MonoBehaviour
{   
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("PlayerMovement")){
            WorkShow.instance.ToggleShop();

        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("PlayerMovement")){
            WorkShow.instance.ToggleShop();
        }
    }

}
