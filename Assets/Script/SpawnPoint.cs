using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject Wall;

    void Start()
    {
        Instantiate(Wall, transform.position, Quaternion.identity);
    }
}
