﻿namespace LinqFormsLab {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.CarName = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.MyCarsList = new System.Windows.Forms.ListBox();
            this.FilteredList = new System.Windows.Forms.ListBox();
            this.CarColor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add To List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddToListOnClick);
            // 
            // CarName
            // 
            this.CarName.Location = new System.Drawing.Point(12, 33);
            this.CarName.Name = "CarName";
            this.CarName.Size = new System.Drawing.Size(66, 20);
            this.CarName.TabIndex = 1;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(12, 127);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(66, 20);
            this.Price.TabIndex = 3;
            this.Price.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "MyCars List";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(540, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "Get Red Cars";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GetRedOnClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(540, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 53);
            this.button3.TabIndex = 10;
            this.button3.Text = "Order by price and Show Result";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SortByPriceOnClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(540, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 26);
            this.button4.TabIndex = 11;
            this.button4.Text = "Get Average";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AverageOnClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(540, 173);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 38);
            this.button5.TabIndex = 12;
            this.button5.Text = "Get Distinct Colors";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.DistinctColorsOnClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(540, 217);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 42);
            this.button6.TabIndex = 13;
            this.button6.Text = "Show Most Expensive Car";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.MostExpensiveOnClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(744, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "FilteredList";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(828, 316);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 33);
            this.button7.TabIndex = 16;
            this.button7.Text = "Exit";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ExitOnClick);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(45, 203);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(116, 71);
            this.button8.TabIndex = 17;
            this.button8.Text = "Test Data";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.TestDataOnClick);
            // 
            // MyCarsList
            // 
            this.MyCarsList.FormattingEnabled = true;
            this.MyCarsList.Location = new System.Drawing.Point(241, 33);
            this.MyCarsList.Name = "MyCarsList";
            this.MyCarsList.Size = new System.Drawing.Size(284, 264);
            this.MyCarsList.TabIndex = 19;
            // 
            // FilteredList
            // 
            this.FilteredList.FormattingEnabled = true;
            this.FilteredList.Location = new System.Drawing.Point(640, 33);
            this.FilteredList.Name = "FilteredList";
            this.FilteredList.Size = new System.Drawing.Size(286, 264);
            this.FilteredList.TabIndex = 20;
            // 
            // CarColor
            // 
            this.CarColor.FormattingEnabled = true;
            this.CarColor.Items.AddRange(new object[] {
            "Red",
            "Yellow",
            "Blue",
            "Black",
            "White",
            "Orange",
            "Green",
            "Brown",
            "Aqua",
            "Cyan",
            "Gray"});
            this.CarColor.Location = new System.Drawing.Point(12, 82);
            this.CarColor.Name = "CarColor";
            this.CarColor.Size = new System.Drawing.Size(66, 21);
            this.CarColor.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 369);
            this.Controls.Add(this.CarColor);
            this.Controls.Add(this.FilteredList);
            this.Controls.Add(this.MyCarsList);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.CarName);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CarName;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ListBox MyCarsList;
        private System.Windows.Forms.ListBox FilteredList;
        private System.Windows.Forms.ComboBox CarColor;
    }
}

