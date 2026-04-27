using UnityEngine;

public class smoke : MonoBehaviour
{
    
    ParticleSystem smokeParticles;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        smokeParticles = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("s"))
        {
            ParticleSystem.EmitParams emitOverride = new ParticleSystem.EmitParams();
            emitOverride.startLifetime = 1f;
            smokeParticles.Emit(emitOverride, 40);

            Debug.Log("smonk");
        }
    }
}
