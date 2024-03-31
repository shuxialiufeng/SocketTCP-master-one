namespace SocketTCP
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
            Application.Run(new FormTcpServer());
<<<<<<< HEAD

            ///修改11
=======
            //修改



            //zj
>>>>>>> 57bb7209dda040020f12f32c3f6326b9fd97d04b
        }
    }
}