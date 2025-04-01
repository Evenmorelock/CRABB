using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public int hatCount;
    public TMPro.TextMeshProUGUI hatCounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hatCounter.text = "Hats (Optional):" + hatCount;
    }
}
