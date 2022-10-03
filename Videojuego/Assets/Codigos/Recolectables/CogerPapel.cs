using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogerPapel : MonoBehaviour
{

    public AudioSource EfectoPapel;

    void OnTriggerEnter(Collider other){

        EfectoPapel.Play();
        //Logra quitar el objeto del escenario cuando el personaje pasa a través de este
        this.gameObject.SetActive(false);

    }//Fin método

}//Fin clase
