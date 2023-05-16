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

namespace EvaluationManagerG10 {
    public partial class FrmStudent : Form {
        public FrmStudent() {
            InitializeComponent();
        }

        private void FrmStudent_Load(object sender, EventArgs e) {

        }

        public partial class FrmStudents : Form {
            public FrmStudents() {
                InitializeComponent();
            }

            private void FrmStudents_Load(object sender, EventArgs e) {
                ShowStudents();
            }

            private void ShowStudents() {
                var students = StudentRepository.GetStudents();
                dgvStudents.DataSource = students;

                dgvStudents.Columns["Id"].DisplayIndex = 0;
                dgvStudents.Columns["FirstName"].DisplayIndex = 1;
                dgvStudents.Columns["LastName"].DisplayIndex = 2;
                dgvStudents.Columns["Grade"].DisplayIndex = 3;
            }
        }
    }
}
