using Autofac.Core;
using Domain.Dtos;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;
using Domain.Services;
using MasterContas.Data.Repositories;
using MasterContas.Presentation.Interfaces.IViews;
using MasterContas.Presentation.Presenter;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace MasterContas.Presentation
{
    public partial class Form1 : Form, UserView
    {


        public event EventHandler ButtonClicked;
        public event TabControlEventHandler TabClicked;

        public Form1()
        {
            InitializeComponent();

            button1.Click += (sender, e) => ButtonClicked?.Invoke(this, EventArgs.Empty); //btnSave Linked

            tabControl1.Selected += (sender, e) => TabClicked?.Invoke(this, null); //TabControl action linked

            new UserPresenter(this); //inicializing the Presenter
        }



        int UserView.Id { get => 0; set => value = 0; }
        string UserView.Name
        {
            get => textBox1.Text; set => value = textBox1.Text;

        }
        string UserView.PassWord
        {
            get => textBox2.Text; set => value = textBox2.Text;


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
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


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        public void add()
        {
            MessageBox.Show("Usuario: " + textBox1.Text + "  Created");
        }



        public void Display(List<UserDto> users)
        {
            GradeUsers.DataSource = users;
            GradeUsers.Refresh();
        }
    }
}