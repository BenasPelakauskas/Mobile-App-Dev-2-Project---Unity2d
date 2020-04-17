using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public void ToGame()
    {
        Application.LoadLevel("SampleScene"); // Load into main game scene
    }
}
