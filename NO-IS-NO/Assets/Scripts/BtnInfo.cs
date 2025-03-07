using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnInfo : MonoBehaviour
{
    public int index;
    public GameObject[] gameObjects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowInfo()
    {
        GameManager.Instance.ShowInfo(index);
        foreach (GameObject obj in gameObjects)
        {
            obj.SetActive(true);
        }
    }
}
