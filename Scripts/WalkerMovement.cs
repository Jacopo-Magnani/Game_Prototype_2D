using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkerMovement : MonoBehaviour
{
    public float speed;
    float distance;  

    public List<Transform> points;
    public int nextID = 0;
    int idChangeValue = 1;

    private bool isWall;
    private bool movingRight = true;

    public Transform isGround;

    void Update()
    {
        MoveToNextPoint();
        /*transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(isGround.position, Vector2.down, distance);

        if(groundInfo.collider == false) 
        {
            if(movingRight == true) {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }

            else 
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }*/

        void MoveToNextPoint()
        {
            Transform goalPoint = points[nextID];
           
            if(goalPoint.transform.position.x > transform.position.x)
            {
                transform.localScale = new Vector3(15, 15, 0);
            }
            
            else 
            {
                transform.localScale = new Vector3(-15, 15, 0);
            }

            transform.position = Vector2.MoveTowards(transform.position, goalPoint.position, speed * Time.deltaTime);

            if (Vector2.Distance(transform.position, goalPoint.position) < 1f)
            { 
                if (nextID == points.Count - 1) {
                    idChangeValue = -1;
                }

                if (nextID == 0) {
                    idChangeValue = 1;
                }   

                nextID += idChangeValue;
            }
        }


    }


}
