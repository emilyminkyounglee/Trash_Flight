using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class Coin : MonoBehaviour
{
    private float minY = -7f; 
    // Start is called before the first frame update
    void Start()
    {
        void Jump()
        {
            Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();

            float randomJumpForce = Random.Range(2f, 10f);
            Vector2 jumpVelocity = Vector2.up * randomJumpForce;
            jumpVelocity.x = Random.Range(-4f, 4f);
            rigidBody.AddForce(jumpVelocity, ForceMode2D.Impulse);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < minY)
        {
            Destroy(gameObject);
        }
    }
}
