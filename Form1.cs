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
using System.Configuration;

namespace HR_department
{
    public partial class Form1 : Form
    {
        private SqlConnection HR_departmentDBConnection = null; // класс благодаря ему проходят все операции с базой данных через созданные подключения
        //sqlConnection это присвоими имя можно было присвоить и например WorkersConnection
        public Form1()  
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {

            HR_departmentDBConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["HR_departmentDB_kluch"].ConnectionString);
            HR_departmentDBConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Workers", HR_departmentDBConnection);

            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView1.DataSource = db.Tables[0];
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                $"INSERT INTO [Workers] (Surname, Name, Patronymic, Birthday, Department, PhoneNumber, Street, House, Flat) VALUES(N'{TBSurname.Text}', N'{TBName.Text}', N'{TBPatronymic.Text}', N'{TBBirthday.Text}', N'{TBDepartment.Text}', N'{TBPhoneNumber.Text}', N'{TBStreet.Text}', N'{TBHouse.Text}', N'{TBFlat.Text}' )",
                HR_departmentDBConnection);


            MessageBox.Show(command.ExecuteNonQuery().ToString("Добавлено")); 
        }

        private void TBSearch_TextChanged(object sender, EventArgs e)  // тут делаю поиск по фамилии (по факту фильтрацию)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =$"Surname LIKE '%{TBSearch.Text}%'";    // сначало делает то что в скобках а после открытия по последнему слову
        }

        private void comboBoxFilterDepartment_SelectedIndexChanged(object sender, EventArgs e) // Здесь  фильтрую таблицу по отделам
        {
            switch (comboBoxFilterDepartment.SelectedIndex)
            {
                case 0:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";
                    break;
                case 1:
                    //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Department VALUES N'{comboBoxFilterDepartment.Items.}' "; // c
                    break;
                case 2:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Department LIKE = N'%Хозяйственный%'";
                    break;
                case 3:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Department = N'%Рабочий%'";
                    break;
                case 4:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Department LIKE N'%Управляющий%'"; // начало
                    break;
                case 5:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"SELECT * FROM Workers WHERE Department  LIKE N'%Охраняющий%'";
                    break;
               
            }
        }
    }
}
