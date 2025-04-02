using SRTN_UI.Forms;

namespace SRTN_UI
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
             

            //IViewManager viewManager = new ViewManager();

            //viewManager.ShowMainView();
            Application.Run(new MainView());
        }
    }
}