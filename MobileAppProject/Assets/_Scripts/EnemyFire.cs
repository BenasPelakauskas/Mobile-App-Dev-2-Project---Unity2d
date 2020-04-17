using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour 
{
    [SerializeField]
    GameObject bullet;

    float fireRate;
    float nextFire;
    public AudioClip _sound;    // Drag audio to inspector
    private AudioSource audio;

    void Start()
    {
        fireRate = 3.5f;
        nextFire = Time.time;
        audio = gameObject.AddComponent<AudioSource>(); //adds audio
        audio.playOnAwake = false;
        audio.clip = _sound;
        audio.volume = 0.2f;
        audio.Stop();
    }

    void Update()
    {
        CheckIfTimeToFire ();
    }

    void CheckIfTimeToFire()
    {
        if (Time.time > nextFire)
        {
            audio.Play();
            Instantiate (bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }

}
