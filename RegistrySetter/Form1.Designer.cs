namespace RegistrySetter
{
    partial class Form1
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
            this.btnSetRegistry = new System.Windows.Forms.Button();
            this.cboSelectList = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSetRegistry
            // 
            this.btnSetRegistry.Location = new System.Drawing.Point(438, 256);
            this.btnSetRegistry.Name = "btnSetRegistry";
            this.btnSetRegistry.Size = new System.Drawing.Size(167, 79);
            this.btnSetRegistry.TabIndex = 0;
            this.btnSetRegistry.Text = "button1";
            this.btnSetRegistry.UseVisualStyleBackColor = true;
            this.btnSetRegistry.Click += new System.EventHandler(this.btnSetRegistry_Click);
            // 
            // cboSelectList
            // 
            this.cboSelectList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectList.FormattingEnabled = true;
            this.cboSelectList.Items.AddRange(new object[] {
            "One Item",
            "Another Item",
            "Third"});
            this.cboSelectList.Location = new System.Drawing.Point(452, 115);
            this.cboSelectList.Name = "cboSelectList";
            this.cboSelectList.Size = new System.Drawing.Size(230, 28);
            this.cboSelectList.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(80, 172);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 20);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cboSelectList);
            this.Controls.Add(this.btnSetRegistry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetRegistry;
        private System.Windows.Forms.ComboBox cboSelectList;
        private System.Windows.Forms.Label lblStatus;
    }
}

