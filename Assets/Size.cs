using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size : MonoBehaviour
{
 
    private Vector3 scaleChange, positionChange;
    [SerializeField] float speed;

    void Awake()
    {
        



        scaleChange = new Vector3(-0.001f, -0.001f, -0.001f);
        positionChange = new Vector3(0.00f, -0.0005f, 0.00f);
    }

    void Update()
    {
        transform.localScale += scaleChange*speed;
        transform.position += positionChange*speed;


        if (transform.localScale.y < 0.1f || transform.localScale.y > 1.0f)
        {
            scaleChange = -scaleChange;
            positionChange = -positionChange;
        }
    }
}