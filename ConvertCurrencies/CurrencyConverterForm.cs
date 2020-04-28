using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertCurrencies
{
    public partial class CurrencyConverterForm : Form
    {
        CurrencyUtils currencyUtils;
        List<AuditEntry> audit;
        private const string auditFile = "audit.json";
        public CurrencyConverterForm()
        {
            InitializeComponent();
            currencyUtils = new CurrencyUtils();
            populateFirstCurrencyChoice();
            initialiseAudit();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            var firstCurrency = (string)listBoxCurrency1.SelectedItem;
            var secondCurrency = (string)listBoxCurrency2.SelectedItem;
            var rate = currencyUtils.currencyConversionRates[firstCurrency + secondCurrency];
            double inputCurrency;
            if(Double.TryParse(textBoxCurrency1.Text, out inputCurrency))
            {
                double result = inputCurrency * rate;
                resultLabel.Text = Math.Round(result, 2, MidpointRounding.AwayFromZero).ToString();
                resultCurrencyLabel.Text = secondCurrency;
                addAudit(firstCurrency, secondCurrency, textBoxCurrency1.Text, resultLabel.Text);
            }
            else
            {
                // error handling
                addAudit(firstCurrency, secondCurrency, textBoxCurrency1.Text, "error parsing");
                MessageBox.Show("Error parsing the source currency");

            }
                
        }

        private void populateFirstCurrencyChoice()
        {
            listBoxCurrency1.Items.AddRange(currencyUtils.availableCurrencies.ToArray());
        }

        private void onFirstCurrencySelected(object sender, EventArgs e)
        {
            var firstCurrency = (string)listBoxCurrency1.SelectedItem;
            var secondCurrencies = currencyUtils.availableCurrencies.Where(t => t != firstCurrency).ToArray();
            listBoxCurrency2.Items.Clear();
            listBoxCurrency2.Items.AddRange(secondCurrencies);
            convertButton.Enabled = false;
        }

        private void onSecondCurrencySelected(object sender, EventArgs e)
        {
            convertButton.Enabled = true;
        }
        private void initialiseAudit()
        {
            try
            {
                // We import the existing audit upon application launch
                var js = File.ReadAllText(auditFile);
                audit = JsonConvert.DeserializeObject<List<AuditEntry>>(js);
            }
            catch(Exception e)
            {
                // if no audit create one
                audit = new List<AuditEntry>();
            }
        }
        private void saveAudit()
        {
            // overwrite the audit file with all entries
            var json = JsonConvert.SerializeObject(audit);
            File.WriteAllText(auditFile, json);
        }
        private void addAudit(string inputCurrency, string outputCurrency, string input, string result)
        {
            var auditEntry = new AuditEntry()
            {
                inputCurrency = inputCurrency,
                outputCurrency = outputCurrency,
                input = input,
                result = result,
                dateTime = DateTime.Now // using computer local time. Serialisation/deserialisation of date will be using local date time settings
            };
            audit.Add(auditEntry);
            saveAudit();
        }

        private void onClickAuditButton(object sender, EventArgs e)
        {
            //Hiding this form and opening the audit form, reopening the main form when closing the audit form
            var auditForm = new AuditForm();
            auditForm.Location = this.Location;
            auditForm.StartPosition = FormStartPosition.Manual;
            auditForm.FormClosing += delegate { this.Show(); };
            auditForm.Show();
            this.Hide();
        }
    }
}
