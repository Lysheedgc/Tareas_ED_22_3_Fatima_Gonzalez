using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
        texto.text="a: ";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            texto.text="a: De México a Italia son 15 horas de vuelo en promedio.";
        } else if (Input.GetKeyDown(KeyCode.B))
        {
            texto.text="a: De México a España son 11 horas 18 minutos de vuelo en promedio.";
        } else if (Input.GetKeyDown(KeyCode.C))
        {
            texto.text="a: De México a Canadá son 4 horas 30 minutos de vuelo en promedio.";
        } else if (Input.GetKeyDown(KeyCode.D))
        {
            texto.text="a: De México a Japón son 12 horas de vuelo en promedio.";
        }
    }
}
