using System.Numerics;
using System.Text.Json;

namespace GsDAutoClicker
{
    internal static class Program
    {
        /// <summary>  
        ///  The main entry point for the application.  
        /// </summary>  
        public static readonly Main PRG = new();
        public static Config config = new();
        public static BigInteger Clicks = 0;
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            if (File.Exists( "config.json" ))
            {
                string json = File.ReadAllText( "config.json" );
                var deserializedConfig = JsonSerializer.Deserialize<Config>( json );
                if (deserializedConfig != null)
                {
                    config = deserializedConfig;
                }
            }
            if (File.Exists( "clicks" ))
            {
                Clicks = BigInteger.Parse( File.ReadAllText( "clicks" ) );
            }

            Application.Run( PRG );
        }
    }
}