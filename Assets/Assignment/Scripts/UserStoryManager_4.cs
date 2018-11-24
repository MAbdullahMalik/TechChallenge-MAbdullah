using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserStoryManager_4 : UserStory {

    [SerializeField] AudioSource audioClip;
    [SerializeField] Animator machineAnimator;

    string MACHINE_STATE = "State";

    public override void OnClick()
    {
        PlaySound(audioClip);

        CancelInvoke("OnClipComplete");
        Invoke("OnClipComplete", audioClip.clip.length);
    }

    void OnClipComplete(){
        //Animate Machine
        int rand = Random.Range(1, 4);
        switch(rand){
            case 1:
                machineAnimator.SetTrigger("Anim1");
                break;
            case 2:
                machineAnimator.SetTrigger("Anim2");
                break;
            case 3:
                machineAnimator.SetTrigger("Anim3");
                break;
        }
    }

    public void BackButtonOnClick()
    {
        LoadScene("Menu");
    }
}
