using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NetworkingManager : MonoBehaviour
{

    public static NetworkingManager instance;
    public static LogIn logIn;
    public string baseURL= @"www.civilife.sit.kmutt.ac.th/backend/";
    // Start is called before the first frame update

    //Reg
    public InputField emailInputField;
      public InputField passwordInputField;
    //Login
        public InputField loginEmailInputField;
      public InputField loginPasswordInputField;


    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnRegButton(){
        Register tempReg = new Register(){email = emailInputField.text, password = passwordInputField.text};
        StartCoroutine(Register(tempReg));

    }
    public void OnLogInButton(){
          
        StartCoroutine(LogIn());

    }
    public IEnumerator Register(Register register){
        var uwr = new UnityWebRequest(baseURL+ "/api/signup","POST");
        string jsonData = JsonUtility.ToJson(register);

        byte[] jsonToSend = new System.Text.UTF8Encoding().GetBytes(jsonData);

        uwr.uploadHandler = (UploadHandler)new UploadHandlerRaw(jsonToSend);

        uwr.downloadHandler = (DownloadHandler) new DownloadHandlerBuffer();
        uwr.SetRequestHeader("Content-Type", "application/json");
        yield return uwr.SendWebRequest();

        if(uwr.result == UnityWebRequest.Result.ConnectionError){
            Debug.Log("Error: " + uwr.error);
        }else{
            Debug.Log(uwr.downloadHandler.text);
            
        }

    }

      public IEnumerator LogIn(){
       WWWForm form = new WWWForm();
       form.AddField("grant_type","password");
       form.AddField("username", loginEmailInputField.text);
       form.AddField("password",loginPasswordInputField.text);

       UnityWebRequest uwr = UnityWebRequest.Post(baseURL + "/api/login/", form);

       yield return uwr.SendWebRequest();

       if(uwr.result == UnityWebRequest.Result.ConnectionError){
        Debug.Log("Error: " + uwr.error);

       }else{
        Debug.Log(uwr.downloadHandler.text);
        logIn = JsonUtility.FromJson<LogIn>(uwr.downloadHandler.text);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        StartCoroutine(SaveData());

       }
       
      

    }
    public IEnumerator SaveData(){
        WWWForm form = new WWWForm();

        form.AddField("username", loginEmailInputField.text);
        form.AddField("password", loginPasswordInputField.text);
        form.AddField("UserData","{score:15}");

        form.headers.Add("Authorization","Bearer"+logIn.access_token);

        UnityWebRequest uwr = UnityWebRequest.Post(baseURL + "api/account", form);
        yield return uwr.SendWebRequest();

        if(uwr.result == UnityWebRequest.Result.ConnectionError){
        Debug.Log("Error: " + uwr.error);

        }else{
        Debug.Log(uwr.downloadHandler.text);
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

        }

    }
}
