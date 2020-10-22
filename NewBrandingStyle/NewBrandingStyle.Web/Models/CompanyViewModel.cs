using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.Models
{
    public class CompanyViewModel
    {
        public int NumberOfCharsInName { get; set; }
        public int NumberOfCharsInDescription { get; internal set; }
        public bool IsHidden { get; internal set; }
    }
}
