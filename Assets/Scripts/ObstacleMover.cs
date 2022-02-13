using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMover : MonoBehaviour
{

    public static float Speed { set; get; } 

    // Start is called before the first frame update
    void Awake()
    {
        Speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += -Vector3.right * Time.deltaTime * Speed;
    }


} // class

































