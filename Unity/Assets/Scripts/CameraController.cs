using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    /// Transform del player
    public Transform player;

    /// Transform del fondo
    public Transform background;

    /// Ajustar la posición de la cámara respecto al player
    public Vector3 offset;

    /// Velocidad de suavizado
    public float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        /// Posición final de la cámara
        Vector3 finalPosition = player.position + offset;

        /// Suavizado del movimiento
        Vector3 smoothed = Vector3.Lerp(transform.position, finalPosition, smoothSpeed);

        /// Update final de la cámara
        transform.position = smoothed;

        /// Mantener el fondo en la misma posición que la cámara
        if (background != null)
        {
            background.position = new Vector3(transform.position.x, transform.position.y, background.position.z);
        }
    }
}
