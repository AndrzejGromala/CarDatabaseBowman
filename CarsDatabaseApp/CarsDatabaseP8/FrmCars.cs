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
   public partial class FrmCars : Form
   {
      FrmSearch formSearch = new FrmSearch();
      public FrmCars()
      {
         InitializeComponent();
      }

      // Method updating the count of cars
      private void DisplayIndex()
      {
         txtNumberOfCars.Text = $"{tblCarBindingSource.Position + 1} of {tblCarBindingSource.Count}";
      }

      private void FrmCars_Load(object sender, EventArgs e)
      {
         // TODO: This line of code loads data into the 'hireDataSet.tblCar' table. You can move, or remove it, as needed.
         this.tblCarTableAdapter.Fill(this.hireDataSet.tblCar);
         this.Text = $"Task A Andrzej Gromala {DateTime.Today: dd/MM/yyyy}";
         DisplayIndex();
      }

      // Button First
      private void btnFirst_Click(object sender, EventArgs e)
      {
         tblCarBindingSource.MoveFirst();
         DisplayIndex();
      }

      // Button Previous
      private void btnPrevious_Click(object sender, EventArgs e)
      {
         tblCarBindingSource.MovePrevious();
         DisplayIndex();
      }

      // Button Next
      private void btnNext_Click(object sender, EventArgs e)
      {
         tblCarBindingSource.MoveNext();
         DisplayIndex();
      }

      // Button Last
      private void btnLast_Click(object sender, EventArgs e)
      {
         tblCarBindingSource.MoveLast();
         DisplayIndex();
      }

      // Button Exit
      private void btnExit_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      // Button Cancel
      private void btnCancel_Click(object sender, EventArgs e)
      {
         tblCarBindingSource.CancelEdit();
      }

      // Button Search
      private void btnSearch_Click(object sender, EventArgs e)
      {
         formSearch.Show();
      }

      // Button Delete
      private void btnDelete_Click(object sender, EventArgs e)
      {
         tblCarBindingSource.RemoveCurrent();
         btnUpdate_Click(sender, e);
         DisplayIndex();
      }

      // Button Add
      private void btnAdd_Click(object sender, EventArgs e)
      {
         hireDataSet.tblCar.AddtblCarRow("", "", "", DateTime.Today, 0.0M, true);
         btnLast_Click(sender, e);
         MessageBox.Show("New Record - Edit Data and Click Update to Save Changes");
      }

      private void btnUpdate_Click(object sender, EventArgs e)
      {
         try
         {
            this.Validate();
            tblCarBindingSource.EndEdit();
            tblCarTableAdapter.Update(hireDataSet.tblCar);
            DisplayIndex();
            MessageBox.Show("Record Updated");
         }
         catch(Exception ex)
         {
            MessageBox.Show(ex.Message);
            tblCarBindingSource.CancelEdit();
            hireDataSet.RejectChanges();
         }
      }
   }
}
