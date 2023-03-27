using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class characterController : MonoBehaviour
{

    [SerializeField] onGround GroundCheckScript;
    public bool isDead = false;
    public Rigidbody rb;
    public CapsuleCollider collider;
    public float jumpForce = 20;
    public float gravity = -9.81f;
    public float gravityScale = 5;
    float velocity;
    int jumpCount = 0;

    public void jumpWithRigidBody()
    {

    }

    public void jumpWithTransform(bool check)
    {
        velocity += gravity * gravityScale * Time.deltaTime;
        if (GroundCheckScript.isGrounded && velocity < 0)
        {
            velocity = 0;
            jumpCount = 0;
        }
        if (check && jumpCount < 2 && !isDead)
        {
            velocity = jumpForce;
            jumpCount += 1;
        }
        transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);

    }

}
