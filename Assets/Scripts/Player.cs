using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public int count;
    public Text healthText;
    public Text countText;
     public Animator anim;
    public float speed = 10;
    public int health = 100;
    public GameObject ammo;
    public Transform shotDir;
    public GameObject levelup;
     public GameObject hp;
      public GameObject spd;
    // Start is called before the first frame update
    void Start()
    {
           levelup.SetActive(false);
           hp.SetActive(false);
            spd.SetActive(false);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    SetHealthText();
   if (Input.GetKeyDown("a")) 
   {

    transform.Rotate(0f,180f,0);        
    }
     if (Input.GetKey("w")) 
   {
        transform.Translate( speed*Time.deltaTime, 0f, 0f);  
   }
   if(Input.GetMouseButtonDown(0)){
       Instantiate(ammo,shotDir.position,transform.rotation);
       anim.SetBool("idle",false);
       anim.SetBool("fire",true);

   }else{
      anim.SetBool("idle",true);
       anim.SetBool("fire",false);
   }
   if(count==30){
       SceneManager.LoadScene(3);
   }
    if(health<0){
       SceneManager.LoadScene(2);
    }
    if(count==10){
        StartCoroutine("Blink");
        StartCoroutine("Text");
    }
    if(count==20){
        StartCoroutine("Blink");
          StartCoroutine("Text");
         spd.SetActive(true);
    }
    
    if(health==50){
        hp.SetActive(true);
    }
}
   
void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
           health-=5;
        } 
        if (col.gameObject.tag == "Heal")
        {
           health+=15;
           Destroy(hp);
        } 
         if (col.gameObject.tag == "speed")
        {
           speed=15;
           Destroy(spd);
        } 
        if (col.gameObject.tag == "Enemy2")
        {
           health-=10;
        }
          if (col.gameObject.tag == "Enemy3")
        {
           health-=15;
        }
        }

    void SetHealthText(){
         healthText.text = "HP: " + health.ToString ();
    }
      void SetKilledText(){
         countText.text = "killed : " + count.ToString() +" zombie";
    }
    void unSetKilledText(){
         countText.text = " ";
    }
    IEnumerator Blink() {
        levelup.SetActive(true);
         yield return new  WaitForSeconds(0.2f);
          levelup.SetActive(false);
         yield return new  WaitForSeconds(0.2f);
         levelup.SetActive(true);
         yield return new  WaitForSeconds(0.2f);
       levelup.SetActive(false);
         yield return new  WaitForSeconds(0.2f);
         levelup.SetActive(true);
         yield return new  WaitForSeconds(0.2f);
       levelup.SetActive(false);
 }   
   IEnumerator Text() {
        SetKilledText();
         yield return new  WaitForSeconds(3);
        unSetKilledText();

 } 
}

