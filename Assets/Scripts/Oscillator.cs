using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField] Rigidbody2D rg;
    [SerializeField] float moveSpeed;
    [SerializeField] float left;
    [SerializeField] float right;
    bool moving;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        moving = true;
    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }
   public void ChangeDir()
    {
        if (transform.rotation.z > right)
        {
            moving = false;
        }
        if (transform.rotation.z < left)
        {
            moving = true;
        }

    }
    public void Move()
    {
        ChangeDir();
        if (moving)
        {
            rg.angularVelocity = moveSpeed;
        }
        if (!moving)
        {
            rg.angularVelocity = -1*moveSpeed;

        }
    }
}
