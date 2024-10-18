using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{   //Work #1
   // int number = 12;
    int[] numberArray = new int[5];

    //Work #2
    string[] stringArray = new string[5];

    //Work #3
    public GameObject[] Planks;

    // public GameObject other;
    public Destroy_Plank script;
    // Start is called before the first frame update
    void Start()
    {
        numberArray[0] = 2;
        numberArray[1] = 3;
        numberArray[2] = 4;
        numberArray[3] = 5;
        numberArray[4] = 6;

        Planks = GameObject.FindGameObjectsWithTag("Plank");

        for (int i = 0; i < Planks.Length; i++) 
        {
            Debug.Log("Plank Number" + i + " is named " + Planks[i].name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (numberArray[0] == 2) 
        {
            if (Input.GetKeyDown(KeyCode.W)) 
            {
                Debug.Log("Punch");
                Invoke("DestroyObject", 0);

              //  Destroy(Planks);
            }
        }
        if (numberArray[1] == 3) 
        {
            if (Input.GetKeyDown(KeyCode.Space)) 
            {
                Debug.Log("Punch");
            }
        }
        if (numberArray[2] == 4) 
        {
            if (Input.GetKeyDown(KeyCode.A)) 
            {
                Debug.Log("Punch");
            }
        }
        if (numberArray[3] == 5) 
        {
            if (Input.GetKeyDown(KeyCode.D)) 
            {
                Debug.Log("Punch");
            }
        }
        if (numberArray[4] == 6) 
        {
            if (Input.GetKeyDown(KeyCode.S)) 
            {
                Debug.Log("Punch");
            }
        }
    }
}
