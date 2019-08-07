namespace WinForm_DataBinding
{
    class Member
    {
        public string Username { get; set; }
        public string TeamId { get; set; }
        public string Email { get; set; }
        public string Availability { get; set; }
        public string FullName { get; set; }

        public Member(string id, string teamId, string email, string fullname)
        {
            Username = id;
            TeamId = teamId;
            Email = email;
            FullName = fullname;
            Availability = "";
        }
    }
}
