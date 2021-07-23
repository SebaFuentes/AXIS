using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointPlayer : MonoBehaviour
{

    private float respawnX, respawnY;
    
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetFloat("respawnX")!=0)
        {
            transform.position=(new Vector2(PlayerPrefs.GetFloat("respawnX"), PlayerPrefs.GetFloat("respawnY")));
        } 
    }

    public void ReachedCheckPoint(float x, float y)
    {
       PlayerPrefs.SetFloat("respawnX",x); 
       PlayerPrefs.SetFloat("respawnY",y);
    }
    
}
