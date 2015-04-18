using System;
using System.Collections.Generic;
using Toci.Db.DbVirtualization;
using Toci.Db.Interfaces;

namespace Toci.Dal.Models
{
    public class BankAccountTransferModel : Model
    {
        public const string NAZWA = "nazwa";

        public BankAccountTransferModel() : base("transfer")
        {
        }

        public string Nazwa
        {
            get
            {
                return (string)Fields[NAZWA].GetValue();
            }
            set
            {
                SetValue(NAZWA, value);
            }
        }

        protected override IModel GetInstance()
        {
            return new BankAccountTransferModel();
        }
    }
}
