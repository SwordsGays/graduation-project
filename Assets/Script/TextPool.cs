﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextPool : MonoBehaviour
{
    public GameObject TarNpc;
    public Transform TargetNPC;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GameManagers._instance._poolManager.Create(TargetNPC, TarNpc, PoolManager.Type.NPC);
            TargetNPC.Translate(new Vector3(1, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            GameManagers._instance._poolManager.Destroy(GameObject.Find("Cube"), PoolManager.Type.NPC, 3f);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            GameManagers._instance._poolManager.Create(TargetNPC, TarNpc, PoolManager.Type.NPC);
            


        }
    }
}