using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public float speed = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 newPos = transform.position;
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Debug.Log("You pressed up.");
            newPos.z += Time.deltaTime * speed;
        }

        transform.position = newPos;
    }
}
