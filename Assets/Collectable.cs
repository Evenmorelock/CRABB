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
        if (unique)
        {
            hatCount.uniqueHats += 1;
        }
        if(other.CompareTag("Player"))
        {
            hatCount.hatCount += 1;
            Destroy(gameObject);
        }
    }
}
