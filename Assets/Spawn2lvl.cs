using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn2lvl : MonoBehaviour
{
     public float maxTime =4;
    private float timer =0;
    public GameObject Column;
    public float heigh ;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
         if( GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().count<20){
        if( GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().count>9){
        if(timer > maxTime){
            GameObject newcol = Instantiate(Column);
            
            Destroy(newcol,15);
            timer = 0;

        }}
        timer+=Time.deltaTime;
        
    }}
}
