using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookReviews
{
    public partial class AdminControl : Form
    {

        List<Employee> EmployeesList = new List<Employee>();
        Employee LoggedAdmin;
        public AdminControl(Employee loggedAdmin)
        {
            InitializeComponent();
            AddToDGV();
            
            LoggedAdmin = loggedAdmin;
            lbl_override.Text = LoggedAdmin.Info();
        }

        private void btn_addEMP_Click(object sender, EventArgs e)
        {
            if (tb_EMPId.Text != "" && tb_empName.Text!="" && tb_empPassword.Text !="" && tb_bsn.Text !="" && comboB_role.Text !="")
            {
                int Id = Convert.ToInt32(tb_EMPId.Text);
                string Name = tb_empName.Text;
                string Password = tb_empPassword.Text;  
                int Bsn = Convert.ToInt32(tb_bsn.Text);
                string role = comboB_role.Text;


                Employee Newemp = new Employee(Id,Name,Password,Bsn,role);

                EmployeesList.Add(Newemp);

                AddToDGV();


                MessageBox.Show(" new employee has been saved");


                tb_EMPId.Clear();
                tb_empName.Clear();
                tb_empPassword.Clear();
                tb_bsn.Clear();
                
            }

            else
            {
                MessageBox.Show("Fields can not be empty");
            }
         
        }
        private void AddToDGV()
        {


            foreach (var employee in EmployeesList)
            {
                dataGridView1.Rows.Add(employee.ID,employee.Name,employee.Password, employee.BSN1, employee.Role);
            }
        }

        private void btn_logout1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
