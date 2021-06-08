using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class siguiendoJugador : MonoBehaviour
{
    public Transform player;
    [Range(1,10)] public float smoothFactor;
    public Vector3 offset;
    public Vector3 minValues, maxValues;
    
    
    void FixedUpdate()
    {
        seguirJugador();
    }

    void seguirJugador()
    {
        Vector3 targetPosition = player.position + offset;
        //Esto verifica si se sale de los limites o no
        Vector3 boundPosition = new Vector3(
            Mathf.Clamp(targetPosition.x,minValues.x,maxValues.x),
            Mathf.Clamp(targetPosition.y,minValues.y,maxValues.y),
            Mathf.Clamp(targetPosition.z,minValues.z,maxValues.z));

        Vector3 smoothedPosition = Vector3.Lerp(transform.position,boundPosition,smoothFactor*Time.fixedDeltaTime);
        transform.position = smoothedPosition;
    }
}
