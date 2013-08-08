using System.Windows.Forms;
namespace ProfileCopy
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
            this.oldComputer_lbl = new System.Windows.Forms.Label();
            this.currentComputer_lbl = new System.Windows.Forms.Label();
            this.oldComputer_txt = new System.Windows.Forms.TextBox();
            this.oldWindowsVer_txt = new System.Windows.Forms.TextBox();
            this.windowsVer_lbl = new System.Windows.Forms.Label();
            this.usersAccount_lbl = new System.Windows.Forms.Label();
            this.oldUsersAccount_combo = new System.Windows.Forms.ComboBox();
            this.newComputer_lbl = new System.Windows.Forms.Label();
            this.newComputer_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newUserAccount_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newWindowsVer_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.desktop_checkBox = new System.Windows.Forms.CheckBox();
            this.outlook_checkBox = new System.Windows.Forms.CheckBox();
            this.signatures_checkBox = new System.Windows.Forms.CheckBox();
            this.favorites_checkBox = new System.Windows.Forms.CheckBox();
            this.forceOverwrite_checkBox = new System.Windows.Forms.CheckBox();
            this.option_lbl = new System.Windows.Forms.Label();
            this.copy_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.output_txt = new System.Windows.Forms.TextBox();
            this.output_lbl = new System.Windows.Forms.Label();
            this.testOldComputerConnection = new System.Windows.Forms.Button();
            this.testNewComputerConnection = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // oldComputer_lbl
            // 
            this.oldComputer_lbl.AutoSize = true;
            this.oldComputer_lbl.Location = new System.Drawing.Point(19, 30);
            this.oldComputer_lbl.Name = "oldComputer_lbl";
            this.oldComputer_lbl.Size = new System.Drawing.Size(71, 13);
            this.oldComputer_lbl.TabIndex = 0;
            this.oldComputer_lbl.Text = "Old Computer";
            this.oldComputer_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // currentComputer_lbl
            // 
            this.currentComputer_lbl.AutoSize = true;
            this.currentComputer_lbl.Location = new System.Drawing.Point(19, 62);
            this.currentComputer_lbl.Name = "currentComputer_lbl";
            this.currentComputer_lbl.Size = new System.Drawing.Size(86, 13);
            this.currentComputer_lbl.TabIndex = 1;
            this.currentComputer_lbl.Text = "Target Computer";
            this.currentComputer_lbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // oldComputer_txt
            // 
            this.oldComputer_txt.Location = new System.Drawing.Point(127, 55);
            this.oldComputer_txt.Name = "oldComputer_txt";
            this.oldComputer_txt.Size = new System.Drawing.Size(257, 20);
            this.oldComputer_txt.TabIndex = 1;
            this.oldComputer_txt.Click += new System.EventHandler(this.oldComputer_txt_clicked);
            // 
            // oldWindowsVer_txt
            // 
            this.oldWindowsVer_txt.Location = new System.Drawing.Point(127, 118);
            this.oldWindowsVer_txt.Name = "oldWindowsVer_txt";
            this.oldWindowsVer_txt.ReadOnly = true;
            this.oldWindowsVer_txt.Size = new System.Drawing.Size(257, 20);
            this.oldWindowsVer_txt.TabIndex = 3;
            // 
            // windowsVer_lbl
            // 
            this.windowsVer_lbl.AutoSize = true;
            this.windowsVer_lbl.Location = new System.Drawing.Point(19, 125);
            this.windowsVer_lbl.Name = "windowsVer_lbl";
            this.windowsVer_lbl.Size = new System.Drawing.Size(89, 13);
            this.windowsVer_lbl.TabIndex = 12;
            this.windowsVer_lbl.Text = "Windows Version";
            // 
            // usersAccount_lbl
            // 
            this.usersAccount_lbl.AutoSize = true;
            this.usersAccount_lbl.Location = new System.Drawing.Point(19, 94);
            this.usersAccount_lbl.Name = "usersAccount_lbl";
            this.usersAccount_lbl.Size = new System.Drawing.Size(79, 13);
            this.usersAccount_lbl.TabIndex = 5;
            this.usersAccount_lbl.Text = "User\'s Account";
            // 
            // oldUsersAccount_combo
            // 
            this.oldUsersAccount_combo.FormattingEnabled = true;
            this.oldUsersAccount_combo.Location = new System.Drawing.Point(127, 86);
            this.oldUsersAccount_combo.Name = "oldUsersAccount_combo";
            this.oldUsersAccount_combo.Size = new System.Drawing.Size(257, 21);
            this.oldUsersAccount_combo.TabIndex = 2;
            // 
            // newComputer_lbl
            // 
            this.newComputer_lbl.AutoSize = true;
            this.newComputer_lbl.Location = new System.Drawing.Point(19, 174);
            this.newComputer_lbl.Name = "newComputer_lbl";
            this.newComputer_lbl.Size = new System.Drawing.Size(77, 13);
            this.newComputer_lbl.TabIndex = 7;
            this.newComputer_lbl.Text = "New Computer";
            this.newComputer_lbl.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // newComputer_txt
            // 
            this.newComputer_txt.Location = new System.Drawing.Point(127, 200);
            this.newComputer_txt.Name = "newComputer_txt";
            this.newComputer_txt.Size = new System.Drawing.Size(257, 20);
            this.newComputer_txt.TabIndex = 3;
            this.newComputer_txt.Click += new System.EventHandler(this.newComputer_txt_clicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Target Computer";
            // 
            // newUserAccount_combo
            // 
            this.newUserAccount_combo.FormattingEnabled = true;
            this.newUserAccount_combo.Location = new System.Drawing.Point(127, 234);
            this.newUserAccount_combo.Name = "newUserAccount_combo";
            this.newUserAccount_combo.Size = new System.Drawing.Size(257, 21);
            this.newUserAccount_combo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "User\'s Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Windows Version";
            // 
            // newWindowsVer_txt
            // 
            this.newWindowsVer_txt.Location = new System.Drawing.Point(127, 266);
            this.newWindowsVer_txt.Name = "newWindowsVer_txt";
            this.newWindowsVer_txt.ReadOnly = true;
            this.newWindowsVer_txt.Size = new System.Drawing.Size(257, 20);
            this.newWindowsVer_txt.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Folders to copy";
            // 
            // desktop_checkBox
            // 
            this.desktop_checkBox.AutoSize = true;
            this.desktop_checkBox.Location = new System.Drawing.Point(90, 343);
            this.desktop_checkBox.Name = "desktop_checkBox";
            this.desktop_checkBox.Size = new System.Drawing.Size(66, 17);
            this.desktop_checkBox.TabIndex = 5;
            this.desktop_checkBox.Text = "Desktop";
            this.desktop_checkBox.UseVisualStyleBackColor = true;
            // 
            // outlook_checkBox
            // 
            this.outlook_checkBox.AutoSize = true;
            this.outlook_checkBox.Location = new System.Drawing.Point(90, 384);
            this.outlook_checkBox.Name = "outlook_checkBox";
            this.outlook_checkBox.Size = new System.Drawing.Size(63, 17);
            this.outlook_checkBox.TabIndex = 6;
            this.outlook_checkBox.Text = "Outlook";
            this.outlook_checkBox.UseVisualStyleBackColor = true;
            this.outlook_checkBox.CheckedChanged += new System.EventHandler(this.outlook_checkBox_CheckedChanged);
            // 
            // signatures_checkBox
            // 
            this.signatures_checkBox.AutoSize = true;
            this.signatures_checkBox.Location = new System.Drawing.Point(183, 384);
            this.signatures_checkBox.Name = "signatures_checkBox";
            this.signatures_checkBox.Size = new System.Drawing.Size(76, 17);
            this.signatures_checkBox.TabIndex = 8;
            this.signatures_checkBox.Text = "Signatures";
            this.signatures_checkBox.UseVisualStyleBackColor = true;
            // 
            // favorites_checkBox
            // 
            this.favorites_checkBox.AutoSize = true;
            this.favorites_checkBox.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.favorites_checkBox.Location = new System.Drawing.Point(183, 343);
            this.favorites_checkBox.Name = "favorites_checkBox";
            this.favorites_checkBox.Size = new System.Drawing.Size(69, 17);
            this.favorites_checkBox.TabIndex = 7;
            this.favorites_checkBox.Text = "Favorites";
            this.favorites_checkBox.UseVisualStyleBackColor = true;
            // 
            // forceOverwrite_checkBox
            // 
            this.forceOverwrite_checkBox.AutoSize = true;
            this.forceOverwrite_checkBox.Location = new System.Drawing.Point(38, 458);
            this.forceOverwrite_checkBox.Name = "forceOverwrite_checkBox";
            this.forceOverwrite_checkBox.Size = new System.Drawing.Size(92, 17);
            this.forceOverwrite_checkBox.TabIndex = 9;
            this.forceOverwrite_checkBox.Text = "Overwrite files";
            this.forceOverwrite_checkBox.UseVisualStyleBackColor = true;
            // 
            // option_lbl
            // 
            this.option_lbl.AutoSize = true;
            this.option_lbl.Location = new System.Drawing.Point(19, 431);
            this.option_lbl.Name = "option_lbl";
            this.option_lbl.Size = new System.Drawing.Size(38, 13);
            this.option_lbl.TabIndex = 25;
            this.option_lbl.Text = "Option";
            // 
            // copy_btn
            // 
            this.copy_btn.Location = new System.Drawing.Point(493, 452);
            this.copy_btn.Name = "copy_btn";
            this.copy_btn.Size = new System.Drawing.Size(75, 23);
            this.copy_btn.TabIndex = 11;
            this.copy_btn.Text = "Copy";
            this.copy_btn.UseVisualStyleBackColor = true;
            this.copy_btn.Click += new System.EventHandler(this.copy_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(400, 452);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 23);
            this.reset_btn.TabIndex = 10;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // output_txt
            // 
            this.output_txt.Location = new System.Drawing.Point(22, 503);
            this.output_txt.Multiline = true;
            this.output_txt.Name = "output_txt";
            this.output_txt.ReadOnly = true;
            this.output_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output_txt.Size = new System.Drawing.Size(546, 95);
            this.output_txt.TabIndex = 26;
            // 
            // output_lbl
            // 
            this.output_lbl.AutoSize = true;
            this.output_lbl.Location = new System.Drawing.Point(19, 487);
            this.output_lbl.Name = "output_lbl";
            this.output_lbl.Size = new System.Drawing.Size(39, 13);
            this.output_lbl.TabIndex = 27;
            this.output_lbl.Text = "Output";
            this.output_lbl.Click += new System.EventHandler(this.label5_Click);
            // 
            // testOldComputerConnection
            // 
            this.testOldComputerConnection.Location = new System.Drawing.Point(400, 52);
            this.testOldComputerConnection.Name = "testOldComputerConnection";
            this.testOldComputerConnection.Size = new System.Drawing.Size(75, 23);
            this.testOldComputerConnection.TabIndex = 28;
            this.testOldComputerConnection.Text = "Connect";
            this.testOldComputerConnection.UseVisualStyleBackColor = true;
            this.testOldComputerConnection.Click += new System.EventHandler(this.testOldComputerConnection_Click);
            // 
            // testNewComputerConnection
            // 
            this.testNewComputerConnection.Location = new System.Drawing.Point(400, 197);
            this.testNewComputerConnection.Name = "testNewComputerConnection";
            this.testNewComputerConnection.Size = new System.Drawing.Size(75, 23);
            this.testNewComputerConnection.TabIndex = 29;
            this.testNewComputerConnection.Text = "Connect";
            this.testNewComputerConnection.UseVisualStyleBackColor = true;
            this.testNewComputerConnection.Click += new System.EventHandler(this.testNewComputerConnection_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(22, 610);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(546, 23);
            this.progressBar.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 645);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.testNewComputerConnection);
            this.Controls.Add(this.testOldComputerConnection);
            this.Controls.Add(this.output_lbl);
            this.Controls.Add(this.output_txt);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.copy_btn);
            this.Controls.Add(this.option_lbl);
            this.Controls.Add(this.forceOverwrite_checkBox);
            this.Controls.Add(this.favorites_checkBox);
            this.Controls.Add(this.signatures_checkBox);
            this.Controls.Add(this.outlook_checkBox);
            this.Controls.Add(this.desktop_checkBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newUserAccount_combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newWindowsVer_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newComputer_txt);
            this.Controls.Add(this.newComputer_lbl);
            this.Controls.Add(this.oldUsersAccount_combo);
            this.Controls.Add(this.usersAccount_lbl);
            this.Controls.Add(this.windowsVer_lbl);
            this.Controls.Add(this.oldWindowsVer_txt);
            this.Controls.Add(this.oldComputer_txt);
            this.Controls.Add(this.currentComputer_lbl);
            this.Controls.Add(this.oldComputer_lbl);
            this.Name = "Form1";
            this.Text = "Profile Copy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oldComputer_lbl;
        private System.Windows.Forms.Label currentComputer_lbl;
        private System.Windows.Forms.TextBox oldComputer_txt;
        private System.Windows.Forms.TextBox oldWindowsVer_txt;
        private System.Windows.Forms.Label windowsVer_lbl;
        private System.Windows.Forms.Label usersAccount_lbl;
        private System.Windows.Forms.ComboBox oldUsersAccount_combo;
        private Label newComputer_lbl;
        private TextBox newComputer_txt;
        private Label label1;
        private ComboBox newUserAccount_combo;
        private Label label2;
        private Label label3;
        private TextBox newWindowsVer_txt;
        private Label label4;
        private CheckBox desktop_checkBox;
        private CheckBox outlook_checkBox;
        private CheckBox signatures_checkBox;
        private CheckBox favorites_checkBox;
        private CheckBox forceOverwrite_checkBox;
        private Label option_lbl;
        private Button copy_btn;
        private Button reset_btn;
        private TextBox output_txt;
        private Label output_lbl;
        private Button testOldComputerConnection;
        private Button testNewComputerConnection;
        private ProgressBar progressBar;
    }
}

