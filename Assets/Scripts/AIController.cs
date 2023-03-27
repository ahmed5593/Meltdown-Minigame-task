using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : characterController
{

    public bool shouldJump = false;
    private void Start()
    {
        GameManager._instance.AI_AliveCount += 1;
    }

    // Update is called once per frame
    void Update()
    {
        jumpWithTransform(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            rb.isKinematic = false;
            collider.isTrigger = false;
            isDead = true;
            GameManager._instance.AI_AliveCount -= 1;
            if (GameManager._instance.AI_AliveCount == 0 && GameManager._instance.playerAlive)
            {
                GameManager._instance.levelWin();
            }
        }

        if (other.CompareTag("AIResponse"))
        {
            StartCoroutine(jump());
        }
    }


    IEnumerator jump()
    {
        jumpWithTransform(true);
        yield return new WaitForSeconds(Random.Range(0.05f, 0.3f));
        jumpWithTransform(true);
    }

}
