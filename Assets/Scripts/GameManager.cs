using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{   //Work #1

    //Work #3

    public GameObject[] PlanksOnScreen = new GameObject[5];

    public GameObject[] PlankPrefabs = new GameObject[5];

    public float Timer = 3;

    public TextMeshProUGUI Timetext;
    public TextMeshProUGUI Healthtext;

    public float Health = 3;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(PlankPrefabs[Random.Range(0, PlankPrefabs.Length)], new Vector3(0, 0 + i, 0), Quaternion.identity);
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
            Timer = 3;
            Health -= 1;
            
        }

        // populate a list of the current planks on screen!
        // i'll update the planks on screen array based on what planks i can find on screen!

        PlanksOnScreen = GameObject.FindGameObjectsWithTag("Plank");

        Debug.Log(PlanksOnScreen.Length);

        if (PlanksOnScreen.Length == 0)
        {
            Timer = 3;
            for (int i = 0;i < 5;i++)
            {
                Instantiate(PlankPrefabs[Random.Range(0, PlankPrefabs.Length)], new Vector3(0, 0 + i, 0), Quaternion.identity);
            }
        }
    }
}
