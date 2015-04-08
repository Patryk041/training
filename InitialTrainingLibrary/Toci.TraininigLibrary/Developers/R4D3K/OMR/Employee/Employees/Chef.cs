﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.R4D3K.OMR.Employee.Employees
{
    class Chef : Employee
    {
        public Chef(int id, string fname, string lname) : base(id, fname, lname)
        {
            this.Id = id;
            this.FirstName = fname;
            this.LastName = lname;
            this.Position = KindOfJob.Chef;
        }
    }
}
