using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntosExperiencia : MonoBehaviour
{
   
    public static int Contador_Experiencia;
    public static int Contador_Rollos;
    public GameObject Valor_Puntos_Experiencia;
    public GameObject Valor_Cantidad_Rollos;

    void Start()
    {
        
    }//Fin método

   
    void Update()
    {
        
        Valor_Puntos_Experiencia.GetComponent<Text>().text = "" + Contador_Experiencia;
        Valor_Cantidad_Rollos.GetComponent<Text>().text = "" + Contador_Rollos;

    }//Fin método
}//Fin clase
