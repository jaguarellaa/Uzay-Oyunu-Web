using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astronoat : MonoBehaviour
{
    public ParticleSystemController psc;
    public bool isDead;
    public float velocity;
    public bool gravity;
    public Rigidbody2D rb2D;
    public GameManager gm;
    public GameObject[] textimgs;

    public int randID;

   
    public AudioSource[] aus;

    public GameObject score;
    public GameObject wordscore;
    public GameObject pause;
    public GameObject cont;
    public GameObject DeathScreen;
    public GameManager managergame;
 
    public int motiveInt;


    private void Start()
    {
        
        rb2D = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
        motiveInt =gm.wordScore ;
    }


    

    void Update()
    {
    

        if (Input.GetMouseButtonDown(0))
        {

           
            rb2D.velocity = Vector2.up * velocity;
            psc.SetPlayDelay();

        }

        if (Input.GetMouseButtonUp(0))
        {


            rb2D.velocity = Vector2.up * velocity;
            psc.SetStopDelay();

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.name == "ScoreArea")
        {


            Destroy(collision.gameObject);
            if (collision.gameObject.tag == "Earth")
            {
                randID = Random.Range(0, 5);
                aus[0].Play();
                managergame.UpdateScore(50);
                managergame.UpdateWordScore(); motiveInt = gm.wordScore;
                if (motiveInt % 5 == 0 )
                {

                   
                   
                    textimgs[randID].SetActive(true);
                    StartCoroutine(YaziKontrolu());
                  


                }

            }
            else
            {
                aus[1].Play();
                managergame.UpdateScore(10);
            }
        }


      

    }

    IEnumerator YaziKontrolu()
    {


        yield return new WaitForSeconds(1.0f);


        textimgs[randID].SetActive(false);
        motiveInt = 1;
   
        Debug.Log("x");


    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            aus[2].Play();
            aus[3].Stop();
            Time.timeScale = 0;
            DeathScreen.SetActive(true);
            score.SetActive(false);
            wordscore.SetActive(false);
            pause.SetActive(false);
            cont.SetActive(false);
        }
    }
}
