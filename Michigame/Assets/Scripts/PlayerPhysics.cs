using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysics : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();

    }

    public void MoveFoward(float speed, float direction)
    {
        rigidbody.AddForce(new Vector2(speed * direction, rigidbody.velocity.y));
    }

    public void Jump(float force)
    {
        rigidbody.AddForce(transform.up * force);
    }
    
}
