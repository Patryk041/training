using System.Collections.Generic;
using Toci.TraininigLibrary.Developers.RS.Omr.Concrete;

namespace Toci.TraininigLibrary.Developers.RS.Omr.Abstract
{
    public abstract class OrganizationalUnitBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public Manager Manager { get; set; }
        public List<RegularEmployee> RegularEmployees { get; set; }
    }
}
