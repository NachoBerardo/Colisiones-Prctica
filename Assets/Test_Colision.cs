using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Colision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter()
    {
        Debug.Log("Contacto");
    }

    void OnCollisionExit()
    {
        Debug.Log("No contacto");
    }

    void OnCollisionStay()
    {
        Debug.Log("En contacto");
    }

    /* Primera coindicion: Que los elementos de la coision tenga un colider. Necesitamos un BoxColider que es parecido a una hitbox. El colider debe tener
     una opcion que sea triger desactivado

    Segunda condicion: Deben tener por lo menos un rigidbody. "Is Kinematic" debe estar descativado 

    Tercera condicion: Debe haber una funcion on collision
    */
}
