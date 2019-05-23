﻿namespace xOwl_Excel_Connector
{
    partial class PrefForm
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
            this.prefLayoutPane = new System.Windows.Forms.TableLayoutPanel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addressLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwdLabel = new System.Windows.Forms.Label();
            this.collabAddrRtb = new System.Windows.Forms.TextBox();
            this.loginRtb = new System.Windows.Forms.TextBox();
            this.passwordRtb = new System.Windows.Forms.TextBox();
            this.badAddressError = new System.Windows.Forms.ErrorProvider(this.components);
            this.badLoginError = new System.Windows.Forms.ErrorProvider(this.components);
            this.badPasswordError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.prefLayoutPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.badAddressError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badLoginError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badPasswordError)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prefLayoutPane
            // 
            this.prefLayoutPane.ColumnCount = 3;
            this.prefLayoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37F));
            this.prefLayoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.prefLayoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.prefLayoutPane.Controls.Add(this.addressLabel, 0, 0);
            this.prefLayoutPane.Controls.Add(this.loginLabel, 0, 1);
            this.prefLayoutPane.Controls.Add(this.passwdLabel, 0, 2);
            this.prefLayoutPane.Controls.Add(this.collabAddrRtb, 1, 0);
            this.prefLayoutPane.Controls.Add(this.loginRtb, 1, 1);
            this.prefLayoutPane.Controls.Add(this.passwordRtb, 1, 2);
            this.prefLayoutPane.Controls.Add(this.tableLayoutPanel1, 1, 3);
            this.prefLayoutPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prefLayoutPane.Location = new System.Drawing.Point(0, 0);
            this.prefLayoutPane.Name = "prefLayoutPane";
            this.prefLayoutPane.RowCount = 4;
            this.prefLayoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.prefLayoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.prefLayoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.prefLayoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.prefLayoutPane.Size = new System.Drawing.Size(484, 192);
            this.prefLayoutPane.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveBtn.Location = new System.Drawing.Point(31, 6);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.saveBtn.Size = new System.Drawing.Size(100, 30);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.Save_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cancelBtn.Location = new System.Drawing.Point(137, 6);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 30);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(3, 16);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(163, 16);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Collaboration Address";
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(3, 64);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(46, 16);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Login";
            // 
            // passwdLabel
            // 
            this.passwdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwdLabel.AutoSize = true;
            this.passwdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdLabel.Location = new System.Drawing.Point(3, 112);
            this.passwdLabel.Name = "passwdLabel";
            this.passwdLabel.Size = new System.Drawing.Size(76, 16);
            this.passwdLabel.TabIndex = 4;
            this.passwdLabel.Text = "Password";
            // 
            // collabAddrRtb
            // 
            this.collabAddrRtb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.collabAddrRtb.Location = new System.Drawing.Point(182, 14);
            this.collabAddrRtb.Name = "collabAddrRtb";
            this.collabAddrRtb.Size = new System.Drawing.Size(242, 20);
            this.collabAddrRtb.TabIndex = 5;
            this.collabAddrRtb.Validating += new System.ComponentModel.CancelEventHandler(this.XowlAddressValidating);
            // 
            // loginRtb
            // 
            this.loginRtb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.loginRtb.Location = new System.Drawing.Point(182, 62);
            this.loginRtb.Name = "loginRtb";
            this.loginRtb.Size = new System.Drawing.Size(100, 20);
            this.loginRtb.TabIndex = 6;
            this.loginRtb.Validating += new System.ComponentModel.CancelEventHandler(this.XowlLoginValidating);
            // 
            // passwordRtb
            // 
            this.passwordRtb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordRtb.Location = new System.Drawing.Point(182, 110);
            this.passwordRtb.Name = "passwordRtb";
            this.passwordRtb.PasswordChar = '*';
            this.passwordRtb.Size = new System.Drawing.Size(100, 20);
            this.passwordRtb.TabIndex = 7;
            this.passwordRtb.Validating += new System.ComponentModel.CancelEventHandler(this.XowlPasswordValidating);
            // 
            // badAddressError
            // 
            this.badAddressError.ContainerControl = this;
            // 
            // badLoginError
            // 
            this.badLoginError.ContainerControl = this;
            // 
            // badPasswordError
            // 
            this.badPasswordError.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.saveBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancelBtn, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(182, 147);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(269, 42);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // PrefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(484, 192);
            this.Controls.Add(this.prefLayoutPane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrefForm";
            this.Text = "xOWL Preferences";
            this.Load += new System.EventHandler(this.PrefForm_Load);
            this.prefLayoutPane.ResumeLayout(false);
            this.prefLayoutPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.badAddressError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.badLoginError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.badPasswordError)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel prefLayoutPane;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwdLabel;
        private System.Windows.Forms.TextBox collabAddrRtb;
        private System.Windows.Forms.TextBox loginRtb;
        private System.Windows.Forms.TextBox passwordRtb;
        private System.Windows.Forms.ErrorProvider badAddressError;
        private System.Windows.Forms.ErrorProvider badLoginError;
        private System.Windows.Forms.ErrorProvider badPasswordError;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}