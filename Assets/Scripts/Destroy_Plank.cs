using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Plank : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite brokenPlank;
    // Start is called before the first frame update
    public void DestroyObject ()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            spriteRenderer.sprite = brokenPlank;
            Destroy(gameObject);
        }
    }
}
