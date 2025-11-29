using UnityEngine;

public class armandoParticles : MonoBehaviour
{
    public ParticleSystem aterriza;
    public ParticleSystem golpeVoley;
    public void ParticlesArmando (int event_)
    {
        Debug.Log("Event: " + event_);
        if(event_ == 1)
        {
            aterriza.Play();
        }else if (event_ == 2)
        {
            golpeVoley.Play();
        }
    }
}
