using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Cysharp.Threading.Tasks;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform leftDoor;
    [SerializeField] private Transform rightDoor;
    [SerializeField] private float moveDuration = 0.5f;
    [SerializeField] private int holdDuration = 5;
    [SerializeField] private Transform controller;
    private bool isClosed;
    private bool isBlocked;
    private Vector3 leftClosedPos;
    private Vector3 rightClosedPos;
    private Vector3 leftOpenedPos;
    private Vector3 rightOpenedPos;

    public bool IsBlocked => isBlocked;

    private void Awake()
    {
        leftClosedPos = leftDoor.position;
        rightClosedPos = rightDoor.position;
        leftOpenedPos = new Vector3(leftClosedPos.x - leftDoor.localScale.x, leftClosedPos.y, leftClosedPos.z);
        rightOpenedPos = new Vector3(rightOpenedPos.x + rightDoor.localScale.x, rightOpenedPos.y, rightOpenedPos.z);
    }

    private void ExecuteDoor()
    {
        if (!isBlocked)
        {
            if (isClosed)
            {
                _ = leftDoor.DOMove(leftOpenedPos, moveDuration).OnComplete(() => HoldTheDoorWithDelay());
                rightDoor.DOMove(rightOpenedPos, moveDuration);
            }
            else
            {
                leftDoor.DOMove(leftClosedPos, moveDuration).OnComplete(() => isClosed = true);
                rightDoor.DOMove(rightClosedPos, moveDuration);
            }
        }
    }

    private async UniTask HoldTheDoorWithDelay()
    {
        isClosed = false;
        await UniTask.Delay(holdDuration * 1000);
        if (!isBlocked)
            ExecuteDoor();
    }
}
