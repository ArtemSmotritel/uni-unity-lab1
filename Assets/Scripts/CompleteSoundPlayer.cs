using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteSoundPlayer : MonoBehaviour
{
    [Range(0f, 1.0f)]
    public float volume = 1.0f;
    private AudioSource completeSoundSource;

    // Start is called before the first frame update
    void Start()
    {
        this.completeSoundSource = GetComponent<AudioSource>();
        LevelCompleteEventManager.AddEventListener(TriggerCompleteSound);
    }

    private void TriggerCompleteSound()
    {
        this.completeSoundSource.PlayOneShot(this.completeSoundSource.clip, this.volume);
    }
}
