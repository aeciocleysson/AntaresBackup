namespace AntaresBackup
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {

#if (!DEBUG)
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new ServiceAntares()
            };
            ServiceBase.Run(ServicesToRun);
#else
            ServiceAntares service = new ServiceAntares();
            service.CriarBackup();
#endif
        }
    }
}
