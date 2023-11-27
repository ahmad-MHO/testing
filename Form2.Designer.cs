namespace temp_converter
{
    partial class Form2
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
            label1 = new Label();
            Btn_temp_app = new Button();
            btn_Calculater = new Button();
            label2 = new Label();
            btn_To_Do = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(306, 27);
            label1.Name = "label1";
            label1.Size = new Size(151, 32);
            label1.TabIndex = 0;
            label1.Text = "Choose App";
            label1.Click += label1_Click;
            // 
            // Btn_temp_app
            // 
            Btn_temp_app.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_temp_app.ForeColor = SystemColors.HotTrack;
            Btn_temp_app.Location = new Point(71, 121);
            Btn_temp_app.Name = "Btn_temp_app";
            Btn_temp_app.Size = new Size(150, 89);
            Btn_temp_app.TabIndex = 1;
            Btn_temp_app.Text = "Temp Converter";
            Btn_temp_app.UseVisualStyleBackColor = true;
            Btn_temp_app.Click += Btn_temp_app_Click;
            // 
            // btn_Calculater
            // 
            btn_Calculater.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Calculater.ForeColor = Color.SeaGreen;
            btn_Calculater.Location = new Point(320, 121);
            btn_Calculater.Name = "btn_Calculater";
            btn_Calculater.Size = new Size(150, 89);
            btn_Calculater.TabIndex = 2;
            btn_Calculater.Text = "Calculater";
            btn_Calculater.UseVisualStyleBackColor = true;
            btn_Calculater.Click += btn_Calculater_Click;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // btn_To_Do
            // 
            btn_To_Do.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_To_Do.ForeColor = Color.Magenta;
            btn_To_Do.Location = new Point(576, 121);
            btn_To_Do.Name = "btn_To_Do";
            btn_To_Do.Size = new Size(150, 89);
            btn_To_Do.TabIndex = 3;
            btn_To_Do.Text = "To Do List";
            btn_To_Do.UseVisualStyleBackColor = true;
            btn_To_Do.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_To_Do);
            Controls.Add(label2);
            Controls.Add(btn_Calculater);
            Controls.Add(Btn_temp_app);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Btn_temp_app;
        private Button btn_Calculater;
        private Label label2;
        private Button btn_To_Do;
    }
}