using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinForm_DataBinding
{
    class ObjectSource : ISource
    {
        private List<Team> _teams;
        private List<Member> _members;

        public ObjectSource()
        {
            _teams = new List<Team>();
            _teams.Add(new Team("BNL", "BNL"));
            _teams.Add(new Team("BNL APPS", "BNL APPS"));
            _teams.Add(new Team("GOC ACTIVE DIRECTORY", "GOC ACTIVE DIRECTORY"));

            _members = new List<Member>();
            _members.Add(new Member("APERINGE", "BNL", "alexis.peringer@heidelbergcement.com", ""));
            _members.Add(new Member("MPAUWELS", "BNL", "michael.pauwels@heidelbergcement.com", ""));
            _members.Add(new Member("MBEERKEN", "BNL", "maurice.beerkens@heidelbergcement.com", ""));
            _members.Add(new Member("MWANING", "BNL", "marco.waning@heidelbergcement.com", ""));
            _members.Add(new Member("DVERHAEG", "BNL", "david.verhaeghe@heidelbergcement.com", ""));
            _members.Add(new Member("CVANREI", "BNL", "cornelis.vanrein@heidelbergcement.com", ""));

            _members.Add(new Member("17377", "BNL APPS", "marco.boosten@heidelbergcement.com", ""));
            _members.Add(new Member("DELIEUX", "BNL APPS", "nathalie.delieux@heidelbergcement.com", ""));
            _members.Add(new Member("NGABRIEL", "BNL APPS", "noella.gabriel@heidelbergcement.com", ""));
            _members.Add(new Member("GOETHALS", "BNL APPS", "brigitte.goethals@heidelbergcement.com", ""));
            _members.Add(new Member("LECOCQJ", "BNL APPS", "joelle.lecocq@heidelbergcement.com", ""));
            _members.Add(new Member("LEONARD", "BNL APPS", "paul.leonard@heidelbergcement.com", ""));

            _members.Add(new Member("LSODOMKA", "GOC ACTIVE DIRECTORY", "lukas.sodomka@heidelbergcement.com", ""));
            _members.Add(new Member("VPALIGA", "GOC ACTIVE DIRECTORY", "vojtech.paliga@heidelbergcement.com", ""));
            _members.Add(new Member("MVESELY", "GOC ACTIVE DIRECTORY", "marek.vesely@heidelbergcement.com", ""));
            _members.Add(new Member("MJELC", "GOC ACTIVE DIRECTORY", "martin.jelc@heidelbergcement.com", ""));
            _members.Add(new Member("DKOVAR", "GOC ACTIVE DIRECTORY", "david.kovar@heidelbergcement.com", ""));

        }

        public object GetTeams()
        {
            return _teams;
        }

        public object GetMembers(string teamId)
        {
            var result = from m in _members
                         where m.TeamId == teamId
                         select m;
            return result.ToList();
        }

        public void DeleteMember(BindingSource bindingSource, Member member)
        {
            bindingSource.Remove(member);
        }

        public void AddMember(BindingSource bindingSource, Member member)
        {
            bindingSource.Add(member);
        }

        public void Save()
        {

        }
    }
}
