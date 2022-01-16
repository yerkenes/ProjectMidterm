using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    // Start is called before the first frame update
     public int speed=2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
