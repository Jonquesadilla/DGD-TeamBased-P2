using TMPro;
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using Random=UnityEngine.Random;
using UnityEngine.SceneManagement;

public class JoshCode : MonoBehaviour
{   //Work #1

    //Work #3

    public GameObject[] PlanksOnScreen = new GameObject[5];
    public GameObject[] PlankPrefabs = new GameObject[5];
    public GameObject[] Planks;

    //public float Timer = 3;
    //public TextMeshProUGUI Timetext;
    //public TextMeshProUGUI Healthtext;
    //public float Health = 3;

    public List<IconInfo> IconsRaw;
    
    public Animator Player;

    public TMP_Text ShownTime;
    public float Temp = 5;
    public float Timer = 5;
    public bool Ready = false;

    public string Recent;

    public SpriteRenderer PlayerSprite;
    public Sprite Chop;
    public Sprite Wait;

    public SpriteRenderer Explosion;
    Color ColorEdit;

    public AudioSource Audio;
    public AudioClip Board, Explode;
    public bool FailState = false;

    public static int Score;
    public float Bonus;
    
    

    // Start is called before the first frame update
    void Start()
    {

        Score = 0;
        
        Bonus = 3.0f;
        
        ColorEdit.a = 0.0f;
        Explosion.GetComponent<SpriteRenderer>().color = ColorEdit;
        PlayerSprite.sprite = Wait;
            
        Timer = 5.0f;
        Ready = true;
        
        for (int i = 0; i < 5; i++)
        {
            PlanksOnScreen[i] = PlankPrefabs[Random.Range(0, PlankPrefabs.Length)];
            Instantiate(PlanksOnScreen[i], new Vector3(0, 4 - i, -2), Quaternion.identity);
            if (i == 5)
            {
               // PlanksOnScreen[i] = null;
            }
        }

        // an array of the prefabs
        // that array will be public and set in the inspector (ie we want to drag onto this script the prefabs in position in the array
        // when the game starts (ie on Start()), we want to pick randomly out of that list a prefab to draw
        // then, that prefab gets instantiated in the location that we want it to be
        // right now, you are searching in the scene tree for existing prefabs (ie find game objects with tag) - this implies that the object already exist
        // instead, you want to use the Instatiate Method at START, with a random pick from the list
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Score == 5) Bonus = 2.0f;
        if (Score == 10) Bonus = 1.5f;
        
        Timer -= Time.deltaTime;
        Temp = Mathf.Round(Timer * 100) / 100;
        ShownTime.text = "Time: " + Temp + "\nScore: " + Score;
        //Healthtext.text = "Health: " + Mathf.Round(Health);
        if (Timer <= 0)
        {

            ColorEdit = Explosion.GetComponent<SpriteRenderer>().color;
            ColorEdit.a = 1.0f;
        
            Explosion.GetComponent<SpriteRenderer>().color = ColorEdit;
            //Audio.clip = Explode;
            //Audio.PlayOneShot(Explode);
            Player.Play("ChopFail");

            SceneManager.LoadScene("End");

        }
      
        // populate a list of the current planks on screen!
        // i'll update the planks on screen array based on what planks i can find on screen!

        PlanksOnScreen = GameObject.FindGameObjectsWithTag("Plank");
        for(int i = 0; i < PlanksOnScreen.Length; i++) 
        {
            //Destroy_Plank_Space destroy_Plank_Space = PlanksOnScreen.GetComponent<Destroy_Plank_Space>().active = true; // Figuring out to call the boolean active on the planks to be true
            if (i == 0) 
            {
                
                if (PlanksOnScreen[i].GetComponent<Destroy_Plank>())
                {
                    PlanksOnScreen[i].GetComponent<Destroy_Plank>().active = true;
                }
                if (PlanksOnScreen[i].GetComponent<Destroy_Plank_S>())
                {
                    PlanksOnScreen[i].GetComponent<Destroy_Plank_S>().active = true;
                }
                if (PlanksOnScreen[i].GetComponent<Destroy_Plank_D>())
                {
                    PlanksOnScreen[i].GetComponent<Destroy_Plank_D>().active = true;
                }
                if (PlanksOnScreen[i].GetComponent<Destroy_Plank_A>())
                {
                    PlanksOnScreen[i].GetComponent<Destroy_Plank_A>().active = true;
                }
                if (PlanksOnScreen[i].GetComponent<Destroy_Plank_Space>())
                {
                    PlanksOnScreen[i].GetComponent<Destroy_Plank_Space>().active = true;
                }
            }
        }
        //Debug.Log(PlanksOnScreen.Length);


        if (PlanksOnScreen.Length == 4) PlayerSprite.sprite = Wait;
        
        if (PlanksOnScreen.Length == 0)
        {
            PlayerSprite.sprite = Chop;
            Timer = Timer + Bonus;
            Score++;
            for (int i = 0;i < 5;i++)
            {
                Instantiate(PlankPrefabs[Random.Range(0, PlankPrefabs.Length)], new Vector3(0, 4 - i, -2), Quaternion.identity);
            }

            Audio.clip = Board;
            Audio.Play();
            
        }
        
        
        
    }
    
    [System.Serializable]
    public class IconInfo
    {
        public string Name;
        public Sprite S;
    }
}
