using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointController : MonoBehaviour
{

    private GameObject pointText;
    private float point = 0;



    // Start is called before the first frame update
    void Start()
    {
        this.pointText = GameObject.Find("PointText");
    }

    // Update is called once per frame
    void Update()
    {
        
        string a = point.ToString();
        this.pointText.GetComponent<Text>().text = a;
        
        

    }

    void OnCollisionEnter (Collision other)
    {
        Debug.Log("tag=" + tag);
        if (tag == "SmallStarTag"|| tag == "SmallCloudTag")
        {
            point += 5;
        }

        else if (tag == "LargeCloudTag" || tag == "LargeStarTag")
        {
            point += 10;

        }
    }
}
