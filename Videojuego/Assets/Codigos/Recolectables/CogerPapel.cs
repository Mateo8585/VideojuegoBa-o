using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CogerPapel : MonoBehaviour
{

    public AudioSource EfectoPapel;
    private Slider Tranquilidad;

     void Start(){
        Tranquilidad = GameObject.Find("Barra_Tranquilidad").GetComponent<Slider>();
    }//Fin método

    void OnTriggerEnter(Collider other){

        //Ejecuta el sonido de coger cosa
        EfectoPapel.Play();

        //Se modifica el canvas
        PuntosExperiencia.Contador_Experiencia += 100;
        PuntosExperiencia.Contador_Rollos += 1;

        //Cuando el objeto desaparezca, entonces se sube una porción de la barra de tranquilidad
        BarraDeTranquilidad.Contador = 0;
        Tranquilidad.value = Tranquilidad.value + 3;
        
        //Logra quitar el objeto del escenario cuando el personaje pasa a través de este
        this.gameObject.SetActive(false);

    }//Fin método

}//Fin clase
