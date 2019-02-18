using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.grey;
    }
}
