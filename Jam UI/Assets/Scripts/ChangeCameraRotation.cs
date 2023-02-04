using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using DG.Tweening;

public class ChangeCameraRotation : MonoBehaviour
{
    private Vector3 lastMousePosition;
    private bool mouseButtonDown = false;
    [SerializeField]
    private CinemachineVirtualCamera activeCamera;
    [SerializeField]
    private List<Transform> Walls;
    int test = 0;
    void Update()
    {
        ChangeWallView();
    }
    private void ChangeWallView()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouseButtonDown = true;
            lastMousePosition = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            Vector3 currentMousePosition = Input.mousePosition;
            if (currentMousePosition.x > lastMousePosition.x)
            {
                Debug.Log(activeCamera.transform.eulerAngles.y);
                WallDownAndUpLeft();
            }
            else if (currentMousePosition.x < lastMousePosition.x)
            {
                Debug.Log(activeCamera.transform.eulerAngles.y);
                WallDownAndUpRight();
            }
            mouseButtonDown = false;
        }
    }

    private void WallDownAndUpRight()
    {

        int eulerAngle = (int)activeCamera.transform.eulerAngles.y;
        switch (eulerAngle)
        {
            case 315:
                activeCamera.transform.DORotate((new Vector3(activeCamera.transform.eulerAngles.x, 45, activeCamera.transform.eulerAngles.x)), 0.3f);
                Walls[0].DOLocalMoveY(58f, 0.2f);
                Walls[2].DOLocalMoveY(48f, 0.2f);
                break;
            case 314:
                activeCamera.transform.DORotate((new Vector3(activeCamera.transform.eulerAngles.x, 45, activeCamera.transform.eulerAngles.x)), 0.3f);
                Walls[0].DOLocalMoveY(58f, 0.2f);
                Walls[2].DOLocalMoveY(48f, 0.2f);
                break;
            case 45:
                activeCamera.transform.DORotate((new Vector3(activeCamera.transform.eulerAngles.x, 135, activeCamera.transform.eulerAngles.x)), 0.3f);
                Walls[1].DOLocalMoveY(58f, 0.2f);
                Walls[3].DOLocalMoveY(48f, 0.2f);
                break;
            case 44:
                activeCamera.transform.DORotate((new Vector3(activeCamera.transform.eulerAngles.x, 135, activeCamera.transform.eulerAngles.x)), 0.3f);
                Walls[1].DOLocalMoveY(58f, 0.2f);
                Walls[3].DOLocalMoveY(48f, 0.2f);
                break;
            case 135:
                activeCamera.transform.DORotate((new Vector3(activeCamera.transform.eulerAngles.x, 225, activeCamera.transform.eulerAngles.x)), 0.3f);
                Walls[2].DOLocalMoveY(58f, 0.2f);
                Walls[0].DOLocalMoveY(48f, 0.2f);
                break;
            case 134:
                activeCamera.transform.DORotate((new Vector3(activeCamera.transform.eulerAngles.x, 225, activeCamera.transform.eulerAngles.x)), 0.3f);
                Walls[2].DOLocalMoveY(58f, 0.2f);
                Walls[0].DOLocalMoveY(48f, 0.2f);
                break;
            case 224:
                activeCamera.transform.DORotate((new Vector3(activeCamera.transform.eulerAngles.x, 315, activeCamera.transform.eulerAngles.x)), 0.3f);
                Walls[3].DOLocalMoveY(58f, 0.2f);
                Walls[1].DOLocalMoveY(48f, 0.2f);
                break;
            case 225:
                activeCamera.transform.DORotate((new Vector3(activeCamera.transform.eulerAngles.x, 315, activeCamera.transform.eulerAngles.x)), 0.3f);
                Walls[3].DOLocalMoveY(58f, 0.2f);
                Walls[1].DOLocalMoveY(48f, 0.2f);
                break;
        }
    }

    private void WallDownAndUpLeft()
    {
        int yRotation = (int)activeCamera.transform.eulerAngles.y;

        switch (yRotation)
        {
            case 315:
                activeCamera.transform.DORotate((new Vector3(activeCamera.transform.eulerAngles.x, activeCamera.transform.eulerAngles.y - 90, activeCamera.transform.eulerAngles.x)), 0.3f);
                Walls[1].DOLocalMoveY(58f, 0.2f);
                Walls[3].DOLocalMoveY(48f, 0.2f);
                break;
            case 314:
                activeCamera.transform.DORotate((new Vector3(activeCamera.transform.eulerAngles.x, activeCamera.transform.eulerAngles.y - 90, activeCamera.transform.eulerAngles.x)), 0.3f);
                Walls[1].DOLocalMoveY(58f, 0.2f);
                Walls[3].DOLocalMoveY(48f, 0.2f);
                break;
            case 224:
                activeCamera.transform.DORotate((new Vector3(activeCamera.transform.eulerAngles.x, activeCamera.transform.eulerAngles.y - 90, activeCamera.transform.eulerAngles.x)), 0.3f);
                Walls[0].DOLocalMoveY(58f, 0.2f);
                Walls[2].DOLocalMoveY(48f, 0.2f);
                break;
            case 225:
                activeCamera.transform.DORotate((new Vector3(activeCamera.transform.eulerAngles.x, activeCamera.transform.eulerAngles.y - 90, activeCamera.transform.eulerAngles.x)), 0.3f);
                Walls[0].DOLocalMoveY(58f, 0.2f);
                Walls[2].DOLocalMoveY(48f, 0.2f);
                break;
            case 134:
                activeCamera.transform.DORotate((new Vector3(activeCamera.transform.eulerAngles.x, activeCamera.transform.eulerAngles.y - 90, activeCamera.transform.eulerAngles.x)), 0.3f);
                Walls[3].DOLocalMoveY(58f, 0.2f);
                Walls[1].DOLocalMoveY(48f, 0.2f);
                break;
            case 135:
                activeCamera.transform.DORotate((new Vector3(activeCamera.transform.eulerAngles.x, activeCamera.transform.eulerAngles.y - 90, activeCamera.transform.eulerAngles.x)), 0.3f);
                Walls[3].DOLocalMoveY(58f, 0.2f);
                Walls[1].DOLocalMoveY(48f, 0.2f);
                break;
            case 44:
                activeCamera.transform.DORotate((new Vector3(activeCamera.transform.eulerAngles.x, activeCamera.transform.eulerAngles.y - 90, activeCamera.transform.eulerAngles.x)), 0.3f);
                Walls[2].DOLocalMoveY(58f, 0.2f);
                Walls[0].DOLocalMoveY(48f, 0.2f);
                break;
            case 45:
                activeCamera.transform.DORotate((new Vector3(activeCamera.transform.eulerAngles.x, activeCamera.transform.eulerAngles.y - 90, activeCamera.transform.eulerAngles.x)), 0.3f);
                Walls[2].DOLocalMoveY(58f, 0.2f);
                Walls[0].DOLocalMoveY(48f, 0.2f);
                break;
        }
    }

}