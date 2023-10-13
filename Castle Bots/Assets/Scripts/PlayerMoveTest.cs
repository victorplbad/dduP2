using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using UnityEngine;

public class PlayerMoveTest : MonoBehaviour
{
   public GameObject player;

    public int speed = 1;

    // Update is called once per frame
    void Update()
    {
       
        
            transform.position = player.transform.position;

         if (Input.GetKey(KeyCode.A))
         {
            transform.Rotate(new Vector2(0, -1) * Time.deltaTime * speed);
         }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector2(1, 0) * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector2(-1, 0) * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector2(0, 1) * Time.deltaTime * speed);
        }


    }
}
