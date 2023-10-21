using Supermarker_mvp.Views;
using Supermarker_mvp.Models;
using Supermarker_mvp.Properties;
using System.Configuration;
using Supermarker_mvp._Repositories;

namespace Supermarker_mvp
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
            string sqlConnectionString = Settings.Default.ConnectionString;
            IPayModeView view = new PayModeView();
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
            Application.Run(new PayModeView());
        }
    }
}