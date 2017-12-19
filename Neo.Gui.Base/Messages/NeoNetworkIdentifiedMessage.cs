using System;

namespace Neo.Gui.Base.Messages
{
    public class NeoNetworkIdentifiedMessage
    {
        public NeoNetworkIdentifiedMessage(string neoNetwork)
        {
            this.NeoNetwork = neoNetwork;
        }

        public string NeoNetwork { get; }
    }
}
