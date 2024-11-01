using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MiniGameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject sceneChangerTrigger;

    [SerializeField]
    private Animator door;

    [SerializeField]
    private TMP_Text miniGameScoreText;

    [SerializeField]
    private AudioSource doorAudioSource;

    [SerializeField]
    private AudioClip doorAudioClip;

    private int miniGameScore;

    private bool firstLock = false;
    private bool secondLock = false;
    private bool thirdLock = false;

    private void Start()
    {
        miniGameScore = 0;
        miniGameScoreText.text = 0.ToString();
    }

    private void MiniGameScoreUpdate()
    {
        miniGameScoreText.text = miniGameScore.ToString();
    }

    private void MiniGameScoreUp()
    {
        miniGameScore++;
        MiniGameScoreUpdate();
    }

    private void MiniGameScoreDown()
    {
        miniGameScore--;
        MiniGameScoreUpdate();
    }

    public void FirstLockTrue()
    {
        firstLock = true;
        MiniGameScoreUp();
        LockCheck();
    }
    public void FirstLockFalse()
    {
        firstLock = false;
        MiniGameScoreDown();
        door.SetBool("IsOpened", false);
    }

    public void SecondLockTrue()
    {
        secondLock = true;
        MiniGameScoreUp();
        LockCheck();
    }
    public void SecondLockFalse()
    {
        secondLock = false;
        MiniGameScoreDown();
        door.SetBool("IsOpened", false);
    }

    public void ThirdLockTrue()
    {
        thirdLock = true;
        MiniGameScoreUp();
        LockCheck();
    }

    public void ThirdLockFalse()
    {
        thirdLock = false;
        MiniGameScoreDown();
        door.SetBool("IsOpened", false);
    }

    private void LockCheck()
    {
        if (firstLock == true && secondLock == true && thirdLock == true)
        {
            door.SetBool("IsOpened", true);
            doorAudioSource.PlayOneShot(doorAudioClip);
            sceneChangerTrigger.SetActive(true);
        }
    }
}
