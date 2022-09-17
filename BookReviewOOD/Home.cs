namespace BookReviews
{
    public partial class Home : Form
    {
        List<Person> listOU = new List<Person>();
        List<User> userList = new List<User>();
        public Home()
        {
            InitializeComponent();
            addUsers();  
            
        }

        private void comboBox_Types_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_signup1_Click(object sender, EventArgs e)
        {
            panel_signin.Visible = true;

        }

        private void btn_Signin_Click(object sender, EventArgs e)
        {

            panel_signin.Visible = true;

        }

        private void btn_signup1_Click(object sender, EventArgs e)
        {
            panel_signin.Hide();
            panel_signup.Visible = true;

        }

        private void button_signin2_Click(object sender, EventArgs e)
        {     

            string name= tb_username.Text;
            string password = tb_password.Text;

            bool isTrue = listOU.Exists(x=>x.Name==name);

            if (isTrue)
            {
                Person loggedUser = listOU.Find(x => x.Name == name);

                if (loggedUser.Login(password))
                {
                    if (loggedUser is Employee)
                    {
                        
                        //Employee employee = (Employee)listOU.Find(x => x.Name == loggedUser.Name);
                        Employee employee = (Employee)loggedUser;

                        if (employee.Role == "Admin" )
                        {
                            AdminControl adminControl = new AdminControl((Employee)loggedUser);
                            adminControl.Show();
                        }
                        else
                        {
                           
                            this.Hide();
                            EmployeeControl bookAdd = new EmployeeControl((Employee)loggedUser);
                            bookAdd.Show();
                           
                        }

                    }
                    else if (loggedUser is User)
                    {
                        ReviewsUser reviewsUser = new ReviewsUser((User)loggedUser);
                        reviewsUser.Show();
                    }

                   

                }
                else
                {
                    MessageBox.Show(" username or password is wrong ");
                }
            }

          

            
        }

        private void button_Signup2_Click(object sender, EventArgs e)
        {
            if (tb_userId1.Text != "" && tb_userName1.Text != "" && tb_Password1.Text != "") 
            {
                int id = tb_userId1.Text.GetHashCode(); //?
                string name = tb_userName1.Text;
                string password = tb_Password1.Text;

                User adduser = new User(id,name,password,DateTime.Now);

                userList.Add(adduser);  
                
                
            }
            else
            {
                MessageBox.Show(" fields can not be empty");
            }

            tbPassword1.Clear();
            tbUseName1.Clear();
            tb_userId1.Clear();
            
            panel_signup.Hide();
            panel_signin.Visible = true;

         

          
        }
        private void addUsers()
        {
            listOU.Add(new User(100, "Jack", "1234"));
            listOU.Add(new Employee(101, "Media", "1234", 5678,"Admin"));
            listOU.Add(new Employee(102, "Jen", "1234", 5678, "Employee"));
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            List<Books> books = new List<Books>();
            listB_AllInfoBook.Items.Clear();
            foreach (var item in books)
            {

                listB_AllInfoBook.Items.Add(item);
            }
        }
    }
}
