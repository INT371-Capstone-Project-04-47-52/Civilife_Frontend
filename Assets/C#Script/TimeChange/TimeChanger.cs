using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace _Scripts{

    public class TimeChanger : MonoBehaviour{

        [SerializeField] private Material skybox;
        private float _elapsedTime = 0f;
        private float _timeScale = 5f;
        private static readonly int Rotation = Shader.PropertyToID("_Rotation");
        private static readonly int Exposure = Shader.PropertyToID("_Exposure");

        void Update(){
            // Debug.Log(Time.deltaTime);
            _elapsedTime += Time.deltaTime/100;

            skybox.SetFloat(Rotation, _elapsedTime * _timeScale);
            skybox.SetFloat(Exposure,Mathf.Clamp(Mathf.Sin(_elapsedTime), 0.15f, 1f));

        } 
    }
}