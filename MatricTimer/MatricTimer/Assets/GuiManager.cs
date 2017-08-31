using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System;

public class GuiManager : MonoBehaviour {
    /*
     Dit is bietjie slegte coding want ek het nou UI Controller en die GUIManager...

        Maar die GUIManager gaan net gebruik word om die kleure/images and styles hanteer...

        StyleManager sou n beter naam wees... Maar dis nou maar so!

         */

    public List<GameObject> ObjectsToStyle;
    enum THoliday { Plett , MSC ,KleinKariba};

    public class StyleManager
    {
        THoliday fHoliday;
        Color fPrimary_Color;
        Color fSecondary_Color;
    }


    void ChangeStyle()
    {


    }


    //The UI Controller for changing between scenes and scripts
}
