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
            _teams.Add(new Team("[TeamId]", "[TeamName]"));

            _members = new List<Member>();
            _members.Add(new Member("[USERNAME]", "[TEAMID]", "[EMAIL]", ""));

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
