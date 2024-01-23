using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float directionX = 0.005f;
    float directionY = 0.005f;
    
    
    void Start()
    {
        
    }




    
    void Update()
    {
        if (transform.position.x < 10.0f || transform.position.y < -15.0f)
        {
            directionX -= 0.005f;
            directionY += 0.005f;
        }

        if (transform.position.x < -10.0f && transform.position.y < 3.5f)
        {
            directionX += 0.005f;
            directionY -= 0.005f;
        }

        transform.position += new Vector3(directionX, directionY, 0);
    }
}
