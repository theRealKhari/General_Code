using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public float fallMultiplier = 4f;
    public float lowJumpMultiplier = 2f;

    Rigidbody2D rb; 

    public bool canJump = true;

    void Awake(){
        rb = GetComponent<Rigidbody2D> ();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.y < 0){
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        } else if (rb.velocity.y > 0 && !Input.GetButton("Jump")){
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
        DoJump();
    }



    void DoJump() {
    
    if (Input.GetButtonDown("Jump") && canJump){
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
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

