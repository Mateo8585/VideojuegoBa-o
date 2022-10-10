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

    }//Fin método

}//Fin clase
