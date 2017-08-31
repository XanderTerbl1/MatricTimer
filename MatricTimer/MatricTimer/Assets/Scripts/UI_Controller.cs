using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Controller : MonoBehaviour {

    [SerializeField]
    private GameObject BG_Shader;
    [SerializeField]
    private GameObject SlideMenu;
    //
    [SerializeField]
    private GameObject TopLeftPoint;
    [HideInInspector]
    public Vector3 StartPoint_SlideMenu;  //Start and End point are used as xref's
    [HideInInspector]
    public Vector3 EndPoint_SlideMenu;  //Start and End point are used as xref's

    void Awake ()
    {
       

        Vector3 SlideStart;
        SlideStart.x = TopLeftPoint.transform.position.x;
        SlideStart.y = SlideMenu.transform.position.y;
        SlideStart.z = SlideMenu.transform.position.z;

        StartPoint_SlideMenu = SlideStart;

    
        Vector3 SlideEnd;
        SlideEnd.x = SlideMenu.transform.position.x;
        SlideEnd.y = SlideMenu.transform.position.y;
        SlideEnd.z = SlideMenu.transform.position.z;
        EndPoint_SlideMenu = SlideEnd;


        TweenTransforms TweenTrans = SlideMenu.GetComponent<TweenTransforms>();
        TweenTrans.startingVector = GetSliderStart();
        TweenTrans.endVector = GetSliderEnd();

        Debug.Log(SlideMenu.transform.localPosition);

    }

    public Vector3 GetSliderStart()
    {
      
        return StartPoint_SlideMenu;
    }

    public Vector3 GetSliderEnd()
    {
        return EndPoint_SlideMenu;
    }

    // Update is called once per frame
    void Update ()
    {

		
	}

    public void ShaderState(bool ShaderState)
    {
        

        if (ShaderState)
        {
            BG_Shader.SetActive(true);
            TweenTransforms TweenTrans = SlideMenu.GetComponent<TweenTransforms>();
            TweenTrans.startingVector = GetSliderStart();
            TweenTrans.endVector = GetSliderEnd();
        }
        else {
            BG_Shader.SetActive(false);
            TweenTransforms TweenTrans = SlideMenu.GetComponent<TweenTransforms>();
            TweenTrans.startingVector = GetSliderEnd();
            TweenTrans.endVector = GetSliderStart();
        }
    }











    




}
