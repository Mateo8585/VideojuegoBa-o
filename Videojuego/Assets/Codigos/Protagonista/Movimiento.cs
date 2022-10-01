using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    //Variable que asocia la velocidad con la que se moverá el personaje verticalmente
    public float Velocidad = 3;

    //Variable que asocia la velocidad con la que se moverá el personaje horizontalmente
    public float Velocidad_Horizontal = 4;

    //Variable que asocia la fuerza con la que saltará el personaje
    public float Fuerza_Salto = 1.0f;

    private Rigidbody FisicaObjeto;

    private float Distancia_Suelo; 

    void Start()
    {
        
        //Agrega una física al personaje para que logre saltar en el escenario
        FisicaObjeto = GetComponent<Rigidbody>();
        Distancia_Suelo = GetComponent<Collider>().bounds.extents.y;

    }//Fin método

    //Método para verificar si el personaje está en el suelo o no
    private bool IsGrounded(){

        return Physics.BoxCast(transform.position, new Vector3(0.4f, 0f, 0.4f), Vector3.down, Quaternion.identity, Distancia_Suelo + 0.1f);

    }//Fin método

    
    void Update()
    {

        //Translada al personaje en el eje Z apartir de la velocidad definida
        transform.Translate(Vector3.forward * Time.deltaTime * Velocidad, Space.World);

        //Esta lógica funciona cuando se presiona la tecla A para que el personaje se mueva a la izquierda
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){

            transform.Translate(Vector3.left * Time.deltaTime * Velocidad_Horizontal);

        }//Fin primera condición

        //Esta lógica funciona cuando se presiona la tecla D para que el personaje se mueva a la Derecha
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){

            transform.Translate(Vector3.left * Time.deltaTime * Velocidad_Horizontal * -1);

        }//Fin primera condición

        //Devuelve un true para que entre en la condición
        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded()){

            FisicaObjeto.AddForce(new Vector3(0, Fuerza_Salto, 0), ForceMode.Impulse);

        }//Fin condición
        
    }//Fin método

}//Fin clase
