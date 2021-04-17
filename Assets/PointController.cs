using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointController : MonoBehaviour
{

    private GameObject pointText;
    private float SmallStarpoint = 0;
    private float SmallCloudpoint = 0;
    private float LargeCloudpoint = 0;
    private float LargeStarpoint = 0;




    // Start is called before the first frame update
    void Start()
    {
        this.pointText = GameObject.Find("PointText");
    }

    // Update is called once per frame
    void Update()
    {
        float sumpoint = SmallStarpoint + SmallCloudpoint + LargeCloudpoint + LargeStarpoint;
        //Debug.Log(sumpoint);
        string a = sumpoint.ToString();
        Debug.Log(a);
        this.pointText.GetComponent<Text>().text = a;
        
        

    }

    void OnCollisionEnter (Collision other)
    {



        if (other.gameObject.tag == "SmallStarTag")
        {
            SmallStarpoint += 5;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            SmallCloudpoint += 5;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            LargeCloudpoint += 10;

        }


        else if (other.gameObject.tag == "LargeStarTag")
        {
            LargeStarpoint += 10;

        }
    }
}
