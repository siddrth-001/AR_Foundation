using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoOff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         Invoke("SetOff", 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void SetOff()
    {
        
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
