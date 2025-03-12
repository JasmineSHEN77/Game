using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceToCam : MonoBehaviour
{
    public Camera mainCamera; // 主摄影机

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
        // 让物体始终朝向摄影机
        if (mainCamera != null)
        {
            // 计算物体朝向摄影机的方向
            Vector3 directionToCamera = mainCamera.transform.position - transform.position;

            // 让物体旋转以朝向摄影机
            transform.rotation = Quaternion.LookRotation(-directionToCamera);
        }
    }
}
