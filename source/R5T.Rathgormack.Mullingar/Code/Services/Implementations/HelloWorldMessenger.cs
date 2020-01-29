using System;

using R5T.Mullingar;


namespace R5T.Rathgormack.Mullingar
{
    public class HelloWorldMessenger : IHelloWorldMessenger
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
