using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMovement : MonoBehaviour
{
    [SerializeField] float magnitudAng;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = new Vector3(0, 1, 0) * Input.GetAxis("Torreta");
        Vector3 velAng = magnitudAng * direccion;
        Vector3 distancia = velAng * Time.deltaTime;
        transform.eulerAngles += distancia;
    }
}
