using System;
using Interfaces;

public interface IBootstrap
{
    public event Action ExecuteAllCommandNotify;
    bool AddCommand(ICommand command);
    void StartExecute(); 
}