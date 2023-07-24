using UnityEngine;

namespace Command
{
    public class LogCommand : Command
    {
        public override void Execute()
        {
            Debug.Log("LogCommand");
            base.Execute();
        }
        public override void Cancle()
        {
            
        }
    }
}