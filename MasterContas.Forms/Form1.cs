using Autofac.Core;
using Domain.Dtos;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;
using Domain.Services;
using MasterContas.Data.Repositories;
using MasterContas.Presentation.IViews;
using MasterContas.Presentation.Presenter;
using System.Security.Cryptography;

namespace MasterContas.Presentation
{
    public partial class Form1 : Form, UserView
    {
        IUserService userService;
        readonly IUserService teste;

        public Form1(IUserService t)
        {
            InitializeComponent();

            teste = t;
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
        {/*

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text)) { return; }


            var dados = new UserDto(0, textBox1.Text, textBox2.Text);
            this._Userservice.Save(dados);
            MessageBox.Show("Sucess!");  */

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {/*
            GradeUsers.DataSource = this._Userservice.GetAll().ToList();
            GradeUsers.Refresh();*/
            //  new UserPresenter(this, userService).add();
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
            GradeUsers.DataSource = new UserPresenter(this).GetAll();
            GradeUsers.Refresh();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new UserPresenter(this).add();
        }

        public void add()
        {
            throw new NotImplementedException();
        }
    }
}