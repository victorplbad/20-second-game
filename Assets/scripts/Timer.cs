using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    private TMP_Text text;
    private float myTimer = 0;
    private float showTimer;

    public GameObject on;
    public GameObject off1;
    public GameObject off2;


    void Awake()
    {

        text = GetComponent<TMP_Text>();


    }



    private void Update()
    {
        myTimer += Time.deltaTime;
        showTimer = Mathf.Floor(myTimer + 40);

        text.text = showTimer.ToString();
        
        if (showTimer >= 60) // lose over after 60
        {
            off1.SetActive(false);
            off2.SetActive(false);
            on.SetActive(true);
        }
    }

}
