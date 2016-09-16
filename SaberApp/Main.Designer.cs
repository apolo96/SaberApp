namespace SaberApp
{
    partial class Main
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
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtLastName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSignUp = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPw = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbAlert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Depth = 0;
            this.txtName.Hint = "Name";
            this.txtName.Location = new System.Drawing.Point(51, 113);
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(259, 23);
            this.txtName.TabIndex = 0;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Depth = 0;
            this.txtLastName.Hint = "LastName";
            this.txtLastName.Location = new System.Drawing.Point(51, 162);
            this.txtLastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.Size = new System.Drawing.Size(259, 23);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.UseSystemPasswordChar = false;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Depth = 0;
            this.btnSignUp.Location = new System.Drawing.Point(203, 306);
            this.btnSignUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Primary = true;
            this.btnSignUp.Size = new System.Drawing.Size(107, 30);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // txtID
            // 
            this.txtID.Depth = 0;
            this.txtID.Hint = "Identification Number";
            this.txtID.Location = new System.Drawing.Point(51, 209);
            this.txtID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.Size = new System.Drawing.Size(259, 23);
            this.txtID.TabIndex = 2;
            this.txtID.UseSystemPasswordChar = false;
            // 
            // txtPw
            // 
            this.txtPw.Depth = 0;
            this.txtPw.Hint = "Password";
            this.txtPw.Location = new System.Drawing.Point(51, 255);
            this.txtPw.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPw.Name = "txtPw";
            this.txtPw.PasswordChar = '*';
            this.txtPw.SelectedText = "";
            this.txtPw.SelectionLength = 0;
            this.txtPw.SelectionStart = 0;
            this.txtPw.Size = new System.Drawing.Size(259, 23);
            this.txtPw.TabIndex = 3;
            this.txtPw.UseSystemPasswordChar = false;
            // 
            // lbAlert
            // 
            this.lbAlert.AutoSize = true;
            this.lbAlert.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlert.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbAlert.Location = new System.Drawing.Point(24, 313);
            this.lbAlert.Name = "lbAlert";
            this.lbAlert.Size = new System.Drawing.Size(0, 15);
            this.lbAlert.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 370);
            this.Controls.Add(this.lbAlert);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaberApp";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLastName;
        private MaterialSkin.Controls.MaterialRaisedButton btnSignUp;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtID;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPw;
        private System.Windows.Forms.Label lbAlert;
    }
}

