using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class GlobalFunctions : MonoBehaviour
{
    public int music_volume;
    public int fx_volume;

    private void Start() {
        string[] StartObjects = {"GUI_Camera", "Canvas_01_Menu_Start"};
        GameObject parentObject = GameObject.Find("UI");
        foreach (Transform child in parentObject.transform)
        {
            child.gameObject.SetActive(StartObjects.Contains(child.gameObject.name));
        }

        Debug.Log("COMIENZA");
    }

    public void ReturnToMainMenu() {
        string[] StartObjects = {"GUI_Camera", "Canvas_02_Menu_Main"};
        GameObject parentObject = GameObject.Find("UI");
        foreach (Transform child in parentObject.transform)
        {
            child.gameObject.SetActive(StartObjects.Contains(child.gameObject.name));
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void DestroyChildrens()
    {
        while (transform.childCount > 0)
        {
            DestroyImmediate(transform.GetChild(0).gameObject);
        }
    }

    public void Exit()
    {
        QuitGame();
    }

    void Update()
    {
    }

}