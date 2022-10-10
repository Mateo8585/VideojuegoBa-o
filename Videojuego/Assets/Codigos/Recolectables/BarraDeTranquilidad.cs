using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeTranquilidad : MonoBehaviour
{

    public Slider BarraT;
    private float ValorMaximo = 100;
    private float ValorActual;
    public static int Contador = 0;

    void Awake(){
        BarraT.GetComponent<Slider>();
    }

    void Start()
    {
        //Se establece que la barra esté al comienzo en su máximo valor
        BarraT.value = 100;

        //Invoca el método "DinámicaBarra" la cantidad de veces necesarias
        InvokeRepeating("DinamicaBarra", 1.0f, 0.2f);
    }//Fin método

    void Update()
    {   

    }//Fin método

    //Este método modifica el estado del slider que funcionará como la barra de tranquilidad
    void DinamicaBarra(){
        Contador = Contador + 1;
        ValorActual = Contador;
        BarraT.value = ValorMaximo - ValorActual;
    }//Fin método

}//Fin clase
