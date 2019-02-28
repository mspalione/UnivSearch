using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KYUniversities.Models
{
    public class FormModel
    {
        public string Institution { get; set; }
        public string Headname { get; set; }
        public string Headtitle { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }

        // This property will hold KY as the available state for selection
        public IEnumerable<SelectListItem> States { get; set; }
    }
}