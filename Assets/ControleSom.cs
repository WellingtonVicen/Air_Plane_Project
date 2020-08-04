using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleSom : MonoBehaviour
{


    public GameControl gamC;


    // Start is called before the first frame update
    void Start()
    {
        gamC = GetComponent<GameControl>();
    }

    // Update is called once per frame
    void Update()
    {

        if(gamC.gameOver == true)
        {

            Debug.Log("parou som");
        }

        
    }
}
