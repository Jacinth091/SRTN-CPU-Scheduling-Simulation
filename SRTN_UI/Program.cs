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
            //GanttChartView ganttChartView = GanttChartView.GetInstance();
            //ganttChartView.Show();
            //Application.Run();
            //Application.Run(new Trial());
            Application.Run(new MainView());
        }
    }
}