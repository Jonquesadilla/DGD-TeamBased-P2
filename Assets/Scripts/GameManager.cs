using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{   //Work #1

    //Work #3

    public GameObject[] PlanksOnScreen = new GameObject[5];

    public GameObject[] PlankPrefabs = new GameObject[5];

    public GameObject[] Planks;

    public float Timer = 15;

    public TextMeshProUGUI Timetext;
    public TextMeshProUGUI Healthtext;

    public AudioSource soundtrack;
    public AudioClip Soundtrack;
    public AudioSource plankbreaking;
    public AudioClip PlankBreaking;
    public AudioSource defeat;
    public AudioClip Defeat;
    public AudioSource victory;
    public AudioClip Victory;
    public AudioSource pain;
    public AudioClip Pain;

    public float Health = 3;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            PlanksOnScreen[i] = PlankPrefabs[Random.Range(0, PlankPrefabs.Length)];
            Instantiate(PlanksOnScreen[i], new Vector3(0, 4 - i, 0), Quaternion.identity);
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
    void Update()
    {
        Timer -= Time.deltaTime;
        Timetext.text = "Time: " + Mathf.Round(Timer);
        Healthtext.text = "Health: " + Mathf.Round(Health);
        if (Timer < 0)
        {
            Timer = 12;
            Health -= 1;
            
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
                    PlanksOnScreen[i].GetComponent<Destroy_Plank_D>().active = true;;
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


        if (PlanksOnScreen.Length == 0)
        {
            Timer += 2;
            for (int i = 0;i < 5;i++)
            {
                Instantiate(PlankPrefabs[Random.Range(0, PlankPrefabs.Length)], new Vector3(0, 4 - i, 0), Quaternion.identity);
            }
        }
    }
}
