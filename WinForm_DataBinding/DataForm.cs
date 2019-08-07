using System;
using System.Windows.Forms;

namespace WinForm_DataBinding
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }

        private BindingSource _teamsBindingSource = new BindingSource();
        private BindingSource _membersBindingSource = new BindingSource();

        private ISource _currentSource;
        private ObjectSource _objectSource = new ObjectSource();
        private DataSetSource _dataSetSource = new DataSetSource();
        private LinqSource _linqSource;

        private ObjectSource _source = new ObjectSource();

        private void Form1_Load(object sender, EventArgs e)
        {
            SourceComBox.SelectedIndex = 0;
            SetSource();
            BindTeams();
            BindMembers();

            _teamsBindingSource.DataSource = _source.GetTeams();

            TeamsComboBox.DataSource = _teamsBindingSource;
            TeamsComboBox.DisplayMember = "TeamId";
            TeamsComboBox.ValueMember = "TeamId";

            MembersGrid.DataSource = _membersBindingSource;
            MembersListBox.DataSource = _membersBindingSource;
            MembersListBox.DisplayMember = "Username";

            IdTextBox.DataBindings.Add("Text", _membersBindingSource, "Username");
            EmailTextBox.DataBindings.Add("Text", _membersBindingSource, "Email");
            TeamTextBox.DataBindings.Add("Text", _membersBindingSource, "TeamId");
            NameTextBox.DataBindings.Add("Text", _membersBindingSource, "FullName");
        }

        private void TeamsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindMembers();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            _membersBindingSource.MovePrevious();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            _membersBindingSource.MoveNext();
        }

        private void SourceComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSource();
            BindTeams();
            BindMembers();
        }

        private void SetSource()
        {
            switch (SourceComBox.SelectedIndex)
            {
                case 0:
                    if (_objectSource is null)
                    {
                        _objectSource = new ObjectSource();
                    }
                    _currentSource = _objectSource;
                    break;
                case 1:
                    if (_dataSetSource is null)
                    {
                        _dataSetSource = new DataSetSource();
                    }
                    _currentSource = _dataSetSource;
                    break;
                case 2:
                    if (_linqSource is null)
                    {
                        _linqSource = new LinqSource();
                    }
                    _currentSource = _linqSource;
                    break;
                default:
                    break;
            }
        }

        private void BindTeams()
        {
            _teamsBindingSource.DataSource = _currentSource.GetTeams();
        }
        private void BindMembers()
        {
            string teamId;

            if (TeamsComboBox.SelectedValue != null)
            {
                teamId = TeamsComboBox.SelectedValue.ToString();
                _membersBindingSource.DataSource = _currentSource.GetMembers(teamId);
            }
        }
    }
}
