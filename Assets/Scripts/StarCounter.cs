using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarCounter : MonoBehaviour
{
public int numberofStars;
public Text numberofstarsText;

    // Start is called before the first frame update
    void Start()
    {
        numberofStars = 0;
        numberofstarsText.text = numberofStars.ToString(); 
    }

    // Update is called once per frame
    public void AddStar()
    {
        numberofStars++;
        numberofstarsText.text =  numberofStars.ToString();
    }


}