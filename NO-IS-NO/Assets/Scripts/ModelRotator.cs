using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelRotator : MonoBehaviour
{

    public Transform model;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float speed;

    float dragStartX = 0;
    public void RotModStart()
    {
        Debug.Log("RotMod" + Input.mousePosition);
        dragStartX = Input.mousePosition.x;
    }
    public void RotMod()
    {
        float rotX = dragStartX -Input.mousePosition.x;
        //Debug.Log("RotMod" + value);
        model.Rotate(0, rotX * Time.deltaTime * speed, 0);
        Debug.Log("RotMod" + rotX);
    }
}
