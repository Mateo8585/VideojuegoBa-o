using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionPapel : MonoBehaviour
{

    public int Velocidad_Rotacion = 1; 
    
    void Start()
    {
        
    }//Fin método

    
    void Update()
    {
        
        transform.Rotate(0, Velocidad_Rotacion, 0, Space.World);

    }//Fin método

}//Fin clase
