namespace Task4_1_
{
    public class BstuNet
    {
        private static BstuNet bstuNet;

        public string ServerName { get; private set; }

        public string IPAdress { get; private set; }

        private static object syncRoot = new object();

        protected BstuNet (string _serverName, string _IPAdress)
        {
            this.ServerName = _serverName;
            this.IPAdress = _IPAdress;
        }

        public static BstuNet GetServer(string _serverName, string _IPAdress)
        {
            if(bstuNet == null)
            {
                lock (syncRoot)
                {
                    if (bstuNet == null) bstuNet = new BstuNet(_serverName, _IPAdress);
                }
            }
            return bstuNet;
        }
    }
}