using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Patient newPatient = new Patient()
                {
                    Fullname = fullname.Text,
                    Age = Convert.ToInt16(age.Text),
                    TempInCelsius = Convert.ToInt16(temp.Text),
                    HeartRate = Convert.ToInt16(heartrate.Text),
                    Cardiac = cardiac.Text == "Yes" ? true : false,
                    DiabeticHistory = diabetic.Text == "Yes" ? true : false,
                    FeverSymptoms = fever.Text == "Yes" ? true : false,
                };
                HealthAnalyzer h = new HealthAnalyzer();

                AccumulatedData robotDoctor = new AccumulatedData();
                
                string result = $"{robotDoctor.ChancePredictor(newPatient, h)}%";

                AccumulatedData.dataTable.Add(newPatient.ToString(), result);
                dataGridView1.Rows.Add(newPatient, result);

                TextCleaner();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("please fill all required inputs " +  ex.Message);
            }
            
        }

        // check if all text box are filled up
        public void TextCleaner()
        {
            fullname.Text = "";
            age.Text = "";
            temp.Text = "";
            heartrate.Text = "";
            cardiac.Text = "";
            diabetic.Text = "";
            fever.Text = "";
            
        }
    }
}
