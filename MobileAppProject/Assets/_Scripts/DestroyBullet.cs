using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour // To Destory bullet 3 seconds after shooting
{
    void Update()
    {
        Destroy(gameObject, 3); // Destroys shot bullets after 3 seconds
    }
}
