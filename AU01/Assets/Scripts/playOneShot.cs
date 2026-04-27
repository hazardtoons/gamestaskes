using UnityEngine;

public class playOneShot : MonoBehaviour
{

    AudioSource ac;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ac = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            ac.Play();
        }
    }
}
