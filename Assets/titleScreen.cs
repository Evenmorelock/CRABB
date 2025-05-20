using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleScreen : MonoBehaviour
{
    public GameObject uUIObject;
    public GameObject uPlayer;
    public GameObject uUICamera;
    public GameObject uUIObjective;
    public GameObject uUIOptionalCounter;
    public GameObject uUIUniqueCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            uUICamera.SetActive(false);
            uUIObject.SetActive(false);
            uPlayer.SetActive(true);
            uUIObjective.SetActive(true);
            uUIOptionalCounter.SetActive(true);
            uUIUniqueCounter.SetActive(true);
        }
    }
}
