using WS.VisualizationUI.Code;

namespace WS.VisualizationUI
{
    internal static class Program
    {
        public static SignalRClient signalRClient { get; set; }
        public static Form1 form { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            signalRClient = new SignalRClient();
            signalRClient.Start().Wait();
            ApplicationConfiguration.Initialize();
            form = new Form1();
            Application.Run(form);
        }
    }
}