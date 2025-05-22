using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopAudio : MonoBehaviour
{
    public AudioSource music;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
        music.Play();
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 190)
        {
            timer = 0;
            music.Play();
        }
    }


}
