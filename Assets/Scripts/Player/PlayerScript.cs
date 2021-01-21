using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed;
    public float RotateSpeed;

    public List<GameObject> bodyParts = new List<GameObject>();
    public GameObject bodyPref;

    public float z_offset = 0.1f;

    void Start () 
    {
        bodyParts.Add(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.up * -1 * RotateSpeed * Time.deltaTime);
           }
    }

    public void AddNewBodyPart()
    {
        Vector3 newBodyPartPos = bodyParts[bodyParts.Count - 1].transform.position;
        newBodyPartPos.z -= z_offset;
        bodyParts.Add(GameObject.Instantiate(bodyPref, newBodyPartPos, Quaternion.identity) as GameObject);
    }
}

