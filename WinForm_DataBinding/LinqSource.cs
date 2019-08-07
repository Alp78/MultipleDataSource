using System;
using System.Linq;
using System.Windows.Forms;

namespace WinForm_DataBinding
{
    class LinqSource : ISource
    {
        private sql_linq_teamsDataContext _context = new sql_linq_teamsDataContext();

        public object GetTeams()
        {
            return _context.linq_teams;
        }

        public object GetMembers(string teamId)
        {
            var query = from p in _context.linq_members
                        where p.TeamId == teamId
                        select p;

            return query.ToList();
        }

        public void AddMember(BindingSource bindingSource, Member member)
        {
            throw new NotImplementedException();
        }

        public void DeleteMember(BindingSource bindingSource, Member member)
        {
            throw new NotImplementedException();
        }



        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
