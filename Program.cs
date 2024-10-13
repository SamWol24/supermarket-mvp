using Microsoft.Data.SqlClient;
using Supermarket_mvp._Repositories;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;

namespace Supermarket_mvp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string sqlConnectionString = "";
            IPayModeView view = new PayModeView();
            IPayModeRepository reposity = new PayModeRepository(sqlConnectionString);
            Application.Run(new PayModeView());
        }
    }
}