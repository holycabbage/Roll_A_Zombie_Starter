using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public List<GameObject> zombies;
    public List<GameObject> zombiesStart;

    public GameObject selectedZombie;

    private Vector3 selectedSize, defaultSize;
    private int i;

    public Text scoreText;
    public float score;

    public Text lifeText;
    public int life;

    public GameObject GameOverText;

    public Vector3 zombieStart;
    public GameObject lifeTrigger;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        score = 0f;
        life = 5;

        selectedSize = new Vector3(1.3f, 1.3f, 1.3f);
        defaultSize = new Vector3(1f, 1f, 1f);
        selectedZombie = zombies[i];
        selectedZombie.transform.localScale = selectedSize;

    }

    public void resetYellow()
    {
        zombies[0].transform.position = zombiesStart[0].transform.position;
       
    }
    public void resetBlue()
    {
        zombies[1].transform.position = zombiesStart[1].transform.position;
    }
    public void resetGreen()
    {
        zombies[2].transform.position = zombiesStart[2].transform.position;
    }
    public void resetRed()
    {
        zombies[3].transform.position = zombiesStart[3].transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("left"))
        {

            Debug.Log("Right key is pressed");
            //change the size of currently selected zombie to default size
            selectedZombie.transform.localScale = defaultSize;
            //change the index to the left zombie
            i = i - 1;

            if (i == -1)
                i = 3;
            selectedZombie = zombies[i];
            //change the size of newly selected zombie
            selectedZombie.transform.localScale = selectedSize;
        }
        if (Input.GetKeyDown("right"))
        {
            Debug.Log("Right key is pressed");
            //change the size of currently selected zombie to default size
            selectedZombie.transform.localScale = defaultSize;
            //change the index to the left zombie
            i = i + 1;

            if (i == 4)
                i = 0;
            selectedZombie = zombies[i];
            //change the size of newly selected zombie
            selectedZombie.transform.localScale = selectedSize;
        }
        if (Input.GetKeyDown("up"))
        {
            Rigidbody rb = selectedZombie.GetComponent<Rigidbody>();
            //rb.mass = selectedMass;
            rb.AddForce(0, 0, 50, ForceMode.Impulse);
        }
        if (Input.GetKeyDown("space"))
        {
            Rigidbody rb = selectedZombie.GetComponent<Rigidbody>();
            //rb.mass = selectedMass;
            rb.AddForce(0, 10, 0, ForceMode.Impulse);
        }

    }

    public void SubtractScore(int deductScore)
    {
        score = score - deductScore;
        if (score < 0)
            score = 0;
        Debug.Log("Score is subtracted to " + score);
        
    }

    public void SubtractLife()
    {
        life = life - 1;

        if (life < 1)
        {
            GameOverText.SetActive(true);
            Time.timeScale = 0f;
        }
        lifeText.text = "Life: " + (life).ToString();

        Debug.Log("life is subtracted to " + life);
    }


    public void ScoreIncreasWithTime()
    {
        score += Time.deltaTime;  
        scoreText.text = "Score: " + ((int)score).ToString();
        Debug.Log("Score is " + scoreText);
        
    }

}
