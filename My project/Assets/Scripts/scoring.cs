using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoring : MonoBehaviour
{
    // Start is called before the first frame update
    public int score = 0;
    public GameObject body;
    public GameObject prompt;
    public Text heighttext;
    public Text prompttext;
    public GameObject faileffect;
    private float bodyheight;
    private double prompttime;



    void Getheight()
    {
        bodyheight = body.transform.position.y;
    }

    void Grader()
    {
        if (Input.GetKeyDown("f"))
        {
            Debug.Log("the button is pressed");
            if ((bodyheight < 500) && (bodyheight > 200))
            {
                score = 1;
                Debug.Log("Scored!!!");
            }

            else if (bodyheight < 150)
            {
                faileffect.SetActive(true);
                
            }
        }

        if ((bodyheight < 200) && (bodyheight > 500))
        {
            Debug.Log("height is 200");
        }
    }



    void promptup(int h_threshold, int duration, string message)
    {
        void deactivePrompt()
        {
            prompt.SetActive(false);
        }

        void deactiveFaileffect()
        {
            faileffect.SetActive(false);
        }

        if ((bodyheight <= h_threshold) && (bodyheight > (h_threshold - duration)))
        {
            prompt.SetActive(true);
            prompttext.text = message;
            Invoke("deactivePrompt", 2.5f);
            Invoke("deactiveFaileffect", 1.5f);
        }
        else if (bodyheight <= (h_threshold - duration))
        {
            prompt.SetActive(false);
        }
    }

    void showheight()
    {
        heighttext.text = "Weather: Sunny   Height: " + bodyheight.ToString("F1");
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Getheight();
        Grader();
        showheight();

        promptup(1000, 995, "Please jump out of the airplane");
        promptup(900, 200, "Release your parachute");
        promptup(10, 100000000, "Your score is " + score.ToString());
        
    }
}
