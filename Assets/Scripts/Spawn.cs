using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject BallPrefab;

    public void Start()
    {
        Instantiate(BallPrefab);
    }
}
