using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTracker : MonoBehaviour
{
    public AudioSource[] soundFX;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            soundFX[0].Play();
        }
        if (Input.GetKeyDown("right"))
        {
            soundFX[1].Play();
        }
        if (Input.GetKeyDown("space"))
        {
            soundFX[2].Play();
        }
        if (Input.GetKeyDown("up"))
        {
            soundFX[3].Play();
        }
    }
}
