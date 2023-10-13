using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveTest : MonoBehaviour
{
   public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;

         if (Input.GetKey(KeyCode.A))
         {
            transform.Rotate(new Vector3(0, -1) * Time.deltaTime * 100, Space.World);
         }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(1, 0) * Time.deltaTime * 100, Space.World);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(-1, 0) * Time.deltaTime * 100, Space.World);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 1) * Time.deltaTime * 100, Space.World);
        }


    }
}
