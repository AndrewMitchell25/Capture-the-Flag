using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameVariables;


public class Flag : MonoBehaviour
{
    
    
    private Player player2Script;
    public GameObject player2;
    public GameObject player4;
    private Player player4Script;
    public GameObject effect;
    public Vector3 offset;
    public Vector3 pickedUpSize;
    private Vector3 startingPos;
    private Vector3 startingScale;

    
    void Start()
    {
        
        startingPos = transform.position;
        startingScale = transform.localScale;
        player2Script = player2.GetComponent<Player>();
        if (twoPlayers == false)
        {
            player4Script = player4.GetComponent<Player>();
        }

    }

    
    void Update()
    {
        if (player2Script.pickedUp == true)
        {
            transform.position = player2.transform.position + offset;
            transform.localScale = pickedUpSize;

            if (player2Script.isTagged == true)
            {

                transform.position = startingPos;
                transform.localScale = startingScale;
                Instantiate(effect, transform.position, Quaternion.identity);
            }

        }

        if (twoPlayers == false && player4Script.pickedUp == true)
        {
            transform.position = player4.transform.position + offset;
            transform.localScale = pickedUpSize;

            if (player4Script.isTagged == true)
            {

                transform.position = startingPos;
                transform.localScale = startingScale;
                Instantiate(effect, transform.position, Quaternion.identity);
            }

        }

        //if (player2Script.pickedUp == false && player4Script.pickedUp == false)
        //{
        //    transform.position = startingPos;
        //    transform.localScale = startingScale;
        //}


    }

    
}
