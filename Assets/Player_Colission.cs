using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Colission : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0)
        {
            transform.position = new Vector3(0, 3, 0);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Death Wall")
        {
            transform.position = new Vector3(0, 3, 0);
        }
    }
}
