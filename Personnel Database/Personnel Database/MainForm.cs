/* Name: HOlly Franks
 * Date: 5-9-2017
 * Programming Problem 11-1 & 11-2
 * Description: Here is both programming problems 1 and 2 (which I combined before I realized we were supposed to do them separately).
 *                  This is a small program that displays the gridset of a VS database, then displays the record view when the user
 *                  clicks the "Display Records" button. I know the data I put in was a tad goofy, but I decided to keep it.
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personnel_Database
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void personnelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personnelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personnelDataSet);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personnelDataSet.Personnel' table. You can move, or remove it, as needed.
            this.personnelTableAdapter.Fill(this.personnelDataSet.Personnel);

        }

        private void recordsButton_Click(object sender, EventArgs e)
        {
            RecordForm records = new RecordForm();
            records.ShowDialog();
            this.personnelTableAdapter.Fill(this.personnelDataSet.Personnel);
        }
    }
}
