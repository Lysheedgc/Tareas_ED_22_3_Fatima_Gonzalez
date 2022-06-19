using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soltar : MonoBehaviour
{
    public Color color1;
    public string mensaje;

    void OnMouseUp()
    {
        //Destruye un objeto después de hacer click en el
        //Destroy(gameObject);
        Debug.Log (mensaje);
    }
}
