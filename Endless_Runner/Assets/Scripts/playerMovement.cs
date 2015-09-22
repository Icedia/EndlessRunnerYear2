using UnityEngine;
using System.Collections;

/*/Author: Rishaad Hausil /*/

public class playerMovement : MonoBehaviour
{
    
    public Transform groundCheck;
    public float rdius;
    public LayerMask ground;

    private bool _onGround;
    private bool _doubleJumped;
    private float _jumpHeight = 8;

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if(_onGround)
        {
            _doubleJumped = false;
        }

        _onGround = Physics2D.OverlapCircle(groundCheck.transform.position, rdius, ground);

        if(Input.GetKeyDown(KeyCode.Space) && _onGround)
        {
            Jump();
        }

        if (Input.GetKeyDown(KeyCode.Space) && !_doubleJumped && !_onGround)
        {
            Jump();
            _doubleJumped = true;
        }
      }
    private void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, _jumpHeight);
    }
}
