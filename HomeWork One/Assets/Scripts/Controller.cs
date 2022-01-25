using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public GameObject punchPrompt;

    public float speed = 2;

    bool punch = false;
    
    // Start is called before the first frame update
    void Start()
    {
        punchPrompt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(punch);

        #region Controls
        Vector3 newPos = transform.position;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Debug.Log("You pressed up.");
            newPos.z += Time.deltaTime * speed;
        }      //if the player presses the up key the character moves forward.
        if (Input.GetKey(KeyCode.DownArrow))
        {
            newPos.z -= Time.deltaTime * speed;
        }    //if the player presses the down key the character moves backward.
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            newPos.x -= Time.deltaTime * speed;
        }    //if the player presses the left key the character moves to the left. 
        if (Input.GetKey(KeyCode.RightArrow))
        {
            newPos.x += Time.deltaTime * speed;
        }   //if the player presses the right key the character moves to the right.

        transform.position = newPos; //updates the character's position.
        #endregion

        #region PunchPrompt
        if (punch == false)
        {
            punchPrompt.SetActive(false);
        }
        
        if (punch == true)  //if punch variable is true, prompt is destroyed.
        {
            punchPrompt.SetActive(true);

            if (Input.GetKey(KeyCode.Space))
            {
                Debug.Log("You punched a donkey!");
            }
        }
        #endregion

    }

    private void OnTriggerEnter(Collider other) //if the player enters the Donkey's collider;
    {
        punch = true; //sets the punch variable to true. 
        //Debug.Log("punch the donkey");
    }

    private void OnTriggerExit(Collider other) //if the player exits the Donkey's collider;
    {
        punch = false; //sets the punch variable to false.  
    }
}

