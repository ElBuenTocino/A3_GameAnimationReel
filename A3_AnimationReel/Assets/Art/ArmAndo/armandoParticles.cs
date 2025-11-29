using UnityEngine;

public class armandoParticles : MonoBehaviour
{
    public ParticleSystem aterriza;
    public void ParticlesArmando (int event_)
    {
        Debug.Log("Event: " + event_);
        if(event_ == 0)
        {
            aterriza.Play();
        }
    }
}
