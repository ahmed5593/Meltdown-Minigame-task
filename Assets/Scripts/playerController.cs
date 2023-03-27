using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : characterController
{
    private void Start()
    {
        GameManager._instance.playerAlive = true;
    }

    void Update()
    {

        jumpWithTransform((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)));
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            rb.isKinematic = false;
            collider.isTrigger = false;
            isDead = true;
            GameManager._instance.LevelFail();
        }
    }

}
