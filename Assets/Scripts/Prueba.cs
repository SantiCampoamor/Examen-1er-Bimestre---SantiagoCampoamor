using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    public int taxis;
    public int diatotal;
    public int dialluvia;
    
    // Start is called before the first frame update
    // 1 dia = 90km = 6 litros
    // 1 dia lluvia = 110km = 7litros
    void Start()
    {
        if (diatotal < 5)
        {
            Debug.Log("ERROR: Se tienen que ingresar más de 5 dias en total");
        }
        else if (dialluvia < 0)
        {
            Debug.Log("ERROR: Los dias de lluvia tienen que ser mayores a 0");
        }
        else if(dialluvia > diatotal)
        {
            Debug.Log("ERROR: No se puede ingresar mas dias de lluvia que el total de dias");
        }

        else if(diatotal >= 5)
        {
            Debug.Log("Una flota de " + taxis + " unidades trabajando durante " + diatotal +
                "días implicará un gasto de " +  (taxis*(diatotal*6 + dialluvia*7))*130 + " pesos en concepto de combustible");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
