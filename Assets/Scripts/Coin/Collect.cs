using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
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
            if(other.name == "Player")
            {
                other.GetComponent<PlayerScript>().AddNewBodyPart();
                Destroy(gameObject);
            }
        }
}
