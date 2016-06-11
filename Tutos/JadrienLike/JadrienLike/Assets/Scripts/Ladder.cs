﻿using UnityEngine;
using System.Collections;

public class Ladder : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            GetPlayerFromCollider(other).OnEnterLadder();
        }
    }

    void OnTriggerExit2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            GetPlayerFromCollider(other).OnExitLadder();
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Player player = this.GetPlayerFromCollider(other);
            if(Input.GetKey(KeyCode.UpArrow))
            {
                player.MoveUp();
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                player.MoveDown();
            }
            player.OnStayLadder();
        }
    }

    private Player GetPlayerFromCollider(Collider2D other)
    {
        return other.GetComponentInParent<Player>();
    }
}
