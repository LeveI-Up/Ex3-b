using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHide : MonoBehaviour
{
    public GameObject Oscillator, cannonball,SoccerBall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Oscillator.SetActive(false);
            cannonball.SetActive(false);
            SoccerBall.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Oscillator.SetActive(true);
            cannonball.SetActive(true);
            SoccerBall.SetActive(true);
        }
    }
}
