
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public ParticleSystem movementParticle;

    [Range(0,10)]
    [SerializeField] int occurAfterVelocity;

    [Range (0,0.2f)]
    [SerializeField] float dustFormationPeriod;

    [SerializeField] Rigidbody2D playerRb;

    float counter;

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if (Mathf.Abs(playerRb.velocity.x) > occurAfterVelocity)
        {
            if (counter > dustFormationPeriod)
            {
                movementParticle.Play();
                counter = 0;
            }

        }
    }
}
