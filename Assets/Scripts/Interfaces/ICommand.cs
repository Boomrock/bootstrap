using System;

namespace Interfaces
{
    public interface ICommand
    {
        event Action CommandExecuteNotify;
        void Execute();
        void Cancle();
    }
}