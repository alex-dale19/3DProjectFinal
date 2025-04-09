using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaClick : MonoBehaviour
{
    void OnMouseDown()
    {
        // Hide the banana
        gameObject.SetActive(false);
    }
}
