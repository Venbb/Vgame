﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    void Awake()
    {
        LuaManager.Instance.Init().DoString("require 'GameStart'");
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
LuaManager.Instance.luaEnv.Tick();
    }
}