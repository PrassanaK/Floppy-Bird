using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirbScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("BirdIsAlive: " + birdIsAlive.ToString());
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            Debug.Log("Input registered");
            myRigidBody.linearVelocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        //Debug.Log("Collision detected with: " + collision.gameObject.name);
        birdIsAlive = false;
        //Debug.Log("birdIsAlive set to: " + birdIsAlive);
    }
}
