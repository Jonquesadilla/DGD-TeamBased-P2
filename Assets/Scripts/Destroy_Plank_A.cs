using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Plank_A : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite brokenPlank;
    public bool active = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && active)
        {
            spriteRenderer.sprite = brokenPlank;
            // something that will delete the sprites from the current list?
            Destroy(gameObject);
        }
    }
}
