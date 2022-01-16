using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerZombi : MonoBehaviour
{
    public float maxTime =1;
    private float timer =0;
    public GameObject Column;
    public float heigh ;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newcol = Instantiate(Column);


    }

    // Update is called once per frame
    void Update()
    {
        if( GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().count<11){
        if(timer > maxTime){
            GameObject newcol = Instantiate(Column);
            
            Destroy(newcol,15);
            timer = 0;

        }
        timer+=Time.deltaTime;
    }}
}

