namespace shop_management
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(618, 345);
            this.textbox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(263, 26);
            this.textbox1.TabIndex = 0;
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(618, 421);
            this.textbox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox2.Name = "textbox2";
            this.textbox2.PasswordChar = '*';
            this.textbox2.Size = new System.Drawing.Size(263, 26);
            this.textbox2.TabIndex = 1;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(445, 342);
            this.l1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(145, 27);
            this.l1.TabIndex = 2;
            this.l1.Text = "User Name";
            this.l1.Click += new System.EventHandler(this.label1_Click);
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1.Location = new System.Drawing.Point(445, 421);
            this.p1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(131, 27);
            this.p1.TabIndex = 3;
            this.p1.Text = "Password";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(516, 513);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(685, 515);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(470, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 76);
            this.panel1.TabIndex = 4;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 704);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.textbox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.TextBox textbox2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
    }
}