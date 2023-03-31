using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;

public class Spawner : MonoBehaviour
{
   
    public Astronoat astronoatscript;

    public GameObject player;
    public GameObject shadow;
    public GameManager gm;

    public GameObject Asteroids;

    public float minY,maxY;

    private int rand;


    float timer ;
    public float maxTime;


    void Start()
    {
        
         
         SpawnColumn();



    }

    

    private void FixedUpdate()
    {   

        if (gm.score <= 250)
        {


            player.transform.localScale = new Vector3(1f, 1f, 1f);
            shadow.transform.localScale = new Vector3(1.5f,1.5f, 1.5f);
            maxTime = 4f;


            timer += Time.deltaTime;

            if (timer >= maxTime)
            {
                SpawnColumn();
                timer = 0;
            }

        }
        else if (gm.score > 250&& gm.score <= 500)
        {
            

            maxTime = 3.5f;
            
            timer += Time.deltaTime;

            if (timer >= maxTime)
            {
                SpawnColumn();
                timer = 0;
            }
          
        }


        else if(gm.score >500&& gm.score <=1000)
        {

            
            maxTime = 3f;
           
            timer += Time.deltaTime;

            if (timer >= maxTime)
            {
                SpawnColumn();
                timer = 0;
            }


        }
        else if (gm.score >1000 && gm.score <= 1500)
        {

            player.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
            shadow.transform.localScale = new Vector3(1.35f,1.35f, 1.35f);
            maxTime = 2.5f;
            timer += Time.deltaTime;

            if (timer >= maxTime)
            {
                SpawnColumn();
                timer = 0;
            }
        }
        else if (gm.score > 1500 && gm.score <= 2000)
        {
            Debug.Log("0.8-2");
            player.transform.localScale = new Vector3(0.6f,0.6f, 0.6f);
            shadow.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
            maxTime = 2f;
            timer += Time.deltaTime;

            if (timer >= maxTime)
            {
                SpawnColumn();
                timer = 0;
            }
        }

        else if (gm.score > 2000&& gm.score <=2500)
        {
            Debug.Log("0.6-1.5");
            player.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            shadow.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            maxTime = 1.5f;
            timer += Time.deltaTime;

            if (timer >= maxTime)
            {
                SpawnColumn();
                timer = 0;
            }
        }
      
        else if(gm.score > 2500)
        {
            Debug.Log("0.3-1");

            player.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
            shadow.transform.localScale = new Vector3(0.45f, 0.45f, 0.45f);
            maxTime = 1f;
            timer += Time.deltaTime;

            if (timer >= maxTime)
            {
                SpawnColumn();
                timer = 0;
            }
        }
      




    }




    void SpawnColumn()
    {

        float randYPos=Random.Range(minY,maxY);

        GameObject newColumn = Instantiate(Asteroids);
        newColumn.transform.position = new Vector2(transform.position.x,
            randYPos);
        rand = Random.Range(0, newColumn.transform.GetChild(2).childCount);
        newColumn.transform.GetChild(2).GetChild(rand).gameObject.SetActive(true);
        if (rand == 6) newColumn.transform.GetChild(2).tag = "Earth";


    }

    

}
