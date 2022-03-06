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

                int resultInInt = robotDoctor.ChancePredictor(newPatient, h);
                string result = $"{resultInInt}%";

                AccumulatedData.dataTable.Add(newPatient.ToString(), result);
                dataGridView1.Rows.Add(newPatient, result, GroupData(resultInInt));

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

        // grouping the data to get most severe
        public string GroupData(int risk)
        {
            try
            {
                int convertString = risk;

                if (convertString <= 15)
                {
                    return "Low Risk";
                }
                else if(convertString > 15 && convertString <= 30)
                {
                    return "Medium Risk";
                }
                else if(convertString > 30 && convertString <= 45)
                {
                    return "High risk";
                }
                else if(convertString > 45 && convertString  <= 60)
                {
                    return "Quarantine";
                }
                else if(convertString > 60 && convertString <= 75)
                {
                    return "Severe";
                }
                else if(convertString > 75 && convertString <= 90)
                {
                    return "Very Severe";
                }
                else if(convertString > 90)
                {
                    return "Critical";
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return "Cannot group Data";
        }   

    }
}
