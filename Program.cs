using Compu_Pos.Data.Context;
using Compu_Pos.Data.IRepos;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Net;

namespace Compu_Pos
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            {
                DI.Provider = Startup.Initialize();
                ApplicationConfiguration.Initialize();
                Application.Run(new MainForm());
            }

        }
    }
}