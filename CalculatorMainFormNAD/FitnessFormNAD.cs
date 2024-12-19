using FitnessCalc.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorMainFormNAD
{
    public partial class FitnessFormNAD : Form
    {
        private Dictionary<string, string> activityLevelMapping = new Dictionary<string, string>
        {
            { "Минимальная активность", "light" },
            { "Умеренная активность", "moderate" },
            { "Активный образ жизни", "active" },
            { "Очень активный образ жизни", "very active" }
        };

        public FitnessFormNAD()
        {
            InitializeComponent();
            comboBoxChooseActivityLevelNAD.Items.AddRange(activityLevelMapping.Keys.ToArray());
            comboBoxChooseActivityLevelNAD.SelectedIndex = 0;
        }

        private void buttonCalculateFitnessNAD_Click(object sender, EventArgs e)
        {
            try
            {
                double weightKg = double.Parse(textBoxEnterWeightNAD.Text);
                double heightCm = double.Parse(textBoxEnterHeightNAD.Text);
                int age = int.Parse(textBoxEnterAgeNAD.Text);

                string gender = radioButtonChooseGenderMaleNAD.Checked ? "male" : "female";

                string selectedActivityLabel = comboBoxChooseActivityLevelNAD.SelectedItem.ToString();
                string activityLevel = activityLevelMapping[selectedActivityLabel];

                FitnessCalcLib fitnessCalc = new FitnessCalcLib();

                double bmi = fitnessCalc.CalculateBMI(weightKg, heightCm / 100);

                var bmrResult = fitnessCalc.CalculateBMR(weightKg, heightCm, age, gender, activityLevel);

                textBoxShowResultNAD.Text = $"BMI: {bmi:F2}\r\n" +
                                            $"Калории: {bmrResult.Calories:F2}\r\n" +
                                            $"Белки: {bmrResult.Proteins:F2} г\r\n" +
                                            $"Жиры: {bmrResult.Fats:F2} г\r\n" +
                                            $"Углеводы: {bmrResult.Carbohydrates:F2} г";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
