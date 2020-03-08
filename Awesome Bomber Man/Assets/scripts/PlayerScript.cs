using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 10f;
    private float minX = -2.55f;
    private float maxX = 2.55f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }
    
    void MovePlayer()
    {
        float h = Input.GetAxis("Horizontal");
        Vector2 CurrentPosition = transform.position; // X and Y

        if (h > 0)
        {
            // going to the right side
            CurrentPosition.x += speed * Time.deltaTime;
        }
        else if(h < 0)
        {
            // going to the left side
            CurrentPosition.x -= speed * Time.deltaTime;
        }

        if (CurrentPosition.x < minX)
        {
            CurrentPosition.x = minX;
        }
        if (CurrentPosition.x > maxX)
        {
            CurrentPosition.x = maxX;
        }

        transform.position = CurrentPosition;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bomb") // if we colided with the bomb
        {
            Time.timeScale = 0f; // this is how we pause the game
        }
    }
} // class
