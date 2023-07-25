using System;
using System.Collections;
using System.Collections.Generic;
using Command;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private IBootstrap _bootstrap = new Bootstrap();

    // Start is called before the first frame update
    void Start()
    {
        _bootstrap.AddCommand(new LogCommand());
        _bootstrap.AddCommand(new WaitCommand());
        _bootstrap.AddCommand(new Log2Command());
        _bootstrap.AddCommand(new WaitCommand());
        _bootstrap.ExecuteAllCommandNotify += Log;
        _bootstrap.StartExecute();
    }

    private void Log()
    {
        Debug.Log("All commands are execute");
    }
}

