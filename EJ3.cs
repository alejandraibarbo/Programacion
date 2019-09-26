using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ3 : MonoBehaviour
{

    Light mligh;
    
    

    // Start is called before the first frame update
    void Start()
    {
        mligh = GetComponent<Light>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (mligh.intensity >= 0.25f && mligh.intensity <= 0.45f)
        {
           
            Color a = new Color(0.10f, 0.34f, 0.42f);
           mligh.color = a;
        }
        if (mligh.intensity >= 0.5f && mligh.intensity <= 0.75f)
        {
            Color r = new Color(1, 0, 0);
            mligh.color = r;
        }
     
        if (mligh.intensity >= 0.8f)
        {
            Color b = new Color(1f, 1f,1f);
            mligh.color = b;
        }
    }
}
