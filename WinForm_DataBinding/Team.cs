using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_DataBinding
{
    class Team
    {
        public string TeamID { get; set; }
        public string TeamName { get; set; }

        public Team(string id, string name)
        {
            TeamID = id;
            TeamName = name;
        }
    }
}
