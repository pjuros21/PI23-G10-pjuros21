using EvaluationManagerG10.Models;
using EvaluationManagerG10.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationManagerG10
{
    public partial class Prijava : Form
    {
        public static Teacher LoggedTeacher { get; set; }

        public Prijava()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void btnLogIn_Click(object sender, EventArgs e) {
            if(textUsername.Text == "") {
                MessageBox.Show("Korisničko ime nije uneseno", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if(txtPassword.Text == "") {
                MessageBox.Show("Lozinka nije unesena!"), "Problem", MessageBoxButtons.OK,
            }
            
            else {
                LoggedTeacher = TeacherRepository.GetTeacher(txtUsername.Text);
                if (LoggedTeacher != null && LoggedTeacher.CheckPassword == (txtPassword.Text) {
                    FrmStudent frmStudents = new FrmStudent();
                    Hide();
                    frmStudents.ShowDialog();
                    Close();
                }
            }
        }
    }
}
