using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;

public class ScenarioSim : MonoBehaviour
{

    [Header("开始的UI")]
    public GameObject startUI;

    [Header("3部分的Timeline")]
    public TimelineAsset[] timelines;



    PlayableDirector playableDirector;

    void Start()
    {

        playableDirector = GetComponent<PlayableDirector>();    
    }


    public void StartSim()
    {
        startUI.SetActive(false);
        playableDirector.playableAsset = timelines[0];
        playableDirector.Play();
    }

    public void SimSelection(int i)
    {
        playableDirector.playableAsset  = timelines[i]; 
        playableDirector.Play();
    }
    public void BackBtn()
    {
        SceneManager.LoadScene(2);
    }

    public void BackBtnToEnd()
    {
        SceneManager.LoadScene(4);
    }
}
