using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2D : MonoBehaviour
{
    public float moveSpeed = 10f;
    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start(){

    }


    // Update is called once per frame
    void Update()
    {
    // Movement
    Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
    transform.position += movement * Time.deltaTime * moveSpeed;
        
    }
    

}