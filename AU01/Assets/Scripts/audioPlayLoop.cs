using UnityEngine;

public class audioPlayLoop : MonoBehaviour
{

    AudioSource ac;
    bool playing = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ac = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        if (playing == false)
        {
            ac.Play();
            playing = true;
        }
        else
        {
            ac.Stop();
            playing = false;
        }

    }
}
