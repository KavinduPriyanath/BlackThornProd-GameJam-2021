using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public void OpenChannel ()
    {
        Application.OpenURL("https://www.youtube.com/channel/UCFZwDbszng2yRDsUi_g7GTg?guided_help_flow=5");
    }
}
