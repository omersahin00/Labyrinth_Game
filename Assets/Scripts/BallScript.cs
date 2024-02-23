using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float speed;
    public bool canMove;

    private void Start()
    {
        canMove = true;
    }

    void Update()
    {
        if (canMove)
            Move();
    }

    private void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime);
    }
}
