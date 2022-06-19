using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public string mensaje;
    void OnMouseDown()
    {
        //Destruye un objeto después de hacer click en el
        Destroy(gameObject);
        Debug.Log(mensaje);
    }
}
