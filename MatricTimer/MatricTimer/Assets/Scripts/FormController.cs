using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormController : MonoBehaviour
{

    [Header("Main Forms")]
    public List<GameObject> MainForms;

    void Start()
    {
        //Onstart Load the Welcome Screen first...
        for (int i = 0; i < MainForms.Count; i++)
        {
            MainForms[i].SetActive(false);
            MainForms[i].transform.position = MainForms[0].transform.position;
        }

        MainForms[0].SetActive(true);//Activate only the main form.

    }


    void Update() {

    }


   public void ChangeActiveForm(int NewActiveForm)
    {
        for (int i = 0; i < MainForms.Count; i++)
        {
            MainForms[i].SetActive(false);
        }

       
    }
}
