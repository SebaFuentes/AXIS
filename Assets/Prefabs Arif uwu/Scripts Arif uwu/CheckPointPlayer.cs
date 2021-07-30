using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointPlayer : MonoBehaviour
{

    private float respawnX, respawnY; // variables float del respawn
    
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetFloat("respawnX")!=0) //  // si no esta donde comenzo (0,0), comienza desde el checkpoint
        {
            transform.position=(new Vector2(PlayerPrefs.GetFloat("respawnX"), PlayerPrefs.GetFloat("respawnY")));
        } 
    }

    public void ReachedCheckPoint(float x, float y) // cambia los puntos de reaparicion.
    {
       PlayerPrefs.SetFloat("respawnX",x); 
       PlayerPrefs.SetFloat("respawnY",y);
    }
    
}
