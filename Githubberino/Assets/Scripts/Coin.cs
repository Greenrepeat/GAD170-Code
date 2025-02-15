﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Script: Coin
    Author: Gareth Lockett
    Version: 1.0
    Description:    A simple script for a coin pickup. Make sure the coin object has a collider set to trigger.
                    The script spins/rotates the GameObject it is on.
                    When a GameObject, with a Rigidbody component, enters the trigger, this GameObject will be destroyed.

                    Note: We will update this script in the future to allow a 'score' to increment with each coin we pick up.
*/

public class Coin : MonoBehaviour
{
    public int xpValue = 5;
    public float spinSpeed = 100f;

    void Update()
    {
        this.transform.Rotate( 2f, 2f, Time.deltaTime * this.spinSpeed );
    }

    private void OnTriggerEnter( Collider other )
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerMovement>().GainXP(xpValue);
            Destroy(this.gameObject);
        }
            


    }
}
