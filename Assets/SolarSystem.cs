using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SolarSystem : MonoBehaviour
{
    // Atibutos Públicos
    public Transform Satelite1Transform;
    public Transform Satelite2Transform;   
    public Transform CamaraTransform;
    // Atributos Privados
    void Start()
    {
        transform.position = new Vector3(10,0,10);
    }
    void Update()
    {
        Vector3 satelite2X = Satelite2Transform.right;
        float anguloSatelite2 = Vector3.Angle(satelite2X, Vector3.right);

        Debug.DrawRay(new Vector3(0, 0, 0), transform.position);
        Debug.DrawRay(transform.position, (Satelite1Transform.position - transform.position), Color.red);
        Debug.DrawRay(transform.position, (Satelite2Transform.position - transform.position) , Color.blue);
        Debug.DrawRay(Satelite1Transform.position,(Satelite2Transform.position - Satelite1Transform.position), Color.green);

        transform.RotateAround(new Vector3(0, 0, 0), Vector3.up, 30 * Time.deltaTime);
        transform.LookAt(new Vector3(0,0,0));

        Satelite1Transform.RotateAround(transform.position, Vector3.forward, 90 * Time.deltaTime);

        Satelite2Transform.RotateAround(Satelite1Transform.position, Vector3.right, 45 * Time.deltaTime);
        Satelite2Transform.LookAt(Satelite1Transform);
        if (anguloSatelite2 < 90)
        {
            Satelite2Transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
        }
        else
        {
            Satelite2Transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
        }

        CamaraTransform.LookAt(transform.position);
    }
}
