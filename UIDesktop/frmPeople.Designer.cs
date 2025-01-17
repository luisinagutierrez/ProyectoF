﻿namespace UIDesktop
{
    partial class frmPeople
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
            lbPeopleIdPlan = new Label();
            txtPeopleEmail = new TextBox();
            lbPeopleEmail = new Label();
            txtPeopleAddress = new TextBox();
            lbPeopleAddress = new Label();
            txtPeopleSurname = new TextBox();
            lbPeopleSurname = new Label();
            txtPeopleName = new TextBox();
            lbPeopleName = new Label();
            lbCreateUpdatePeople = new Label();
            dgvPeople = new DataGridView();
            btnUpdatePeople = new Button();
            btnCreatePeople = new Button();
            btnBack = new Button();
            lbPeoplePersonType = new Label();
            txtPeopleFileId = new TextBox();
            lbPeopleFileId = new Label();
            lbPeopleBirthDate = new Label();
            txtPeopleTelephone = new TextBox();
            lbPeopleTelephone = new Label();
            dtpPeopleBirthDate = new DateTimePicker();
            btnDeletePerson = new Button();
            lbIdPerson = new Label();
            txtIdPerson = new TextBox();
            cboxTypePerson = new ComboBox();
            cBoxIdPlan = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            SuspendLayout();
            // 
            // lbPeopleIdPlan
            // 
            lbPeopleIdPlan.AutoSize = true;
            lbPeopleIdPlan.Location = new Point(1358, 221);
            lbPeopleIdPlan.Name = "lbPeopleIdPlan";
            lbPeopleIdPlan.Size = new Size(55, 20);
            lbPeopleIdPlan.TabIndex = 81;
            lbPeopleIdPlan.Text = "Id plan";
            // 
            // txtPeopleEmail
            // 
            txtPeopleEmail.Location = new Point(1062, 307);
            txtPeopleEmail.Name = "txtPeopleEmail";
            txtPeopleEmail.Size = new Size(266, 27);
            txtPeopleEmail.TabIndex = 80;
            // 
            // lbPeopleEmail
            // 
            lbPeopleEmail.AutoSize = true;
            lbPeopleEmail.Location = new Point(939, 310);
            lbPeopleEmail.Name = "lbPeopleEmail";
            lbPeopleEmail.Size = new Size(52, 20);
            lbPeopleEmail.TabIndex = 79;
            lbPeopleEmail.Text = "E-mail";
            // 
            // txtPeopleAddress
            // 
            txtPeopleAddress.Location = new Point(1062, 222);
            txtPeopleAddress.Name = "txtPeopleAddress";
            txtPeopleAddress.Size = new Size(183, 27);
            txtPeopleAddress.TabIndex = 78;
            // 
            // lbPeopleAddress
            // 
            lbPeopleAddress.AutoSize = true;
            lbPeopleAddress.Location = new Point(939, 225);
            lbPeopleAddress.Name = "lbPeopleAddress";
            lbPeopleAddress.Size = new Size(72, 20);
            lbPeopleAddress.TabIndex = 77;
            lbPeopleAddress.Text = "Direccion";
            // 
            // txtPeopleSurname
            // 
            txtPeopleSurname.Location = new Point(1438, 175);
            txtPeopleSurname.Name = "txtPeopleSurname";
            txtPeopleSurname.Size = new Size(124, 27);
            txtPeopleSurname.TabIndex = 76;
            // 
            // lbPeopleSurname
            // 
            lbPeopleSurname.AutoSize = true;
            lbPeopleSurname.Location = new Point(1358, 182);
            lbPeopleSurname.Name = "lbPeopleSurname";
            lbPeopleSurname.Size = new Size(66, 20);
            lbPeopleSurname.TabIndex = 75;
            lbPeopleSurname.Text = "Apellido";
            // 
            // txtPeopleName
            // 
            txtPeopleName.Location = new Point(1062, 179);
            txtPeopleName.Name = "txtPeopleName";
            txtPeopleName.Size = new Size(124, 27);
            txtPeopleName.TabIndex = 74;
            // 
            // lbPeopleName
            // 
            lbPeopleName.AutoSize = true;
            lbPeopleName.Location = new Point(939, 182);
            lbPeopleName.Name = "lbPeopleName";
            lbPeopleName.Size = new Size(64, 20);
            lbPeopleName.TabIndex = 73;
            lbPeopleName.Text = "Nombre";
            // 
            // lbCreateUpdatePeople
            // 
            lbCreateUpdatePeople.AutoSize = true;
            lbCreateUpdatePeople.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCreateUpdatePeople.Location = new Point(823, 61);
            lbCreateUpdatePeople.Name = "lbCreateUpdatePeople";
            lbCreateUpdatePeople.Size = new Size(115, 25);
            lbCreateUpdatePeople.TabIndex = 72;
            lbCreateUpdatePeople.Text = "Personas";
            // 
            // dgvPeople
            // 
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.Location = new Point(28, 116);
            dgvPeople.Name = "dgvPeople";
            dgvPeople.RowHeadersWidth = 51;
            dgvPeople.RowTemplate.Height = 29;
            dgvPeople.Size = new Size(888, 385);
            dgvPeople.TabIndex = 70;
            dgvPeople.CellContentClick += dgvPeople_CellContentClick;
            dgvPeople.SelectionChanged += dgvPeople_SelectionChanged;
            // 
            // btnUpdatePeople
            // 
            btnUpdatePeople.Location = new Point(1345, 453);
            btnUpdatePeople.Name = "btnUpdatePeople";
            btnUpdatePeople.Size = new Size(121, 48);
            btnUpdatePeople.TabIndex = 69;
            btnUpdatePeople.Text = "Actualizar datos persona";
            btnUpdatePeople.UseVisualStyleBackColor = true;
            btnUpdatePeople.Click += btnUpdatePeople_Click;
            // 
            // btnCreatePeople
            // 
            btnCreatePeople.Location = new Point(1159, 453);
            btnCreatePeople.Name = "btnCreatePeople";
            btnCreatePeople.Size = new Size(121, 48);
            btnCreatePeople.TabIndex = 68;
            btnCreatePeople.Text = "Guardar nueva persona";
            btnCreatePeople.UseVisualStyleBackColor = true;
            btnCreatePeople.Click += btnCreatePeople_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlLightLight;
            btnBack.Location = new Point(977, 453);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(121, 48);
            btnBack.TabIndex = 67;
            btnBack.Text = "Atras";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lbPeoplePersonType
            // 
            lbPeoplePersonType.AutoSize = true;
            lbPeoplePersonType.Location = new Point(939, 402);
            lbPeoplePersonType.Name = "lbPeoplePersonType";
            lbPeoplePersonType.Size = new Size(139, 20);
            lbPeoplePersonType.TabIndex = 89;
            lbPeoplePersonType.Text = "Rol en la institucion";
            // 
            // txtPeopleFileId
            // 
            txtPeopleFileId.Location = new Point(1438, 135);
            txtPeopleFileId.Name = "txtPeopleFileId";
            txtPeopleFileId.Size = new Size(87, 27);
            txtPeopleFileId.TabIndex = 88;
            // 
            // lbPeopleFileId
            // 
            lbPeopleFileId.AutoSize = true;
            lbPeopleFileId.Location = new Point(1358, 138);
            lbPeopleFileId.Name = "lbPeopleFileId";
            lbPeopleFileId.Size = new Size(54, 20);
            lbPeopleFileId.TabIndex = 87;
            lbPeopleFileId.Text = "Legajo";
            // 
            // lbPeopleBirthDate
            // 
            lbPeopleBirthDate.AutoSize = true;
            lbPeopleBirthDate.Location = new Point(939, 267);
            lbPeopleBirthDate.Name = "lbPeopleBirthDate";
            lbPeopleBirthDate.Size = new Size(146, 20);
            lbPeopleBirthDate.TabIndex = 85;
            lbPeopleBirthDate.Text = "Fecha de nacimiento";
            // 
            // txtPeopleTelephone
            // 
            txtPeopleTelephone.Location = new Point(1062, 352);
            txtPeopleTelephone.Name = "txtPeopleTelephone";
            txtPeopleTelephone.Size = new Size(124, 27);
            txtPeopleTelephone.TabIndex = 84;
            // 
            // lbPeopleTelephone
            // 
            lbPeopleTelephone.AutoSize = true;
            lbPeopleTelephone.Location = new Point(939, 355);
            lbPeopleTelephone.Name = "lbPeopleTelephone";
            lbPeopleTelephone.Size = new Size(67, 20);
            lbPeopleTelephone.TabIndex = 83;
            lbPeopleTelephone.Text = "Telefono";
            // 
            // dtpPeopleBirthDate
            // 
            dtpPeopleBirthDate.Location = new Point(1091, 262);
            dtpPeopleBirthDate.Name = "dtpPeopleBirthDate";
            dtpPeopleBirthDate.Size = new Size(283, 27);
            dtpPeopleBirthDate.TabIndex = 91;
            // 
            // btnDeletePerson
            // 
            btnDeletePerson.Location = new Point(1528, 453);
            btnDeletePerson.Name = "btnDeletePerson";
            btnDeletePerson.Size = new Size(121, 48);
            btnDeletePerson.TabIndex = 92;
            btnDeletePerson.Text = "Eliminar persona";
            btnDeletePerson.UseVisualStyleBackColor = true;
            btnDeletePerson.Click += btnDeletePerson_Click;
            // 
            // lbIdPerson
            // 
            lbIdPerson.AutoSize = true;
            lbIdPerson.Location = new Point(939, 145);
            lbIdPerson.Name = "lbIdPerson";
            lbIdPerson.Size = new Size(73, 20);
            lbIdPerson.TabIndex = 93;
            lbIdPerson.Text = "IdPersona";
            // 
            // txtIdPerson
            // 
            txtIdPerson.Location = new Point(1062, 138);
            txtIdPerson.Name = "txtIdPerson";
            txtIdPerson.Size = new Size(124, 27);
            txtIdPerson.TabIndex = 94;
            // 
            // cboxTypePerson
            // 
            cboxTypePerson.FormattingEnabled = true;
            cboxTypePerson.Items.AddRange(new object[] { "1", "2" });
            cboxTypePerson.Location = new Point(1084, 399);
            cboxTypePerson.Name = "cboxTypePerson";
            cboxTypePerson.Size = new Size(72, 28);
            cboxTypePerson.TabIndex = 95;
            // 
            // cBoxIdPlan
            // 
            cBoxIdPlan.FormattingEnabled = true;
            cBoxIdPlan.Location = new Point(1438, 218);
            cBoxIdPlan.Name = "cBoxIdPlan";
            cBoxIdPlan.Size = new Size(87, 28);
            cBoxIdPlan.TabIndex = 96;
            // 
            // frmPeople
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1726, 766);
            Controls.Add(cBoxIdPlan);
            Controls.Add(cboxTypePerson);
            Controls.Add(txtIdPerson);
            Controls.Add(lbIdPerson);
            Controls.Add(btnDeletePerson);
            Controls.Add(dtpPeopleBirthDate);
            Controls.Add(lbPeoplePersonType);
            Controls.Add(txtPeopleFileId);
            Controls.Add(lbPeopleFileId);
            Controls.Add(lbPeopleBirthDate);
            Controls.Add(txtPeopleTelephone);
            Controls.Add(lbPeopleTelephone);
            Controls.Add(lbPeopleIdPlan);
            Controls.Add(txtPeopleEmail);
            Controls.Add(lbPeopleEmail);
            Controls.Add(txtPeopleAddress);
            Controls.Add(lbPeopleAddress);
            Controls.Add(txtPeopleSurname);
            Controls.Add(lbPeopleSurname);
            Controls.Add(txtPeopleName);
            Controls.Add(lbPeopleName);
            Controls.Add(lbCreateUpdatePeople);
            Controls.Add(dgvPeople);
            Controls.Add(btnUpdatePeople);
            Controls.Add(btnCreatePeople);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPeople";
            Text = "Crear o actualizar persona";
            Load += frmPeople_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbPeopleIdPlan;
        private TextBox txtPeopleEmail;
        private Label lbPeopleEmail;
        private TextBox txtPeopleAddress;
        private Label lbPeopleAddress;
        private TextBox txtPeopleSurname;
        private Label lbPeopleSurname;
        private TextBox txtPeopleName;
        private Label lbPeopleName;
        private Label lbCreateUpdatePeople;
        private DataGridView dgvPeople;
        private Button btnUpdatePeople;
        private Button btnCreatePeople;
        private Button btnBack;
        private TextBox txtPeoplePersonType;
        private Label lbPeoplePersonType;
        private TextBox txtPeopleFileId;
        private Label lbPeopleFileId;
        private Label lbPeopleBirthDate;
        private TextBox txtPeopleTelephone;
        private Label lbPeopleTelephone;
        private DateTimePicker dtpPeopleBirthDate;
        private Button btnDeletePerson;
        private Label lbIdPerson;
        private TextBox txtIdPerson;
        private ComboBox cboxTypePerson;
        private ComboBox cBoxIdPlan;
    }
}