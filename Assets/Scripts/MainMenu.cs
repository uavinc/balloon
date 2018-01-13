using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject winText;
    public GameObject HUD;
    public GameObject Spawner;


    private void Awake ()
    {
        if(PlayerPrefs.GetInt("isWin") == 1)
        {
            winText.SetActive(true);
            PlayerPrefs.SetInt("isWin", 0);
        }
    }

    public void StartGame ()
    {
        HUD.SetActive(true);
        Spawner.SetActive(true);
        gameObject.SetActive(false);
    }
}
