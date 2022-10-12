using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class AnswerScripts : MonoBehaviour
{
   public bool isCorrect = false;
    public QuizManager quizManager;

    public Color startColor;

    public Transform CorrectImage;
    public Transform IncorrectImage;
    // public GameObject Correct_Image;
    // public GameObject Incorrect_Image;
    private void Start(){
        startColor = GetComponent<Image>().color;
    }
   public void Answer(){

    if(isCorrect){
        GetComponent<Image>().color = Color.green;
        // Correct_Image.SetActive(true);
        TweenResult(CorrectImage);
        Debug.Log("Correct Answer");
        quizManager.correct();
    }
    else
    {   
        GetComponent<Image>().color = Color.red;
        // Incorrect_Image.SetActive(true);
        TweenResult(IncorrectImage);
        Debug.Log("Wrong Answer");
         quizManager.wrong();
    }
   }
    void TweenResult(Transform resultTransform){
        Sequence result = DOTween.Sequence();
        result.Append(resultTransform.DOScale(1,.5f).SetEase(Ease.OutBack)); // Scale from 0 to 1
        result.AppendInterval(1f); // Wait for 1 second
        result.Append(resultTransform.DOScale(0,.2f).SetEase(Ease.Linear)); // Scale back down to 0
     
   }
}
