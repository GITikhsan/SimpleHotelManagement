namespace SimpleHotelManagement.View
{
    partial class UserControlGuest
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlClient = new System.Windows.Forms.TabControl();
            this.tabPageAddGuest = new System.Windows.Forms.TabPage();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchGuest = new System.Windows.Forms.TabPage();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.textBoxSearchPhoneNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageUpdateAndDeleteGuest = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxClientID1 = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxAddress1 = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNo1 = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxLastName1 = new System.Windows.Forms.TextBox();
            this.textBoxFirstName1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlClient.SuspendLayout();
            this.tabPageAddGuest.SuspendLayout();
            this.tabPageSearchGuest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.tabPageUpdateAndDeleteGuest.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlClient
            // 
            this.tabControlClient.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlClient.Controls.Add(this.tabPageAddGuest);
            this.tabControlClient.Controls.Add(this.tabPageSearchGuest);
            this.tabControlClient.Controls.Add(this.tabPageUpdateAndDeleteGuest);
            this.tabControlClient.Location = new System.Drawing.Point(16, 24);
            this.tabControlClient.Name = "tabControlClient";
            this.tabControlClient.SelectedIndex = 0;
            this.tabControlClient.Size = new System.Drawing.Size(1065, 412);
            this.tabControlClient.TabIndex = 1;
            this.tabControlClient.SelectedIndexChanged += new System.EventHandler(this.tabControlClient_SelectedIndexChanged);
            // 
            // tabPageAddGuest
            // 
            this.tabPageAddGuest.Controls.Add(this.textBoxClientID);
            this.tabPageAddGuest.Controls.Add(this.label13);
            this.tabPageAddGuest.Controls.Add(this.textBoxAddress);
            this.tabPageAddGuest.Controls.Add(this.label5);
            this.tabPageAddGuest.Controls.Add(this.textBoxPhoneNo);
            this.tabPageAddGuest.Controls.Add(this.label4);
            this.tabPageAddGuest.Controls.Add(this.buttonAdd);
            this.tabPageAddGuest.Controls.Add(this.textBoxLastName);
            this.tabPageAddGuest.Controls.Add(this.label3);
            this.tabPageAddGuest.Controls.Add(this.textBoxFirstName);
            this.tabPageAddGuest.Controls.Add(this.label2);
            this.tabPageAddGuest.Controls.Add(this.label1);
            this.tabPageAddGuest.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddGuest.Name = "tabPageAddGuest";
            this.tabPageAddGuest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddGuest.Size = new System.Drawing.Size(1057, 378);
            this.tabPageAddGuest.TabIndex = 0;
            this.tabPageAddGuest.Text = "Add a guest";
            this.tabPageAddGuest.UseVisualStyleBackColor = true;
            this.tabPageAddGuest.Click += new System.EventHandler(this.tabPageAddGuest_Click);
            this.tabPageAddGuest.Leave += new System.EventHandler(this.tabPageAddGuest_Leave);
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxClientID.Location = new System.Drawing.Point(588, 139);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(294, 28);
            this.textBoxClientID.TabIndex = 17;
            this.textBoxClientID.TextChanged += new System.EventHandler(this.textBoxClientID_TextChanged);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(584, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 19);
            this.label13.TabIndex = 16;
            this.label13.Text = "ID card number:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAddress.Location = new System.Drawing.Point(162, 217);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(720, 77);
            this.textBoxAddress.TabIndex = 15;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Address:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPhoneNo.Location = new System.Drawing.Point(162, 139);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(294, 28);
            this.textBoxPhoneNo.TabIndex = 13;
            this.textBoxPhoneNo.TextChanged += new System.EventHandler(this.textBoxPhoneNo_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Phone number:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(94)))), ((int)(((byte)(115)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(162, 309);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 40);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLastName.Location = new System.Drawing.Point(588, 50);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(294, 28);
            this.textBoxLastName.TabIndex = 10;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(584, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFirstName.Location = new System.Drawing.Point(162, 50);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(294, 28);
            this.textBoxFirstName.TabIndex = 8;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "First name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(94)))), ((int)(((byte)(115)))));
            this.label1.Location = new System.Drawing.Point(23, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add a guest";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPageSearchGuest
            // 
            this.tabPageSearchGuest.Controls.Add(this.dataGridViewClient);
            this.tabPageSearchGuest.Controls.Add(this.textBoxSearchPhoneNo);
            this.tabPageSearchGuest.Controls.Add(this.label6);
            this.tabPageSearchGuest.Controls.Add(this.label7);
            this.tabPageSearchGuest.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchGuest.Name = "tabPageSearchGuest";
            this.tabPageSearchGuest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchGuest.Size = new System.Drawing.Size(1057, 378);
            this.tabPageSearchGuest.TabIndex = 1;
            this.tabPageSearchGuest.Text = "Search for guest";
            this.tabPageSearchGuest.UseVisualStyleBackColor = true;
            this.tabPageSearchGuest.Click += new System.EventHandler(this.tabPageSearchGuest_Click);
            this.tabPageSearchGuest.Enter += new System.EventHandler(this.tabPageSearchGuest_Enter);
            this.tabPageSearchGuest.Leave += new System.EventHandler(this.tabPageSearchGuest_Leave);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.AllowUserToDeleteRows = false;
            this.dataGridViewClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewClient.Location = new System.Drawing.Point(41, 108);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            this.dataGridViewClient.RowHeadersWidth = 51;
            this.dataGridViewClient.RowTemplate.Height = 24;
            this.dataGridViewClient.Size = new System.Drawing.Size(973, 234);
            this.dataGridViewClient.TabIndex = 9;
            this.dataGridViewClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClient_CellContentClick);
            // 
            // textBoxSearchPhoneNo
            // 
            this.textBoxSearchPhoneNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchPhoneNo.Location = new System.Drawing.Point(190, 61);
            this.textBoxSearchPhoneNo.Name = "textBoxSearchPhoneNo";
            this.textBoxSearchPhoneNo.Size = new System.Drawing.Size(294, 28);
            this.textBoxSearchPhoneNo.TabIndex = 8;
            this.textBoxSearchPhoneNo.TextChanged += new System.EventHandler(this.textBoxSearchPhoneNo_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(186, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Phone number:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(94)))), ((int)(((byte)(115)))));
            this.label7.Location = new System.Drawing.Point(23, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Search for guest";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tabPageUpdateAndDeleteGuest
            // 
            this.tabPageUpdateAndDeleteGuest.Controls.Add(this.label14);
            this.tabPageUpdateAndDeleteGuest.Controls.Add(this.label10);
            this.tabPageUpdateAndDeleteGuest.Controls.Add(this.label11);
            this.tabPageUpdateAndDeleteGuest.Controls.Add(this.label8);
            this.tabPageUpdateAndDeleteGuest.Controls.Add(this.label9);
            this.tabPageUpdateAndDeleteGuest.Controls.Add(this.textBoxClientID1);
            this.tabPageUpdateAndDeleteGuest.Controls.Add(this.buttonDelete);
            this.tabPageUpdateAndDeleteGuest.Controls.Add(this.textBoxAddress1);
            this.tabPageUpdateAndDeleteGuest.Controls.Add(this.textBoxPhoneNo1);
            this.tabPageUpdateAndDeleteGuest.Controls.Add(this.buttonUpdate);
            this.tabPageUpdateAndDeleteGuest.Controls.Add(this.textBoxLastName1);
            this.tabPageUpdateAndDeleteGuest.Controls.Add(this.textBoxFirstName1);
            this.tabPageUpdateAndDeleteGuest.Controls.Add(this.label12);
            this.tabPageUpdateAndDeleteGuest.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateAndDeleteGuest.Name = "tabPageUpdateAndDeleteGuest";
            this.tabPageUpdateAndDeleteGuest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateAndDeleteGuest.Size = new System.Drawing.Size(1057, 378);
            this.tabPageUpdateAndDeleteGuest.TabIndex = 2;
            this.tabPageUpdateAndDeleteGuest.Text = "Update and delete";
            this.tabPageUpdateAndDeleteGuest.UseVisualStyleBackColor = true;
            this.tabPageUpdateAndDeleteGuest.Click += new System.EventHandler(this.tabPageUpdateAndDeleteGuest_Click);
            this.tabPageUpdateAndDeleteGuest.Leave += new System.EventHandler(this.tabPageUpdateAndDeleteGuest_Leave);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(151, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 19);
            this.label14.TabIndex = 33;
            this.label14.Text = "Address:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(577, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 19);
            this.label10.TabIndex = 32;
            this.label10.Text = "ID card number:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(151, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 19);
            this.label11.TabIndex = 31;
            this.label11.Text = "Phone number:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(577, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 19);
            this.label8.TabIndex = 30;
            this.label8.Text = "Last name:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(151, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 19);
            this.label9.TabIndex = 29;
            this.label9.Text = "First name:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBoxClientID1
            // 
            this.textBoxClientID1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxClientID1.Location = new System.Drawing.Point(581, 163);
            this.textBoxClientID1.Name = "textBoxClientID1";
            this.textBoxClientID1.Size = new System.Drawing.Size(294, 28);
            this.textBoxClientID1.TabIndex = 28;
            this.textBoxClientID1.TextChanged += new System.EventHandler(this.textBoxClientID1_TextChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(295, 333);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(110, 40);
            this.buttonDelete.TabIndex = 26;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxAddress1
            // 
            this.textBoxAddress1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAddress1.Location = new System.Drawing.Point(155, 241);
            this.textBoxAddress1.Multiline = true;
            this.textBoxAddress1.Name = "textBoxAddress1";
            this.textBoxAddress1.Size = new System.Drawing.Size(720, 77);
            this.textBoxAddress1.TabIndex = 25;
            this.textBoxAddress1.TextChanged += new System.EventHandler(this.textBoxAddress1_TextChanged);
            // 
            // textBoxPhoneNo1
            // 
            this.textBoxPhoneNo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPhoneNo1.Location = new System.Drawing.Point(155, 163);
            this.textBoxPhoneNo1.Name = "textBoxPhoneNo1";
            this.textBoxPhoneNo1.Size = new System.Drawing.Size(294, 28);
            this.textBoxPhoneNo1.TabIndex = 23;
            this.textBoxPhoneNo1.TextChanged += new System.EventHandler(this.textBoxPhoneNo1_TextChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(94)))), ((int)(((byte)(115)))));
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(155, 333);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(110, 40);
            this.buttonUpdate.TabIndex = 21;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxLastName1
            // 
            this.textBoxLastName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLastName1.Location = new System.Drawing.Point(581, 74);
            this.textBoxLastName1.Name = "textBoxLastName1";
            this.textBoxLastName1.Size = new System.Drawing.Size(294, 28);
            this.textBoxLastName1.TabIndex = 20;
            this.textBoxLastName1.TextChanged += new System.EventHandler(this.textBoxLastName1_TextChanged);
            // 
            // textBoxFirstName1
            // 
            this.textBoxFirstName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFirstName1.Location = new System.Drawing.Point(155, 74);
            this.textBoxFirstName1.Name = "textBoxFirstName1";
            this.textBoxFirstName1.Size = new System.Drawing.Size(294, 28);
            this.textBoxFirstName1.TabIndex = 18;
            this.textBoxFirstName1.TextChanged += new System.EventHandler(this.textBoxFirstName1_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(94)))), ((int)(((byte)(115)))));
            this.label12.Location = new System.Drawing.Point(23, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 22);
            this.label12.TabIndex = 16;
            this.label12.Text = "Update and delete guest";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "guest_id";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "first_name";
            this.Column2.HeaderText = "First Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "last_name";
            this.Column3.HeaderText = "Last Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "phone_number";
            this.Column4.HeaderText = "Phone Number";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "address\t";
            this.Column5.HeaderText = "Address";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ID_card_number";
            this.Column6.HeaderText = "ID Card Number";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // UserControlGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlClient);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlGuest";
            this.Size = new System.Drawing.Size(1102, 462);
            this.Load += new System.EventHandler(this.UserControlGuest_Load);
            this.tabControlClient.ResumeLayout(false);
            this.tabPageAddGuest.ResumeLayout(false);
            this.tabPageAddGuest.PerformLayout();
            this.tabPageSearchGuest.ResumeLayout(false);
            this.tabPageSearchGuest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.tabPageUpdateAndDeleteGuest.ResumeLayout(false);
            this.tabPageUpdateAndDeleteGuest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlClient;
        private System.Windows.Forms.TabPage tabPageAddGuest;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSearchGuest;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.TextBox textBoxSearchPhoneNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPageUpdateAndDeleteGuest;
        private System.Windows.Forms.TextBox textBoxClientID1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxAddress1;
        private System.Windows.Forms.TextBox textBoxPhoneNo1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxLastName1;
        private System.Windows.Forms.TextBox textBoxFirstName1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
