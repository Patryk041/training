﻿using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.GhostRider.Kir.GhostRiderSolution;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Didi;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Didi.Banki;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe
{
    public class HandlersGenerator : GenericGenerator<TransferHandle>
    {
        public HandlersGenerator()
        {
            GenericElementsDictionary = new Dictionary<string, List<TransferHandle>>
            {
                {  "Gliwice", new List<TransferHandle>()
                    {
                        new DidiInnyBank(new DidiBankTransfer()),
                        new DidiINGBank(new DidiBankTransfer()),
                        new DidiPKOBank(new DidiBankTransfer())
                    }
                }
            };
        }
    }
}