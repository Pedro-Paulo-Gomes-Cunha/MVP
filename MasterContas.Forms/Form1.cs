using Domain.Dtos;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;
using Domain.Services;
using MasterContas.Data.Repositories;
using System.Security.Cryptography;

namespace MasterContas.Forms
{
    public partial class Form1 : Form
    {
        UserService _Userservice = new UserService(null);
        public Form1()
        {
            InitializeComponent();

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text)) { return; }


            var dados = new UserDto(0, textBox1.Text, textBox2.Text);
            this._Userservice.Save(dados);
            MessageBox.Show("Sucess!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GradeUsers.DataSource = this._Userservice.GetAll().ToList();
            GradeUsers.Refresh();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            GradeUsers.DataSource = this._Userservice.GetAll().ToList();
            GradeUsers.Refresh();

        }
    }
}