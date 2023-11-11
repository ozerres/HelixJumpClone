using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public Rigidbody rb;

    public GameObject splashPrefab;
    private GameManager gm;

    public float jumpForce;


    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

   
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        rb.AddForce(Vector3.up * jumpForce);
        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0,-0.25f,0), transform.rotation);
        splash.transform.SetParent(other.gameObject.transform);

        string materialName = other.gameObject.GetComponent<MeshRenderer>().material.name;

       
        if (materialName == "Unsafe Color (Instance)")
        {
            gm.RestartGame();
        }
        else if (materialName == "Last Ring (Instance)")
        {

        }
    }
}
