using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwan : MonoBehaviour
{

    public GameObject pipe;
    public float height;
    public float maxTime;

    private float cont = 0f;



    // Start is called before the first frame update
    void Start()
    {

        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(10,Random.Range(-height, height),10);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cont> maxTime)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(17, Random.Range(-height, height), 0);
            cont = 0;
        }

        cont += Time.deltaTime;
    }
}
