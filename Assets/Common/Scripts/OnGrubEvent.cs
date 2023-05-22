using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGrubEvent : MonoBehaviour
{
    public void OnSelect()
    {
        gameObject.SetActive(true);
    }

    public void OnUnselect()
    {
        gameObject.SetActive(false);
    }
}
