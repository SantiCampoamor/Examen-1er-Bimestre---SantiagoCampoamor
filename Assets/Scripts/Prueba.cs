using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    public int taxis;
    public int dia;
    public int dialluvia;
    public int Litros;
    // Start is called before the first frame update
    void Start()
    {
        if (dia + dialluvia < 5)
        {
            Debug.Log("ERROR: Se tienen que ingresar más de 5 dias en total");
        }
        else if (dialluvia < 0)
        {
            Debug.Log("ERROR: Los dias de lluvia tienen que ser mayores a 0");
        }
        else if(dia + dialluvia >= 5)
        {
            Debug.Log("Una flota de" + taxis + "unidades trabajando durante" + dia + dialluvia +
                "días implicará un gasto de" + Litros*130 + "pesos en concepto de combustible");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
