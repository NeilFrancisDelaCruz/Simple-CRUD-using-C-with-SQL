namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label5 = new Label();
            button5 = new Button();
            GridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold);
            button1.Location = new Point(146, 508);
            button1.Name = "button1";
            button1.Size = new Size(110, 48);
            button1.TabIndex = 0;
            button1.Text = "HOME";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.GreenYellow;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold);
            button2.Location = new Point(785, 508);
            button2.Name = "button2";
            button2.Size = new Size(110, 48);
            button2.TabIndex = 1;
            button2.Text = "CREATE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 255, 192);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold);
            button3.Location = new Point(635, 508);
            button3.Name = "button3";
            button3.Size = new Size(110, 48);
            button3.TabIndex = 2;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold);
            button4.Location = new Point(307, 508);
            button4.Name = "button4";
            button4.Size = new Size(110, 48);
            button4.TabIndex = 3;
            button4.Text = "DELETE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            label1.Location = new Point(307, 144);
            label1.Name = "label1";
            label1.Size = new Size(28, 19);
            label1.TabIndex = 4;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            label2.Location = new Point(307, 198);
            label2.Name = "label2";
            label2.Size = new Size(66, 19);
            label2.TabIndex = 5;
            label2.Text = "EMAIL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            label3.Location = new Point(307, 316);
            label3.Name = "label3";
            label3.Size = new Size(119, 19);
            label3.TabIndex = 7;
            label3.Text = "USER NAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            label4.Location = new Point(307, 252);
            label4.Name = "label4";
            label4.Size = new Size(97, 19);
            label4.TabIndex = 6;
            label4.Text = "ADDRESS";
            label4.Click += label4_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(562, 142);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(200, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(562, 249);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 23);
            txtAddress.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(562, 195);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(562, 313);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(200, 23);
            txtUserName.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(562, 368);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 12;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            label5.Location = new Point(307, 380);
            label5.Name = "label5";
            label5.Size = new Size(114, 19);
            label5.TabIndex = 13;
            label5.Text = "PASSWORD";
            // 
            // button5
            // 
            button5.BackColor = Color.SkyBlue;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold);
            button5.Location = new Point(474, 508);
            button5.Name = "button5";
            button5.Size = new Size(110, 48);
            button5.TabIndex = 14;
            button5.Text = "READ";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // GridView1
            // 
            GridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridView1.Location = new Point(273, 58);
            GridView1.Name = "GridView1";
            GridView1.Size = new Size(541, 394);
            GridView1.TabIndex = 15;
            GridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1022, 672);
            Controls.Add(GridView1);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtEmail);
            Controls.Add(txtAddress);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label5;
        private Button button5;
        private DataGridView GridView1;
    }
}
