using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public UIManager hatCount;
    public string hatType;
    public bool unique;
    public bool unlocked;
    public pauseMenu pauseMenu;
    public AudioSource collect;

    private void OnTriggerEnter(Collider other)
    {
        if (unique)
        {
            hatCount.uniqueHats += 1;
        }

        if (hatType == "skull" && pauseMenu.skullUnlocked == false)
        {
            pauseMenu.skullUnlocked = true;
            pauseMenu.equipSkull();
        }
        if (hatType == "bucket" && pauseMenu.bucketUnlocked == false)
        {
            pauseMenu.bucketUnlocked = true;
            pauseMenu.equipBucket();
        }
        if (hatType == "chefHat" && pauseMenu.chefHatUnlocked == false)
        {
            pauseMenu.chefHatUnlocked = true;
            pauseMenu.equipChefHat();
        }
        if (hatType == "helmet" && pauseMenu.helmetUnlocked == false)
        {
            pauseMenu.helmetUnlocked = true;
            pauseMenu.equipHelmet();
        }
        if (hatType == "propellerCap" && pauseMenu.propellerCapUnlocked == false)
        {
            pauseMenu.propellerCapUnlocked = true;
            pauseMenu.equipPropellerCap();
        }
        if (hatType == "box" && pauseMenu.boxUnlocked == false)
        {
            pauseMenu.boxUnlocked = true;
            pauseMenu.equipBox();
        }
        if (hatType == "cone" && pauseMenu.coneUnlocked == false)
        {
            pauseMenu.coneUnlocked = true;
            pauseMenu.equipCone();
        }
        if (hatType == "redCap" && pauseMenu.redCapUnlocked == false)
        {
            pauseMenu.redCapUnlocked = true;
            pauseMenu.equipRedCap();
        }
        if (hatType == "spikyWig" && pauseMenu.wigUnlocked == false)
        {
            pauseMenu.wigUnlocked = true;
            pauseMenu.equipWig();
        }
        if (hatType == "securityCap" && pauseMenu.securityCapUnlocked == false)
        {
            pauseMenu.securityCapUnlocked = true;
            pauseMenu.equipSecurityCap();
        }
        if (hatType == "plate" && pauseMenu.plateUnlocked == false)
        {
            pauseMenu.plateUnlocked = true;
            pauseMenu.equipPlate();
        }

        if (other.CompareTag("Player"))
        {
            hatCount.hatCount += 1;
            collect.Play();
            Destroy(gameObject);
        }
    }
}
