using UnityEngine;
public class onGround : MonoBehaviour
{
    public float distanceToCheck = 0.5f;
    public bool isGrounded;
    private void Update()
    {
        if (Physics.Raycast(transform.position, Vector2.down, distanceToCheck))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
}