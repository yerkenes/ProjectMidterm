using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int speed=10 ;
    public float destroyTime;
    // Start is called before the first frame update
    public int count;
    void Start()
    {
        Invoke("DestroyAmmo",destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right*speed*Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D  col)
    {
      
         if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
            Destroy(gameObject); 
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().count+=1;
        }
         if (col.gameObject.tag == "Enemy2")
        {
            Destroy(col.gameObject);
            Destroy(gameObject); 
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().count+=1;
        }
         if (col.gameObject.tag == "Enemy3")
        {
            Destroy(col.gameObject);
            Destroy(gameObject); 
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().count+=1;
        }
     }
    
    void DestroyAmmo(){
        Destroy(gameObject);
    }

}
