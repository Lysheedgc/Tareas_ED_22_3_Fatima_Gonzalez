using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encima : MonoBehaviour
{
    public string mensaje;

     void OnMouseOver()
    {
        //Destruye un objeto después de hacer click en el
        Destroy(gameObject);
        Debug.Log (mensaje);
    }
}
