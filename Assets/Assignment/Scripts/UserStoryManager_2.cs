using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserStoryManager_2 : UserStory {

    [SerializeField] AudioSource audioClip;
    [SerializeField] Animator doorAnimator;

    string DOOR_STATE = "State";

    public override void OnClick()
    {
        PlaySound(audioClip);
        CancelInvoke("OnClipComplete");
        Invoke("OnClipComplete", audioClip.clip.length);
    }

    void OnClipComplete(){
        //Animate Door
        bool currentState = doorAnimator.GetBool(DOOR_STATE);
        doorAnimator.SetBool(DOOR_STATE, !currentState);
    }

    public void BackButtonOnClick()
    {
        LoadScene("Menu");
    }
}
