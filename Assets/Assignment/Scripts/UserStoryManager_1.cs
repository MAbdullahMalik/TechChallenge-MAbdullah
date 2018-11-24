using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserStoryManager_1 : UserStory {

    [SerializeField] AudioSource audioClip;
    [SerializeField] Animator bulbAnimator;

    string BULB_STATE = "State";

    public override void OnClick()
    {
        PlaySound(audioClip);

        CancelInvoke("OnClipComplete");
        Invoke("OnClipComplete", audioClip.clip.length);
    }

    void OnClipComplete(){
        //Animate Bulb
        bool currentState = bulbAnimator.GetBool(BULB_STATE);
        bulbAnimator.SetBool(BULB_STATE, !currentState);
    }

    public void BackButtonOnClick(){
        LoadScene("Menu");
    }
}
