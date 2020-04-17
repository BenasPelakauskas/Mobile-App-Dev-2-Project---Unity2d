using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerHealth : MonoBehaviour
{
    // Declaring variables
    public int _health = 3;
    public int _damage = 0;
    public int _numOfHearts;

    public Image[] hearts; //Image array
    public Sprite heart_full;
    public Sprite heart_empty;

    public AudioClip _sound;    // Drag audio to inspector
    private AudioSource audio;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "bullet") // If the player collides with the bullet
            _health = _health - _damage; // Take damage
            _health -= _damage;

            if (_health == 0)
        {
            audio.Play();       // Play "oof" sound on death
            Destroy(gameObject, 1); //If health is 0, destroy ship.
        }
    }

    private void Update() //Number of hearts
    {
        if (_health > _numOfHearts)
        {
            _health = _numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < _health)
            {
                hearts[i].sprite = heart_full;
            }
            else
            {
                hearts[i].sprite = heart_empty;
            }

            if(i < _numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
            // Audio
            audio = gameObject.AddComponent<AudioSource>(); //adds audio
            audio.playOnAwake = false;
            audio.clip = _sound;
            audio.Stop();
        }
    }

}
