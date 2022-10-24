namespace WebApp.DTO
{
    public class UserDto
    {
        string name;
        string password;

        public UserDto()
        {           
        }

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
    }
}
