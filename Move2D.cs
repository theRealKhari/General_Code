using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2D : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float jumpAmount = 5f;
    public bool canJump = true;
    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start(){
        
    }


    // Update is called once per frame
    void Update()
    {
    Jump();

    // Movement
    Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
    transform.position += movement * Time.deltaTime * moveSpeed;
        
    }
    
    void Jump() {
    
    if (Input.GetButtonDown("Jump") && canJump){
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpAmount), ForceMode2D.Impulse);
        canJump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        // allow jumping again
        canJump = true;
    }

    private void OnCollisionExit2D(Collision2D col)
    {

    }

}