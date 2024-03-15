using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class fly : MonoBehaviour
{
    public float speed = 5f;

    bool switc = true; //switch flying position

    private SpriteRenderer spriteRenderer; //referencing the property of sprite

    
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {   if(switc)  //if bool = true
        {
            movebirdright(); //rocket turn right
        }
        if (!switc) //if bool = false
        {
            movebirdleft();
        }

        if (transform.position.x >= 10f) //if object reaches end of screen then turn
        {
            switc = false;
            spriteRenderer.flipX = true; //flip object point to other dir
        }

        if (transform.position.x <= -10f) //if object goes outside of screen then turn
        {
            switc = true; //will turn object back into screen
            spriteRenderer.flipX = false; //flip object
        }

    }

    public void movebirdright()  //function to move the rocket to RIGHT
    {
        transform.Translate(speed * Time.deltaTime, 0, 0); //0,0 for X Y direction

    }

    public void movebirdleft()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);  //move in opposite direction
    }
}
