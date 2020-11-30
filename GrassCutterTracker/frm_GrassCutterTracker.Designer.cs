namespace GrassCutterTracker
{
    partial class frm_GrassCutterTracker
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GrassCutterTracker));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddItem = new System.Windows.Forms.Button();
            this.dgv_Items = new System.Windows.Forms.DataGridView();
            this.btn_EditItem = new System.Windows.Forms.Button();
            this.btn_DeleteItem = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.cbo_Sort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_SaveAs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Items)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grass Cutter Tracker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.Location = new System.Drawing.Point(39, 341);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(75, 23);
            this.btn_AddItem.TabIndex = 1;
            this.btn_AddItem.Text = "Add Item";
            this.btn_AddItem.UseVisualStyleBackColor = true;
            this.btn_AddItem.Click += new System.EventHandler(this.btn_AddItem_Click);
            // 
            // dgv_Items
            // 
            this.dgv_Items.AllowUserToAddRows = false;
            this.dgv_Items.AllowUserToDeleteRows = false;
            this.dgv_Items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Items.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgv_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Items.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Items.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_Items.Location = new System.Drawing.Point(39, 137);
            this.dgv_Items.MultiSelect = false;
            this.dgv_Items.Name = "dgv_Items";
            this.dgv_Items.ReadOnly = true;
            this.dgv_Items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Items.Size = new System.Drawing.Size(489, 198);
            this.dgv_Items.TabIndex = 2;
            this.dgv_Items.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Items_CellFormatting);
            this.dgv_Items.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_Items_MouseDoubleClick);
            // 
            // btn_EditItem
            // 
            this.btn_EditItem.Location = new System.Drawing.Point(120, 341);
            this.btn_EditItem.Name = "btn_EditItem";
            this.btn_EditItem.Size = new System.Drawing.Size(75, 23);
            this.btn_EditItem.TabIndex = 3;
            this.btn_EditItem.Text = "Edit Item";
            this.btn_EditItem.UseVisualStyleBackColor = true;
            this.btn_EditItem.Click += new System.EventHandler(this.btn_EditItem_Click);
            // 
            // btn_DeleteItem
            // 
            this.btn_DeleteItem.Location = new System.Drawing.Point(204, 341);
            this.btn_DeleteItem.Name = "btn_DeleteItem";
            this.btn_DeleteItem.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteItem.TabIndex = 4;
            this.btn_DeleteItem.Text = "Delete Item";
            this.btn_DeleteItem.UseVisualStyleBackColor = true;
            this.btn_DeleteItem.Click += new System.EventHandler(this.btn_DeleteItem_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(453, 370);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // cbo_Sort
            // 
            this.cbo_Sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Sort.FormattingEnabled = true;
            this.cbo_Sort.Location = new System.Drawing.Point(407, 110);
            this.cbo_Sort.Name = "cbo_Sort";
            this.cbo_Sort.Size = new System.Drawing.Size(121, 21);
            this.cbo_Sort.TabIndex = 6;
            this.cbo_Sort.SelectedIndexChanged += new System.EventHandler(this.cbo_Sort_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sort By:";
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(453, 341);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(75, 23);
            this.btn_Load.TabIndex = 8;
            this.btn_Load.Text = "Load File";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_SaveAs
            // 
            this.btn_SaveAs.Location = new System.Drawing.Point(372, 341);
            this.btn_SaveAs.Name = "btn_SaveAs";
            this.btn_SaveAs.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveAs.TabIndex = 8;
            this.btn_SaveAs.Text = "Save As";
            this.btn_SaveAs.UseVisualStyleBackColor = true;
            this.btn_SaveAs.Click += new System.EventHandler(this.btn_SaveAs_Click);
            // 
            // frm_GrassCutterTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 423);
            this.Controls.Add(this.btn_SaveAs);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_Sort);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_DeleteItem);
            this.Controls.Add(this.btn_EditItem);
            this.Controls.Add(this.dgv_Items);
            this.Controls.Add(this.btn_AddItem);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_GrassCutterTracker";
            this.Text = "Grass Cutter Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_GrassCutterTracker_FormClosing);
            this.Load += new System.EventHandler(this.frm_GrassCutterTracker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Items)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddItem;
        private System.Windows.Forms.DataGridView dgv_Items;
        private System.Windows.Forms.Button btn_EditItem;
        private System.Windows.Forms.Button btn_DeleteItem;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.ComboBox cbo_Sort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_SaveAs;
    }
}