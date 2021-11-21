
namespace TailoringServiceFormApplication
{
    partial class BillForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelInvoice = new System.Windows.Forms.Label();
            this.labelBilledTo = new System.Windows.Forms.Label();
            this.textBoxBillCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxBillCustomerContact = new System.Windows.Forms.TextBox();
            this.labelBillCustomerContact = new System.Windows.Forms.Label();
            this.labelBillIssueDate = new System.Windows.Forms.Label();
            this.dateTimePickerBillDateCreated = new System.Windows.Forms.DateTimePicker();
            this.textBoxBillInvoiceNumber = new System.Windows.Forms.TextBox();
            this.labelBillNumber = new System.Windows.Forms.Label();
            this.panelBillCustomerInformation = new System.Windows.Forms.Panel();
            this.labelBillDetails = new System.Windows.Forms.Label();
            this.textBoxBillArticle = new System.Windows.Forms.TextBox();
            this.labelBillArticle = new System.Windows.Forms.Label();
            this.textBoxBillService = new System.Windows.Forms.TextBox();
            this.labelKindOfService = new System.Windows.Forms.Label();
            this.textBoxBillAdditionalInformation = new System.Windows.Forms.TextBox();
            this.labelBillInformation = new System.Windows.Forms.Label();
            this.labelBillPickUpDate = new System.Windows.Forms.Label();
            this.dateTimePickerBillPickUpDate = new System.Windows.Forms.DateTimePicker();
            this.panelBillJobDetails = new System.Windows.Forms.Panel();
            this.panelBillPrice = new System.Windows.Forms.Panel();
            this.labelBillPrice = new System.Windows.Forms.Label();
            this.labelBillAmount = new System.Windows.Forms.Label();
            this.textBoxBillSubtotal = new System.Windows.Forms.TextBox();
            this.labelBillSubtotal = new System.Windows.Forms.Label();
            this.textBoxBillGST = new System.Windows.Forms.TextBox();
            this.labelBillGST = new System.Windows.Forms.Label();
            this.textBoxBillPST = new System.Windows.Forms.TextBox();
            this.labelBillPST = new System.Windows.Forms.Label();
            this.textBoxBillTotalAmount = new System.Windows.Forms.TextBox();
            this.labelBillTotal = new System.Windows.Forms.Label();
            this.buttonBillOk = new System.Windows.Forms.Button();
            this.buttonBillSaveDetails = new System.Windows.Forms.Button();
            this.textBoxBillJobOrder = new System.Windows.Forms.TextBox();
            this.labelBillJobOrder = new System.Windows.Forms.Label();
            this.labelBillPreparedBy = new System.Windows.Forms.Label();
            this.textBoxBillPreparedBy = new System.Windows.Forms.TextBox();
            this.panelBillCustomerInformation.SuspendLayout();
            this.panelBillJobDetails.SuspendLayout();
            this.panelBillPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(314, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(124, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Q.J.G. Tailoring Services";
            // 
            // labelInvoice
            // 
            this.labelInvoice.AutoSize = true;
            this.labelInvoice.Location = new System.Drawing.Point(347, 31);
            this.labelInvoice.Name = "labelInvoice";
            this.labelInvoice.Size = new System.Drawing.Size(50, 13);
            this.labelInvoice.TabIndex = 1;
            this.labelInvoice.Text = "INVOICE";
            // 
            // labelBilledTo
            // 
            this.labelBilledTo.AutoSize = true;
            this.labelBilledTo.Location = new System.Drawing.Point(4, 19);
            this.labelBilledTo.Name = "labelBilledTo";
            this.labelBilledTo.Size = new System.Drawing.Size(54, 13);
            this.labelBilledTo.TabIndex = 2;
            this.labelBilledTo.Text = "Billed To: ";
            // 
            // textBoxBillCustomerName
            // 
            this.textBoxBillCustomerName.Location = new System.Drawing.Point(100, 12);
            this.textBoxBillCustomerName.Name = "textBoxBillCustomerName";
            this.textBoxBillCustomerName.Size = new System.Drawing.Size(205, 20);
            this.textBoxBillCustomerName.TabIndex = 3;
            // 
            // textBoxBillCustomerContact
            // 
            this.textBoxBillCustomerContact.Location = new System.Drawing.Point(100, 38);
            this.textBoxBillCustomerContact.Name = "textBoxBillCustomerContact";
            this.textBoxBillCustomerContact.Size = new System.Drawing.Size(205, 20);
            this.textBoxBillCustomerContact.TabIndex = 5;
            // 
            // labelBillCustomerContact
            // 
            this.labelBillCustomerContact.AutoSize = true;
            this.labelBillCustomerContact.Location = new System.Drawing.Point(4, 46);
            this.labelBillCustomerContact.Name = "labelBillCustomerContact";
            this.labelBillCustomerContact.Size = new System.Drawing.Size(90, 13);
            this.labelBillCustomerContact.TabIndex = 4;
            this.labelBillCustomerContact.Text = "Contact Number: ";
            // 
            // labelBillIssueDate
            // 
            this.labelBillIssueDate.AutoSize = true;
            this.labelBillIssueDate.Location = new System.Drawing.Point(415, 19);
            this.labelBillIssueDate.Name = "labelBillIssueDate";
            this.labelBillIssueDate.Size = new System.Drawing.Size(70, 13);
            this.labelBillIssueDate.TabIndex = 6;
            this.labelBillIssueDate.Text = "Issued Date: ";
            // 
            // dateTimePickerBillDateCreated
            // 
            this.dateTimePickerBillDateCreated.Location = new System.Drawing.Point(491, 13);
            this.dateTimePickerBillDateCreated.Name = "dateTimePickerBillDateCreated";
            this.dateTimePickerBillDateCreated.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBillDateCreated.TabIndex = 7;
            //this.dateTimePickerBillDateCreated.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBoxBillInvoiceNumber
            // 
            this.textBoxBillInvoiceNumber.Location = new System.Drawing.Point(491, 43);
            this.textBoxBillInvoiceNumber.Name = "textBoxBillInvoiceNumber";
            this.textBoxBillInvoiceNumber.Size = new System.Drawing.Size(123, 20);
            this.textBoxBillInvoiceNumber.TabIndex = 9;
            // 
            // labelBillNumber
            // 
            this.labelBillNumber.AutoSize = true;
            this.labelBillNumber.Location = new System.Drawing.Point(400, 46);
            this.labelBillNumber.Name = "labelBillNumber";
            this.labelBillNumber.Size = new System.Drawing.Size(85, 13);
            this.labelBillNumber.TabIndex = 8;
            this.labelBillNumber.Text = "Invoice Number:";
            // 
            // panelBillCustomerInformation
            // 
            this.panelBillCustomerInformation.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelBillCustomerInformation.Controls.Add(this.textBoxBillPreparedBy);
            this.panelBillCustomerInformation.Controls.Add(this.textBoxBillInvoiceNumber);
            this.panelBillCustomerInformation.Controls.Add(this.labelBillNumber);
            this.panelBillCustomerInformation.Controls.Add(this.labelBillPreparedBy);
            this.panelBillCustomerInformation.Controls.Add(this.dateTimePickerBillDateCreated);
            this.panelBillCustomerInformation.Controls.Add(this.labelBillIssueDate);
            this.panelBillCustomerInformation.Controls.Add(this.textBoxBillCustomerContact);
            this.panelBillCustomerInformation.Controls.Add(this.labelBillCustomerContact);
            this.panelBillCustomerInformation.Controls.Add(this.textBoxBillCustomerName);
            this.panelBillCustomerInformation.Controls.Add(this.labelBilledTo);
            this.panelBillCustomerInformation.Location = new System.Drawing.Point(22, 55);
            this.panelBillCustomerInformation.Name = "panelBillCustomerInformation";
            this.panelBillCustomerInformation.Size = new System.Drawing.Size(701, 101);
            this.panelBillCustomerInformation.TabIndex = 10;
            // 
            // labelBillDetails
            // 
            this.labelBillDetails.AutoSize = true;
            this.labelBillDetails.Location = new System.Drawing.Point(9, 3);
            this.labelBillDetails.Name = "labelBillDetails";
            this.labelBillDetails.Size = new System.Drawing.Size(59, 13);
            this.labelBillDetails.TabIndex = 11;
            this.labelBillDetails.Text = "Job Details";
            // 
            // textBoxBillArticle
            // 
            this.textBoxBillArticle.Location = new System.Drawing.Point(151, 29);
            this.textBoxBillArticle.Name = "textBoxBillArticle";
            this.textBoxBillArticle.Size = new System.Drawing.Size(95, 20);
            this.textBoxBillArticle.TabIndex = 11;
            // 
            // labelBillArticle
            // 
            this.labelBillArticle.AutoSize = true;
            this.labelBillArticle.Location = new System.Drawing.Point(55, 32);
            this.labelBillArticle.Name = "labelBillArticle";
            this.labelBillArticle.Size = new System.Drawing.Size(80, 13);
            this.labelBillArticle.TabIndex = 10;
            this.labelBillArticle.Text = "Kind Of Article: ";
            // 
            // textBoxBillService
            // 
            this.textBoxBillService.Location = new System.Drawing.Point(373, 29);
            this.textBoxBillService.Name = "textBoxBillService";
            this.textBoxBillService.Size = new System.Drawing.Size(95, 20);
            this.textBoxBillService.TabIndex = 13;
            // 
            // labelKindOfService
            // 
            this.labelKindOfService.AutoSize = true;
            this.labelKindOfService.Location = new System.Drawing.Point(277, 32);
            this.labelKindOfService.Name = "labelKindOfService";
            this.labelKindOfService.Size = new System.Drawing.Size(84, 13);
            this.labelKindOfService.TabIndex = 12;
            this.labelKindOfService.Text = "Kind Of Service:";
            // 
            // textBoxBillAdditionalInformation
            // 
            this.textBoxBillAdditionalInformation.Location = new System.Drawing.Point(152, 67);
            this.textBoxBillAdditionalInformation.Name = "textBoxBillAdditionalInformation";
            this.textBoxBillAdditionalInformation.Size = new System.Drawing.Size(436, 20);
            this.textBoxBillAdditionalInformation.TabIndex = 15;
            this.textBoxBillAdditionalInformation.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelBillInformation
            // 
            this.labelBillInformation.AutoSize = true;
            this.labelBillInformation.Location = new System.Drawing.Point(38, 70);
            this.labelBillInformation.Name = "labelBillInformation";
            this.labelBillInformation.Size = new System.Drawing.Size(111, 13);
            this.labelBillInformation.TabIndex = 14;
            this.labelBillInformation.Text = "Additional Information:";
            // 
            // labelBillPickUpDate
            // 
            this.labelBillPickUpDate.AutoSize = true;
            this.labelBillPickUpDate.Location = new System.Drawing.Point(55, 109);
            this.labelBillPickUpDate.Name = "labelBillPickUpDate";
            this.labelBillPickUpDate.Size = new System.Drawing.Size(77, 13);
            this.labelBillPickUpDate.TabIndex = 16;
            this.labelBillPickUpDate.Text = "Pick-Up Date: ";
            // 
            // dateTimePickerBillPickUpDate
            // 
            this.dateTimePickerBillPickUpDate.Location = new System.Drawing.Point(152, 109);
            this.dateTimePickerBillPickUpDate.Name = "dateTimePickerBillPickUpDate";
            this.dateTimePickerBillPickUpDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBillPickUpDate.TabIndex = 17;
            // 
            // panelBillJobDetails
            // 
            this.panelBillJobDetails.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelBillJobDetails.Controls.Add(this.textBoxBillJobOrder);
            this.panelBillJobDetails.Controls.Add(this.dateTimePickerBillPickUpDate);
            this.panelBillJobDetails.Controls.Add(this.labelBillJobOrder);
            this.panelBillJobDetails.Controls.Add(this.labelBillPickUpDate);
            this.panelBillJobDetails.Controls.Add(this.textBoxBillAdditionalInformation);
            this.panelBillJobDetails.Controls.Add(this.labelBillInformation);
            this.panelBillJobDetails.Controls.Add(this.textBoxBillService);
            this.panelBillJobDetails.Controls.Add(this.labelKindOfService);
            this.panelBillJobDetails.Controls.Add(this.textBoxBillArticle);
            this.panelBillJobDetails.Controls.Add(this.labelBillArticle);
            this.panelBillJobDetails.Controls.Add(this.labelBillDetails);
            this.panelBillJobDetails.Location = new System.Drawing.Point(25, 186);
            this.panelBillJobDetails.Name = "panelBillJobDetails";
            this.panelBillJobDetails.Size = new System.Drawing.Size(695, 140);
            this.panelBillJobDetails.TabIndex = 18;
            // 
            // panelBillPrice
            // 
            this.panelBillPrice.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelBillPrice.Controls.Add(this.textBoxBillTotalAmount);
            this.panelBillPrice.Controls.Add(this.labelBillTotal);
            this.panelBillPrice.Controls.Add(this.textBoxBillPST);
            this.panelBillPrice.Controls.Add(this.labelBillPST);
            this.panelBillPrice.Controls.Add(this.textBoxBillGST);
            this.panelBillPrice.Controls.Add(this.textBoxBillSubtotal);
            this.panelBillPrice.Controls.Add(this.labelBillGST);
            this.panelBillPrice.Controls.Add(this.labelBillAmount);
            this.panelBillPrice.Controls.Add(this.labelBillSubtotal);
            this.panelBillPrice.Controls.Add(this.labelBillPrice);
            this.panelBillPrice.Location = new System.Drawing.Point(25, 365);
            this.panelBillPrice.Name = "panelBillPrice";
            this.panelBillPrice.Size = new System.Drawing.Size(243, 208);
            this.panelBillPrice.TabIndex = 19;
            // 
            // labelBillPrice
            // 
            this.labelBillPrice.AutoSize = true;
            this.labelBillPrice.Location = new System.Drawing.Point(66, 15);
            this.labelBillPrice.Name = "labelBillPrice";
            this.labelBillPrice.Size = new System.Drawing.Size(0, 13);
            this.labelBillPrice.TabIndex = 0;
            // 
            // labelBillAmount
            // 
            this.labelBillAmount.AutoSize = true;
            this.labelBillAmount.Location = new System.Drawing.Point(7, 15);
            this.labelBillAmount.Name = "labelBillAmount";
            this.labelBillAmount.Size = new System.Drawing.Size(43, 13);
            this.labelBillAmount.TabIndex = 1;
            this.labelBillAmount.Text = "Amount";
            // 
            // textBoxBillSubtotal
            // 
            this.textBoxBillSubtotal.Location = new System.Drawing.Point(117, 40);
            this.textBoxBillSubtotal.Name = "textBoxBillSubtotal";
            this.textBoxBillSubtotal.Size = new System.Drawing.Size(95, 20);
            this.textBoxBillSubtotal.TabIndex = 19;
            // 
            // labelBillSubtotal
            // 
            this.labelBillSubtotal.AutoSize = true;
            this.labelBillSubtotal.Location = new System.Drawing.Point(21, 43);
            this.labelBillSubtotal.Name = "labelBillSubtotal";
            this.labelBillSubtotal.Size = new System.Drawing.Size(55, 13);
            this.labelBillSubtotal.TabIndex = 18;
            this.labelBillSubtotal.Text = "Subtotal : ";
            // 
            // textBoxBillGST
            // 
            this.textBoxBillGST.Location = new System.Drawing.Point(117, 70);
            this.textBoxBillGST.Name = "textBoxBillGST";
            this.textBoxBillGST.Size = new System.Drawing.Size(95, 20);
            this.textBoxBillGST.TabIndex = 21;
            // 
            // labelBillGST
            // 
            this.labelBillGST.AutoSize = true;
            this.labelBillGST.Location = new System.Drawing.Point(21, 73);
            this.labelBillGST.Name = "labelBillGST";
            this.labelBillGST.Size = new System.Drawing.Size(55, 13);
            this.labelBillGST.TabIndex = 20;
            this.labelBillGST.Text = "GST (5%):";
            // 
            // textBoxBillPST
            // 
            this.textBoxBillPST.Location = new System.Drawing.Point(117, 99);
            this.textBoxBillPST.Name = "textBoxBillPST";
            this.textBoxBillPST.Size = new System.Drawing.Size(95, 20);
            this.textBoxBillPST.TabIndex = 23;
            // 
            // labelBillPST
            // 
            this.labelBillPST.AutoSize = true;
            this.labelBillPST.Location = new System.Drawing.Point(21, 102);
            this.labelBillPST.Name = "labelBillPST";
            this.labelBillPST.Size = new System.Drawing.Size(57, 13);
            this.labelBillPST.TabIndex = 22;
            this.labelBillPST.Text = "PST (7%): ";
            // 
            // textBoxBillTotalAmount
            // 
            this.textBoxBillTotalAmount.Location = new System.Drawing.Point(117, 130);
            this.textBoxBillTotalAmount.Name = "textBoxBillTotalAmount";
            this.textBoxBillTotalAmount.Size = new System.Drawing.Size(95, 20);
            this.textBoxBillTotalAmount.TabIndex = 25;
            // 
            // labelBillTotal
            // 
            this.labelBillTotal.AutoSize = true;
            this.labelBillTotal.Location = new System.Drawing.Point(21, 133);
            this.labelBillTotal.Name = "labelBillTotal";
            this.labelBillTotal.Size = new System.Drawing.Size(76, 13);
            this.labelBillTotal.TabIndex = 24;
            this.labelBillTotal.Text = "Total Amount: ";
            // 
            // buttonBillOk
            // 
            this.buttonBillOk.Location = new System.Drawing.Point(394, 408);
            this.buttonBillOk.Name = "buttonBillOk";
            this.buttonBillOk.Size = new System.Drawing.Size(178, 23);
            this.buttonBillOk.TabIndex = 20;
            this.buttonBillOk.Text = "Save To Continue";
            this.buttonBillOk.UseVisualStyleBackColor = true;
            // 
            // buttonBillSaveDetails
            // 
            this.buttonBillSaveDetails.Location = new System.Drawing.Point(395, 451);
            this.buttonBillSaveDetails.Name = "buttonBillSaveDetails";
            this.buttonBillSaveDetails.Size = new System.Drawing.Size(177, 23);
            this.buttonBillSaveDetails.TabIndex = 21;
            this.buttonBillSaveDetails.Text = "Go Back To Registration";
            this.buttonBillSaveDetails.UseVisualStyleBackColor = true;
            // 
            // textBoxBillJobOrder
            // 
            this.textBoxBillJobOrder.Location = new System.Drawing.Point(574, 29);
            this.textBoxBillJobOrder.Name = "textBoxBillJobOrder";
            this.textBoxBillJobOrder.Size = new System.Drawing.Size(90, 20);
            this.textBoxBillJobOrder.TabIndex = 11;
            // 
            // labelBillJobOrder
            // 
            this.labelBillJobOrder.AutoSize = true;
            this.labelBillJobOrder.Location = new System.Drawing.Point(509, 36);
            this.labelBillJobOrder.Name = "labelBillJobOrder";
            this.labelBillJobOrder.Size = new System.Drawing.Size(59, 13);
            this.labelBillJobOrder.TabIndex = 10;
            this.labelBillJobOrder.Text = "Job Order: ";
            // 
            // labelBillPreparedBy
            // 
            this.labelBillPreparedBy.AutoSize = true;
            this.labelBillPreparedBy.Location = new System.Drawing.Point(411, 77);
            this.labelBillPreparedBy.Name = "labelBillPreparedBy";
            this.labelBillPreparedBy.Size = new System.Drawing.Size(74, 13);
            this.labelBillPreparedBy.TabIndex = 18;
            this.labelBillPreparedBy.Text = "Prepaped By: ";
            // 
            // textBoxBillPreparedBy
            // 
            this.textBoxBillPreparedBy.Location = new System.Drawing.Point(491, 70);
            this.textBoxBillPreparedBy.Name = "textBoxBillPreparedBy";
            this.textBoxBillPreparedBy.Size = new System.Drawing.Size(165, 20);
            this.textBoxBillPreparedBy.TabIndex = 18;
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 589);
            this.Controls.Add(this.buttonBillSaveDetails);
            this.Controls.Add(this.buttonBillOk);
            this.Controls.Add(this.panelBillPrice);
            this.Controls.Add(this.panelBillJobDetails);
            this.Controls.Add(this.panelBillCustomerInformation);
            this.Controls.Add(this.labelInvoice);
            this.Controls.Add(this.labelTitle);
            this.Name = "BillForm";
            this.Text = "Bill Form";
            this.Load += new System.EventHandler(this.BillForm_Load);
            this.panelBillCustomerInformation.ResumeLayout(false);
            this.panelBillCustomerInformation.PerformLayout();
            this.panelBillJobDetails.ResumeLayout(false);
            this.panelBillJobDetails.PerformLayout();
            this.panelBillPrice.ResumeLayout(false);
            this.panelBillPrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelInvoice;
        private System.Windows.Forms.Label labelBilledTo;
        private System.Windows.Forms.TextBox textBoxBillCustomerName;
        private System.Windows.Forms.TextBox textBoxBillCustomerContact;
        private System.Windows.Forms.Label labelBillCustomerContact;
        private System.Windows.Forms.Label labelBillIssueDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerBillDateCreated;
        private System.Windows.Forms.TextBox textBoxBillInvoiceNumber;
        private System.Windows.Forms.Label labelBillNumber;
        private System.Windows.Forms.Panel panelBillCustomerInformation;
        private System.Windows.Forms.Label labelBillDetails;
        private System.Windows.Forms.TextBox textBoxBillArticle;
        private System.Windows.Forms.Label labelBillArticle;
        private System.Windows.Forms.TextBox textBoxBillService;
        private System.Windows.Forms.Label labelKindOfService;
        private System.Windows.Forms.TextBox textBoxBillAdditionalInformation;
        private System.Windows.Forms.Label labelBillInformation;
        private System.Windows.Forms.Label labelBillPickUpDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerBillPickUpDate;
        private System.Windows.Forms.Panel panelBillJobDetails;
        private System.Windows.Forms.Panel panelBillPrice;
        private System.Windows.Forms.TextBox textBoxBillTotalAmount;
        private System.Windows.Forms.Label labelBillTotal;
        private System.Windows.Forms.TextBox textBoxBillPST;
        private System.Windows.Forms.Label labelBillPST;
        private System.Windows.Forms.TextBox textBoxBillGST;
        private System.Windows.Forms.TextBox textBoxBillSubtotal;
        private System.Windows.Forms.Label labelBillGST;
        private System.Windows.Forms.Label labelBillAmount;
        private System.Windows.Forms.Label labelBillSubtotal;
        private System.Windows.Forms.Label labelBillPrice;
        private System.Windows.Forms.Button buttonBillOk;
        private System.Windows.Forms.Button buttonBillSaveDetails;
        private System.Windows.Forms.TextBox textBoxBillJobOrder;
        private System.Windows.Forms.Label labelBillJobOrder;
        private System.Windows.Forms.TextBox textBoxBillPreparedBy;
        private System.Windows.Forms.Label labelBillPreparedBy;
    }
}