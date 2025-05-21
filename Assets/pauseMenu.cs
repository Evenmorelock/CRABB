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
        HatMenuUI.SetActive(false);
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
    public void equipSkull()
    {
        if (skullUnlocked == true)
        {
            skull.SetActive(true);
            bucket.SetActive(false);
            helmet.SetActive(false);
            chefHat.SetActive(false);
            propellerCap.SetActive(false);
            box.SetActive(false);
            cone.SetActive(false);
            redCap.SetActive(false);
            wig.SetActive(false);
            securityCap.SetActive(false);
            plate.SetActive(false);
        }
    }
    public void equipBucket()
    {
        if (bucketUnlocked == true)
        {
            skull.SetActive(false);
            bucket.SetActive(true);
            helmet.SetActive(false);
            chefHat.SetActive(false);
            propellerCap.SetActive(false);
            box.SetActive(false);
            cone.SetActive(false);
            redCap.SetActive(false);
            wig.SetActive(false);
            securityCap.SetActive(false);
            plate.SetActive(false);
        }
    }
    public void equipHelmet()
    {
        if (helmetUnlocked == true)
        {
            skull.SetActive(false);
            bucket.SetActive(false);
            helmet.SetActive(true);
            chefHat.SetActive(false);
            propellerCap.SetActive(false);
            box.SetActive(false);
            cone.SetActive(false);
            redCap.SetActive(false);
            wig.SetActive(false);
            securityCap.SetActive(false);
            plate.SetActive(false);
        }
    }
    public void equipChefHat()
    {
        if (chefHatUnlocked == true)
        {
            skull.SetActive(false);
            bucket.SetActive(false);
            helmet.SetActive(false);
            chefHat.SetActive(true);
            propellerCap.SetActive(false);
            box.SetActive(false);
            cone.SetActive(false);
            redCap.SetActive(false);
            wig.SetActive(false);
            securityCap.SetActive(false);
            plate.SetActive(false);
        }
    }
    public void equipPropellerCap()
    {
        if (propellerCapUnlocked == true)
        {
            skull.SetActive(false);
            bucket.SetActive(false);
            helmet.SetActive(false);
            chefHat.SetActive(false);
            propellerCap.SetActive(true);
            box.SetActive(false);
            cone.SetActive(false);
            redCap.SetActive(false);
            wig.SetActive(false);
            securityCap.SetActive(false);
            plate.SetActive(false);
        }
    }
    public void equipBox()
    {
        if (boxUnlocked == true)
        {
            skull.SetActive(false);
            bucket.SetActive(false);
            helmet.SetActive(false);
            chefHat.SetActive(false);
            propellerCap.SetActive(false);
            box.SetActive(true);
            cone.SetActive(false);
            redCap.SetActive(false);
            wig.SetActive(false);
            securityCap.SetActive(false);
            plate.SetActive(false);
        }
    }
    public void equipCone()
    {
        if (coneUnlocked == true)
        {
            skull.SetActive(false);
            bucket.SetActive(false);
            helmet.SetActive(false);
            chefHat.SetActive(false);
            propellerCap.SetActive(false);
            box.SetActive(false);
            cone.SetActive(true);
            redCap.SetActive(false);
            wig.SetActive(false);
            securityCap.SetActive(false);
            plate.SetActive(false);
        }
    }
    public void equipRedCap()
    {
        if (redCapUnlocked == true)
        {
            skull.SetActive(false);
            bucket.SetActive(false);
            helmet.SetActive(false);
            chefHat.SetActive(false);
            propellerCap.SetActive(false);
            box.SetActive(false);
            cone.SetActive(false);
            redCap.SetActive(true);
            wig.SetActive(false);
            securityCap.SetActive(false);
            plate.SetActive(false);
        }
    }
    public void equipWig()
    {
        if (wigUnlocked == true)
        {
            skull.SetActive(false);
            bucket.SetActive(false);
            helmet.SetActive(false);
            chefHat.SetActive(false);
            propellerCap.SetActive(false);
            box.SetActive(false);
            cone.SetActive(false);
            redCap.SetActive(false);
            wig.SetActive(true);
            securityCap.SetActive(false);
            plate.SetActive(false);
        }
    }
    public void equipSecurityCap()
    {
        if (securityCapUnlocked == true)
        {
            skull.SetActive(false);
            bucket.SetActive(false);
            helmet.SetActive(false);
            chefHat.SetActive(false);
            propellerCap.SetActive(false);
            box.SetActive(false);
            cone.SetActive(false);
            redCap.SetActive(false);
            wig.SetActive(false);
            securityCap.SetActive(true);
            plate.SetActive(false);
        }
    }
    public void equipPlate()
    {
        if (plateUnlocked == true)
        {
            skull.SetActive(false);
            bucket.SetActive(false);
            helmet.SetActive(false);
            chefHat.SetActive(false);
            propellerCap.SetActive(false);
            box.SetActive(false);
            cone.SetActive(false);
            redCap.SetActive(false);
            wig.SetActive(false);
            securityCap.SetActive(false);
            plate.SetActive(true);
        }
    }
}
