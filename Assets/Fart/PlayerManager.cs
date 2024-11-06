using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Animator Player;

    public TMP_Text ShownTime;
    public float Temp = 5;
    public float Timer = 5;
    public bool Ready = false;

    public String Recent;

    public SpriteRenderer Explosion;
    Color ColorEdit;
    
    public 
    
    // Start is called before the first frame update
    void Start()
    {
        
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey("1"))
        {
            
            ColorEdit.a = 0.0f;
            
            Timer = 5.0f;
            Ready = true;
            
        }

        if (Input.GetKey("space")) Recent = "S";
        if (Input.GetKey("backspace")) Recent = "F";
        
        if (Timer >= 0.00 && Ready == true)
        {
            
            Timer -= Time.deltaTime;
            Temp = Mathf.Round(Timer * 100) / 100;
            ShownTime.text = "Time: " + Temp;
            
        }
        if (Timer <= 0.00)
        {
            
            if (Recent == "S") Player.SetInteger("Success", 2);
            else
            {
                
                ColorEdit = Explosion.GetComponent<SpriteRenderer>().color;
                ColorEdit.a = 1.0f;
        
                Explosion.GetComponent<SpriteRenderer>().color = ColorEdit;
                
                Player.SetInteger("Success", 1);
                
                //gameObject.animation("animationName").wrapMode=WrapMode.PingPong;
                //Player["ChopFail"].wrapMode = WrapMode.Once;
                Player.Play("ChopFail");
                
            }
        
            Player.Play("ChopWait");
            //Player.SetInteger("Success", 0);
            Ready = false;
            
        }

    }
}
