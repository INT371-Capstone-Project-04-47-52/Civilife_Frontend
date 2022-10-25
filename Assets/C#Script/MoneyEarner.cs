using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MoneyEarner : MonoBehaviour
{   
    public int _coins;
    [SerializeField] public TMP_Text _coinsText;
    public GameObject questClicker;
    [SerializeField] public GameObject _clickFX;
     [SerializeField] public RectTransform _buttonPosition;
    public GameObject item;
    public GameObject gameComplete;
    // Start is called before the first frame update
    void Start()
    {
        //  newPosition = transform.position;
         _coins = 0;
         _coinsText.text = _coins.ToString();
         
       
    }

    public void EarnMoney(){
        //  if (Input.GetMouseButtonDown(0))
        //  {
        //      RaycastHit hit;
        //      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //      if (Physics.Raycast(ray, out hit))
        //      {
        //          newPosition = hit.point;
        //          transform.position = newPosition;
        //      }
        //  }

        //  Instantiate(_clickFX,  transform.position, Quaternion.identity);
        
         Instantiate(_clickFX, _buttonPosition.position+ new Vector3(Random.Range(-1000,-1200), Random.Range(-550,-700),0), Quaternion.identity);
        _coins++;
        _coinsText.text = _coins.ToString();
        if(_coins==20){
             Debug.Log("Game Complete"); //else game is complete
             gameComplete.SetActive(true);
             StartCoroutine(ExampleCoroutine());
             
             questClicker.SetActive(false);
             item.SetActive(true);
              _coins=0;
         
        }


    }
      IEnumerator ExampleCoroutine()
    {
       
        yield return new WaitForSeconds(5);

   
    }
}
