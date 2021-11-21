using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TailoringServiceCodeFirstFromDB;
using System.Diagnostics;
using TSControllerUtilities;



namespace TailoringServiceFormApplication
{
    public partial class TailorForm : Form
    {
        public TailorForm()
        {
            InitializeComponent();
           
        }
        private void TailorForm_Load(object sender, EventArgs e)
        {
           

            // common setup for datagridview controls
            InitializeDataGridView<Order>(dataGridViewTailorOrders, "EmployeeId", "CreateDate");
           
           
        }
        public void InitializeDataGridView<T>(DataGridView gridView, params string[] columnsToHide) where T : class
        {
            // Allow users to add/delete rows, and fill out columns to the entire width of the control

            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = false;
            gridView.ReadOnly = true;
            gridView.AllowUserToResizeRows = false;
            gridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            gridView.DataError += (s, e) => HandleDataError<T>(s as DataGridView, e);

            // set data to the datagridview
            gridView.DataSource = Controller<TailoringServiceEntities, T>.SetBindingList();

            foreach (string column in columnsToHide)
                gridView.Columns[column].Visible = false;


        }

        private void HandleDataError<T>(DataGridView gridView, DataGridViewDataErrorEventArgs e)
        {
            Debug.WriteLine("DataError " + typeof(T) + " " + gridView.Name + " row " + e.RowIndex + " col " + e.ColumnIndex + " Context: " + e.Context.ToString());
            e.Cancel = true;
        }

    }
}
