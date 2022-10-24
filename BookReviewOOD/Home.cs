using BookReviews.classes;

namespace BookReviews
{
    public partial class Home : Form
    {
        List<Person> listOU = new List<Person>();
        PeopleManager peopleManager = new PeopleManager();
        //List<User> userList = new List<User>();
        public Home()
        {
            InitializeComponent();
           
            
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



        private void button_signin2_Click(object sender, EventArgs e)
        {     

            string name= tb_username.Text;
            string password = tb_password.Text;

            bool result =peopleManager.Login(name,password);
            

            if (result)
            {
                Person loggedUser = peopleManager.GetLoggedInUser(name);
                
             
                    if (loggedUser is Employee)
                    {

                        //Employee employee = (Employee)listOU.Find(x => x.Name == loggedUser.Name);
                        Employee employee = (Employee)loggedUser;

                        if (employee.Role == "Admin")
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
                else
                {
                    MessageBox.Show("u r not an emp");
                }
                
            }
            else
            {
                MessageBox.Show(" username or password is wrong ");
            }





            //bool isTrue = listOU.Exists(x=>x.Name==name);

            //if (isTrue)
            //{
            //    Person loggedUser = listOU.Find(x => x.Name == name);

            //    if (loggedUser.Login(password))
            //    {
            //        if (loggedUser is Employee)
            //        {
                        
            //            //Employee employee = (Employee)listOU.Find(x => x.Name == loggedUser.Name);
            //            Employee employee = (Employee)loggedUser;

            //            if (employee.Role == "Admin" )
            //            {
            //                AdminControl adminControl = new AdminControl((Employee)loggedUser);
            //                adminControl.Show();
            //            }
            //            else
            //            {
                           
            //                this.Hide();
            //                EmployeeControl bookAdd = new EmployeeControl((Employee)loggedUser);
            //                bookAdd.Show();
                           
            //            }

            //        }
                 

                   

            //    }
            //    else
            //    {
            //        MessageBox.Show(" username or password is wrong ");
            //    }
            //}

          

            
        }


        //private void addUsers()
        //{
        //    listOU.Add(new User("100", "Jack", "1234"));
        //    listOU.Add(new Employee("101", "Media", "1234", 5678,"Admin"));
        //    listOU.Add(new Employee("102", "Jen", "1234", 5678, "Employee"));
        //}

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            //List<Books> books = new List<Books>();
            //listB_AllInfoBook.Items.Clear();
            //foreach (var item in books)
            //{

            //    listB_AllInfoBook.Items.Add(item);
            //}
        }

        private void listB_AllInfoBook_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
