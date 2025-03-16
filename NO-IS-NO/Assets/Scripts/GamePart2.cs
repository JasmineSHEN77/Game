using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePart2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        animator = GirlModel.transform.GetComponent<Animator>();
        girl.Select();
    }

    // Update is called once per frame
    void Update()
    {

    }

    [Header("模型切换")]
    public GameObject GirlModel;
    public GameObject BoyModel;

    public Button boy;
    public Button girl;
    Animator animator;
    public void ModelSwitchBtn(bool isGirl)
    {
        if (isGirl)
        {
            GirlModel.SetActive(true);
            BoyModel.SetActive(false);

            animator = GirlModel.transform.GetComponent<Animator>();

            girl.Select();
            boy.OnDeselect(null);
        }
        else
        {
            GirlModel.SetActive(false);
            BoyModel.SetActive(true);

            animator = BoyModel.transform.GetComponent<Animator>();
            boy.Select();
            girl.OnDeselect(null);
        }
    }


    [Header("Warning对话框内容")]
    public Sprite[] FiveWarningInfo;
    public Image LeftInfo;
    public GameObject[] ToHideObj;
    public GameObject SeeSolutionBtn;

     int warningIndex;
    public void GoFiveWarningInfo(int index)
    {
        warningIndex = index;
        LeftInfo.sprite = FiveWarningInfo[index]; 

        foreach (GameObject item in ToHideObj)
        {
            item.SetActive(false);
        }
        SeeSolutionBtn.SetActive(true);
    }

    [Header("SeeSolution内容")]
    public GameObject warningBtns;
    public GameObject[] Solutions;
    public GameObject GoSim;
    public void SeeSolution()
    {
        warningBtns.SetActive(false);
        Solutions[warningIndex].SetActive(true);

        SeeSolutionBtn.SetActive(false);
        GoSim.SetActive(true);
    }


    public void GoSimluation()
    { }
}


