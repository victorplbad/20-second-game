using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject foulder;
    public GameObject browser;
    public GameObject picture;

    public GameObject real;
    public bool haveSpawnedReal = false;
    public int diceroll;

    public int count = 0;
    
    public Transform thisParent;


    void Start() // spawn 161 obnjtives and 1 "real"
    {

        while (count <= 162)
        {
            if (haveSpawnedReal == false)
            {

                diceroll = Random.Range(0, 4);
                Debug.Log(diceroll + " before real");

                if (diceroll == 0)
                {
                    //clone = Instantiate(real, transform.position, transform.rotation,transform.parent);
                    //Instantiate(real, thisParents);
                    real = Instantiate(real, transform.parent = thisParent);
                    haveSpawnedReal = true;
                }
                
                else if (diceroll == 1)
                {
                    
                    foulder = Instantiate(foulder, transform.parent = thisParent);
                    
                }
                else if (diceroll == 2)
                {
                    browser = Instantiate(browser, transform.parent = thisParent);
                }
                else if (diceroll == 3)
                {
                    picture = Instantiate(picture, transform.parent = thisParent);
                }

            }
            else
            {
                diceroll = Random.Range(0, 3);
                Debug.Log(diceroll + " after real");

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

        


    }


}
