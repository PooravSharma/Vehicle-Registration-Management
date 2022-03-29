
namespace Assessment_3
{
    partial class Vehicle_Registration_Management
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.button_Open = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button_Enter = new System.Windows.Forms.Button();
            this.button_Leave = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Tag = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_LinearSearch = new System.Windows.Forms.Button();
            this.button_BinarySearch = new System.Windows.Forms.Button();
            this.StripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.DeleteTip = new System.Windows.Forms.ToolTip(this.components);
            this.EnterTip = new System.Windows.Forms.ToolTip(this.components);
            this.EditlTip = new System.Windows.Forms.ToolTip(this.components);
            this.TagTip = new System.Windows.Forms.ToolTip(this.components);
            this.ResetTip = new System.Windows.Forms.ToolTip(this.components);
            this.TextBoxTip = new System.Windows.Forms.ToolTip(this.components);
            this.ListBoxTip = new System.Windows.Forms.ToolTip(this.components);
            this.OpenTip = new System.Windows.Forms.ToolTip(this.components);
            this.SaveTip = new System.Windows.Forms.ToolTip(this.components);
            this.LinearTip = new System.Windows.Forms.ToolTip(this.components);
            this.BinaryTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(237, 303);
            this.listBox.TabIndex = 0;
            this.ListBoxTip.SetToolTip(this.listBox, "Displays the plates ");
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            this.listBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(398, 55);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(111, 34);
            this.button_Open.TabIndex = 2;
            this.button_Open.Text = "Open";
            this.OpenTip.SetToolTip(this.button_Open, "Click to open text file");
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(265, 12);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(241, 20);
            this.textBox.TabIndex = 3;
            this.TextBoxTip.SetToolTip(this.textBox, "Click to type ");
         
            // 
            // button_Enter
            // 
            this.button_Enter.Location = new System.Drawing.Point(266, 58);
            this.button_Enter.Name = "button_Enter";
            this.button_Enter.Size = new System.Drawing.Size(111, 28);
            this.button_Enter.TabIndex = 4;
            this.button_Enter.Text = "Enter";
            this.EnterTip.SetToolTip(this.button_Enter, "Click to add a rego plate to the List");
            this.button_Enter.UseVisualStyleBackColor = true;
            this.button_Enter.Click += new System.EventHandler(this.button_Enter_Click);
            // 
            // button_Leave
            // 
            this.button_Leave.Location = new System.Drawing.Point(264, 106);
            this.button_Leave.Name = "button_Leave";
            this.button_Leave.Size = new System.Drawing.Size(113, 31);
            this.button_Leave.TabIndex = 5;
            this.button_Leave.Text = "Delete";
            this.DeleteTip.SetToolTip(this.button_Leave, "Click to remove rego plate");
            this.button_Leave.UseVisualStyleBackColor = true;
            this.button_Leave.Click += new System.EventHandler(this.button_Leave_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(265, 158);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(112, 31);
            this.button_Edit.TabIndex = 6;
            this.button_Edit.Text = "Edit";
            this.EditlTip.SetToolTip(this.button_Edit, "Click to edit a rego plate");
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Tag
            // 
            this.button_Tag.Location = new System.Drawing.Point(265, 211);
            this.button_Tag.Name = "button_Tag";
            this.button_Tag.Size = new System.Drawing.Size(111, 34);
            this.button_Tag.TabIndex = 7;
            this.button_Tag.Text = "Tag";
            this.TagTip.SetToolTip(this.button_Tag, "Click to tag plates from list");
            this.button_Tag.UseVisualStyleBackColor = true;
            this.button_Tag.Click += new System.EventHandler(this.button_Tag_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.Color.Red;
            this.button_Reset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Reset.Location = new System.Drawing.Point(265, 277);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(111, 38);
            this.button_Reset.TabIndex = 8;
            this.button_Reset.Text = "Reset";
            this.ResetTip.SetToolTip(this.button_Reset, "Removes everythings from List ");
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(397, 106);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(111, 34);
            this.button_Save.TabIndex = 9;
            this.button_Save.Text = "Save";
            this.SaveTip.SetToolTip(this.button_Save, "Click to save list into a textbox");
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_LinearSearch
            // 
            this.button_LinearSearch.Location = new System.Drawing.Point(397, 158);
            this.button_LinearSearch.Name = "button_LinearSearch";
            this.button_LinearSearch.Size = new System.Drawing.Size(112, 31);
            this.button_LinearSearch.TabIndex = 10;
            this.button_LinearSearch.Text = "Linear Search";
            this.LinearTip.SetToolTip(this.button_LinearSearch, "Click to liner search");
            this.button_LinearSearch.UseVisualStyleBackColor = true;
            this.button_LinearSearch.Click += new System.EventHandler(this.button_LinearSearch_Click);
            // 
            // button_BinarySearch
            // 
            this.button_BinarySearch.Location = new System.Drawing.Point(398, 211);
            this.button_BinarySearch.Name = "button_BinarySearch";
            this.button_BinarySearch.Size = new System.Drawing.Size(111, 34);
            this.button_BinarySearch.TabIndex = 11;
            this.button_BinarySearch.Text = "Binary Search";
            this.BinaryTip.SetToolTip(this.button_BinarySearch, "Click to binary search");
            this.button_BinarySearch.UseVisualStyleBackColor = true;
            this.button_BinarySearch.Click += new System.EventHandler(this.button_BinarySearch_Click);
            // 
            // StripStatus
            // 
            this.StripStatus.Name = "StripStatus";
            this.StripStatus.Size = new System.Drawing.Size(63, 17);
            this.StripStatus.Text = "StatusStrip";
            this.StripStatus.Click += new System.EventHandler(this.Vehicle_Registration_Management_Load);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 334);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(518, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // DeleteTip
            // 
            this.DeleteTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // EnterTip
            // 
            this.EnterTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // EditlTip
            // 
            this.EditlTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // TagTip
            // 
            this.TagTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ResetTip
            // 
            this.ResetTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // TextBoxTip
            // 
            this.TextBoxTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ListBoxTip
            // 
            this.ListBoxTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // OpenTip
            // 
            this.OpenTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // SaveTip
            // 
            this.SaveTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // LinearTip
            // 
            this.LinearTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // BinaryTip
            // 
            this.BinaryTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Vehicle_Registration_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 356);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_BinarySearch);
            this.Controls.Add(this.button_LinearSearch);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Tag);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_Leave);
            this.Controls.Add(this.button_Enter);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.listBox);
            this.Name = "Vehicle_Registration_Management";
            this.Text = "Vehicle Registration Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Vehicle_Registration_Management_FormClosed);
            this.Load += new System.EventHandler(this.Vehicle_Registration_Management_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button_Enter;
        private System.Windows.Forms.Button button_Leave;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Tag;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_LinearSearch;
        private System.Windows.Forms.Button button_BinarySearch;
        private System.Windows.Forms.ToolStripStatusLabel StripStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolTip DeleteTip;
        private System.Windows.Forms.ToolTip EnterTip;
        private System.Windows.Forms.ToolTip EditlTip;
        private System.Windows.Forms.ToolTip TagTip;
        private System.Windows.Forms.ToolTip ResetTip;
        private System.Windows.Forms.ToolTip TextBoxTip;
        private System.Windows.Forms.ToolTip ListBoxTip;
        private System.Windows.Forms.ToolTip OpenTip;
        private System.Windows.Forms.ToolTip SaveTip;
        private System.Windows.Forms.ToolTip LinearTip;
        private System.Windows.Forms.ToolTip BinaryTip;
    }
}

