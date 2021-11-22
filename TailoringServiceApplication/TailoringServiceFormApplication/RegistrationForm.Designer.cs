
namespace TailoringServiceFormApplication
{
    partial class RegistrationForm
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
            this.labelRegistrationName = new System.Windows.Forms.Label();
            this.textBoxRegistrationCustomerName = new System.Windows.Forms.TextBox();
            this.labelRegistrationOrderId = new System.Windows.Forms.Label();
            this.textBoxRegistrationOrderNumber = new System.Windows.Forms.TextBox();
            this.textBoxRegistrationCustomerContact = new System.Windows.Forms.TextBox();
            this.labelRegistrationCustomerContact = new System.Windows.Forms.Label();
            this.labelRegistrationService = new System.Windows.Forms.Label();
            this.labelRegistrationClothingArticle = new System.Windows.Forms.Label();
            this.listBoxRegistrationClothingArticle = new System.Windows.Forms.ListBox();
            this.labelRegistrationBillId = new System.Windows.Forms.Label();
            this.textBoxRegistrationBillId = new System.Windows.Forms.TextBox();
            this.labelRegistrationPickUpDate = new System.Windows.Forms.Label();
            this.dateTimePickerRegistrationPickUpDate = new System.Windows.Forms.DateTimePicker();
            this.labelRegistrationStatus = new System.Windows.Forms.Label();
            this.comboBoxRegistrationStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxRegistrationService = new System.Windows.Forms.ComboBox();
            this.labelRegistrationDescription = new System.Windows.Forms.Label();
            this.textBoxRegistrationDescription = new System.Windows.Forms.TextBox();
            this.labelRegistrationDateCreated = new System.Windows.Forms.Label();
            this.dateTimePickerRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.labelOrderRegistrationDetails = new System.Windows.Forms.Label();
            this.buttonRegistrationCreateOrder = new System.Windows.Forms.Button();
            this.buttonRegistrationUpdateOrder = new System.Windows.Forms.Button();
            this.labelRegistrationMeasurements = new System.Windows.Forms.Label();
            this.textBoxRegistrationBust = new System.Windows.Forms.TextBox();
            this.textBoxRegistrationNeck = new System.Windows.Forms.TextBox();
            this.textBoxRegistrationWaist = new System.Windows.Forms.TextBox();
            this.textBoxRegistrationHip = new System.Windows.Forms.TextBox();
            this.textBoxRegistrationArmLength = new System.Windows.Forms.TextBox();
            this.textBoxRegistrationShoulderLength = new System.Windows.Forms.TextBox();
            this.textBoxRegistrationLegLength = new System.Windows.Forms.TextBox();
            this.panelMeasurement = new System.Windows.Forms.Panel();
            this.labelRegistrationCustomerDetails = new System.Windows.Forms.Label();
            this.panelCustomerDetails = new System.Windows.Forms.Panel();
            this.checkBoxRegistrationBust = new System.Windows.Forms.CheckBox();
            this.checkBoxRegistrationNeck = new System.Windows.Forms.CheckBox();
            this.checkBoxRegistrationWaist = new System.Windows.Forms.CheckBox();
            this.checkBoxRegistrationHip = new System.Windows.Forms.CheckBox();
            this.checkBoxRegistrationShoulderLength = new System.Windows.Forms.CheckBox();
            this.checkBoxRegistrationArmLength = new System.Windows.Forms.CheckBox();
            this.checkBoxRegistrationLegLength = new System.Windows.Forms.CheckBox();
            this.labelRegistrationArticleNumber = new System.Windows.Forms.Label();
            this.textBoxRegistrationOrderMeasurementId = new System.Windows.Forms.TextBox();
            this.textBoxRegistrationPreparedBy = new System.Windows.Forms.TextBox();
            this.labelRegistrationPreparedBy = new System.Windows.Forms.Label();
            this.buttonRegistrationGoBack = new System.Windows.Forms.Button();
            this.panelMeasurement.SuspendLayout();
            this.panelCustomerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRegistrationName
            // 
            this.labelRegistrationName.AutoSize = true;
            this.labelRegistrationName.Location = new System.Drawing.Point(13, 36);
            this.labelRegistrationName.Name = "labelRegistrationName";
            this.labelRegistrationName.Size = new System.Drawing.Size(82, 13);
            this.labelRegistrationName.TabIndex = 0;
            this.labelRegistrationName.Text = "Customer Name";
            // 
            // textBoxRegistrationCustomerName
            // 
            this.textBoxRegistrationCustomerName.Location = new System.Drawing.Point(102, 36);
            this.textBoxRegistrationCustomerName.Name = "textBoxRegistrationCustomerName";
            this.textBoxRegistrationCustomerName.Size = new System.Drawing.Size(224, 20);
            this.textBoxRegistrationCustomerName.TabIndex = 1;
            // 
            // labelRegistrationOrderId
            // 
            this.labelRegistrationOrderId.AutoSize = true;
            this.labelRegistrationOrderId.Location = new System.Drawing.Point(315, 20);
            this.labelRegistrationOrderId.Name = "labelRegistrationOrderId";
            this.labelRegistrationOrderId.Size = new System.Drawing.Size(73, 13);
            this.labelRegistrationOrderId.TabIndex = 2;
            this.labelRegistrationOrderId.Text = "Order Number";
            // 
            // textBoxRegistrationOrderNumber
            // 
            this.textBoxRegistrationOrderNumber.Location = new System.Drawing.Point(403, 13);
            this.textBoxRegistrationOrderNumber.Name = "textBoxRegistrationOrderNumber";
            this.textBoxRegistrationOrderNumber.Size = new System.Drawing.Size(105, 20);
            this.textBoxRegistrationOrderNumber.TabIndex = 3;
            // 
            // textBoxRegistrationCustomerContact
            // 
            this.textBoxRegistrationCustomerContact.Location = new System.Drawing.Point(507, 36);
            this.textBoxRegistrationCustomerContact.Name = "textBoxRegistrationCustomerContact";
            this.textBoxRegistrationCustomerContact.Size = new System.Drawing.Size(132, 20);
            this.textBoxRegistrationCustomerContact.TabIndex = 4;
            // 
            // labelRegistrationCustomerContact
            // 
            this.labelRegistrationCustomerContact.AutoSize = true;
            this.labelRegistrationCustomerContact.Location = new System.Drawing.Point(422, 36);
            this.labelRegistrationCustomerContact.Name = "labelRegistrationCustomerContact";
            this.labelRegistrationCustomerContact.Size = new System.Drawing.Size(79, 13);
            this.labelRegistrationCustomerContact.TabIndex = 5;
            this.labelRegistrationCustomerContact.Text = "Contact Details";
            // 
            // labelRegistrationService
            // 
            this.labelRegistrationService.AutoSize = true;
            this.labelRegistrationService.Location = new System.Drawing.Point(20, 157);
            this.labelRegistrationService.Name = "labelRegistrationService";
            this.labelRegistrationService.Size = new System.Drawing.Size(79, 13);
            this.labelRegistrationService.TabIndex = 6;
            this.labelRegistrationService.Text = "Kind of Service";
            // 
            // labelRegistrationClothingArticle
            // 
            this.labelRegistrationClothingArticle.AutoSize = true;
            this.labelRegistrationClothingArticle.Location = new System.Drawing.Point(20, 199);
            this.labelRegistrationClothingArticle.Name = "labelRegistrationClothingArticle";
            this.labelRegistrationClothingArticle.Size = new System.Drawing.Size(77, 13);
            this.labelRegistrationClothingArticle.TabIndex = 8;
            this.labelRegistrationClothingArticle.Text = "Clothing Article";
            // 
            // listBoxRegistrationClothingArticle
            // 
            this.listBoxRegistrationClothingArticle.FormattingEnabled = true;
            this.listBoxRegistrationClothingArticle.Items.AddRange(new object[] {
            "Pants",
            "Coats",
            "Hoodies",
            "TankTop",
            "T-Shirts",
            "Shorts",
            "Hats",
            "Others"});
            this.listBoxRegistrationClothingArticle.Location = new System.Drawing.Point(106, 199);
            this.listBoxRegistrationClothingArticle.Name = "listBoxRegistrationClothingArticle";
            this.listBoxRegistrationClothingArticle.Size = new System.Drawing.Size(82, 69);
            this.listBoxRegistrationClothingArticle.TabIndex = 9;
            // 
            // labelRegistrationBillId
            // 
            this.labelRegistrationBillId.AutoSize = true;
            this.labelRegistrationBillId.Location = new System.Drawing.Point(583, 383);
            this.labelRegistrationBillId.Name = "labelRegistrationBillId";
            this.labelRegistrationBillId.Size = new System.Drawing.Size(60, 13);
            this.labelRegistrationBillId.TabIndex = 10;
            this.labelRegistrationBillId.Text = "Bill Number";
            // 
            // textBoxRegistrationBillId
            // 
            this.textBoxRegistrationBillId.Location = new System.Drawing.Point(649, 378);
            this.textBoxRegistrationBillId.Name = "textBoxRegistrationBillId";
            this.textBoxRegistrationBillId.Size = new System.Drawing.Size(107, 20);
            this.textBoxRegistrationBillId.TabIndex = 11;
            // 
            // labelRegistrationPickUpDate
            // 
            this.labelRegistrationPickUpDate.AutoSize = true;
            this.labelRegistrationPickUpDate.Location = new System.Drawing.Point(17, 358);
            this.labelRegistrationPickUpDate.Name = "labelRegistrationPickUpDate";
            this.labelRegistrationPickUpDate.Size = new System.Drawing.Size(71, 13);
            this.labelRegistrationPickUpDate.TabIndex = 12;
            this.labelRegistrationPickUpDate.Text = "Pick-Up Date";
            // 
            // dateTimePickerRegistrationPickUpDate
            // 
            this.dateTimePickerRegistrationPickUpDate.Location = new System.Drawing.Point(106, 351);
            this.dateTimePickerRegistrationPickUpDate.Name = "dateTimePickerRegistrationPickUpDate";
            this.dateTimePickerRegistrationPickUpDate.Size = new System.Drawing.Size(205, 20);
            this.dateTimePickerRegistrationPickUpDate.TabIndex = 13;
            // 
            // labelRegistrationStatus
            // 
            this.labelRegistrationStatus.AutoSize = true;
            this.labelRegistrationStatus.Location = new System.Drawing.Point(20, 411);
            this.labelRegistrationStatus.Name = "labelRegistrationStatus";
            this.labelRegistrationStatus.Size = new System.Drawing.Size(37, 13);
            this.labelRegistrationStatus.TabIndex = 14;
            this.labelRegistrationStatus.Text = "Status";
            // 
            // comboBoxRegistrationStatus
            // 
            this.comboBoxRegistrationStatus.FormattingEnabled = true;
            this.comboBoxRegistrationStatus.Items.AddRange(new object[] {
            "Incoming",
            "In-Progress",
            "Finish and Ready for Pick-Up"});
            this.comboBoxRegistrationStatus.Location = new System.Drawing.Point(109, 403);
            this.comboBoxRegistrationStatus.Name = "comboBoxRegistrationStatus";
            this.comboBoxRegistrationStatus.Size = new System.Drawing.Size(137, 21);
            this.comboBoxRegistrationStatus.TabIndex = 15;
            // 
            // comboBoxRegistrationService
            // 
            this.comboBoxRegistrationService.FormattingEnabled = true;
            this.comboBoxRegistrationService.Items.AddRange(new object[] {
            "Alteration",
            "Repair",
            "Custom Made (MTM)"});
            this.comboBoxRegistrationService.Location = new System.Drawing.Point(106, 157);
            this.comboBoxRegistrationService.Name = "comboBoxRegistrationService";
            this.comboBoxRegistrationService.Size = new System.Drawing.Size(167, 21);
            this.comboBoxRegistrationService.TabIndex = 16;
            // 
            // labelRegistrationDescription
            // 
            this.labelRegistrationDescription.AutoSize = true;
            this.labelRegistrationDescription.Location = new System.Drawing.Point(10, 145);
            this.labelRegistrationDescription.Name = "labelRegistrationDescription";
            this.labelRegistrationDescription.Size = new System.Drawing.Size(108, 13);
            this.labelRegistrationDescription.TabIndex = 17;
            this.labelRegistrationDescription.Text = "Additional Information";
            // 
            // textBoxRegistrationDescription
            // 
            this.textBoxRegistrationDescription.Location = new System.Drawing.Point(13, 161);
            this.textBoxRegistrationDescription.Name = "textBoxRegistrationDescription";
            this.textBoxRegistrationDescription.Size = new System.Drawing.Size(464, 20);
            this.textBoxRegistrationDescription.TabIndex = 18;
            // 
            // labelRegistrationDateCreated
            // 
            this.labelRegistrationDateCreated.AutoSize = true;
            this.labelRegistrationDateCreated.Location = new System.Drawing.Point(14, 20);
            this.labelRegistrationDateCreated.Name = "labelRegistrationDateCreated";
            this.labelRegistrationDateCreated.Size = new System.Drawing.Size(30, 13);
            this.labelRegistrationDateCreated.TabIndex = 19;
            this.labelRegistrationDateCreated.Text = "Date";
            // 
            // dateTimePickerRegistrationDate
            // 
            this.dateTimePickerRegistrationDate.Location = new System.Drawing.Point(62, 14);
            this.dateTimePickerRegistrationDate.Name = "dateTimePickerRegistrationDate";
            this.dateTimePickerRegistrationDate.Size = new System.Drawing.Size(205, 20);
            this.dateTimePickerRegistrationDate.TabIndex = 20;
            // 
            // labelOrderRegistrationDetails
            // 
            this.labelOrderRegistrationDetails.AutoSize = true;
            this.labelOrderRegistrationDetails.Location = new System.Drawing.Point(12, 132);
            this.labelOrderRegistrationDetails.Name = "labelOrderRegistrationDetails";
            this.labelOrderRegistrationDetails.Size = new System.Drawing.Size(68, 13);
            this.labelOrderRegistrationDetails.TabIndex = 21;
            this.labelOrderRegistrationDetails.Text = "Order Details";
            // 
            // buttonRegistrationCreateOrder
            // 
            this.buttonRegistrationCreateOrder.Location = new System.Drawing.Point(489, 348);
            this.buttonRegistrationCreateOrder.Name = "buttonRegistrationCreateOrder";
            this.buttonRegistrationCreateOrder.Size = new System.Drawing.Size(126, 23);
            this.buttonRegistrationCreateOrder.TabIndex = 22;
            this.buttonRegistrationCreateOrder.Text = "Create Order";
            this.buttonRegistrationCreateOrder.UseVisualStyleBackColor = true;
            // 
            // buttonRegistrationUpdateOrder
            // 
            this.buttonRegistrationUpdateOrder.Location = new System.Drawing.Point(649, 348);
            this.buttonRegistrationUpdateOrder.Name = "buttonRegistrationUpdateOrder";
            this.buttonRegistrationUpdateOrder.Size = new System.Drawing.Size(126, 23);
            this.buttonRegistrationUpdateOrder.TabIndex = 23;
            this.buttonRegistrationUpdateOrder.Text = "Update Order";
            this.buttonRegistrationUpdateOrder.UseVisualStyleBackColor = true;
            // 
            // labelRegistrationMeasurements
            // 
            this.labelRegistrationMeasurements.AutoSize = true;
            this.labelRegistrationMeasurements.Location = new System.Drawing.Point(39, 9);
            this.labelRegistrationMeasurements.Name = "labelRegistrationMeasurements";
            this.labelRegistrationMeasurements.Size = new System.Drawing.Size(96, 13);
            this.labelRegistrationMeasurements.TabIndex = 24;
            this.labelRegistrationMeasurements.Text = "Job Measurements";
            // 
            // textBoxRegistrationBust
            // 
            this.textBoxRegistrationBust.Location = new System.Drawing.Point(66, 44);
            this.textBoxRegistrationBust.Name = "textBoxRegistrationBust";
            this.textBoxRegistrationBust.Size = new System.Drawing.Size(43, 20);
            this.textBoxRegistrationBust.TabIndex = 26;
            // 
            // textBoxRegistrationNeck
            // 
            this.textBoxRegistrationNeck.Location = new System.Drawing.Point(66, 81);
            this.textBoxRegistrationNeck.Name = "textBoxRegistrationNeck";
            this.textBoxRegistrationNeck.Size = new System.Drawing.Size(43, 20);
            this.textBoxRegistrationNeck.TabIndex = 28;
            // 
            // textBoxRegistrationWaist
            // 
            this.textBoxRegistrationWaist.Location = new System.Drawing.Point(195, 44);
            this.textBoxRegistrationWaist.Name = "textBoxRegistrationWaist";
            this.textBoxRegistrationWaist.Size = new System.Drawing.Size(43, 20);
            this.textBoxRegistrationWaist.TabIndex = 30;
            // 
            // textBoxRegistrationHip
            // 
            this.textBoxRegistrationHip.Location = new System.Drawing.Point(195, 81);
            this.textBoxRegistrationHip.Name = "textBoxRegistrationHip";
            this.textBoxRegistrationHip.Size = new System.Drawing.Size(43, 20);
            this.textBoxRegistrationHip.TabIndex = 32;
            // 
            // textBoxRegistrationArmLength
            // 
            this.textBoxRegistrationArmLength.Location = new System.Drawing.Point(370, 78);
            this.textBoxRegistrationArmLength.Name = "textBoxRegistrationArmLength";
            this.textBoxRegistrationArmLength.Size = new System.Drawing.Size(43, 20);
            this.textBoxRegistrationArmLength.TabIndex = 36;
            // 
            // textBoxRegistrationShoulderLength
            // 
            this.textBoxRegistrationShoulderLength.Location = new System.Drawing.Point(370, 44);
            this.textBoxRegistrationShoulderLength.Name = "textBoxRegistrationShoulderLength";
            this.textBoxRegistrationShoulderLength.Size = new System.Drawing.Size(43, 20);
            this.textBoxRegistrationShoulderLength.TabIndex = 34;
            // 
            // textBoxRegistrationLegLength
            // 
            this.textBoxRegistrationLegLength.Location = new System.Drawing.Point(370, 116);
            this.textBoxRegistrationLegLength.Name = "textBoxRegistrationLegLength";
            this.textBoxRegistrationLegLength.Size = new System.Drawing.Size(43, 20);
            this.textBoxRegistrationLegLength.TabIndex = 38;
            // 
            // panelMeasurement
            // 
            this.panelMeasurement.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelMeasurement.Controls.Add(this.textBoxRegistrationOrderMeasurementId);
            this.panelMeasurement.Controls.Add(this.labelRegistrationArticleNumber);
            this.panelMeasurement.Controls.Add(this.checkBoxRegistrationLegLength);
            this.panelMeasurement.Controls.Add(this.checkBoxRegistrationArmLength);
            this.panelMeasurement.Controls.Add(this.checkBoxRegistrationShoulderLength);
            this.panelMeasurement.Controls.Add(this.checkBoxRegistrationHip);
            this.panelMeasurement.Controls.Add(this.checkBoxRegistrationWaist);
            this.panelMeasurement.Controls.Add(this.checkBoxRegistrationNeck);
            this.panelMeasurement.Controls.Add(this.checkBoxRegistrationBust);
            this.panelMeasurement.Controls.Add(this.textBoxRegistrationBust);
            this.panelMeasurement.Controls.Add(this.textBoxRegistrationLegLength);
            this.panelMeasurement.Controls.Add(this.labelRegistrationDescription);
            this.panelMeasurement.Controls.Add(this.textBoxRegistrationDescription);
            this.panelMeasurement.Controls.Add(this.textBoxRegistrationArmLength);
            this.panelMeasurement.Controls.Add(this.labelRegistrationMeasurements);
            this.panelMeasurement.Controls.Add(this.textBoxRegistrationShoulderLength);
            this.panelMeasurement.Controls.Add(this.textBoxRegistrationNeck);
            this.panelMeasurement.Controls.Add(this.textBoxRegistrationHip);
            this.panelMeasurement.Controls.Add(this.textBoxRegistrationWaist);
            this.panelMeasurement.Location = new System.Drawing.Point(279, 132);
            this.panelMeasurement.Name = "panelMeasurement";
            this.panelMeasurement.Size = new System.Drawing.Size(496, 191);
            this.panelMeasurement.TabIndex = 39;
            //this.panelMeasurement.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMeasurement_Paint);
            // 
            // labelRegistrationCustomerDetails
            // 
            this.labelRegistrationCustomerDetails.AutoSize = true;
            this.labelRegistrationCustomerDetails.Location = new System.Drawing.Point(8, 9);
            this.labelRegistrationCustomerDetails.Name = "labelRegistrationCustomerDetails";
            this.labelRegistrationCustomerDetails.Size = new System.Drawing.Size(86, 13);
            this.labelRegistrationCustomerDetails.TabIndex = 40;
            this.labelRegistrationCustomerDetails.Text = "Customer Details";
            // 
            // panelCustomerDetails
            // 
            this.panelCustomerDetails.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelCustomerDetails.Controls.Add(this.labelRegistrationCustomerDetails);
            this.panelCustomerDetails.Controls.Add(this.labelRegistrationCustomerContact);
            this.panelCustomerDetails.Controls.Add(this.textBoxRegistrationCustomerContact);
            this.panelCustomerDetails.Controls.Add(this.textBoxRegistrationCustomerName);
            this.panelCustomerDetails.Controls.Add(this.labelRegistrationName);
            this.panelCustomerDetails.Location = new System.Drawing.Point(4, 43);
            this.panelCustomerDetails.Name = "panelCustomerDetails";
            this.panelCustomerDetails.Size = new System.Drawing.Size(771, 64);
            this.panelCustomerDetails.TabIndex = 41;
            // 
            // checkBoxRegistrationBust
            // 
            this.checkBoxRegistrationBust.AutoSize = true;
            this.checkBoxRegistrationBust.Location = new System.Drawing.Point(13, 47);
            this.checkBoxRegistrationBust.Name = "checkBoxRegistrationBust";
            this.checkBoxRegistrationBust.Size = new System.Drawing.Size(47, 17);
            this.checkBoxRegistrationBust.TabIndex = 39;
            this.checkBoxRegistrationBust.Text = "Bust";
            this.checkBoxRegistrationBust.UseVisualStyleBackColor = true;
            // 
            // checkBoxRegistrationNeck
            // 
            this.checkBoxRegistrationNeck.AutoSize = true;
            this.checkBoxRegistrationNeck.Location = new System.Drawing.Point(13, 84);
            this.checkBoxRegistrationNeck.Name = "checkBoxRegistrationNeck";
            this.checkBoxRegistrationNeck.Size = new System.Drawing.Size(52, 17);
            this.checkBoxRegistrationNeck.TabIndex = 40;
            this.checkBoxRegistrationNeck.Text = "Neck";
            this.checkBoxRegistrationNeck.UseVisualStyleBackColor = true;
            // 
            // checkBoxRegistrationWaist
            // 
            this.checkBoxRegistrationWaist.AutoSize = true;
            this.checkBoxRegistrationWaist.Location = new System.Drawing.Point(141, 47);
            this.checkBoxRegistrationWaist.Name = "checkBoxRegistrationWaist";
            this.checkBoxRegistrationWaist.Size = new System.Drawing.Size(53, 17);
            this.checkBoxRegistrationWaist.TabIndex = 41;
            this.checkBoxRegistrationWaist.Text = "Waist";
            this.checkBoxRegistrationWaist.UseVisualStyleBackColor = true;
            // 
            // checkBoxRegistrationHip
            // 
            this.checkBoxRegistrationHip.AutoSize = true;
            this.checkBoxRegistrationHip.Location = new System.Drawing.Point(141, 84);
            this.checkBoxRegistrationHip.Name = "checkBoxRegistrationHip";
            this.checkBoxRegistrationHip.Size = new System.Drawing.Size(42, 17);
            this.checkBoxRegistrationHip.TabIndex = 42;
            this.checkBoxRegistrationHip.Text = "Hip";
            this.checkBoxRegistrationHip.UseVisualStyleBackColor = true;
            // 
            // checkBoxRegistrationShoulderLength
            // 
            this.checkBoxRegistrationShoulderLength.AutoSize = true;
            this.checkBoxRegistrationShoulderLength.Location = new System.Drawing.Point(260, 47);
            this.checkBoxRegistrationShoulderLength.Name = "checkBoxRegistrationShoulderLength";
            this.checkBoxRegistrationShoulderLength.Size = new System.Drawing.Size(104, 17);
            this.checkBoxRegistrationShoulderLength.TabIndex = 43;
            this.checkBoxRegistrationShoulderLength.Text = "Shoulder Length";
            this.checkBoxRegistrationShoulderLength.UseVisualStyleBackColor = true;
            // 
            // checkBoxRegistrationArmLength
            // 
            this.checkBoxRegistrationArmLength.AutoSize = true;
            this.checkBoxRegistrationArmLength.Location = new System.Drawing.Point(260, 81);
            this.checkBoxRegistrationArmLength.Name = "checkBoxRegistrationArmLength";
            this.checkBoxRegistrationArmLength.Size = new System.Drawing.Size(80, 17);
            this.checkBoxRegistrationArmLength.TabIndex = 44;
            this.checkBoxRegistrationArmLength.Text = "Arm Length";
            this.checkBoxRegistrationArmLength.UseVisualStyleBackColor = true;
            // 
            // checkBoxRegistrationLegLength
            // 
            this.checkBoxRegistrationLegLength.AutoSize = true;
            this.checkBoxRegistrationLegLength.Location = new System.Drawing.Point(260, 119);
            this.checkBoxRegistrationLegLength.Name = "checkBoxRegistrationLegLength";
            this.checkBoxRegistrationLegLength.Size = new System.Drawing.Size(80, 17);
            this.checkBoxRegistrationLegLength.TabIndex = 45;
            this.checkBoxRegistrationLegLength.Text = "Leg Length";
            this.checkBoxRegistrationLegLength.UseVisualStyleBackColor = true;
            // 
            // labelRegistrationArticleNumber
            // 
            this.labelRegistrationArticleNumber.AutoSize = true;
            this.labelRegistrationArticleNumber.Location = new System.Drawing.Point(367, 9);
            this.labelRegistrationArticleNumber.Name = "labelRegistrationArticleNumber";
            this.labelRegistrationArticleNumber.Size = new System.Drawing.Size(73, 13);
            this.labelRegistrationArticleNumber.TabIndex = 46;
            this.labelRegistrationArticleNumber.Text = "ArticleNumber";
            // 
            // textBoxRegistrationOrderMeasurementId
            // 
            this.textBoxRegistrationOrderMeasurementId.Location = new System.Drawing.Point(446, 3);
            this.textBoxRegistrationOrderMeasurementId.Name = "textBoxRegistrationOrderMeasurementId";
            this.textBoxRegistrationOrderMeasurementId.Size = new System.Drawing.Size(43, 20);
            this.textBoxRegistrationOrderMeasurementId.TabIndex = 47;
            // 
            // textBoxRegistrationPreparedBy
            // 
            this.textBoxRegistrationPreparedBy.Location = new System.Drawing.Point(634, 13);
            this.textBoxRegistrationPreparedBy.Name = "textBoxRegistrationPreparedBy";
            this.textBoxRegistrationPreparedBy.Size = new System.Drawing.Size(105, 20);
            this.textBoxRegistrationPreparedBy.TabIndex = 43;
            // 
            // labelRegistrationPreparedBy
            // 
            this.labelRegistrationPreparedBy.AutoSize = true;
            this.labelRegistrationPreparedBy.Location = new System.Drawing.Point(546, 20);
            this.labelRegistrationPreparedBy.Name = "labelRegistrationPreparedBy";
            this.labelRegistrationPreparedBy.Size = new System.Drawing.Size(71, 13);
            this.labelRegistrationPreparedBy.TabIndex = 42;
            this.labelRegistrationPreparedBy.Text = "Prepared By: ";
            // 
            // buttonRegistrationGoBack
            // 
            this.buttonRegistrationGoBack.Location = new System.Drawing.Point(549, 427);
            this.buttonRegistrationGoBack.Name = "buttonRegistrationGoBack";
            this.buttonRegistrationGoBack.Size = new System.Drawing.Size(174, 23);
            this.buttonRegistrationGoBack.TabIndex = 44;
            this.buttonRegistrationGoBack.Text = "Go Back to Choose User";
            this.buttonRegistrationGoBack.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(787, 462);
            this.Controls.Add(this.buttonRegistrationGoBack);
            this.Controls.Add(this.textBoxRegistrationPreparedBy);
            this.Controls.Add(this.labelRegistrationPreparedBy);
            this.Controls.Add(this.panelCustomerDetails);
            this.Controls.Add(this.panelMeasurement);
            this.Controls.Add(this.buttonRegistrationUpdateOrder);
            this.Controls.Add(this.buttonRegistrationCreateOrder);
            this.Controls.Add(this.labelOrderRegistrationDetails);
            this.Controls.Add(this.dateTimePickerRegistrationDate);
            this.Controls.Add(this.labelRegistrationDateCreated);
            this.Controls.Add(this.comboBoxRegistrationService);
            this.Controls.Add(this.comboBoxRegistrationStatus);
            this.Controls.Add(this.labelRegistrationStatus);
            this.Controls.Add(this.dateTimePickerRegistrationPickUpDate);
            this.Controls.Add(this.labelRegistrationPickUpDate);
            this.Controls.Add(this.textBoxRegistrationBillId);
            this.Controls.Add(this.labelRegistrationBillId);
            this.Controls.Add(this.listBoxRegistrationClothingArticle);
            this.Controls.Add(this.labelRegistrationClothingArticle);
            this.Controls.Add(this.labelRegistrationService);
            this.Controls.Add(this.textBoxRegistrationOrderNumber);
            this.Controls.Add(this.labelRegistrationOrderId);
            this.Name = "RegistrationForm";
            this.Text = "Registration Form";
            //this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.panelMeasurement.ResumeLayout(false);
            this.panelMeasurement.PerformLayout();
            this.panelCustomerDetails.ResumeLayout(false);
            this.panelCustomerDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegistrationName;
        private System.Windows.Forms.TextBox textBoxRegistrationCustomerName;
        private System.Windows.Forms.Label labelRegistrationOrderId;
        private System.Windows.Forms.TextBox textBoxRegistrationOrderNumber;
        private System.Windows.Forms.TextBox textBoxRegistrationCustomerContact;
        private System.Windows.Forms.Label labelRegistrationCustomerContact;
        private System.Windows.Forms.Label labelRegistrationService;
        private System.Windows.Forms.Label labelRegistrationClothingArticle;
        private System.Windows.Forms.ListBox listBoxRegistrationClothingArticle;
        private System.Windows.Forms.Label labelRegistrationBillId;
        private System.Windows.Forms.TextBox textBoxRegistrationBillId;
        private System.Windows.Forms.Label labelRegistrationPickUpDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegistrationPickUpDate;
        private System.Windows.Forms.Label labelRegistrationStatus;
        private System.Windows.Forms.ComboBox comboBoxRegistrationStatus;
        private System.Windows.Forms.ComboBox comboBoxRegistrationService;
        private System.Windows.Forms.Label labelRegistrationDescription;
        private System.Windows.Forms.TextBox textBoxRegistrationDescription;
        private System.Windows.Forms.Label labelRegistrationDateCreated;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegistrationDate;
        private System.Windows.Forms.Label labelOrderRegistrationDetails;
        private System.Windows.Forms.Button buttonRegistrationCreateOrder;
        private System.Windows.Forms.Button buttonRegistrationUpdateOrder;
        private System.Windows.Forms.Label labelRegistrationMeasurements;
        private System.Windows.Forms.TextBox textBoxRegistrationBust;
        private System.Windows.Forms.TextBox textBoxRegistrationNeck;
        private System.Windows.Forms.TextBox textBoxRegistrationWaist;
        private System.Windows.Forms.TextBox textBoxRegistrationHip;
        private System.Windows.Forms.TextBox textBoxRegistrationArmLength;
        private System.Windows.Forms.TextBox textBoxRegistrationShoulderLength;
        private System.Windows.Forms.TextBox textBoxRegistrationLegLength;
        private System.Windows.Forms.Panel panelMeasurement;
        private System.Windows.Forms.Label labelRegistrationCustomerDetails;
        private System.Windows.Forms.Panel panelCustomerDetails;
        private System.Windows.Forms.CheckBox checkBoxRegistrationLegLength;
        private System.Windows.Forms.CheckBox checkBoxRegistrationArmLength;
        private System.Windows.Forms.CheckBox checkBoxRegistrationShoulderLength;
        private System.Windows.Forms.CheckBox checkBoxRegistrationHip;
        private System.Windows.Forms.CheckBox checkBoxRegistrationWaist;
        private System.Windows.Forms.CheckBox checkBoxRegistrationNeck;
        private System.Windows.Forms.CheckBox checkBoxRegistrationBust;
        private System.Windows.Forms.TextBox textBoxRegistrationOrderMeasurementId;
        private System.Windows.Forms.Label labelRegistrationArticleNumber;
        private System.Windows.Forms.TextBox textBoxRegistrationPreparedBy;
        private System.Windows.Forms.Label labelRegistrationPreparedBy;
        private System.Windows.Forms.Button buttonRegistrationGoBack;
    }
}

