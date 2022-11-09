using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Image [] lives;
    public int livesRemaining;
    public int numberofStars; 
    public Text numberofstarsText;
    public GameObject canvasV;
    public GameObject canvasF;
    private BGMManager bgmManager;
    private SFXManager sfxManager;
    public Animator animator;

    
    
    void Awake()
    {
        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
        bgmManager = GameObject.Find("BGMManager").GetComponent<BGMManager>();
        canvasV.GetComponent<GameObject>();
        canvasF.GetComponent<GameObject>();
        //Si ya hay una instancia y no soy yo, me destruyo. 
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(this);
    }

    public void LoseLife()
    {
        if(livesRemaining==0)
           return;
        livesRemaining--;
        lives[livesRemaining].enabled = false;
        if(livesRemaining==0)
        {
            bgmManager.StopBGM();
            sfxManager.DeathSound();
            canvasF.SetActive(true);
            Destroy (GameObject.FindWithTag("Player"));
            Debug.Log("YOU LOSE");
        }
    }
    
    public void StarAchievement()
    {
        numberofStars++;
        numberofstarsText.text = numberofStars.ToString();
        sfxManager.StarSound();
        if(numberofStars==10)
        {
            bgmManager.StopBGM();
            sfxManager.VictorySound();
            canvasV.SetActive(true);
            Destroy (GameObject.FindWithTag("Player"));
            Debug.Log("YOU WIN");
        }
    }

    // Update is called once per frame
    void Update()
    {}
}
