namespace temp_converter
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
            Btn_fehren = new Button();
            Btn_celesus = new Button();
            Btn_kalven = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Txt_fehren = new TextBox();
            Txt_celesus = new TextBox();
            Txt_kalven = new TextBox();
            SuspendLayout();
            // 
            // Btn_fehren
            // 
            Btn_fehren.Location = new Point(297, 67);
            Btn_fehren.Name = "Btn_fehren";
            Btn_fehren.Size = new Size(75, 23);
            Btn_fehren.TabIndex = 0;
            Btn_fehren.Text = "Go";
            Btn_fehren.UseVisualStyleBackColor = true;
            Btn_fehren.Click += Btn_fehren_Click;
            // 
            // Btn_celesus
            // 
            Btn_celesus.Location = new Point(297, 118);
            Btn_celesus.Name = "Btn_celesus";
            Btn_celesus.Size = new Size(75, 23);
            Btn_celesus.TabIndex = 1;
            Btn_celesus.Text = "Go";
            Btn_celesus.UseVisualStyleBackColor = true;
            Btn_celesus.Click += Btn_celesus_Click;
            // 
            // Btn_kalven
            // 
            Btn_kalven.Location = new Point(297, 170);
            Btn_kalven.Name = "Btn_kalven";
            Btn_kalven.Size = new Size(75, 23);
            Btn_kalven.TabIndex = 2;
            Btn_kalven.Text = "Go";
            Btn_kalven.UseVisualStyleBackColor = true;
            Btn_kalven.Click += Btn_kalven_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(12, 68);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 3;
            label1.Text = "Fehrenhett";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 4;
            label2.Text = "Celesus";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(12, 164);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 5;
            label3.Text = "Kalven";
            // 
            // Txt_fehren
            // 
            Txt_fehren.Location = new Point(133, 68);
            Txt_fehren.Name = "Txt_fehren";
            Txt_fehren.Size = new Size(100, 23);
            Txt_fehren.TabIndex = 6;
            // 
            // Txt_celesus
            // 
            Txt_celesus.Location = new Point(133, 118);
            Txt_celesus.Name = "Txt_celesus";
            Txt_celesus.Size = new Size(100, 23);
            Txt_celesus.TabIndex = 7;
            // 
            // Txt_kalven
            // 
            Txt_kalven.Location = new Point(133, 166);
            Txt_kalven.Name = "Txt_kalven";
            Txt_kalven.Size = new Size(100, 23);
            Txt_kalven.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 255);
            Controls.Add(Txt_kalven);
            Controls.Add(Txt_celesus);
            Controls.Add(Txt_fehren);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btn_kalven);
            Controls.Add(Btn_celesus);
            Controls.Add(Btn_fehren);
            Name = "Form1";
            Text = "Tempreture Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_fehren;
        private Button Btn_celesus;
        private Button Btn_kalven;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Txt_fehren;
        private TextBox Txt_celesus;
        private TextBox Txt_kalven;
    }
}