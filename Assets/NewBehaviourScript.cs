using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sprite.color = Color.blue;
        }
    }
}
