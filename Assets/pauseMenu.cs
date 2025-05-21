using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject HatMenuUI;

    public bool skullUnlocked;
    public bool bucketUnlocked;
    public bool helmetUnlocked;
    public bool chefHatUnlocked;
    public bool propellerCapUnlocked;
    public bool boxUnlocked;
    public bool coneUnlocked;
    public bool redCapUnlocked;
    public bool wigUnlocked;
    public bool securityCapUnlocked;
    public bool plateUnlocked;

    public GameObject skull;
    public GameObject bucket;
    public GameObject helmet;
    public GameObject chefHat;
    public GameObject propellerCap;
    public GameObject box;
    public GameObject cone;
    public GameObject redCap;
    public GameObject wig;
    public GameObject securityCap;
    public GameObject plate;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else 
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
    public void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
       pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }
    public void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
    public void OpenHats()
    {
        Debug.Log("Uh Oh it hat time");
        pauseMenuUI.SetActive(false);
        HatMenuUI.SetActive(true);
    }

}
