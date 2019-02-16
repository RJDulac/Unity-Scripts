using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 startPosition;
    void Start()
    {


        //Vector3 is a new position
        //grab the current position = (assign) new position
        //transform.position = new Vector3(0,0,0);

        //assign through inspector with startPosition field
        transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
