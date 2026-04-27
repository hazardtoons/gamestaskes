using UnityEngine;
using System.Collections;

public class audioPlayLoop : MonoBehaviour
{

    AudioSource ac;
    AudioReverbFilter verb;
    AudioLowPassFilter eq;
    bool playing = false;
    bool reverb = false;
    bool eqbool = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ac = GetComponent<AudioSource>();
        verb = GetComponent<AudioReverbFilter>();
        eq = GetComponent<AudioLowPassFilter>();
        Debug.Log("playing = " + playing);
        Debug.Log("reverb = " + reverb);
        Debug.Log("EQ = " + eqbool);
    }

    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            
            if (playing == false)
            {
                Debug.Log("i get high (i get high) i GET high (i GET high)");
                Debug.Log("i get high (i get high) i GET high (i GET high)");
                Debug.Log("i get HIGH on your memoryHIGH on your memoryHIGH on your memory");
                ac.Play();
                playing = true;
            }
            else
            {
                Debug.Log("you HATE HIM??? you want him SILENCED???");
                ac.Stop();
                playing = false;
            }
        }

        if (Input.GetKeyDown("r"))
        {
            if (reverb == false)
            {
                Debug.Log("REVERB TIME");
                reverb = true;
                verb.reverbLevel = 0;
            } 
            else
            {
                Debug.Log("Normal-Style");
                reverb = false;
                verb.reverbLevel = -10000;
            }
        }

        if (Input.GetKeyDown("e"))
        {
            if (eqbool == false)
            {
                Debug.Log("step outside for a sec");
                eqbool = true;
                eq.cutoffFrequency = 500;
            }
            else
            {
                Debug.Log("welcome back inside, we saved you a can of pepsi");
                eqbool = false;
                eq.cutoffFrequency = 22000;
            }
        }
    }
}
