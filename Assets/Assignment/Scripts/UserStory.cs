using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class UserStory : MainMenu
{
    public abstract void OnClick();

    public virtual void PlaySound(AudioSource audioClip)
    {
        if (audioClip != null)
        {
            audioClip.Play();
        }
    }
}
