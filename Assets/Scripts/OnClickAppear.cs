using System.Collections.Generic;
using UnityEngine;

public class OnClickAppear : MonoBehaviour
{
    [Header("Objects you want to show/hide")]
    public List<GameObject> objectsToControl = new List<GameObject>();

    public void ShowObjects()
    {
        foreach (GameObject obj in objectsToControl)
        {
            if (obj != null)
                obj.SetActive(true);
        }
    }

    public void HideObjects()
    {
        foreach (GameObject obj in objectsToControl)
        {
            if (obj != null)
                obj.SetActive(false);
        }
    }
}