using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winNow : MonoBehaviour
{
    public GameObject player;
    public GameObject playerCamera;
    public GameObject winCamera;
    public UIManager uiManager;
    public titleScreen titleScreen;
    public GameObject finalScore;
    public TMPro.TextMeshProUGUI finalScoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            player.SetActive(false);
            playerCamera.SetActive(false);
            titleScreen.uUIObjective.SetActive(false);
            titleScreen.uUIOptionalCounter.SetActive(false);
            titleScreen.uUIUniqueCounter.SetActive(false);
            winCamera.SetActive(true);
            finalScore.SetActive(true);
            finalScoreText.text = "Hats (optional): " + uiManager.hatCount + "   Hats (Unique): " + uiManager.uniqueHats;
        }
    }
}
