using System.Collections;
using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace Command
{
    public class WaitCommand:Command
    {
        public override void Execute()
        {
            WaitAsync();
        }

        public override void Cancle()
        {

        }
        
        
        async Task WaitAsync()
        {
            await Task.Run(Wait);
            Debug.Log("WaitCommand execute");
            base.Execute();
        }

        private void Wait()
        {
            Thread.Sleep(3000); 
        }
    }
}