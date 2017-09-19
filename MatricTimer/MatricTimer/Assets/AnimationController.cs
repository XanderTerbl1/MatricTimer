using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {



    public  enum TPositionState {psStart, psHorz, psSingles};
    public enum TSingle {sDays , sHours , sMinutes, sSeconds ,sNone};

    TSingle TheSingle = TSingle.sNone;
    TPositionState TheState;

    public Animator DoubleTimeAnim;
    public GameObject Circle;
    float rotation = 0;


    void Start ()
    {
        TheState = TPositionState.psHorz;
	}

    void Update()
    {

    }
	


    public void doAnimate()
    {

        if (TheState == TPositionState.psStart)
        {
            //Move to Horz
            DoubleTimeAnim.SetTrigger("toHorz");
            TheState = TPositionState.psHorz;
        }
        else if (TheState == TPositionState.psHorz)
        {
            DoubleTimeAnim.SetTrigger("toVertz");
            TheState = TPositionState.psStart;
        }
        else
        {
            //Change the Singles Animation
        }
    }
}
