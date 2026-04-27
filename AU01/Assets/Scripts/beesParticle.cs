using UnityEngine;

public class beesParticle : MonoBehaviour
{
    ParticleSystem beeParticles;
    bool bees = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        beeParticles = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("j"))
        {

            if (bees == false)
            {
                Debug.Log("ITS BEES");
                beeParticles.Play();
                bees = true;
            }
            else
            {
                Debug.Log("the swarm has dissapated.");
                beeParticles.Stop();
                bees = false;
            }
        }
    }
}
