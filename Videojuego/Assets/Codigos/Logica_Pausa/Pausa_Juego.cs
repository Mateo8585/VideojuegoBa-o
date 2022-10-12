using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa_Juego : MonoBehaviour
{
    
    public GameObject MenuPausa;

    //Antes de que inicie el juego, específica que la interfaz de menú pausa esté escondida
    void Awake()
    {
        MenuPausa.SetActive(false);
    }//Fin método

    public void Pausar_Boton(){

        MenuPausa.SetActive(true);
        Time.timeScale = 0;

    }//Fin método

    public void Continuar_Boton(){
         MenuPausa.SetActive(false);
         Time.timeScale = 1;
    }//Fin método

    public void Regresar_Menu(){
        SceneManager.LoadScene("Menu_Principal");
        Time.timeScale = 1;
        PuntosExperiencia.Contador_Experiencia = 0;
        PuntosExperiencia.Contador_Rollos = 0;
    }//Fin método

}//Fin clase
