namespace NetAssistTool.UI
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.hostnameLabel = new System.Windows.Forms.Label();
            this.hostnameTextBox = new System.Windows.Forms.TextBox();
            this.timedoutTextBox = new System.Windows.Forms.TextBox();
            this.timedoutLabel = new System.Windows.Forms.Label();
            this.hopsTextBox = new System.Windows.Forms.TextBox();
            this.hopsLabel = new System.Windows.Forms.Label();
            this.hostnameListLabel = new System.Windows.Forms.Label();
            this.hostnameListBox = new System.Windows.Forms.ListBox();
            this.addHostnameButton = new System.Windows.Forms.Button();
            this.hostnameListTextBox = new System.Windows.Forms.TextBox();
            this.delHostnameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(193, 327);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "&Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(112, 327);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "&Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // hostnameLabel
            // 
            this.hostnameLabel.AutoSize = true;
            this.hostnameLabel.Location = new System.Drawing.Point(12, 29);
            this.hostnameLabel.Name = "hostnameLabel";
            this.hostnameLabel.Size = new System.Drawing.Size(90, 13);
            this.hostnameLabel.TabIndex = 2;
            this.hostnameLabel.Text = "Hostname (Local)";
            // 
            // hostnameTextBox
            // 
            this.hostnameTextBox.Location = new System.Drawing.Point(108, 22);
            this.hostnameTextBox.Name = "hostnameTextBox";
            this.hostnameTextBox.Size = new System.Drawing.Size(157, 20);
            this.hostnameTextBox.TabIndex = 3;
            // 
            // timedoutTextBox
            // 
            this.timedoutTextBox.Location = new System.Drawing.Point(108, 55);
            this.timedoutTextBox.Name = "timedoutTextBox";
            this.timedoutTextBox.Size = new System.Drawing.Size(157, 20);
            this.timedoutTextBox.TabIndex = 5;
            // 
            // timedoutLabel
            // 
            this.timedoutLabel.AutoSize = true;
            this.timedoutLabel.Location = new System.Drawing.Point(12, 58);
            this.timedoutLabel.Name = "timedoutLabel";
            this.timedoutLabel.Size = new System.Drawing.Size(67, 13);
            this.timedoutLabel.TabIndex = 4;
            this.timedoutLabel.Text = "Timeout (ms)";
            // 
            // hopsTextBox
            // 
            this.hopsTextBox.Location = new System.Drawing.Point(108, 91);
            this.hopsTextBox.Name = "hopsTextBox";
            this.hopsTextBox.Size = new System.Drawing.Size(157, 20);
            this.hopsTextBox.TabIndex = 7;
            // 
            // hopsLabel
            // 
            this.hopsLabel.AutoSize = true;
            this.hopsLabel.Location = new System.Drawing.Point(12, 94);
            this.hopsLabel.Name = "hopsLabel";
            this.hopsLabel.Size = new System.Drawing.Size(87, 13);
            this.hopsLabel.TabIndex = 6;
            this.hopsLabel.Text = "# de solicitações";
            // 
            // hostnameListLabel
            // 
            this.hostnameListLabel.AutoSize = true;
            this.hostnameListLabel.Location = new System.Drawing.Point(12, 127);
            this.hostnameListLabel.Name = "hostnameListLabel";
            this.hostnameListLabel.Size = new System.Drawing.Size(136, 13);
            this.hostnameListLabel.TabIndex = 8;
            this.hostnameListLabel.Text = "Lista de hostname externos";
            // 
            // hostnameListBox
            // 
            this.hostnameListBox.FormattingEnabled = true;
            this.hostnameListBox.Location = new System.Drawing.Point(12, 176);
            this.hostnameListBox.Name = "hostnameListBox";
            this.hostnameListBox.Size = new System.Drawing.Size(256, 82);
            this.hostnameListBox.TabIndex = 9;
            // 
            // addHostnameButton
            // 
            this.addHostnameButton.Location = new System.Drawing.Point(193, 147);
            this.addHostnameButton.Name = "addHostnameButton";
            this.addHostnameButton.Size = new System.Drawing.Size(75, 23);
            this.addHostnameButton.TabIndex = 10;
            this.addHostnameButton.Text = "Add";
            this.addHostnameButton.UseVisualStyleBackColor = true;
            this.addHostnameButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // hostnameListTextBox
            // 
            this.hostnameListTextBox.Location = new System.Drawing.Point(12, 149);
            this.hostnameListTextBox.Name = "hostnameListTextBox";
            this.hostnameListTextBox.Size = new System.Drawing.Size(163, 20);
            this.hostnameListTextBox.TabIndex = 11;
            // 
            // delHostnameButton
            // 
            this.delHostnameButton.Location = new System.Drawing.Point(193, 264);
            this.delHostnameButton.Name = "delHostnameButton";
            this.delHostnameButton.Size = new System.Drawing.Size(75, 23);
            this.delHostnameButton.TabIndex = 12;
            this.delHostnameButton.Text = "Remover";
            this.delHostnameButton.UseVisualStyleBackColor = true;
            this.delHostnameButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // ConfigForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(284, 359);
            this.Controls.Add(this.delHostnameButton);
            this.Controls.Add(this.hostnameListTextBox);
            this.Controls.Add(this.addHostnameButton);
            this.Controls.Add(this.hostnameListBox);
            this.Controls.Add(this.hostnameListLabel);
            this.Controls.Add(this.hopsTextBox);
            this.Controls.Add(this.hopsLabel);
            this.Controls.Add(this.timedoutTextBox);
            this.Controls.Add(this.timedoutLabel);
            this.Controls.Add(this.hostnameTextBox);
            this.Controls.Add(this.hostnameLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.Shown += new System.EventHandler(this.ConfigForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label hostnameLabel;
        private System.Windows.Forms.TextBox hostnameTextBox;
        private System.Windows.Forms.TextBox timedoutTextBox;
        private System.Windows.Forms.Label timedoutLabel;
        private System.Windows.Forms.TextBox hopsTextBox;
        private System.Windows.Forms.Label hopsLabel;
        private System.Windows.Forms.Label hostnameListLabel;
        private System.Windows.Forms.ListBox hostnameListBox;
        private System.Windows.Forms.Button addHostnameButton;
        private System.Windows.Forms.TextBox hostnameListTextBox;
        private System.Windows.Forms.Button delHostnameButton;
    }
}