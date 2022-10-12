using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Iniciar_Juego : MonoBehaviour
{
    
    void Start()
    {
        
    }//Fin método
    
    void Update()
    {
        
    }//Fin método

    public void PrimerNivelJuego(){

        SceneManager.LoadScene("SampleScene");
        PuntosExperiencia.Contador_Experiencia = 0;
        PuntosExperiencia.Contador_Rollos = 0;

    }//Fin método

}//Fin clase
