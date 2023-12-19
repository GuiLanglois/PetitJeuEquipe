using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject SceneChangerTrigger;
    
    private bool firstLock = false;
    private bool secondLock = false;
    private bool thirdLock = false;
    
    public void FirstLockTrue()
    {
        firstLock = true;
        LockCheck();
    }
    public void FirstLockFalse()
    {
        firstLock = false;
    }

    public void SecondLockTrue()
    {
        secondLock = true;
        LockCheck();
    }
    public void SecondLockFalse()
    {
        secondLock = false;
    }

    public void ThirdLockTrue()
    {
        thirdLock = true;
        LockCheck();
    }

    public void ThirdLockFalse()
    {
        thirdLock = false;
    }

    private void LockCheck()
    {
        if (firstLock == true && secondLock == true && thirdLock == true)
        {
            SceneChangerTrigger.SetActive(true);
        }
    }
}
