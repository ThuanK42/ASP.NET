namespace QuanLySinhVienDemo.Object
{
    public class UserSystem
    {
        public string username { set; get; }
        public string password { set; get; }

        public UserSystem(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public UserSystem()
        {
        }

        public override string ToString()
        {
            return username + " - " + password;
        }
    }
}