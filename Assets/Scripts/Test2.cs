using DI.Attributes.Register;
using UnityEngine;
using Utilities.Behaviours;

[Register]
internal class Test2 : KernelEntityBehaviour
{
    
    internal void Logger() {
        Debug.Log("Все работает");
    }
}
