using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public Rigidbody rb;
    public float jumpForce;


    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        rb.AddForce(Vector3.up * jumpForce);

        string materialName = other.gameObject.GetComponent<MeshRenderer>().material.name;

        if (materialName == "Safe Color (Instance)")
        {

        }
        else if (materialName == "Unsafe Color (Instance)")
        {

        }
        else if (materialName == "Last Ring (Instance)")
        {

        }
    }
}
