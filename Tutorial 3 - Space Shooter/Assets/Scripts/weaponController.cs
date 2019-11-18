using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponController : MonoBehaviour
{
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    public float delay;

    private AudioSource audiosource;


    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        InvokeRepeating("Fire", delay, fireRate);
    }

    void Fire()
    {
        Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
        audiosource.Play();
    }
}

