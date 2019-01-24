using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //PUBLIC VARIABLE
    public float speed = 10;
    public float jumpSpeed = 500;

    //PRIVATE VARIABLES
    private Rigidbody2D rBody;
    

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        rBody.freezeRotation = true;
    }

    // // Update is called once per frame
    void Update()
    {
        //Space click
        
        if(Input.GetKeyDown(KeyCode.Space)){
            rBody.AddForce(new Vector2(0,jumpSpeed));
        }
    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// Use fixed update for phyics based movement only
    ///
    ///</summary>
    void FixedUpdate()
    {
        float horiz = Input.GetAxis("Horizontal");
        // float vert = Input.GetAxis("Vertical");



        float currentVelocityY = rBody.velocity.y;

        rBody.velocity = new Vector2(horiz*speed,currentVelocityY);
    }
}
