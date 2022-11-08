using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class GameController : MonoBehaviour
{
    public static GameController instance;
    public BoxSpawner boxSpawner;
    public Box currentBox;
    public CameraFollow cameraFollow;
    public int score;
    public Text scoretxt;
    public int moveCount;
    public GameObject BoxTower;
    public Transform SuccessImage;
    public GameObject box_prefab;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        score = 0;
        box_prefab.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        GetMouseInput();
    }

    void GetMouseInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentBox.DropBox();
        }
    }
    public void SpawnNewBox()
    { if(score >= 4){
       TweenResult(SuccessImage);
        BoxTower.SetActive(false);
         box_prefab.SetActive(false);
         score=0;
        //   Invoke("NextBox", 0f);
        //GamObject Setactive false
        
    }
     if(score <= 3){
     
           Invoke("NextBox", 0.2f);
    }
      
    }
    public void NextBox()
    {
        boxSpawner.SpawnBox();
    }
    public void addScore()
    {
        score++;
        scoretxt.text = "" + score;
    }
    public void MoveCamera()
    {
        moveCount++;
        if (moveCount == 2)
        {
            moveCount = 0;
            cameraFollow.targetPos.y += 2f;
        }
    }
          void TweenResult(Transform resultTransform){
        Sequence result = DOTween.Sequence();
        result.Append(resultTransform.DOScale(1,.5f).SetEase(Ease.OutBack)); // Scale from 0 to 1
        result.AppendInterval(1f); // Wait for 1 second
        result.Append(resultTransform.DOScale(0,.2f).SetEase(Ease.Linear)); // Scale back down to 0
     
   }
      IEnumerator ExampleCoroutine()
    {
       
        yield return new WaitForSeconds(5);

   
    }
}
