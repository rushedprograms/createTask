namespace createTask
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
            this.login = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.rent = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.amount = new System.Windows.Forms.Label();
            this.movieChosen = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(12, 12);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(92, 23);
            this.login.TabIndex = 0;
            this.login.Text = "Manager Menu";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(170, 158);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(108, 42);
            this.returnButton.TabIndex = 1;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // rent
            // 
            this.rent.Location = new System.Drawing.Point(10, 158);
            this.rent.Name = "rent";
            this.rent.Size = new System.Drawing.Size(108, 42);
            this.rent.TabIndex = 2;
            this.rent.Text = "Rent";
            this.rent.UseVisualStyleBackColor = true;
            this.rent.Click += new System.EventHandler(this.rent_Click);
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(89, 242);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(0, 13);
            this.amount.TabIndex = 7;
            // 
            // movieChosen
            // 
            this.movieChosen.FormattingEnabled = true;
            this.movieChosen.Items.AddRange(new object[] {
            "Pantypool",
            "Toy Story 7",
            "Starwars but Communist",
            "Star Trek but Magic",
            "Memology"});
            this.movieChosen.Location = new System.Drawing.Point(141, 116);
            this.movieChosen.Margin = new System.Windows.Forms.Padding(2);
            this.movieChosen.Name = "movieChosen";
            this.movieChosen.Size = new System.Drawing.Size(135, 21);
            this.movieChosen.TabIndex = 8;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(141, 63);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(137, 20);
            this.nameBox.TabIndex = 9;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(141, 93);
            this.addressBox.Margin = new System.Windows.Forms.Padding(2);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(135, 20);
            this.addressBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Movie Chosen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Amount Due:";
            // 
            // checkOut
            // 
            this.checkOut.Location = new System.Drawing.Point(170, 216);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(108, 49);
            this.checkOut.TabIndex = 15;
            this.checkOut.Text = "Check Out";
            this.checkOut.UseVisualStyleBackColor = true;
            this.checkOut.Click += new System.EventHandler(this.checkOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 277);
            this.Controls.Add(this.checkOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.movieChosen);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.rent);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.login);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Movie Rental";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button rent;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox movieChosen;
        private System.Windows.Forms.Button checkOut;
    }
}

