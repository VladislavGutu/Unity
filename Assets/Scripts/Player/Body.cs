using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Body : MonoBehaviour
{

    public float speed;
    public Vector3 lastBodypart;
    public GameObject lastBodypartObj;
    public PlayerScript mainPlayer;

    public int indx;

    void Start()
    {
        
        mainPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
        speed = mainPlayer.speed;
        indx = mainPlayer.bodyParts.IndexOf(gameObject);
        lastBodypartObj = mainPlayer.bodyParts[mainPlayer.bodyParts.Count - 2];
        
       
    }

    // Update is called once per frame
    void Update()
    {
        lastBodypart = lastBodypartObj.transform.position;
        lastBodypart.z -= mainPlayer.z_offset;
        transform.LookAt(lastBodypart);
        transform.position = Vector3.Lerp(transform.position, lastBodypart, Time.deltaTime * speed);

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(indx > 2)
            {
                //Application.LoadLevel(Application.loadedLevel);
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
}
