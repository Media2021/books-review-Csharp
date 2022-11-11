using BookReviews.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DBlayer;

namespace BookReviews
{
    public partial class AdminControl : Form
    {
        static PersonDB personDB = new PersonDB();
        PeopleManager peopleManager = new PeopleManager(personDB);

        List<Employee> EmployeesList = new List<Employee>();

        Employee LoggedAdmin;
        public AdminControl(Employee loggedAdmin)
        {
            InitializeComponent();
            updateEmp();
            AddToDGV();
            
            LoggedAdmin = loggedAdmin;
            lbl_override.Text = LoggedAdmin.Info();
        }

        private void btn_addEMP_Click(object sender, EventArgs e)
        {
            if ( tb_empName.Text!="" && tb_empPassword.Text !="" && tb_bsn.Text !="" && comboB_role.Text !="")
            {
               
                string Name = tb_empName.Text;
                string Password = tb_empPassword.Text;  
                int Bsn = Convert.ToInt32(tb_bsn.Text);
                string role = comboB_role.Text;


                Employee Newemp = new Employee(Name,Password,Bsn,role);
                peopleManager.addEmp(Newemp);

                updateEmp();

                AddToDGV();


                MessageBox.Show(" new employee has been saved");


               
                tb_empName.Clear();
                tb_empPassword.Clear();
                tb_bsn.Clear();
                
            }

            else
            {
                MessageBox.Show("Fields can not be empty");
            }
         
        }
        private void updateEmp()
        {
            EmployeesList.Clear();
            foreach (var person in peopleManager.GetPeople())
            {
                if (person is Employee)
                {
                    EmployeesList.Add((Employee)person);
                }

            }
        }
        private void AddToDGV()
        {

            dataGridView1.Rows.Clear();

            foreach (var emp in EmployeesList)
            {               

                dataGridView1.Rows.Add(emp.ID, emp.Name, emp.Password, emp.BSN1, emp.Role);               
                
            }
        }

        private void btn_logout1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminControl_Load(object sender, EventArgs e)
        {

        }

        private void btn_dtEMP_Click(object sender, EventArgs e)
        {
           

            int index = dataGridView1.CurrentCell.RowIndex;
            var user = EmployeesList[index];//?
            peopleManager.DeleteEmp(user);
            updateEmp();
            AddToDGV();
        }

        private void tb_empPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
