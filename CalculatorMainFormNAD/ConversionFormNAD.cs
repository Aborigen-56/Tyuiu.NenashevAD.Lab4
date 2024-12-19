using ConversionCalc.Lib;
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
    public partial class ConversionFormNAD : Form
    {
        private ConversionCalcLib conversionCalc;

        public ConversionFormNAD()
        {
            InitializeComponent();
            conversionCalc = new ConversionCalcLib();
            comboBoxChooseInLengthNAD.SelectedIndex = 0;
            comboBoxChooseOutLengthNAD.SelectedIndex = 1;
            comboBoxChooseInWeightNAD.SelectedIndex = 0;
            comboBoxChooseOutWeightNAD.SelectedIndex = 1;
            comboBoxChooseInVolumeNAD.SelectedIndex = 0;
            comboBoxChooseOutVolumeNAD.SelectedIndex = 1;
        }

        private string GetUnitAbbreviation(string fullUnitName)
        {
            return fullUnitName switch
            {
                "Килограммы (kg)" => "kg",
                "Граммы (grams)" => "g",
                "Тонны (tons)" => "tons",
                "Фунты (lbs)" => "lbs",
                "Унции (oz)" => "oz",

                "Метры (m)" => "m",
                "Сантиметры (cm)" => "cm",
                "Миллиметры (mm)" => "mm",
                "Километры (km)" => "km",
                "Футы (ft)" => "ft",
                "Дюймы (in)" => "in",

                "Литры (l)" => "l",
                "Миллилитры (ml)" => "ml",
                "Галлоны (gal)" => "gal",
                "Кубические метры (m3)" => "m3",

                _ => string.Empty
            };
        }

        private void CalculateConversion(ComboBox inUnitComboBox, ComboBox outUnitComboBox, TextBox inputTextBox, TextBox outputTextBox)
        {
            if (double.TryParse(inputTextBox.Text, out double inputValue))
            {
                string inUnit = inUnitComboBox.SelectedItem?.ToString() ?? string.Empty;
                string outUnit = outUnitComboBox.SelectedItem?.ToString() ?? string.Empty;

                if (string.IsNullOrEmpty(inUnit) || string.IsNullOrEmpty(outUnit))
                {
                    MessageBox.Show("Выберите входную и выходную единицы измерения.");
                    return;
                }

                inUnit = GetUnitAbbreviation(inUnit);
                outUnit = GetUnitAbbreviation(outUnit);

                try
                {
                    double result = conversionCalc.Convert(inputValue, inUnit, outUnit);
                    outputTextBox.Text = result.ToString();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Введите корректное число.");
            }
        }

        private void buttonCalculateWeightNAD_Click(object sender, EventArgs e)
        {
            CalculateConversion(comboBoxChooseInWeightNAD, comboBoxChooseOutWeightNAD, textBoxInputWeightNAD, textBoxOutputWeightNAD);
        }

        private void buttonCalculateLengthNAD_Click(object sender, EventArgs e)
        {
            CalculateConversion(comboBoxChooseInLengthNAD, comboBoxChooseOutLengthNAD, textBoxInputLengthNAD, textBoxOutputLengthNAD);
        }

        private void buttonCalculateVolumeNAD_Click(object sender, EventArgs e)
        {
            CalculateConversion(comboBoxChooseInVolumeNAD, comboBoxChooseOutVolumeNAD, textBoxInputVolumeNAD, textBoxOutputVolumeNAD);
        }
    }
}
