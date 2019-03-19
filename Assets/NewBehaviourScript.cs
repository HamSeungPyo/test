using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject bon;
    public float speed = 5;
    void Start()
    {
        
    }

    void Update()
    {
        Debug.Log(transform.forward.normalized);
        if (Input.GetKey(KeyCode.Space))
        {
            bon.transform.position -= transform.right.normalized * Time.deltaTime* speed;
        }
    }
}
