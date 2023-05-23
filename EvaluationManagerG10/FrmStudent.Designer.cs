namespace EvaluationManagerG10 {
    partial class FrmStudent {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.btnGenerateEvaluationReport = new System.Windows.Forms.Button();
            this.evaluirtaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(24, 12);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(751, 397);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // btnGenerateEvaluationReport
            // 
            this.btnGenerateEvaluationReport.Location = new System.Drawing.Point(24, 415);
            this.btnGenerateEvaluationReport.Name = "btnGenerateEvaluationReport";
            this.btnGenerateEvaluationReport.Size = new System.Drawing.Size(112, 23);
            this.btnGenerateEvaluationReport.TabIndex = 1;
            this.btnGenerateEvaluationReport.Text = "Generiraj izvještaj";
            this.btnGenerateEvaluationReport.UseVisualStyleBackColor = true;
            this.btnGenerateEvaluationReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // evaluirtaj
            // 
            this.evaluirtaj.Location = new System.Drawing.Point(700, 415);
            this.evaluirtaj.Name = "evaluirtaj";
            this.evaluirtaj.Size = new System.Drawing.Size(75, 23);
            this.evaluirtaj.TabIndex = 2;
            this.evaluirtaj.Text = "button1";
            this.evaluirtaj.UseVisualStyleBackColor = true;
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.evaluirtaj);
            this.Controls.Add(this.btnGenerateEvaluationReport);
            this.Controls.Add(this.dgvStudent);
            this.Name = "FrmStudent";
            this.Text = "FrmStudent";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btnGenerateEvaluationReport;
        private System.Windows.Forms.Button evaluirtaj;
    }
}