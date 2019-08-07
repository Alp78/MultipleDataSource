using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinForm_DataBinding
{
    class DataSetSource : ISource
    {
        private DataSet _dataSet;

        public DataSetSource()
        {
            _dataSet = new DataSet();

            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["teamsConnectionString"].ConnectionString; ;
            
            SqlConnection cn = new SqlConnection(connStr);

            SqlDataAdapter tda = new SqlDataAdapter("SELECT TeamId FROM teams", cn);
            tda.Fill(_dataSet, "Teams");

            SqlDataAdapter mda = new SqlDataAdapter("SELECT * FROM members", cn);
            mda.Fill(_dataSet, "Members");
        }

        public void AddMember(BindingSource bindingSource, Member member)
        {
            throw new NotImplementedException();
        }

        public void DeleteMember(BindingSource bindingSource, Member member)
        {
            throw new NotImplementedException();
        }

        public object GetMembers(string teamId)
        {
            DataTable table = _dataSet.Tables["members"];
            table.DefaultView.RowFilter = $"TeamId='{teamId}'";

            return table;
        }

        public object GetTeams()
        {
            DataTable table = _dataSet.Tables["teams"];
            return table;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
