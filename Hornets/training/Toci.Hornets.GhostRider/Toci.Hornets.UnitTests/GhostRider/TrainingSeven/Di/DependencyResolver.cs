
using Autofac;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.GhostRider.Kir.BankLoggingMechanism;
using Toci.Hornets.GhostRider.TrainingSeven.Di;
using Toci.Hornets.GhostRider.TrainingSix.Database.Abstraction.Model;
using Toci.Hornets.Opole.OpoleKir.Banks;
using IContainer = System.ComponentModel.IContainer;

namespace Toci.Hornets.UnitTests.GhostRider.TrainingSeven.Di
{
    public class DependencyResolver
    {
        protected ContainerBuilder ContainerBuilder;
        protected ILifetimeScope Scope;

        public DependencyResolver()
        {
            Initialize();
            //DataStorageQuery
        }

        public T Resolve<T>()
        {
            return Scope.Resolve<T>();
        }

        protected void Initialize()
        {
            ContainerBuilder = new ContainerBuilder();

            ContainerBuilder.RegisterType<INGTransferHandle>().As<TransferHandle>();
            ContainerBuilder.RegisterType<TransferMoney>().As<TransferMoney>();
            ContainerBuilder.RegisterType<IngLogTransfer>().As<ILogTransfers>();

            //builder.RegisterType<OnlineState>().Keyed<IDeviceState>(DeviceState.Online);
            //builder.RegisterType<OfflineState>().Keyed<IDeviceState>(DeviceState.Offline);

            Autofac.IContainer container = ContainerBuilder.Build();
            
            Scope = container.BeginLifetimeScope();
        }
    }
}