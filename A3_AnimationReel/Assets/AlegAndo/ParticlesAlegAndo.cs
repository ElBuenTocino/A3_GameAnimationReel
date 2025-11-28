using UnityEngine;

public class ParticlesAlegAndo : MonoBehaviour
{
    public ParticleSystem frontFootParticle, backFootParticle;

    void RunningParticleEvent(string feet)
    {
        if (feet == "Front")
        {
            frontFootParticle.Play();
        }
        if (feet == "Back")
        {
            backFootParticle.Play();
        }
    }
}
