using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_character_motion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     transform.Translate(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical")*15f*Time.deltaTime,0f,0f);
        Vector2 character = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0) {
            character.x = -7;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            character.x = 7;
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            character.y = 7;
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            character.y = 7;
        }
        transform.localScale = character;

    }
}
