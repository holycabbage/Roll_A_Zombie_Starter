using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public GameManager gm;
    public AudioClip hit;
    AudioSource sourse;
    // Start is called before the first frame update
    void Start()
    {
        sourse = GetComponent<AudioSource> ();        
    }

    // Update is called once per frame
    void Update()
    {
       gm.ScoreIncreasWithTime();


    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Zombie collided.");
        sourse.PlayOneShot (hit);

        if (other.gameObject.tag == "yellow") 
        {
            gm.SubtractScore(5);
            Debug.Log("Yellow zombie just collided.");

        }
        else if (other.gameObject.tag == "blue") 
        {
            gm.SubtractScore(10);
            Debug.Log("Blue zombie just collided.");        

        }
        else if (other.gameObject.tag == "green") 
        {
            gm.SubtractScore(15);
            Debug.Log("Green zombie just collided.");
            
        }
        else if (other.gameObject.tag == "red") 
        {
            gm.SubtractScore(20);
            Debug.Log("Red zombie just collided.");            

        }
    }


}
