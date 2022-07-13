using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float velocidad = 0.5f;
    public float salto = 10.0f;
    public GameObject persona;
    public Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = persona.AddComponent<Rigidbody2D>();
        transform.position = new Vector3(-8.277f, 3.32f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.S))
        {
           transform.position += Vector3.down *velocidad *Time.deltaTime;
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            rb2d.AddForce(transform.up * salto, ForceMode2D.Impulse);
        }
        if(Input.GetKey(KeyCode.A))
        {
           transform.position += Vector3.left *velocidad *Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D))
        {
           transform.position += Vector3.right *velocidad *Time.deltaTime;
        }
    }
}
