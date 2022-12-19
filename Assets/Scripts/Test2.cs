using DI.Attributes.Register;
using UnityEngine;
using Utilities.Behaviours;

[Register(typeof(ITesting))]
internal class Test2 : KernelEntityBehaviour, ITesting
{
    
    public void log(string message) {
        Debug.Log(message);
    }
}

interface ITesting {
    void log(string message);
}
