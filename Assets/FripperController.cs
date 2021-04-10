using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    private HingeJoint myHingeJoint;

    private float defaultAngle = 20;

    private float flickAngle = -20;



    // Start is called before the first frame update
    void Start()
    {
        this.myHingeJoint = GetComponent<HingeJoint>();

        SetAngle(this.defaultAngle);
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle (this.flickAngle);

        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripper")
        {
            SetAngle (this.defaultAngle);

        }

    }


}

public void SetAngle(float angle)
{
    jointSpring jointSpr = this.myHingeJoint.spring;
    jointSpr.targetPostion = angle;
    this.myHingeJoint.spring = jointSpr;

}
