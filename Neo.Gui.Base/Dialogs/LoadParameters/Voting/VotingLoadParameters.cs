﻿namespace Neo.Gui.Wpf.Views.Voting
{
    public class VotingLoadParameters
    {
        public UInt160 ScriptHash { get; }

        public VotingLoadParameters(UInt160 scriptHash)
        {
            this.ScriptHash = scriptHash;
        }
    }
}