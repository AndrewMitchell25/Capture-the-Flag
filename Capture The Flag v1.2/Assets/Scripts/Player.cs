﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static GameVariables;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public bool isTagged;
    public bool captured;
    public bool pickedUp;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    public GameObject jail;
    public Animator camAnim;
    public float waitTime2 = 2f;
    public float waitTime4 = 10;
    public bool movement = true;
    public GameObject effect;
    public Vector3 outOfJail;
    public CircleCollider2D collider1;
    public Animator score;
    public int playerNum;
    public int team;
    public int enemy;


    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Awake()
    {
        StartCoroutine(PauseControls(2));
    }

    void Update()
    {

        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal " + playerNum), Input.GetAxisRaw("Vertical " + playerNum));
        moveVelocity = moveInput.normalized * speed;

        if (team == 1 && transform.position.x <= -0.5f && pickedUp == true)
        {
            captured = true;
            redScore += 1;
            Restart();
        }

        if (team == 2 && transform.position.x >= 0.5f && pickedUp == true)
        {
            captured = true;
            blueScore += 1;
            Restart();
        }
    }

    void FixedUpdate()
    {

        if (isTagged == true)
        {

            transform.position = jail.transform.position;
            Instantiate(effect, transform.position, Quaternion.identity);
            camAnim.SetTrigger("Shake");
            isTagged = false;
            pickedUp = false;

            if (twoPlayers == false)
            {
                StartCoroutine(GetOutOfJail(waitTime4));
            }
            else
            {
                StartCoroutine(GetOutOfJail(waitTime2));
            }

            
        }
        else
        {
            if (movement == true)
            {
                rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
            }
            
        }

    }
    //private void OnTriggerExit2D(Collider2D other)
    //{
    //    if (other.name == "Flag " + enemy)
    //    {
    //        pickedUp = false;
    //    }
    //}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Flag " + enemy)
        {
            pickedUp = true;
            
        }

        if (other.CompareTag("Team" + enemy))
        {
            if (team == 1)
            {
                isTagged |= (transform.position.x > 0 && movement == true);
            }

            if(team == 2)
            {
                isTagged |= (transform.position.x < 0 && movement == true);
            }
        }

        if (other.CompareTag("Team" + team))
        {
            if (movement == false)
            {
                transform.position = outOfJail;
                Instantiate(effect, transform.position, Quaternion.identity);
                collider1.enabled = true;
                movement = true;
            }

        }
    }

    IEnumerator PauseControls(float time)
    {
        movement = false;
        yield return new WaitForSecondsRealtime(time);
        
        movement = true;
    }

    IEnumerator GetOutOfJail(float time)
    {
        movement = false;
        collider1.enabled = false;
        yield return new WaitForSecondsRealtime(time);
        if (movement == false)
        {
            transform.position = outOfJail;
            Instantiate(effect, transform.position, Quaternion.identity);
            movement = true;
            collider1.enabled = true;
        }
    }

    
}

