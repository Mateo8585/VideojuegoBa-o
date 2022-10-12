using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interfaz_Puntaje : MonoBehaviour
{

    public float Rango_Deteccion;
    public LayerMask Capa_Jugador;

    bool Activacion;

    void Start()
    {
        
    }//Fin método


    void Update()
    {
        //Se crea una esfera alrededor del objeto "baño" para que detecte la llegada el jugador. Regresa un valor verdadero o falso
        Activacion = Physics.CheckSphere(transform.position, Rango_Deteccion, Capa_Jugador);

        //Condición para desplegar interfaz de puntaje final
        if(Activacion == true){
            SceneManager.LoadScene("Interfaz_Puntaje");
        }//Fin condición

    }//Fin método

    //Método para dibujar la esfera creada
    private void OnDrawGizmos(){
        Gizmos.DrawWireSphere(transform.position, Rango_Deteccion);
    }//Fin método

}//Fin clase
