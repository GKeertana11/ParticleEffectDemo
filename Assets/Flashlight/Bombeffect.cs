using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombeffect : MonoBehaviour
{
    ParticleSystem particle;
    // Start is called before the first frame update
    void Start()
    {
        particle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Ground")
        {
            particle.Play();
            Debug.Log("true");
        }
    }
}
