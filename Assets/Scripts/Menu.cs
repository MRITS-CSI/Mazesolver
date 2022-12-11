using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Menu : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text messageField;

    public void ButtonPressed()
    {
        string name = inputField.text;
        Regex rg = new Regex("[0-9]+");

        if (name == null && name.Length == 0)
        {
            return;
        }
        
        if (!rg.IsMatch(name))
        {
            Debug.Log("Not matched");
            messageField.text = "Please enter a valid team number and press start when told to do so.";
            return;
        }

        Debug.Log("Matched");

        PlayerPrefs.SetString("teamNumber", name);

        int sceneNumber = (int) (Random.value * 3f) + 1;

        SceneManager.LoadScene(string.Format("GameOver", sceneNumber), LoadSceneMode.Additive);
    }
}
