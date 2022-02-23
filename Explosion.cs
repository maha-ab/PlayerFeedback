using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    ParticleSystem explosionParticleSystem;
    public ParticleSystem explosionPrefab;

    public SoundManager soundManager;

  
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="bullet")
        {
            soundManager.Explosion();
            explosionParticleSystem = ParticleSystem.Instantiate(explosionPrefab, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
            Destroy(collision.rigidbody.gameObject);
            Destroy(explosionParticleSystem, 1.0f);
        }
    }
}



