using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Plank_Space : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spriteRenderer.color = Color.red; ;
        }
    }
}
