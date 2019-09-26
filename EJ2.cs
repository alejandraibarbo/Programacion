using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ2 : MonoBehaviour
{
    Renderer mrenderer;
    float t = 0;


    // Start is called before the first frame update
    void Start()
    {
        mrenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        Color r = new Color(1f, 0.07f, 0.07f);
        Color a = new Color(0.10f, 0.34f, 0.42f);
        Color m = new Color(0.53f, 0.10f, 0.7f);


        if (t >= 0 && t >= 3)
        {
            
            mrenderer .material.color = r;
        }
        if (t >= 4 && t >= 6)
        {
           
            mrenderer.material.color = a;
        }
        if (t >= 7)
        {
            mrenderer.material.color = m;

        }

    }
}
