using Jimu.Server;
using System;

namespace JiMuStartServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationHostServer.Instance.Run();
        }
    }
}
