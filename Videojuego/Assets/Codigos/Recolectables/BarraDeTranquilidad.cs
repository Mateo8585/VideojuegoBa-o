using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeTranquilidad : MonoBehaviour
{

    public Slider BarraT;
    public float ValorMaximo;
    private float ValorActual;
    private int Contador = 0;

    void Start()
    {
        Contador = Contador + 1;
        ValorActual = Contador;
        BarraT.GetComponent<Slider>().value = ValorMaximo / ValorActual;
    }//Fin método

    void Update()
    {

        //BarraT.GetComponent<Slider>().value = 10;

    }//Fin método

    void DinamicaBarra(){
        Contador = Contador + 1;
        ValorActual = Contador;
        BarraT.GetComponent<Slider>().value = ValorMaximo / ValorActual;

    }//Fin método

}//Fin clase
