using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public GameManager gm1;
    public AudioClip hit1;
    AudioSource sourse1;

    // Start is called before the first frame update
    void Start()
    {
        sourse1 = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Zombie dead.");
        sourse1.PlayOneShot(hit1);

        if (other.gameObject.tag == "yellow")
        {
            gm1.SubtractLife();
            Debug.Log("Yellow zombie just dead.");
            gm1.resetYellow();

        }
        else if (other.gameObject.tag == "blue")
        {
            gm1.SubtractLife();
            Debug.Log("Yellow zombie just dead.");
            gm1.resetBlue();

        }
        else if (other.gameObject.tag == "green")
        {
            gm1.SubtractLife();
            Debug.Log("Yellow zombie just dead.");
            gm1.resetGreen();
        }
        else if (other.gameObject.tag == "red")
        {
            gm1.SubtractLife();
            Debug.Log("Yellow zombie just dead.");
            gm1.resetRed();
        }
    }
}
