using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject foulder;
    public GameObject browser;
    public GameObject picture;

    public GameObject real;

    private bool haveSpawnedReal = false;
    private int diceroll;

    private int count = 0;
    public int Maxcount = 160;
    
    public Transform thisParent;
    


    void Start() // spawn 161 obnjtives and 1 "real"
    {

        while (count <= Maxcount)
        {
            if (haveSpawnedReal == false)
            {

                diceroll = Random.Range(0, 1000);
                                    //Debug.Log(diceroll + " before real");

                if (diceroll <= 1 || diceroll <= 10)
                {
                    
                    real = Instantiate(real, transform.parent = thisParent);
                    haveSpawnedReal = true;
                }
                
                else if (diceroll <= 11 || diceroll <= 340)
                {
                    
                    foulder = Instantiate(foulder, transform.parent = thisParent);
                    
                }
                else if (diceroll <= 341 || diceroll <= 670)
                {
                    browser = Instantiate(browser, transform.parent = thisParent);
                }
                else if (diceroll <= 671 || diceroll <= 999)
                {
                    picture = Instantiate(picture, transform.parent = thisParent);
                }

            }
            else
            {
                diceroll = Random.Range(0, 3);
                                    //Debug.Log(diceroll + " after real");

                if (diceroll == 0)
                {
                    foulder = Instantiate(foulder, transform.parent = thisParent);
                }
                else if (diceroll == 1)
                {
                    browser = Instantiate(browser, transform.parent = thisParent);
                }
                else if (diceroll == 2)
                {
                    picture = Instantiate(picture, transform.parent = thisParent);
                }

            }

            count++;
        }

        if (count == Maxcount || haveSpawnedReal == false)
        {
            real = Instantiate(real, transform.parent = thisParent);
            haveSpawnedReal = true;
        }
        else
        {
            if (diceroll == 0)
            {
                foulder = Instantiate(foulder, transform.parent = thisParent);
            }
            else if (diceroll == 1)
            {
                browser = Instantiate(browser, transform.parent = thisParent);
            }
            else if (diceroll == 2)
            {
                picture = Instantiate(picture, transform.parent = thisParent);
            }
        }


    }


    void SpawnRando()
    {


    }

    void SpawnReal()
    {


    }




}
