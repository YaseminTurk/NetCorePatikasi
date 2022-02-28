namespace ToDo_Uygulamasi
{
    public class TeamUserModel
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public TeamUserModel(int ıd, string userName)
        {
            Id = ıd;
            UserName = userName;
        }
    }
}
