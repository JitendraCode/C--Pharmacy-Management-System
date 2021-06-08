namespace finalblackbook
{
    partial class usersoforg
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label userIdLabel;
            System.Windows.Forms.Label name_Of_UserLabel;
            System.Windows.Forms.Label time_DurationLabel;
            System.Windows.Forms.Label service_ChargesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usersoforg));
            this.pharmacyDataSet5 = new finalblackbook.pharmacyDataSet5();
            this.usersorgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersorgTableAdapter = new finalblackbook.pharmacyDataSet5TableAdapters.usersorgTableAdapter();
            this.tableAdapterManager = new finalblackbook.pharmacyDataSet5TableAdapters.TableAdapterManager();
            this.usersorgBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.usersorgBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txttimeduration = new System.Windows.Forms.TextBox();
            this.txtservice = new System.Windows.Forms.TextBox();
            this.usersorgDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            userIdLabel = new System.Windows.Forms.Label();
            name_Of_UserLabel = new System.Windows.Forms.Label();
            time_DurationLabel = new System.Windows.Forms.Label();
            service_ChargesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersorgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersorgBindingNavigator)).BeginInit();
            this.usersorgBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersorgDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userIdLabel.Location = new System.Drawing.Point(74, 29);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new System.Drawing.Size(67, 18);
            userIdLabel.TabIndex = 1;
            userIdLabel.Text = "User Id:";
            // 
            // name_Of_UserLabel
            // 
            name_Of_UserLabel.AutoSize = true;
            name_Of_UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            name_Of_UserLabel.Location = new System.Drawing.Point(74, 92);
            name_Of_UserLabel.Name = "name_Of_UserLabel";
            name_Of_UserLabel.Size = new System.Drawing.Size(121, 18);
            name_Of_UserLabel.TabIndex = 3;
            name_Of_UserLabel.Text = "Name Of User:";
            // 
            // time_DurationLabel
            // 
            time_DurationLabel.AutoSize = true;
            time_DurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            time_DurationLabel.Location = new System.Drawing.Point(341, 26);
            time_DurationLabel.Name = "time_DurationLabel";
            time_DurationLabel.Size = new System.Drawing.Size(119, 18);
            time_DurationLabel.TabIndex = 5;
            time_DurationLabel.Text = "Time Duration:";
            // 
            // service_ChargesLabel
            // 
            service_ChargesLabel.AutoSize = true;
            service_ChargesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            service_ChargesLabel.Location = new System.Drawing.Point(341, 92);
            service_ChargesLabel.Name = "service_ChargesLabel";
            service_ChargesLabel.Size = new System.Drawing.Size(137, 18);
            service_ChargesLabel.TabIndex = 7;
            service_ChargesLabel.Text = "Service Charges:";
            // 
            // pharmacyDataSet5
            // 
            this.pharmacyDataSet5.DataSetName = "pharmacyDataSet5";
            this.pharmacyDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersorgBindingSource
            // 
            this.usersorgBindingSource.DataMember = "usersorg";
            this.usersorgBindingSource.DataSource = this.pharmacyDataSet5;
            // 
            // usersorgTableAdapter
            // 
            this.usersorgTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = finalblackbook.pharmacyDataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersorgTableAdapter = this.usersorgTableAdapter;
            // 
            // usersorgBindingNavigator
            // 
            this.usersorgBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.usersorgBindingNavigator.BindingSource = this.usersorgBindingSource;
            this.usersorgBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.usersorgBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.usersorgBindingNavigator.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersorgBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.usersorgBindingNavigatorSaveItem});
            this.usersorgBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usersorgBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.usersorgBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.usersorgBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.usersorgBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.usersorgBindingNavigator.Name = "usersorgBindingNavigator";
            this.usersorgBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.usersorgBindingNavigator.Size = new System.Drawing.Size(662, 25);
            this.usersorgBindingNavigator.TabIndex = 0;
            this.usersorgBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(49, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // usersorgBindingNavigatorSaveItem
            // 
            this.usersorgBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usersorgBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usersorgBindingNavigatorSaveItem.Image")));
            this.usersorgBindingNavigatorSaveItem.Name = "usersorgBindingNavigatorSaveItem";
            this.usersorgBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.usersorgBindingNavigatorSaveItem.Text = "Save Data";
            this.usersorgBindingNavigatorSaveItem.Click += new System.EventHandler(this.usersorgBindingNavigatorSaveItem_Click);
            // 
            // txtid
            // 
            this.txtid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersorgBindingSource, "UserId", true));
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(206, 26);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 24);
            this.txtid.TabIndex = 2;
            this.txtid.Validating += new System.ComponentModel.CancelEventHandler(this.txtid_Validating);
            // 
            // txtuser
            // 
            this.txtuser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersorgBindingSource, "Name_Of_User", true));
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(206, 89);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(100, 24);
            this.txtuser.TabIndex = 4;
            // 
            // txttimeduration
            // 
            this.txttimeduration.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersorgBindingSource, "Time_Duration", true));
            this.txttimeduration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimeduration.Location = new System.Drawing.Point(484, 26);
            this.txttimeduration.Name = "txttimeduration";
            this.txttimeduration.Size = new System.Drawing.Size(100, 24);
            this.txttimeduration.TabIndex = 6;
            // 
            // txtservice
            // 
            this.txtservice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersorgBindingSource, "Service_Charges", true));
            this.txtservice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtservice.Location = new System.Drawing.Point(484, 92);
            this.txtservice.Name = "txtservice";
            this.txtservice.Size = new System.Drawing.Size(100, 24);
            this.txtservice.TabIndex = 8;
            // 
            // usersorgDataGridView
            // 
            this.usersorgDataGridView.AutoGenerateColumns = false;
            this.usersorgDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersorgDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.usersorgDataGridView.DataSource = this.usersorgBindingSource;
            this.usersorgDataGridView.Location = new System.Drawing.Point(93, 214);
            this.usersorgDataGridView.Name = "usersorgDataGridView";
            this.usersorgDataGridView.Size = new System.Drawing.Size(442, 220);
            this.usersorgDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UserId";
            this.dataGridViewTextBoxColumn1.HeaderText = "UserId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name_Of_User";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name_Of_User";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Time_Duration";
            this.dataGridViewTextBoxColumn3.HeaderText = "Time_Duration";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Service_Charges";
            this.dataGridViewTextBoxColumn4.HeaderText = "Service_Charges";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(29, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(141, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Search User";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(303, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Delete User";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(429, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 26);
            this.button4.TabIndex = 72;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(541, 160);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 26);
            this.button5.TabIndex = 73;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // usersoforg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(662, 458);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usersorgDataGridView);
            this.Controls.Add(userIdLabel);
            this.Controls.Add(this.txtid);
            this.Controls.Add(name_Of_UserLabel);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(time_DurationLabel);
            this.Controls.Add(this.txttimeduration);
            this.Controls.Add(service_ChargesLabel);
            this.Controls.Add(this.txtservice);
            this.Controls.Add(this.usersorgBindingNavigator);
            this.Name = "usersoforg";
            this.Text = "usersoforg";
            this.Load += new System.EventHandler(this.usersoforg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersorgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersorgBindingNavigator)).EndInit();
            this.usersorgBindingNavigator.ResumeLayout(false);
            this.usersorgBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersorgDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pharmacyDataSet5 pharmacyDataSet5;
        private System.Windows.Forms.BindingSource usersorgBindingSource;
        private pharmacyDataSet5TableAdapters.usersorgTableAdapter usersorgTableAdapter;
        private pharmacyDataSet5TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator usersorgBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton usersorgBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txttimeduration;
        private System.Windows.Forms.TextBox txtservice;
        private System.Windows.Forms.DataGridView usersorgDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}