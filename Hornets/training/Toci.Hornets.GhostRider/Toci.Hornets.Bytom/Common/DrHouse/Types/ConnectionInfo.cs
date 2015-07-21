namespace Toci.Hornets.Bytom.Common.DrHouse.Types
{
    public class ConnectionInfo
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ServerUrl { get; set; }
        public string TrustedConnection { get; set; }
        public string DatabaseName { get; set; }
        public int ConnectionTimeut { get; set; }
    }
}
