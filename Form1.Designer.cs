namespace lab3B
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
            this.dresserGroupBox = new System.Windows.Forms.GroupBox();
            this.dressercomboBox = new System.Windows.Forms.ComboBox();
            this.serviceGroupBox = new System.Windows.Forms.GroupBox();
            this.serviceListBox = new System.Windows.Forms.ListBox();
            this.listGroupBox = new System.Windows.Forms.GroupBox();
            this.chargesListBox = new System.Windows.Forms.ListBox();
            this.priceGroupBox = new System.Windows.Forms.GroupBox();
            this.priceListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addserviceButton = new System.Windows.Forms.Button();
            this.totalButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.dresserGroupBox.SuspendLayout();
            this.serviceGroupBox.SuspendLayout();
            this.listGroupBox.SuspendLayout();
            this.priceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dresserGroupBox
            // 
            this.dresserGroupBox.Controls.Add(this.dressercomboBox);
            this.dresserGroupBox.Location = new System.Drawing.Point(19, 22);
            this.dresserGroupBox.Name = "dresserGroupBox";
            this.dresserGroupBox.Size = new System.Drawing.Size(173, 184);
            this.dresserGroupBox.TabIndex = 0;
            this.dresserGroupBox.TabStop = false;
            this.dresserGroupBox.Text = "Select a Hairdresser";
            // 
            // dressercomboBox
            // 
            this.dressercomboBox.FormattingEnabled = true;
            this.dressercomboBox.Items.AddRange(new object[] {
            "Jane",
            "Pat",
            "Ron",
            "Sue",
            "Laurie"});
            this.dressercomboBox.Location = new System.Drawing.Point(13, 25);
            this.dressercomboBox.Name = "dressercomboBox";
            this.dressercomboBox.Size = new System.Drawing.Size(150, 24);
            this.dressercomboBox.TabIndex = 0;
            this.dressercomboBox.Text = "Jane";
            this.dressercomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // serviceGroupBox
            // 
            this.serviceGroupBox.Controls.Add(this.serviceListBox);
            this.serviceGroupBox.Location = new System.Drawing.Point(198, 22);
            this.serviceGroupBox.Name = "serviceGroupBox";
            this.serviceGroupBox.Size = new System.Drawing.Size(185, 184);
            this.serviceGroupBox.TabIndex = 1;
            this.serviceGroupBox.TabStop = false;
            this.serviceGroupBox.Text = "Select a Service";
            // 
            // serviceListBox
            // 
            this.serviceListBox.FormattingEnabled = true;
            this.serviceListBox.ItemHeight = 16;
            this.serviceListBox.Items.AddRange(new object[] {
            "Cut",
            "Wash, blow-dry and style",
            "Colour",
            "Highlights",
            "Extensions",
            "Up-do"});
            this.serviceListBox.Location = new System.Drawing.Point(6, 25);
            this.serviceListBox.Name = "serviceListBox";
            this.serviceListBox.Size = new System.Drawing.Size(173, 148);
            this.serviceListBox.TabIndex = 0;
            this.serviceListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listGroupBox
            // 
            this.listGroupBox.Controls.Add(this.chargesListBox);
            this.listGroupBox.Location = new System.Drawing.Point(406, 22);
            this.listGroupBox.Name = "listGroupBox";
            this.listGroupBox.Size = new System.Drawing.Size(205, 184);
            this.listGroupBox.TabIndex = 2;
            this.listGroupBox.TabStop = false;
            this.listGroupBox.Text = "Charged Items:";
            // 
            // chargesListBox
            // 
            this.chargesListBox.FormattingEnabled = true;
            this.chargesListBox.ItemHeight = 16;
            this.chargesListBox.Location = new System.Drawing.Point(12, 21);
            this.chargesListBox.Name = "chargesListBox";
            this.chargesListBox.Size = new System.Drawing.Size(177, 148);
            this.chargesListBox.TabIndex = 0;
            // 
            // priceGroupBox
            // 
            this.priceGroupBox.Controls.Add(this.priceListBox);
            this.priceGroupBox.Location = new System.Drawing.Point(639, 22);
            this.priceGroupBox.Name = "priceGroupBox";
            this.priceGroupBox.Size = new System.Drawing.Size(194, 184);
            this.priceGroupBox.TabIndex = 3;
            this.priceGroupBox.TabStop = false;
            this.priceGroupBox.Text = "Price:";
            // 
            // priceListBox
            // 
            this.priceListBox.FormattingEnabled = true;
            this.priceListBox.ItemHeight = 16;
            this.priceListBox.Location = new System.Drawing.Point(11, 18);
            this.priceListBox.Name = "priceListBox";
            this.priceListBox.Size = new System.Drawing.Size(163, 148);
            this.priceListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Price:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addserviceButton
            // 
            this.addserviceButton.Location = new System.Drawing.Point(204, 285);
            this.addserviceButton.Name = "addserviceButton";
            this.addserviceButton.Size = new System.Drawing.Size(141, 25);
            this.addserviceButton.TabIndex = 5;
            this.addserviceButton.Text = "Add Service";
            this.addserviceButton.UseVisualStyleBackColor = true;
            this.addserviceButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(382, 285);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(147, 25);
            this.totalButton.TabIndex = 6;
            this.totalButton.Text = "Total Price";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(558, 285);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(117, 25);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(705, 285);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(108, 25);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "  Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 336);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.addserviceButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceGroupBox);
            this.Controls.Add(this.listGroupBox);
            this.Controls.Add(this.serviceGroupBox);
            this.Controls.Add(this.dresserGroupBox);
            this.Name = "Form1";
            this.Text = "Perfect Cut Hair Salon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dresserGroupBox.ResumeLayout(false);
            this.serviceGroupBox.ResumeLayout(false);
            this.listGroupBox.ResumeLayout(false);
            this.priceGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox dresserGroupBox;
        private System.Windows.Forms.ComboBox dressercomboBox;
        private System.Windows.Forms.GroupBox serviceGroupBox;
        private System.Windows.Forms.ListBox serviceListBox;
        private System.Windows.Forms.GroupBox listGroupBox;
        private System.Windows.Forms.ListBox chargesListBox;
        private System.Windows.Forms.GroupBox priceGroupBox;
        private System.Windows.Forms.ListBox priceListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addserviceButton;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
    }
}

