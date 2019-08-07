using System.Windows.Forms;

namespace WinForm_DataBinding
{
    interface ISource
    {
        object GetTeams();
        object GetMembers(string teamId);
        void DeleteMember(BindingSource bindingSource, Member member);
        void AddMember(BindingSource bindingSource, Member member);
        void Save();
    }
}
