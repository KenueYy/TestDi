using DI.Attributes.Construct;
using DI.Attributes.Register;
using DI.Attributes.Run;
using DI.Interfaces.KernelInterfaces;
using DI.Kernels;
using System.Collections.Generic;
using Utilities.Behaviours;


internal class TestManager : KernelEntityBehaviour
{

    private void Handler() {
        
    }




    #region KernelEntity
    private List<ITesting> _connectionManager;


    [ConstructMethod]
    private void Construct(IKernel kernel) {
        _connectionManager = kernel.GetInjections<ITesting>();
        _connectionManager.ForEach(x => x.log("Error"));
    }



    #endregion
}
