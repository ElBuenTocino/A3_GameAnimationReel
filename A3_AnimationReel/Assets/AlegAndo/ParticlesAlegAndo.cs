using UnityEngine;

public class ParticlesAlegAndo : MonoBehaviour
{
    public ParticleSystem frontFootParticle, backFootParticle;
    public ParticleSystem frontHitParticle;

    private void Start()
    {
        if (GetComponent<Animator>().runtimeAnimatorController != null)
        {
            GetComponent<Animator>().runtimeAnimatorController = null;
        }
    }

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

    void HitParticle()
    {
        frontHitParticle.Play();
    }
}
