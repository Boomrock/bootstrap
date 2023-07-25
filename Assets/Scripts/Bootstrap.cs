using System;
using System.Collections;
using System.Collections.Generic;
using Command;
using Interfaces;
using UnityEngine;

public class Bootstrap : IBootstrap
{
    public event Action ExecuteAllCommandNotify; 

    private Queue<ICommand> _commands = new Queue<ICommand>();
    private int _commandCount; 
    private int _commandExecute;
    private bool _commandsExecuted;
    public bool AddCommand(ICommand command)
    {
        if(_commandsExecuted)
            return false;
        _commands.Enqueue(command);
        return true;
    }
    public void StartExecute()
    {
        if(_commandsExecuted)
            return;
        _commandExecute = 0;
        _commandCount = _commands.Count;
        _commandsExecuted = true;
        execute();
    }

    private void execute()
    {
        if (_commands.Count == 0)
        {
            ExecuteAllCommandNotify?.Invoke();
            return;
        }
        
        var command = _commands.Dequeue();
        command.CommandExecuteNotify += execute;
        command.Execute();

    }
}

