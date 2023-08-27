using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using Unity.Mathematics;
using System.Runtime.CompilerServices;

public class SlappyBird : MonoBehaviour
{
    private Rigidbody2D myRigidbody;
    [SerializeField] private float jumpForce;
    public float moveSpeed;

    bool moving = true;
    public int score;
    
    [SerializeField] private TextMeshProUGUI scoreText;

    public GameObject block;

    public float minY = -10;
    public float maxY = 10;


    private void Awake()
    {
        myRigidbody= GetComponent<Rigidbody2D>();   

        score = 0;
        
    }

    private void Update()
    {
        scoreText.text = ("Score: " + score.ToString());
        
        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }


    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.CompareTag("Block"))
        {
            moving = false;


            myRigidbody.gravityScale = 5.0f;


        }
        if (collision.CompareTag("ScorePoint"))
        {
            score++;
            spawnBlocks(); 


        }
       

    }

    

    private void FixedUpdate()
    {
        if(moving == true)
        {
            transform.Translate(transform.right * moveSpeed * Time.deltaTime);
        }
        
       

    }
  
    private void Jump()
    {
       myRigidbody.velocity = Vector2.zero;
            myRigidbody.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        



        
    }

    private void spawnBlocks()
    {
        

        float randomY = UnityEngine.Random.Range(minY, maxY);

       
        Instantiate(block, transform.position + new Vector3(7, randomY, 0),quaternion.identity);


    }

    

}
