using DI.Attributes.Construct;
using DI.Attributes.Register;
using DI.Attributes.Run;
using DI.Interfaces.KernelInterfaces;
using DI.Kernels;
using Utilities.Behaviours;

[Register]
internal class TestManager : KernelEntityBehaviour
{

    [ConstructField]
    private Test2 _test2;

    [ConstructMethod(typeof(LogicSceneKernel))]
    private void Construct(IKernel kernel) {
        if(_test2 == null) {
            return;
        }
    }

    [RunMethod]
    private void Run(IKernel kernel) {
        _test2.Logger();
    }
}
