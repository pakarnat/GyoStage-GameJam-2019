using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableRotation : MonoBehaviour
{

    Transform table;
    [SerializeField]
    GameObject PlayerBall;
    [SerializeField]
    float speed = 1.0f;
    [SerializeField]
    bool wrongControls = false;

    
    void Start()
    {        
        table = GetComponent<Transform>();        
    }  

    // Update is called once per frame
    void FixedUpdate()
    {
        if (wrongControls)
        {

            table.Rotate(new Vector3(-Input.GetAxis("Mouse X"), 0, -Input.GetAxis("Mouse Y")) * Time.deltaTime * speed);
        }
        else
        {
            table.Rotate(new Vector3(Input.GetAxis("Mouse Y"), 0, Input.GetAxis("Mouse X")) * Time.deltaTime * speed);
        }
    }
}
