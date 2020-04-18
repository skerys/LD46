﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] PlayerInput player;

    void Update()
    {
        transform.position = player.transform.position;
    }
}
