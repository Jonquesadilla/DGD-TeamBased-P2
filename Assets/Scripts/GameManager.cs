using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
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

    public GameObject[] PlankPrefabs = new GameObject[5];

    public float Timer = 3;
    public TextMeshProUGUI Timetext;
    public TextMeshProUGUI Healthtext;
    public float Health = 100;
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

        for (int i = 0; i < 5; i++)
        {
            Instantiate(PlankPrefabs[UnityEngine.Random.Range(0, PlankPrefabs.Length)], new Vector3(0, 0 + i, 0), Quaternion.identity);
        }
        //Instantiate(PlankPrefabs[UnityEngine.Random.Range(0, PlankPrefabs.Length)]);
        //Instantiate(PlankPrefabs[UnityEngine.Random.Range(0, PlankPrefabs.Length)]);  //The code to randomly spawn the different planks

        // an array of the prefabs
        // that array will be public and set in the inspector (ie we want to drag onto this script the prefabs in position in the array
        // when the game starts (ie on Start()), we want to pick randomly out of that list a prefab to draw
        // then, that prefab gets instantiated in the location that we want it to be
        // right now, you are searching in the scene tree for existing prefabs (ie find game objects with tag) - this implies that the object already exist
        // instead, you want to use the Instatiate Method at START, with a random pick from the list
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
        Timer -= Time.deltaTime;
        Timetext.text = "Time: " + Mathf.Round(Timer);
        Healthtext.text = "Health: " + Mathf.Round(Health);
    }
    public void SpawnNewPlank()
    {

    }
}
