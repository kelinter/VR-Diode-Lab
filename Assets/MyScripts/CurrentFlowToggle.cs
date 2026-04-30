using UnityEngine;

public class CurrentFlowToggle : MonoBehaviour
{
    [SerializeField] private ParticleSystem currentParticles;

    public void TurnCurrentOn()
    {
        if (currentParticles != null)
        {
            currentParticles.Play();
        }
    }

    public void TurnCurrentOff()
    {
        if (currentParticles != null)
        {
            currentParticles.Stop();
        }
    }
}
