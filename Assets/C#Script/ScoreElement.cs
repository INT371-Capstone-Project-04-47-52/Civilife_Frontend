using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreElement : MonoBehaviour
{

    public TMP_Text usernameText;
    public TMP_Text coinsText;
    public TMP_Text energyText;
    public TMP_Text happyText;

    public void NewScoreElement (string _username, int _coins, int _energy, int _happy)
    {
        usernameText.text = _username;
        coinsText.text = _coins.ToString();
        energyText.text = _energy.ToString();
        happyText.text = _happy.ToString();
    }

}