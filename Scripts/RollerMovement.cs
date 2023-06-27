using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerMovement : MonoBehaviour
{
    [SerializeField]
    public float speed;

    private Rigidbody2D body;
    
    private bool isGround;
    private bool isWall;
   
    [SerializeField]
    private Transform groundPosition;
    [SerializeField]
    private float groundDistance;

    [SerializeField]
    private Transform wallPosition;
    [SerializeField]
    private float wallDistance;

    private LayerMask whatIsGround;

    private bool hasTurned;
    private float turnNinety = 90;
    

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        speed = 1f;
        hasTurned = false;

    }

    // Update is called once per frame
    void Update()
    {
        CheckState();
    }

    void FixedUpdate() {
        body.velocity = transform.right * -1;
    }

    void CheckState() 
    {
        isGround = Physics2D.Raycast(groundPosition.position, -transform.up, groundDistance, whatIsGround);
        isWall = Physics2D.Raycast(wallPosition.position, transform.right, wallDistance, whatIsGround);

        if (!isGround)
        {
            if (hasTurned == false)
            {
                turnNinety = 90;
                transform.eulerAngles = new Vector3(0, 0, turnNinety);
                hasTurned = true;
            }
        }

        if (isGround)
        {
            hasTurned = false;
        }

        if (isWall)
        {
            if (!hasTurned)
            {
                turnNinety += 90;
                transform.eulerAngles = new Vector3(0, 0, turnNinety);
            }
        } 
    }

    private void OnDrawGizmos() {
        Gizmos.DrawLine(groundPosition.position, new Vector2(groundPosition.position.x, groundPosition.position.y - groundDistance));
        Gizmos.DrawLine(wallPosition.position, new Vector2(wallPosition.position.x + wallDistance, wallPosition.position.y));
    }
}
