using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Puntaje_Logica : MonoBehaviour
{
   
    public GameObject Puntaje_Final;
    public GameObject Cantidad_Total_Rollos;

    void Start()
    {
        
    }//Fin método

    
    void Update()
    {
        Puntaje_Final.GetComponent<Text>().text = "" + PuntosExperiencia.Contador_Experiencia;
        Cantidad_Total_Rollos.GetComponent<Text>().text = "" + PuntosExperiencia.Contador_Rollos;
    }//Fin método

    public void Puntaje_Regresar_Menu(){
        SceneManager.LoadScene("Menu_Principal");
        PuntosExperiencia.Contador_Experiencia = 0;
        PuntosExperiencia.Contador_Rollos = 0;
    }//Fin método

    public void Puntaje_Jugar_Nuevamente(){
        SceneManager.LoadScene("SampleScene");
        PuntosExperiencia.Contador_Experiencia = 0;
        PuntosExperiencia.Contador_Rollos = 0;
    }//Fin método

}//Fin clase
