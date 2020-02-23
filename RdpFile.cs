namespace RdpHelper
{
    public class RdpFile
    {
        public static string Build(string address, string username = null, string password = null)
        {
            return InternalBuild(new RdpConfig(address, username, password));
        }

        public static string Build(in RdpConfig config)
        {
            return InternalBuild(config);
        }

        private static string InternalBuild(in RdpConfig config)
        {
            return config.ToString();
        }
    }
}


