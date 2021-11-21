
namespace TailoringServiceFormApplication
{
    partial class TailorForm
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
            this.dataGridViewTailorOrders = new System.Windows.Forms.DataGridView();
            this.labelTailorOrders = new System.Windows.Forms.Label();
            this.labelMeasurements = new System.Windows.Forms.Label();
            this.dataGridViewtailorMeasurement = new System.Windows.Forms.DataGridView();
            this.labelChangeTo = new System.Windows.Forms.Label();
            this.listBoxStatus = new System.Windows.Forms.ListBox();
            this.buttonSaveChangedStatus = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTailorOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtailorMeasurement)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTailorOrders
            // 
            this.dataGridViewTailorOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTailorOrders.Location = new System.Drawing.Point(36, 72);
            this.dataGridViewTailorOrders.Name = "dataGridViewTailorOrders";
            this.dataGridViewTailorOrders.RowHeadersWidth = 82;
            this.dataGridViewTailorOrders.RowTemplate.Height = 33;
            this.dataGridViewTailorOrders.Size = new System.Drawing.Size(685, 347);
            this.dataGridViewTailorOrders.TabIndex = 0;
            // 
            // labelTailorOrders
            // 
            this.labelTailorOrders.AutoSize = true;
            this.labelTailorOrders.Location = new System.Drawing.Point(31, 32);
            this.labelTailorOrders.Name = "labelTailorOrders";
            this.labelTailorOrders.Size = new System.Drawing.Size(77, 25);
            this.labelTailorOrders.TabIndex = 1;
            this.labelTailorOrders.Text = "Orders";
            // 
            // labelMeasurements
            // 
            this.labelMeasurements.AutoSize = true;
            this.labelMeasurements.Location = new System.Drawing.Point(31, 446);
            this.labelMeasurements.Name = "labelMeasurements";
            this.labelMeasurements.Size = new System.Drawing.Size(143, 25);
            this.labelMeasurements.TabIndex = 2;
            this.labelMeasurements.Text = "Measurement";
            // 
            // dataGridViewtailorMeasurement
            // 
            this.dataGridViewtailorMeasurement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtailorMeasurement.Location = new System.Drawing.Point(36, 486);
            this.dataGridViewtailorMeasurement.Name = "dataGridViewtailorMeasurement";
            this.dataGridViewtailorMeasurement.RowHeadersWidth = 82;
            this.dataGridViewtailorMeasurement.RowTemplate.Height = 33;
            this.dataGridViewtailorMeasurement.Size = new System.Drawing.Size(685, 130);
            this.dataGridViewtailorMeasurement.TabIndex = 3;
            // 
            // labelChangeTo
            // 
            this.labelChangeTo.AutoSize = true;
            this.labelChangeTo.Location = new System.Drawing.Point(747, 196);
            this.labelChangeTo.Name = "labelChangeTo";
            this.labelChangeTo.Size = new System.Drawing.Size(117, 25);
            this.labelChangeTo.TabIndex = 4;
            this.labelChangeTo.Text = "Change to:";
            // 
            // listBoxStatus
            // 
            this.listBoxStatus.FormattingEnabled = true;
            this.listBoxStatus.ItemHeight = 25;
            this.listBoxStatus.Location = new System.Drawing.Point(870, 132);
            this.listBoxStatus.Name = "listBoxStatus";
            this.listBoxStatus.Size = new System.Drawing.Size(160, 154);
            this.listBoxStatus.TabIndex = 5;
            // 
            // buttonSaveChangedStatus
            // 
            this.buttonSaveChangedStatus.Location = new System.Drawing.Point(870, 338);
            this.buttonSaveChangedStatus.Name = "buttonSaveChangedStatus";
            this.buttonSaveChangedStatus.Size = new System.Drawing.Size(167, 48);
            this.buttonSaveChangedStatus.TabIndex = 6;
            this.buttonSaveChangedStatus.Text = "Save Changes";
            this.buttonSaveChangedStatus.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(865, 91);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(73, 25);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Status";
            // 
            // TailorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 656);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonSaveChangedStatus);
            this.Controls.Add(this.listBoxStatus);
            this.Controls.Add(this.labelChangeTo);
            this.Controls.Add(this.dataGridViewtailorMeasurement);
            this.Controls.Add(this.labelMeasurements);
            this.Controls.Add(this.labelTailorOrders);
            this.Controls.Add(this.dataGridViewTailorOrders);
            this.Name = "TailorForm";
            this.Text = "TailorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTailorOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtailorMeasurement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTailorOrders;
        private System.Windows.Forms.Label labelTailorOrders;
        private System.Windows.Forms.Label labelMeasurements;
        private System.Windows.Forms.DataGridView dataGridViewtailorMeasurement;
        private System.Windows.Forms.Label labelChangeTo;
        private System.Windows.Forms.ListBox listBoxStatus;
        private System.Windows.Forms.Button buttonSaveChangedStatus;
        private System.Windows.Forms.Label labelStatus;
    }
}