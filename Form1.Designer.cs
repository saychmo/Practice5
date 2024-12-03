namespace WinFormsApp2
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
            choice_textBox = new TextBox();
            color_textBox = new TextBox();
            model_textBox = new TextBox();
            brand_textBox = new TextBox();
            printButton = new Button();
            textBox4 = new TextBox();
            Dishwasher_button = new Button();
            WashingMaching_button = new Button();
            Appliance_button = new Button();
            SuspendLayout();
            // 
            // choice_textBox
            // 
            choice_textBox.Location = new Point(498, 49);
            choice_textBox.Name = "choice_textBox";
            choice_textBox.Size = new Size(226, 27);
            choice_textBox.TabIndex = 13;
            choice_textBox.Text = "емкость/количество программ";
            choice_textBox.Enter += choice_textBox_Enter;
            choice_textBox.Leave += choice_textBox_Leave;
            // 
            // color_textBox
            // 
            color_textBox.Location = new Point(350, 49);
            color_textBox.Name = "color_textBox";
            color_textBox.Size = new Size(125, 27);
            color_textBox.TabIndex = 12;
            color_textBox.Text = "цвет";
            color_textBox.Enter += color_textBox_Enter;
            color_textBox.Leave += color_textBox_Leave;
            // 
            // model_textBox
            // 
            model_textBox.Location = new Point(192, 49);
            model_textBox.Name = "model_textBox";
            model_textBox.Size = new Size(125, 27);
            model_textBox.TabIndex = 11;
            model_textBox.Text = "модель";
            model_textBox.Enter += model_textBox_Enter_1;
            model_textBox.Leave += model_textBox_Leave;
            // 
            // brand_textBox
            // 
            brand_textBox.Location = new Point(29, 49);
            brand_textBox.Name = "brand_textBox";
            brand_textBox.Size = new Size(125, 27);
            brand_textBox.TabIndex = 10;
            brand_textBox.Text = "марка";
            brand_textBox.Enter += brand_textBox_Enter;
            brand_textBox.Leave += brand_textBox_Leave;
            // 
            // printButton
            // 
            printButton.Location = new Point(298, 194);
            printButton.Name = "printButton";
            printButton.Size = new Size(94, 29);
            printButton.TabIndex = 18;
            printButton.Text = "print";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Window;
            textBox4.Location = new Point(89, 271);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(456, 171);
            textBox4.TabIndex = 17;
            // 
            // Dishwasher_button
            // 
            Dishwasher_button.Location = new Point(410, 93);
            Dishwasher_button.Name = "Dishwasher_button";
            Dishwasher_button.Size = new Size(125, 62);
            Dishwasher_button.TabIndex = 16;
            Dishwasher_button.Text = "Add Dishwasher";
            Dishwasher_button.UseVisualStyleBackColor = true;
            Dishwasher_button.Click += Dishwasher_button_Click;
            // 
            // WashingMaching_button
            // 
            WashingMaching_button.Location = new Point(240, 93);
            WashingMaching_button.Name = "WashingMaching_button";
            WashingMaching_button.Size = new Size(152, 62);
            WashingMaching_button.TabIndex = 15;
            WashingMaching_button.Text = "Add WashingMachine ";
            WashingMaching_button.UseVisualStyleBackColor = true;
            WashingMaching_button.Click += WashingMaching_button_Click;
            // 
            // Appliance_button
            // 
            Appliance_button.Location = new Point(89, 93);
            Appliance_button.Name = "Appliance_button";
            Appliance_button.Size = new Size(125, 62);
            Appliance_button.TabIndex = 14;
            Appliance_button.Text = "Add Appliance";
            Appliance_button.UseVisualStyleBackColor = true;
            Appliance_button.Click += Appliance_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(printButton);
            Controls.Add(textBox4);
            Controls.Add(Dishwasher_button);
            Controls.Add(WashingMaching_button);
            Controls.Add(Appliance_button);
            Controls.Add(choice_textBox);
            Controls.Add(color_textBox);
            Controls.Add(model_textBox);
            Controls.Add(brand_textBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox choice_textBox;
        private TextBox color_textBox;
        private TextBox model_textBox;
        private TextBox brand_textBox;
        private Button printButton;
        private TextBox textBox4;
        private Button Dishwasher_button;
        private Button WashingMaching_button;
        private Button Appliance_button;
    }
}