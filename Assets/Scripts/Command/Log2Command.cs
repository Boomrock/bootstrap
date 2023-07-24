using UnityEngine;

namespace Command
{
    public class Log2Command:Command
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