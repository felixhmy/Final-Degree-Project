/// Realizado por: Félix Hernández Muñoz-Yusta

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 2;
    public float jump = 3;

    Vector2 initialPosition = new Vector2(-2.323f, -1.203f);
    Rigidbody2D rigidbody;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        Movimiento();
        ResetPosition();

        animator.SetFloat("Velocity", rigidbody.velocity.y);

        if (CheckGround.touching)
        {
            animator.SetBool("inGround", true);
        }
        else
        {
            animator.SetBool("inGround", false);
        }
    }

    void Movimiento()
    {
        bool isMoving = false;

        /// Movimiento teclas
        if (Input.GetKey(KeyCode.D)) /// Derecha
        {
            rigidbody.velocity = new Vector2(speed, rigidbody.velocity.y);
            isMoving = true;
            /// El personje mira a la derecha
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        else if (Input.GetKey(KeyCode.A)) /// Izquierda
        {
            rigidbody.velocity = new Vector2(-speed, rigidbody.velocity.y);
            isMoving = true;
            /// El personaje mira a la izquierda
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        else
        {
            rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);
        }

        animator.SetBool("Movement", isMoving);

        /// Salto
        if (Input.GetKey(KeyCode.Space) && CheckGround.touching)
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, jump);
            animator.SetBool("Jumped", true);
        }else if (CheckGround.touching)
        {
            animator.SetBool("Jumped", false);
        }
    }

    void ResetPosition()
    {
        /// Volver al origen
        if (Input.GetKey(KeyCode.R))
        {
            transform.position = initialPosition;
            rigidbody.velocity = Vector2.zero;
        }
    }
}