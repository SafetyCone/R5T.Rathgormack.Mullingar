using System;

using R5T.Mullingar;using R5T.T0064;


namespace R5T.Rathgormack.Mullingar
{[ServiceImplementationMarker]
    public class HelloWorldMessenger : IHelloWorldMessenger,IServiceImplementation
    {
        private IHelloWorldMessageProvider HelloWorldMessageProvider { get; }


        public HelloWorldMessenger (IHelloWorldMessageProvider helloWorldMessageProvider)
        {
            this.HelloWorldMessageProvider = helloWorldMessageProvider;
        }

        public void SendHelloWorldMessage()
        {
            var message = this.HelloWorldMessageProvider.GetHelloWorldMessage();

            Console.Out.WriteLine(message);
        }
    }
}
