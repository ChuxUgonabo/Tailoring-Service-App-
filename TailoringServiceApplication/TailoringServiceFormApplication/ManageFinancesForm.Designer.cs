
namespace TailoringServiceFormApplication
{
    partial class ManageFinancesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSortByMonth = new System.Windows.Forms.Button();
            this.dataGridViewFinances = new System.Windows.Forms.DataGridView();
            this.button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinances)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSortByMonth
            // 
            this.buttonSortByMonth.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSortByMonth.Location = new System.Drawing.Point(145, 590);
            this.buttonSortByMonth.Name = "buttonSortByMonth";
            this.buttonSortByMonth.Size = new System.Drawing.Size(156, 32);
            this.buttonSortByMonth.TabIndex = 9;
            this.buttonSortByMonth.Text = "Select Month";
            this.buttonSortByMonth.UseVisualStyleBackColor = false;
            // 
            // dataGridViewFinances
            // 
            this.dataGridViewFinances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFinances.Location = new System.Drawing.Point(68, 59);
            this.dataGridViewFinances.Name = "dataGridViewFinances";
            this.dataGridViewFinances.RowHeadersWidth = 51;
            this.dataGridViewFinances.RowTemplate.Height = 24;
            this.dataGridViewFinances.Size = new System.Drawing.Size(833, 445);
            this.dataGridViewFinances.TabIndex = 8;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button.Location = new System.Drawing.Point(405, 590);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(156, 32);
            this.button.TabIndex = 10;
            this.button.Text = "Select Month";
            this.button.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Location = new System.Drawing.Point(648, 590);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Select Month";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ManageFinancesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 669);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button);
            this.Controls.Add(this.buttonSortByMonth);
            this.Controls.Add(this.dataGridViewFinances);
            this.Name = "ManageFinancesForm";
            this.Text = "ManageFinancesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinances)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSortByMonth;
        private System.Windows.Forms.DataGridView dataGridViewFinances;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button2;
    }
}