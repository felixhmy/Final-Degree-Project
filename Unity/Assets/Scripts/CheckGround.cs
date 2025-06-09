/// Realizado por: Félix Hernández Muñoz-Yusta

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public static bool touching;

    /// Comprueba si esta tocando el suelo para que no salte en el aire
    private void OnTriggerEnter2D(Collider2D collision)
    {
        touching = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        touching = false;
    }
}
