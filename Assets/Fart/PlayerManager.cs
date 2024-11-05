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

    public String Recent;

    public SpriteRenderer Explosion;
    
    public 
    
    // Start is called before the first frame update
    void Start()
    {

        Explosion.GetComponent<Renderer>().material.color.a = 1.0f;

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey("space")) Recent = "S";
        if (Input.GetKey("backspace")) Recent = "F";
        
        if (Timer >= 0.00)
        {
            
            Timer -= Time.deltaTime;
            Temp = Mathf.Round(Timer * 100) / 100;
            ShownTime.text = "Time: " + Temp;
            
        }
        else
        {
            
            if (Recent == "S") Player.SetBool("Success", true);
            if (Recent == "F")
            {
                
                
                
                Player.SetBool("Success", false);
                
            }

        }

    }
}
