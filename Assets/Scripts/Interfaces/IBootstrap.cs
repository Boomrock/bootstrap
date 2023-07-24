using Interfaces;

public interface IBootstrap
{
    void AddCommand(ICommand command);
    void StartExecute(); 
}