using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Rule
    {
        public int RuleId { get; set; }

        public string RuleName { get; set; }
        public string Description { get; set; }

        public decimal Fines { get; set; }
    }
}
