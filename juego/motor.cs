using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour
{
    [SerializeField] float magnitud = 8, magnitudAng = 10;
    [SerializeField] AudioClip idle, driving;
    AudioSource audiomotor;
    Rigidbody mrgbdy;
    // Start is called before the first frame update
    void Start()
    {
        audiomotor = GetComponent<AudioSource>();
        mrgbdy = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float magFuerza = 50;
        float sentido = 1;
        Vector3 dir = transform.forward;
        Vector3 fuerza = magFuerza * dir * sentido;

        Vector3 direccion = transform.forward * Input.GetAxis("Vertical");
        Vector3 velocidad = magnitud * (direccion);
        Vector3 distancia = velocidad * Time.deltaTime;
        transform.position += distancia;

        Vector3 direccionA = new Vector3(0, 1, 0) * Input.GetAxis("Horizontal");
        Vector3 velAng = magnitudAng * direccionA;
        Vector3 distAng = velAng * Time.deltaTime;
        transform.eulerAngles += distAng;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mrgbdy.AddForce(fuerza);
        }

        if(velocidad.magnitude>1|| velAng.magnitude > 1)
        {
            audiomotor.clip = driving;
            if (!audiomotor.isPlaying) audiomotor.Play();
        }
        else
        {
            audiomotor.clip = idle;
            if (!audiomotor.isPlaying) audiomotor.Play();
        }
    }
}
