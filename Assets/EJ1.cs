using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ1 : MonoBehaviour
{
    public int cantidadDeUnidades;
    public int periodoDeDias;
    int costoTotalCombustible;
    public int diasLluvia;
    int dia = (90 / 15) * 130;
    int lluvia = (110 / 15) * 130;
    

    // Start is called before the first frame update
    void Start()
    {
        costoTotalCombustible = (((periodoDeDias - diasLluvia) * dia) + (diasLluvia * lluvia)) * cantidadDeUnidades;

        if(periodoDeDias > 5 && diasLluvia >= 0 && periodoDeDias > diasLluvia)
        {
            Debug.Log("Una flota de " + cantidadDeUnidades + " unidades trabajando durante " + periodoDeDias + " días implicará un gasto de " + costoTotalCombustible + " pesos en concepto de combustible.");
        }
        else
        {
            Debug.Log("Error, se necesita tener cantidad de días total es mayor a 5 y que la cantidad de días de lluvia sea positiva y menor que la cantidad total de días.");
        }
    }

    // Update is called once per frame 
    void Update()
    {
        
    }
}
