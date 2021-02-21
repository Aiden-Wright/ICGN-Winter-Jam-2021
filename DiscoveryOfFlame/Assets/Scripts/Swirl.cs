using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swirl : MonoBehaviour
{
    ParticleSystem P;
    // Start is called before the first frame update
    void Start()
    {
        P = gameObject.GetComponent<ParticleSystem>();
        transform.position = new Vector3(transform.position.x + .5f, transform.position.y + .2f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        ParticleSystem.Particle[] particles = new ParticleSystem.Particle[P.main.maxParticles];
        P.GetParticles(particles);
        for(int i = 0; i < particles.Length; ++i)
        {
            ParticleSystem.Particle particle = particles[i];
            particle.velocity = new Vector3(particle.velocity.x * transform.localScale.x,
                                            particle.velocity.y * transform.localScale.y,
                                            particle.velocity.z * transform.localScale.z);
        }
    }
}
