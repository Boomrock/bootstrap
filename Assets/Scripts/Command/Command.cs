using System;
using Interfaces;

namespace Command
{
    public abstract class Command:ICommand
    {
        public event Action CommandExecuteNotify;

        public virtual void Execute()
        {
            CommandExecuteNotify?.Invoke();
        }
        public abstract void Cancle();
    }
}