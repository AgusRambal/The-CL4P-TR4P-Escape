using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAndPlayAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioScenes.Instance.gameObject.GetComponent<AudioSource>().Pause();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
