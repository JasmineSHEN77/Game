using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInFront : MonoBehaviour
{
     Camera mainCamera; // 主摄影机
    public float visibleAngleMin = 0f; // 可见角度范围
    public float visibleAngleMax = 45f; // 可见角度范围
    public GameObject showObj;

    void Start()
    {

        // 如果没有指定摄影机，使用主摄影机
        if (mainCamera == null)
        {
            mainCamera = Camera.main;
        }
    }

    void Update()
    {
        //// 计算物体与摄影机的方向向量
        //Vector3 directionToObject = transform.position - mainCamera.transform.position;
        //directionToObject.Normalize();

        // 获取摄影机的正前方方向
        Vector3 cameraForward = mainCamera.transform.forward;

        // 计算物体方向与摄影机正前方的夹角
        float angle = Vector3.Angle(cameraForward, -transform.forward);
        //Debug.Log(angle);
        // 根据角度决定是否显示物
        if (angle >= visibleAngleMin && angle <= visibleAngleMax)
        {
            showObj.SetActive(true);
        }
        else
        {
            showObj.SetActive(false);
        }
    }
}
