﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
public class TextTask : MonoBehaviour
{
    private MethodInfo methodInfo;
    void Start()
    {
        TaskManager.instance.TaskEvent += Task;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool Task(MethodInfo methodInfo)
    {

    }
}
