using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserStoryManager_3 : UserStory {

    [SerializeField] AudioSource audioClip;
    [SerializeField] Animator[] bulbAnimators;

    int totalNumberOfBulbs = 0;
    int currentBulb = 0;

    string BULB_STATE = "State";

    public void Start(){
        totalNumberOfBulbs = bulbAnimators.Length;
    }

    public override void OnClick()
    {
        PlaySound(audioClip);
        AnimateBulb();
    }

    void AnimateBulb(){
        //Animate Bulb
        Animator selectedBulb = bulbAnimators[ currentBulb++ % totalNumberOfBulbs];

        bool currentState = selectedBulb.GetBool(BULB_STATE);
        selectedBulb.SetBool(BULB_STATE, !currentState);
    }

    public void BackButtonOnClick()
    {
        LoadScene("Menu");
    }
}
