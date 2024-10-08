using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    private ParticleSystem particle;

    private void Start()
    {
        particle = GetComponent<ParticleSystem>();
        Player.instance.OnHit += SpawnParticle;
    }

    public void SpawnParticle()
    {
        particle.Play();
    }
}
