using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ4 : MonoBehaviour
{

    Light mlight;
    Transform mtransform;
    // Start is called before the first frame update
    void Start()
    {
        mlight = GetComponent<Light>();
        mtransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        mlight.intensity = 0.5f * mtransform.localScale.magnitude;
    }
}
