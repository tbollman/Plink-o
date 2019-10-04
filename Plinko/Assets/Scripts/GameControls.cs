using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControls : MonoBehaviour
{
    public List<GameObject> lines;
    private float speed;
    private Rigidbody2D rigid;
    private CharacterStats plStats;
    private bool spacePressed;
    public int score = 0;
    public Transform player;
    
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        plStats = GetComponent<CharacterStats>();
        speed = plStats.speed;
        spacePressed = false;
        rigid.gravityScale = 0.0f;        
    }
    
    // Update is called once per frame
    void Update()
    {
        speed = 5;
      if(Input.GetKeyDown("space")) {
            spacePressed = true;
            rigid.gravityScale = 1.0f;
        }
        if((Input.GetKeyDown("left") || Input.GetKeyDown("right")) && spacePressed == false)
        {
            rigid.velocity = new Vector2(Mathf.Lerp(0,Input.GetAxis("Horizontal")*speed,0.8f),Mathf.Lerp(0,Input.GetAxis("Vertical")*speed,0.8f));
            speed = 0;
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.name.Equals("1pt")) 
        {
            score += 1;
            print(score);
            transform.position = new Vector3(0,6,0);
            rigid.gravityScale = 0.0f;
            rigid.velocity = Vector2.zero;
            rigid.angularVelocity = 0f;
            spacePressed = false;

        }
        else if(coll.gameObject.name.Equals("2pt"))
        {
            score += 2;
            print(score);
            transform.position = new Vector3(0,6,0);
            rigid.gravityScale = 0.0f;
            rigid.velocity = Vector2.zero;
            rigid.angularVelocity = 0f;
            spacePressed = false;
        }
        else if(coll.gameObject.name.Equals("3pt"))
        {
            score += 3;
            print(score);
            transform.position = new Vector3(0,6,0);
            rigid.gravityScale = 0.0f;
            rigid.velocity = Vector2.zero;
            rigid.angularVelocity = 0f;
            spacePressed = false;
        }
        else if(coll.gameObject.name.Equals("4pt"))
        {
            score += 4;
            print(score);
            transform.position = new Vector3(0,6,0);
            rigid.gravityScale = 0.0f;
            rigid.velocity = Vector2.zero;
            rigid.angularVelocity = 0f;
            spacePressed = false;
        }
    }
}
