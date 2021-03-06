﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnpoint;

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        player.transform.position = respawnpoint.transform.position;
    }
}
