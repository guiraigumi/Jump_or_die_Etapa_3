using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public GameObject instrucciones;

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Platforms");
    }

    public void LoadMenuPrincipal()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ToggleCanvasGroupActive()
    {
    instrucciones.gameObject.SetActive(!instrucciones.gameObject.activeSelf);
    }

    public GameObject title;
    public GameObject mainButtons;
    public GameObject optionsMenu;

    public void OpenOptions()
    {
        title.SetActive(false);
        mainButtons.SetActive(false);
        optionsMenu.SetActive(true);
    }
}
