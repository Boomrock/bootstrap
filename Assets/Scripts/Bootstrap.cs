using System;
using System.Collections;
using System.Collections.Generic;
using Command;
using Interfaces;
using UnityEngine;

public class Bootstrap : MonoBehaviour, IBootstrap
{
    private void Start()
    {
        this.AddCommand(new WaitCommand());
        this.AddCommand(new LogCommand());
        this.AddCommand(new Log2Command());
        this.StartExecute();
    }

    private Queue<ICommand> _commands = new Queue<ICommand>();
    private int _commandCount; 
    private int _commandExecute; 
    public void AddCommand(ICommand command)
    {
        command.CommandExecuteNotify += CommandExecute;
        _commands.Enqueue(command);
        
    }
    private void CommandExecute ()
    {
        _commandExecute++;
        Debug.Log($"{_commandExecute}/{_commandCount}");   
    }

    public void StartExecute()
    {
        _commandExecute = 0;
        _commandCount = _commands.Count;
        while (_commands.Count > 0)
        {
            var command = _commands.Dequeue();
            command.Execute(); 
        }
    }
}

