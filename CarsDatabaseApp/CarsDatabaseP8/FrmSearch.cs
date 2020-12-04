using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsDatabaseP8
{
   public partial class FrmSearch : Form
   {
      public FrmSearch()
      {
         InitializeComponent();
      }

      private void FrmSearch_Load(object sender, EventArgs e)
      {
         // TODO: This line of code loads data into the 'hireDataSet.tblCar' table. You can move, or remove it, as needed.
         this.tblCarTableAdapter.Fill(this.hireDataSet.tblCar);
         this.Text = $"Task A Andrzej Gromala {DateTime.Today: dd/MM/yyyy}";
         //this.dataGridView1.Columns["RentalPerDay"].DefaultCellStyle.Format = "c2";
         //this.dataGridView1.Columns["RentalPerDay"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      }

      // Button Close
      private void btnClose_Click(object sender, EventArgs e)
      {
         this.Hide();
      }

      // Button Run
      private void btnRun_Click(object sender, EventArgs e)
      {
         if (String.IsNullOrEmpty(cboField.Text) ||
                     String.IsNullOrEmpty(cboOperator.Text) || String.IsNullOrEmpty(txtSearchValue.Text))
         {
            MessageBox.Show("Missing Search Criteria");
         }
         else
         {
            string filter = $"{cboField.Text} {cboOperator.Text} '{txtSearchValue.Text}'";
            DataView view = new DataView(hireDataSet.Tables["tblCar"]);
            dataGridView1.DataSource = view;
            view.RowFilter = filter;
         }
      }
   }
}
