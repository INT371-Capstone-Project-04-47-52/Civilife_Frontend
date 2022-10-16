using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class PanelAnimation : MonoBehaviour
{
    public RectTransform loginPanel, createCharacter;

    private void Start()
    {
       
        // FadeEffect(playBtn, 0.5f, 1.5f, 1.5f);
        // MoveUI(loginPanel, new Vector2(0, 0), 0.25f, 0f, Ease.OutFlash);
    
    
    }


    public void ButtonMethod(string value)
    {
        switch (value)
        {
            case "CreateCharacterBtn":
                MoveUI(loginPanel, new Vector2(-1222, -107), 0.25f, 0f, Ease.OutFlash);
                MoveUI(createCharacter, new Vector2(1426, -179), 0.25f, 0f, Ease.OutFlash);
                break;
            // case "PowerShopBtn":
            //     MoveUI(loginPanel, new Vector2(-500, 0), 0.25f, 0f, Ease.OutFlash);
            //     MoveUI(mainPage, new Vector2(0, 0), 0.25f, 0.25f, Ease.OutFlash);
            //     break;
            case "CreateCharacterBackBtn":
                MoveUI(createCharacter, new Vector2(2846, -179), 0.25f, 0f, Ease.OutFlash);
                MoveUI(loginPanel, new Vector2(-3, -107), 0.25f,0f, Ease.OutFlash);
                break;
            // case "PowerShopBackBtn":
            //     MoveUI(mainPage, new Vector2(0, 820), 0.25f, 0f, Ease.OutFlash);
            //     MoveUI(loginPanel, new Vector2(0, 0), 0.25f, 0.25f, Ease.OutFlash);
            //     break;
        }
    }

    // void FadeEffect(Image _image, float fadeTo, float fadeDuration, float delay)
    // {
    //     _image.DOFade(fadeTo, fadeDuration);
    //     _image.DOFade(1, fadeDuration).SetDelay(delay).OnComplete(() => FadeEffect(_image, fadeTo, fadeDuration, delay));
    // }

    void MoveUI(RectTransform _traansform, Vector2 position, float moveTime, float delayTime, Ease ease)
    {
        _traansform.DOAnchorPos(position, moveTime).SetDelay(delayTime).SetEase(ease);
    }
}
