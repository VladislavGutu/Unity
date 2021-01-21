using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") || other.CompareTag("PlayerBody"))
        {
            //Application.LoadLevel(Application.loadedLevel);
            SceneManager.LoadScene("SampleScene");
        }

    }
    
}
