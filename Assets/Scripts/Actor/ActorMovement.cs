using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorMovement : MonoBehaviour
{
    [SerializeField] private Vector2 speed;

    private IInput input;
    private new Rigidbody2D rigidbody;

    private void Start()
    {
        input = GetComponent<IInput>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 moveDirection = new Vector2(input.Horizontal, input.Vertical).normalized;

        Vector3 moveDelta = new Vector3(moveDirection.x * speed.x, moveDirection.y * speed.y, 0);

        Vector3 pushDirection = Vector3.zero;

        moveDelta += pushDirection;
        pushDirection = Vector3.Lerp(pushDirection, Vector3.zero, 0f);

        rigidbody.MovePosition(transform.position + moveDelta * Time.deltaTime);
    }
}
