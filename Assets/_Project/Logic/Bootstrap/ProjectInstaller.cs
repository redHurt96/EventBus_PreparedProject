using UniRx;
using Zenject;

namespace _Project.Bootstrap
{
    public class ProjectInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            MessageBroker messageBroker = new();

            Container.Bind<IMessagePublisher>().FromInstance(messageBroker).AsSingle();
            Container.Bind<IMessageReceiver>().FromInstance(messageBroker).AsSingle();
        }
    }
}
