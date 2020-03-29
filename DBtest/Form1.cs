using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            //начальная инициализация
            using (Model1 db = new Model1())
            {
                try
                {
                    //инициализвация списка всех сотрудников
                    var staffInfo = db.Database.SqlQuery<StaffInfo>("dbo.StaffInfo");
                    foreach (var staff in staffInfo)
                    {
                        if (staff.date_unemploy == null)
                            staffDataGridView.Rows.Add(staff.second_name.ToString() + " " + staff.first_name.ToString()[0] + ". " + staff.last_name.ToString()[0] + ".", staff.status_name.ToString(), staff.dep_name.ToString(), staff.post_name.ToString(), staff.date_employ.ToString().Substring(0, 10), staff.date_unemploy.ToString());
                        else
                            staffDataGridView.Rows.Add(staff.second_name.ToString() + " " + staff.first_name.ToString()[0] + ". " + staff.last_name.ToString()[0] + ".", staff.status_name.ToString(), staff.dep_name.ToString(), staff.post_name.ToString(), staff.date_employ.ToString().Substring(0, 10), staff.date_unemploy.ToString().Substring(0, 10));
                    }
                }
                catch(System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Не удалось найти хранимую процедуру StaffInfo", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //инициализация выбора статуса 
                statusComboBox.Items.Add("");
                foreach (status s in db.status)
                {
                    statComboBox.Items.Add(s.name);
                    statusComboBox.Items.Add(s.name);
                }
                if(statComboBox.Items.Count!=0) statComboBox.SelectedIndex = 0;
                statusComboBox.SelectedIndex = 0;

                //Инициализация должностей
                postComboBox.Items.Add("");
                foreach(post p in db.posts)
                {
                    postComboBox.Items.Add(p.name);
                }
                postComboBox.SelectedIndex = 0;

                //Инициализация департаментов
                depComboBox.Items.Add("");
                foreach(dep d in db.deps)
                {
                    depComboBox.Items.Add(d.name);
                }
                depComboBox.SelectedIndex = 0;

            }


        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            staffDataGridView.Rows.Clear(); //чистим датагрид
            //Во избежание крашей
            if (depComboBox.SelectedIndex < 0) depComboBox.SelectedIndex = 0;
            if (postComboBox.SelectedIndex < 0) postComboBox.SelectedIndex = 0;
            if (statusComboBox.SelectedIndex < 0) statusComboBox.SelectedIndex = 0;

            using (Model1 db = new Model1())
            {
                try
                {
                    //Параметры хранимой процедуры
                    System.Data.SqlClient.SqlParameter secondName = new System.Data.SqlClient.SqlParameter("@SecondName", secondNameTextBox.Text.ToString());
                    System.Data.SqlClient.SqlParameter dep = new System.Data.SqlClient.SqlParameter("@Dep", depComboBox.SelectedItem.ToString());
                    System.Data.SqlClient.SqlParameter post = new System.Data.SqlClient.SqlParameter("@Post", postComboBox.SelectedItem.ToString());
                    System.Data.SqlClient.SqlParameter status = new System.Data.SqlClient.SqlParameter("@Status", statusComboBox.SelectedItem.ToString());

                    //Вызов хранимой процедуры
                    var staffInfo = db.Database.SqlQuery<StaffInfo>("exec GetInfoByRequest @SecondName,@Status,@Dep,@Post", secondName, status, dep, post).ToList();


                    foreach (var staff in staffInfo)
                    {
                        if (staff.date_unemploy == null)
                            staffDataGridView.Rows.Add(staff.second_name.ToString() + " " + staff.first_name.ToString()[0] + ". " + staff.last_name.ToString()[0] + ".", staff.status_name.ToString(), staff.dep_name.ToString(), staff.post_name.ToString(), staff.date_employ.ToString().Substring(0, 10), staff.date_unemploy.ToString());
                        else
                            staffDataGridView.Rows.Add(staff.second_name.ToString() + " " + staff.first_name.ToString()[0] + ". " + staff.last_name.ToString()[0] + ".", staff.status_name.ToString(), staff.dep_name.ToString(), staff.post_name.ToString(), staff.date_employ.ToString().Substring(0, 10), staff.date_unemploy.ToString().Substring(0, 10));
                    }
                }
                catch(System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Не удалось найти хранимую процедуру GetInfoByRequest", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }

        private void statButton_Click(object sender, EventArgs e)
        {
            statDataGridView.Rows.Clear();

            using (Model1 db = new Model1())
            {
                try
                {
                    //Параметры хранимой процедуры
                    System.Data.SqlClient.SqlParameter status = new System.Data.SqlClient.SqlParameter("@Status", statComboBox.SelectedItem.ToString());
                    System.Data.SqlClient.SqlParameter begin = new System.Data.SqlClient.SqlParameter("@Begin", beginDateTimePicker.Value.ToString());
                    System.Data.SqlClient.SqlParameter end = new System.Data.SqlClient.SqlParameter("@End", endDateTimePicker.Value.ToString());

                    //Вызов хранимой процедуры
                    var statistics = db.Database.SqlQuery<Statistics>("exec StaffStat @Status,@Begin,@End", status, begin, end).ToList();

                    foreach (var staff in statistics)
                    {
                        statDataGridView.Rows.Add(staff.dat.ToString().Substring(0, 10), staff.employers_count.ToString());
                    }
                }
                catch(System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Не удалось найти хранимую процедуру StaffStat", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            staffDataGridView.Rows.Clear(); //чистим датагрид
            //Обнуляем всё
            depComboBox.SelectedIndex = 0;
            postComboBox.SelectedIndex = 0;
            statusComboBox.SelectedIndex = 0;
            secondNameTextBox.Text = "";

            using (Model1 db = new Model1())
            {
                try
                {
                    //инициализвация списка всех сотрудников
                    var staffInfo = db.Database.SqlQuery<StaffInfo>("dbo.StaffInfo");
                    foreach (var staff in staffInfo)
                    {
                        if (staff.date_unemploy == null)
                            staffDataGridView.Rows.Add(staff.second_name.ToString() + " " + staff.first_name.ToString()[0] + ". " + staff.last_name.ToString()[0] + ".", staff.status_name.ToString(), staff.dep_name.ToString(), staff.post_name.ToString(), staff.date_employ.ToString().Substring(0, 10), staff.date_unemploy.ToString());
                        else
                            staffDataGridView.Rows.Add(staff.second_name.ToString() + " " + staff.first_name.ToString()[0] + ". " + staff.last_name.ToString()[0] + ".", staff.status_name.ToString(), staff.dep_name.ToString(), staff.post_name.ToString(), staff.date_employ.ToString().Substring(0, 10), staff.date_unemploy.ToString().Substring(0, 10));

                    }
                }
                catch(System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Не удалось найти хранимую процедуру StaffInfo", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            }
    }
}
