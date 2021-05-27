using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float deltaRotation = 30f;
    public float deltaMovement = 10f;
    public Color color1;
    public Color color2;
    public Color color3;
    public Color color4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
        Movement();
    }

    void Rotate()
    {
        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(new Vector3(0f, -deltaRotation, 0f) * Time.deltaTime);
        else if (Input.GetKey(KeyCode.E))
            transform.Rotate(new Vector3(0f, deltaRotation, 0f) * Time.deltaTime);
    }

    void Movement()
    {

        if (Input.GetKey("up")){
            transform.Translate(Vector3.forward * deltaMovement * Time.deltaTime);
            GetComponent<Renderer>().material.color = color1;
        }
            
        else if (Input.GetKey("down")){
            transform.Translate(Vector3.back * deltaMovement * Time.deltaTime);
            GetComponent<Renderer>().material.color = color2;
        }
            
        else if (Input.GetKey("left")){
            transform.Translate(Vector3.left * deltaMovement * Time.deltaTime);
            GetComponent<Renderer>().material.color = color3;
        }
            
        else if (Input.GetKey("right")){
            transform.Translate(Vector3.right * deltaMovement * Time.deltaTime);
            GetComponent<Renderer>().material.color = color4;
        }
            

    }
}