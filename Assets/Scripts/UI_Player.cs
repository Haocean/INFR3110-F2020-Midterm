using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Player : MonoBehaviour
{
    public Text myText;

    public bool timeBool = false;
    public float timeTotal;

    public bool scoreBool = false;
    public float scoreTotal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBool == true)
        {
            timeTotal = timeTotal + Time.deltaTime;
            myText.text = timeTotal.ToString();
        }

        if (scoreBool == true)
        {
            scoreTotal = scoreTotal - Time.deltaTime;
            myText.text = scoreTotal.ToString();
        }
    }
}
