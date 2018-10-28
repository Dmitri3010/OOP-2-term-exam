namespace Task4_1_
{
    public class Computer
    {
        public BstuNet Server { get; set; }

        public void Connect(string _serverIP, string _serverName)
        {
            Server = BstuNet.GetServer(_serverName, _serverIP);
        }
    }
}