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
    public partial class AuditForm : Form
    {
        List<AuditEntry> audit;
        List<AuditEntry> auditFiltered;
        private const string auditFile = "audit.json";
        public AuditForm()
        {
            InitializeComponent();
            initialiseAudit();
        }

        private void onClickExitButton(object sender, EventArgs e)
        {
            Close();
        }

        private void initialiseAudit()
        {
            try
            {
                var js = File.ReadAllText(auditFile);
                audit = JsonConvert.DeserializeObject<List<AuditEntry>>(js);
            }
            catch (Exception e)
            {
                // can't open the audit file so initialise an empty list. Will display nothing but won't crash
                audit = new List<AuditEntry>();
            }
            finally
            {
                clearFilter();
                updateGridView();
            }
        }
        private void updateGridView()
        {
            // showing the filtered audit to the grid
            var list = auditFiltered.Select(k => new { date = k.dateTime.ToString(), k.input, k.inputCurrency, k.result, k.outputCurrency }).ToList();
            var source = new BindingSource(list, null);
            dataGridView1.DataSource = source;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void clearFilter()
        {
            // copy the non filtered audit to the filtered audit list
            auditFiltered = new List<AuditEntry>(audit);
        }

        private void onFilterClicked(object sender, EventArgs e)
        {
            filter();
            updateGridView();
        }

        private void filter()
        {
            // using  2 date times picker for the begining and the ending. 1 for date 1 for time.
            // Adding date and time together to get date time.
            DateTime begining = beginingDatePortionPicker.Value.Date +
                    beginingTimePortionPicker.Value.TimeOfDay;
            DateTime ending = endDatePortionPicker.Value.Date +
                    endTmePortionPicker.Value.TimeOfDay;
            auditFiltered = audit.Where(t => t.dateTime > begining && t.dateTime < ending).ToList();
        }

        private void onClearClicked(object sender, EventArgs e)
        {
            clearFilter();
            updateGridView();
        }
    }

}
