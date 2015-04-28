namespace NetAssistTool.UI
{
    partial class MainAppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAppForm));
            this.sysIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.quitMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.stopServiceButton = new System.Windows.Forms.Button();
            this.startServiceButton = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pararServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logTabControl = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.logMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitMenuStrip.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.logTabControl.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.logMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // sysIcon
            // 
            this.sysIcon.ContextMenuStrip = this.quitMenuStrip;
            this.sysIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("sysIcon.Icon")));
            this.sysIcon.Text = "Network Assist Server";
            this.sysIcon.Visible = true;
            this.sysIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.sysIcon_MouseDoubleClick);
            // 
            // quitMenuStrip
            // 
            this.quitMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem1});
            this.quitMenuStrip.Name = "quitMenuStrip";
            this.quitMenuStrip.Size = new System.Drawing.Size(94, 26);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem1.Text = "&Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // buttonPanel
            // 
            this.buttonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPanel.Controls.Add(this.stopServiceButton);
            this.buttonPanel.Controls.Add(this.startServiceButton);
            this.buttonPanel.Location = new System.Drawing.Point(513, 27);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(119, 49);
            this.buttonPanel.TabIndex = 4;
            // 
            // stopServiceButton
            // 
            this.stopServiceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.stopServiceButton.Enabled = false;
            this.stopServiceButton.Location = new System.Drawing.Point(0, 23);
            this.stopServiceButton.Name = "stopServiceButton";
            this.stopServiceButton.Size = new System.Drawing.Size(119, 23);
            this.stopServiceButton.TabIndex = 4;
            this.stopServiceButton.Text = "&Parar serviço";
            this.stopServiceButton.UseVisualStyleBackColor = true;
            this.stopServiceButton.Visible = false;
            this.stopServiceButton.Click += new System.EventHandler(this.stopServiceButton_Click);
            // 
            // startServiceButton
            // 
            this.startServiceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.startServiceButton.Location = new System.Drawing.Point(0, 0);
            this.startServiceButton.Name = "startServiceButton";
            this.startServiceButton.Size = new System.Drawing.Size(119, 23);
            this.startServiceButton.TabIndex = 3;
            this.startServiceButton.Text = "&Iniciar serviço";
            this.startServiceButton.UseVisualStyleBackColor = true;
            this.startServiceButton.Click += new System.EventHandler(this.startServiceButton_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(632, 24);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "mainMenu";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarServiçoToolStripMenuItem,
            this.pararServiçoToolStripMenuItem,
            this.configuraçõesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.principalToolStripMenuItem.Text = "Principal";
            // 
            // iniciarServiçoToolStripMenuItem
            // 
            this.iniciarServiçoToolStripMenuItem.Name = "iniciarServiçoToolStripMenuItem";
            this.iniciarServiçoToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.iniciarServiçoToolStripMenuItem.Text = "&Iniciar serviço";
            this.iniciarServiçoToolStripMenuItem.Click += new System.EventHandler(this.iniciarServiçoToolStripMenuItem_Click);
            // 
            // pararServiçoToolStripMenuItem
            // 
            this.pararServiçoToolStripMenuItem.Enabled = false;
            this.pararServiçoToolStripMenuItem.Name = "pararServiçoToolStripMenuItem";
            this.pararServiçoToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.pararServiçoToolStripMenuItem.Text = "&Parar serviço";
            this.pararServiçoToolStripMenuItem.Visible = false;
            this.pararServiçoToolStripMenuItem.Click += new System.EventHandler(this.pararServiçoToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.configuraçõesToolStripMenuItem.Text = "&Configurações";
            this.configuraçõesToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // logTabControl
            // 
            this.logTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTabControl.Controls.Add(this.tabPageMain);
            this.logTabControl.Location = new System.Drawing.Point(3, 82);
            this.logTabControl.Name = "logTabControl";
            this.logTabControl.SelectedIndex = 0;
            this.logTabControl.Size = new System.Drawing.Size(629, 274);
            this.logTabControl.TabIndex = 5;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.logTextBox);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(621, 248);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Log";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logTextBox.ContextMenuStrip = this.logMenuStrip;
            this.logTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTextBox.Location = new System.Drawing.Point(3, 3);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logTextBox.Size = new System.Drawing.Size(615, 242);
            this.logTextBox.TabIndex = 0;
            // 
            // logMenuStrip
            // 
            this.logMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.logMenuStrip.Name = "logMenuStrip";
            this.logMenuStrip.Size = new System.Drawing.Size(112, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItem1.Text = "&Limpar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // MainAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 356);
            this.Controls.Add(this.logTabControl);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(648, 395);
            this.Name = "MainAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Net Assist Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.quitMenuStrip.ResumeLayout(false);
            this.buttonPanel.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.logTabControl.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.logMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon sysIcon;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button stopServiceButton;
        private System.Windows.Forms.Button startServiceButton;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pararServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.TabControl logTabControl;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.ContextMenuStrip quitMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.ContextMenuStrip logMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}