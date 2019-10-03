using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour
{
    [SerializeField] float magnitud = 8, magnitudAng = 10;
    [SerializeField] AudioClip idle, driving;
    AudioSource audioMotor;
    Rigidbody rbd;
    void Start()
    {
        audioMotor = GetComponent<AudioSource>();
        rbd = GetComponent<Rigidbody>();
    }


    void Update()
    {
        float magFuerza = 500;
        float sentido = 1;
        Vector3 dir = transform.forward;
        Vector3 fuerza = magFuerza * dir * sentido;

        Vector3 direccion = transform.forward * Input.GetAxis("Vertical");        
        Vector3 velocidad = magnitud * (direccion);
        Vector3 distancia = velocidad * Time.deltaTime;
        transform.position += distancia;       
