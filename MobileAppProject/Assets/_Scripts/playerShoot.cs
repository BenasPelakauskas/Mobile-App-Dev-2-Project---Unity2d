using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code help from https://www.youtube.com/watch?v=01HVr1fp7pU

public class playerShoot : MonoBehaviour
{
    [SerializeField]
    private Transform Cannon;

    [SerializeField]
    private GameObject playerBullet;

    private Vector2 lookDirection;
    private float lookAngle;

    public AudioClip _sound;    // Audio selection in inspector
    private AudioSource audio;


    private void Start()
    {
        audio = gameObject.AddComponent<AudioSource>(); //adds audio
        audio.playOnAwake = false;
        audio.clip = _sound;
        audio.volume = 0.2f;
        audio.Stop();
    }
    // Update is called once per frame
    void Update()
    {
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
       // transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f); // Stop Ship from rotating

        if (Input.GetMouseButtonDown(0))
        {
            FireBullet();
        }
    }

    private void FireBullet()
    {
        audio.Play(); // Play audio when shooting
        GameObject firedBullet = Instantiate(playerBullet, Cannon.position, Cannon.rotation);
        firedBullet.GetComponent<Rigidbody2D>().velocity = Cannon.up * 10f;
    }
}
