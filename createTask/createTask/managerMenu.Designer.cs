namespace createTask
{
    partial class managerMenu
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
            this.addButton = new System.Windows.Forms.Button();
            this.movieName = new System.Windows.Forms.TextBox();
            this.moviePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListBox();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 105);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(82, 37);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click_1);
            // 
            // movieName
            // 
            this.movieName.Location = new System.Drawing.Point(83, 27);
            this.movieName.Name = "movieName";
            this.movieName.Size = new System.Drawing.Size(100, 20);
            this.movieName.TabIndex = 2;
            // 
            // moviePrice
            // 
            this.moviePrice.Location = new System.Drawing.Point(83, 68);
            this.moviePrice.Name = "moviePrice";
            this.moviePrice.Size = new System.Drawing.Size(100, 20);
            this.moviePrice.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Movie Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price: ";
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(203, 27);
            this.list.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(304, 121);
            this.list.TabIndex = 9;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(106, 110);
            this.back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(84, 37);
            this.back.TabIndex = 10;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // managerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 154);
            this.Controls.Add(this.back);
            this.Controls.Add(this.list);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moviePrice);
            this.Controls.Add(this.movieName);
            this.Controls.Add(this.addButton);
            this.Name = "managerMenu";
            this.Text = "Manager menu";
            this.Load += new System.EventHandler(this.managerMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox movieName;
        private System.Windows.Forms.TextBox moviePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Button back;
    }
}