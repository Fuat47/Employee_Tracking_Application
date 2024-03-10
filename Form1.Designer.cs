namespace PersonelTakip
{
    partial class frmMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtAddress = new TextBox();
            label7 = new Label();
            cbDepartment = new ComboBox();
            dtStartDate = new DateTimePicker();
            label8 = new Label();
            numChildren = new NumericUpDown();
            chkMilitary = new CheckBox();
            chkForeign = new CheckBox();
            rdOHSYes = new RadioButton();
            rdOHSNo = new RadioButton();
            label9 = new Label();
            label10 = new Label();
            rdMasteryYes = new RadioButton();
            rdMasteryNo = new RadioButton();
            panel2 = new Panel();
            panel3 = new Panel();
            btnNewRecord = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            lbEmployees = new ListBox();
            label11 = new Label();
            lblEmployeeNumber = new Label();
            lblRecordInfo = new Label();
            txtPhone = new TextBox();
            epEmployeeForm = new ErrorProvider(components);
            timerWatch = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numChildren).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epEmployeeForm).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 127);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 48F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(178, 33);
            label1.Name = "label1";
            label1.Size = new Size(843, 73);
            label1.TabIndex = 1;
            label1.Text = "Employee Tracking Application";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 160);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 211);
            label3.Name = "label3";
            label3.Size = new Size(62, 19);
            label3.TabIndex = 2;
            label3.Text = "Surname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 262);
            label4.Name = "label4";
            label4.Size = new Size(47, 19);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 313);
            label5.Name = "label5";
            label5.Size = new Size(60, 19);
            label5.TabIndex = 4;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 445);
            label6.Name = "label6";
            label6.Size = new Size(80, 19);
            label6.TabIndex = 5;
            label6.Text = "Department";
            // 
            // txtName
            // 
            txtName.Location = new Point(29, 182);
            txtName.Name = "txtName";
            txtName.Size = new Size(173, 26);
            txtName.TabIndex = 1;
            txtName.Validating += txtName_Validating;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(29, 233);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(173, 26);
            txtSurname.TabIndex = 2;
            txtSurname.Validating += txtSurname_Validating;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(29, 335);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(173, 107);
            txtAddress.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(234, 160);
            label7.Name = "label7";
            label7.Size = new Size(126, 19);
            label7.TabIndex = 10;
            label7.Text = "Start Date of Work";
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Items.AddRange(new object[] { "Human Resources", "Finance", "Sales and Marketing", "Research and Development", "Information Technology", "Customer Service", "Management" });
            cbDepartment.Location = new Point(29, 467);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(173, 27);
            cbDepartment.TabIndex = 5;
            // 
            // dtStartDate
            // 
            dtStartDate.Location = new Point(234, 182);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(200, 26);
            dtStartDate.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(234, 211);
            label8.Name = "label8";
            label8.Size = new Size(130, 19);
            label8.TabIndex = 13;
            label8.Text = "Number of Children";
            // 
            // numChildren
            // 
            numChildren.Location = new Point(234, 234);
            numChildren.Name = "numChildren";
            numChildren.Size = new Size(200, 26);
            numChildren.TabIndex = 7;
            // 
            // chkMilitary
            // 
            chkMilitary.AutoSize = true;
            chkMilitary.Location = new Point(234, 284);
            chkMilitary.Name = "chkMilitary";
            chkMilitary.Size = new Size(251, 23);
            chkMilitary.TabIndex = 8;
            chkMilitary.Text = "Have you done your military service?";
            chkMilitary.UseVisualStyleBackColor = true;
            // 
            // chkForeign
            // 
            chkForeign.AutoSize = true;
            chkForeign.Location = new Point(234, 313);
            chkForeign.Name = "chkForeign";
            chkForeign.Size = new Size(232, 23);
            chkForeign.TabIndex = 9;
            chkForeign.Text = "Do you speak a foreign language?";
            chkForeign.UseVisualStyleBackColor = true;
            // 
            // rdOHSYes
            // 
            rdOHSYes.AutoSize = true;
            rdOHSYes.Location = new Point(3, 7);
            rdOHSYes.Name = "rdOHSYes";
            rdOHSYes.Size = new Size(49, 23);
            rdOHSYes.TabIndex = 10;
            rdOHSYes.TabStop = true;
            rdOHSYes.Text = "Yes";
            rdOHSYes.UseVisualStyleBackColor = true;
            // 
            // rdOHSNo
            // 
            rdOHSNo.AutoSize = true;
            rdOHSNo.Location = new Point(58, 7);
            rdOHSNo.Name = "rdOHSNo";
            rdOHSNo.Size = new Size(47, 23);
            rdOHSNo.TabIndex = 11;
            rdOHSNo.TabStop = true;
            rdOHSNo.Text = "No";
            rdOHSNo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(234, 357);
            label9.Name = "label9";
            label9.Size = new Size(224, 19);
            label9.TabIndex = 20;
            label9.Text = "Have you completed OHS training?";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(234, 423);
            label10.Name = "label10";
            label10.Size = new Size(217, 19);
            label10.TabIndex = 21;
            label10.Text = "Do you have a mastery certificate?";
            // 
            // rdMasteryYes
            // 
            rdMasteryYes.AutoSize = true;
            rdMasteryYes.Location = new Point(3, 6);
            rdMasteryYes.Name = "rdMasteryYes";
            rdMasteryYes.Size = new Size(49, 23);
            rdMasteryYes.TabIndex = 12;
            rdMasteryYes.TabStop = true;
            rdMasteryYes.Text = "Yes";
            rdMasteryYes.UseVisualStyleBackColor = true;
            // 
            // rdMasteryNo
            // 
            rdMasteryNo.AutoSize = true;
            rdMasteryNo.Location = new Point(58, 6);
            rdMasteryNo.Name = "rdMasteryNo";
            rdMasteryNo.Size = new Size(47, 23);
            rdMasteryNo.TabIndex = 13;
            rdMasteryNo.TabStop = true;
            rdMasteryNo.Text = "No";
            rdMasteryNo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(rdOHSYes);
            panel2.Controls.Add(rdOHSNo);
            panel2.Location = new Point(234, 379);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 34);
            panel2.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.Controls.Add(rdMasteryYes);
            panel3.Controls.Add(rdMasteryNo);
            panel3.Location = new Point(234, 445);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 36);
            panel3.TabIndex = 25;
            // 
            // btnNewRecord
            // 
            btnNewRecord.BackColor = Color.ForestGreen;
            btnNewRecord.Location = new Point(29, 557);
            btnNewRecord.Name = "btnNewRecord";
            btnNewRecord.Size = new Size(100, 34);
            btnNewRecord.TabIndex = 14;
            btnNewRecord.Text = "New Record";
            btnNewRecord.UseVisualStyleBackColor = false;
            btnNewRecord.Click += btnNewRecord_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(244, 557);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(91, 34);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.CornflowerBlue;
            btnUpdate.Location = new Point(341, 557);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 34);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Add";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Orange;
            btnSave.Location = new Point(902, 557);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 34);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lbEmployees
            // 
            lbEmployees.FormattingEnabled = true;
            lbEmployees.ItemHeight = 19;
            lbEmployees.Location = new Point(522, 182);
            lbEmployees.Name = "lbEmployees";
            lbEmployees.Size = new Size(472, 270);
            lbEmployees.TabIndex = 30;
            lbEmployees.SelectedIndexChanged += lbEmployees_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 16F);
            label11.Location = new Point(522, 153);
            label11.Name = "label11";
            label11.Size = new Size(139, 25);
            label11.TabIndex = 31;
            label11.Text = "Employee List";
            // 
            // lblEmployeeNumber
            // 
            lblEmployeeNumber.AutoSize = true;
            lblEmployeeNumber.Location = new Point(523, 461);
            lblEmployeeNumber.Name = "lblEmployeeNumber";
            lblEmployeeNumber.Size = new Size(81, 19);
            lblEmployeeNumber.TabIndex = 32;
            lblEmployeeNumber.Text = "0 Employee";
            // 
            // lblRecordInfo
            // 
            lblRecordInfo.AutoSize = true;
            lblRecordInfo.Font = new Font("Times New Roman", 16F);
            lblRecordInfo.ForeColor = Color.Red;
            lblRecordInfo.Location = new Point(146, 131);
            lblRecordInfo.Name = "lblRecordInfo";
            lblRecordInfo.Size = new Size(122, 25);
            lblRecordInfo.TabIndex = 33;
            lblRecordInfo.Text = "New Record";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(29, 282);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(172, 26);
            txtPhone.TabIndex = 3;
            // 
            // epEmployeeForm
            // 
            epEmployeeForm.ContainerControl = this;
            // 
            // frmMainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.Teal;
            ClientSize = new Size(1029, 636);
            Controls.Add(txtPhone);
            Controls.Add(lblRecordInfo);
            Controls.Add(lblEmployeeNumber);
            Controls.Add(label11);
            Controls.Add(lbEmployees);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnNewRecord);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(chkForeign);
            Controls.Add(chkMilitary);
            Controls.Add(numChildren);
            Controls.Add(label8);
            Controls.Add(dtStartDate);
            Controls.Add(cbDepartment);
            Controls.Add(label7);
            Controls.Add(txtAddress);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "frmMainForm";
            Text = "Form1";
            Load += frmMainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numChildren).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epEmployeeForm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtAddress;
        private Label label7;
        private ComboBox cbDepartment;
        private DateTimePicker dtStartDate;
        private Label label8;
        private NumericUpDown numChildren;
        private CheckBox chkMilitary;
        private CheckBox chkForeign;
        private RadioButton rdOHSYes;
        private RadioButton rdOHSNo;
        private Label label9;
        private Label label10;
        private RadioButton rdMasteryYes;
        private RadioButton rdMasteryNo;
        private Panel panel2;
        private Panel panel3;
        private Button btnNewRecord;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private ListBox lbEmployees;
        private Label label11;
        private Label lblEmployeeNumber;
        private Label lblRecordInfo;
        private TextBox txtPhone;
        private ErrorProvider epEmployeeForm;
        private System.Windows.Forms.Timer timerWatch;
    }
}
