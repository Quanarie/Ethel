using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorMovement : MonoBehaviour
{
    [SerializeField] private Vector2 speed;

    private IMoveDirection direction;
    private new Rigidbody2D rigidbody;

    private void Start()
    {
        direction = GetComponent<IMoveDirection>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 moveDirection = new Vector2(direction.Horizontal, direction.Vertical).normalized;

        Vector3 moveDelta = new Vector3(moveDirection.x * speed.x, moveDirection.y * speed.y, 0);

        rigidbody.MovePosition(transform.position + moveDelta * Time.deltaTime);
    }
}
