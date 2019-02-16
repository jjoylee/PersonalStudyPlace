using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;

namespace Chapter11
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            if(args.Length < 2)
            {
                Console.WriteLine("GumballMachine <name> <inventory>");
                Environment.Exit(0);
            }

            count = Int32.Parse(args[1]);
            GumballMachine gumballMachine = new GumballMachine(args[, count);

            Console.WriteLine("Starting Gumball server...");

            try
            {
                HttpClientChannel
                ChannelServices.RegisterChannel(channel, false);
                RemotingServices.Marshal(gumballMachine, "GumballMachine");

                Console.WriteLine("Press Enter to quit\n\n");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new RemoteException(e.Message, e);
            }
        }
    }
}
