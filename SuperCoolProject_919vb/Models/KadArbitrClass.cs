using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCoolProject_919vb.Models {
    public class KadArbitrClass {
        public int Page { get; set; } // страница 
        public int Count { get; set; } // количество
        public List<object>? Courts { get; set; } // суды
        public DateTime? DateFrom { get; set; } // дата от
        public DateTime? DateTo { get; set; } // дата до
        public List<Side>? Sides { get; set; } // стороны дела
        public List<object> Judges { get; set; } //судьи
        public List<string> CaseNumbers { get; set; } //номера дел
        public bool WithVKSInstances { get; set; } // служебные поручения
        public String? CaseType { get; set; } // тип дела
    }

    public class Side {
        public string Name { get; set; } // название
        public int Type { get; set; } // участник дела
        public bool ExactMatch { get; set; } // ???
    }
}
