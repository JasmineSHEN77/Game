using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public int Phase = 0;

    public GameObject title;
    public GameObject[] phases;
    public GameObject[] phaseObjs;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(Instance);
        }
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void GoPhase(int index)
    {
        title.SetActive(false);
        phases[index].gameObject.SetActive(true);
        foreach (GameObject obj in phaseObjs)
        {
            obj.SetActive(false);
        }
        phaseObjs[index].SetActive(true);

    }

    public void BackBtn()
    {
        title.SetActive(true);
        foreach (GameObject go in phases)
        {
            go.SetActive(false);    
        }
    }

    [Header("Part1第一部分  012对应  X？√  三个按钮")]
    public string[] infos;
    public List<GameObject> p1Signs;
    public TMP_Text infoTMP;
    public void ShowInfo(int index)
    {
        infoTMP.text = infos[index];


        for (int i = 0; i < p1Signs.Count; i++) {
            if (i == index)
            {
                p1Signs[i].SetActive(true);
            }
            else
            {
                p1Signs[i].SetActive(false);
            }
        }
     
    }

}
