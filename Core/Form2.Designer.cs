namespace Core
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fullname = new System.Windows.Forms.TextBox();
            this.heartrate = new System.Windows.Forms.TextBox();
            this.temp = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.fever = new System.Windows.Forms.ComboBox();
            this.diabetic = new System.Windows.Forms.ComboBox();
            this.cardiac = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Patients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Risk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Temperature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Heart Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cardiac Arrest";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Diabetic History";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fever Symptoms";
            // 
            // fullname
            // 
            this.fullname.Location = new System.Drawing.Point(153, 63);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(157, 20);
            this.fullname.TabIndex = 7;
            // 
            // heartrate
            // 
            this.heartrate.Location = new System.Drawing.Point(153, 181);
            this.heartrate.Name = "heartrate";
            this.heartrate.Size = new System.Drawing.Size(157, 20);
            this.heartrate.TabIndex = 8;
            // 
            // temp
            // 
            this.temp.Location = new System.Drawing.Point(153, 136);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(157, 20);
            this.temp.TabIndex = 9;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(153, 98);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(157, 20);
            this.age.TabIndex = 10;
            // 
            // fever
            // 
            this.fever.FormattingEnabled = true;
            this.fever.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.fever.Location = new System.Drawing.Point(155, 325);
            this.fever.Name = "fever";
            this.fever.Size = new System.Drawing.Size(155, 21);
            this.fever.TabIndex = 11;
            // 
            // diabetic
            // 
            this.diabetic.FormattingEnabled = true;
            this.diabetic.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.diabetic.Location = new System.Drawing.Point(153, 276);
            this.diabetic.Name = "diabetic";
            this.diabetic.Size = new System.Drawing.Size(157, 21);
            this.diabetic.TabIndex = 12;
            // 
            // cardiac
            // 
            this.cardiac.FormattingEnabled = true;
            this.cardiac.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cardiac.Location = new System.Drawing.Point(153, 228);
            this.cardiac.Name = "cardiac";
            this.cardiac.Size = new System.Drawing.Size(157, 21);
            this.cardiac.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 57);
            this.panel1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(202, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(449, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Data Collation System For New Covid19 Variant";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(367, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Analyse Data";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Patients,
            this.Risk});
            this.dataGridView1.Location = new System.Drawing.Point(461, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Patients
            // 
            this.Patients.HeaderText = "Patients";
            this.Patients.Name = "Patients";
            // 
            // Risk
            // 
            this.Risk.HeaderText = "Risk(%)";
            this.Risk.Name = "Risk";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cardiac);
            this.Controls.Add(this.diabetic);
            this.Controls.Add(this.fever);
            this.Controls.Add(this.age);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.heartrate);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.TextBox heartrate;
        private System.Windows.Forms.TextBox temp;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.ComboBox fever;
        private System.Windows.Forms.ComboBox diabetic;
        private System.Windows.Forms.ComboBox cardiac;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Risk;
    }
}