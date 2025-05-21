using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcChatter : MonoBehaviour
{
    public GameObject chatter;
    public AudioSource talk;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            chatter.SetActive(true);
            talk.Play();
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        { 
            chatter.SetActive(false); 
        }
    }
}
