  namespace temp_converter
{
    partial class calculator
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
            txt_input = new TextBox();
            btn_histore = new Button();
            btn_one = new Button();
            btn_seven = new Button();
            btn_four = new Button();
            btn_percenteg = new Button();
            btn_Sqrt = new Button();
            btn_CE = new Button();
            btn_Lbracet = new Button();
            btn_eight = new Button();
            btn_five = new Button();
            btn_two = new Button();
            btn_zero = new Button();
            btn_C = new Button();
            btn_Rbracket = new Button();
            btn_nine = new Button();
            btn_six = new Button();
            btn_three = new Button();
            btn_Remove = new Button();
            btn_divid = new Button();
            btn_by = new Button();
            btn_minis = new Button();
            btn_plus = new Button();
            btn_ecual = new Button();
            lbl_result = new Label();
            btn_dot = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            standeredToolStripMenuItem = new ToolStripMenuItem();
            scientificToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_input
            // 
            txt_input.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_input.Location = new Point(12, 33);
            txt_input.Name = "txt_input";
            txt_input.Size = new Size(262, 43);
            txt_input.TabIndex = 0;
            txt_input.Text = "0";
            // 
            // btn_histore
            // 
            btn_histore.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_histore.Location = new Point(12, 509);
            btn_histore.Name = "btn_histore";
            btn_histore.Size = new Size(262, 34);
            btn_histore.TabIndex = 1;
            btn_histore.Text = "History";
            btn_histore.UseVisualStyleBackColor = true;
            // 
            // btn_one
            // 
            btn_one.FlatAppearance.BorderColor = Color.Red;
            btn_one.FlatAppearance.BorderSize = 2;
            btn_one.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_one.Location = new Point(16, 377);
            btn_one.Name = "btn_one";
            btn_one.Size = new Size(60, 60);
            btn_one.TabIndex = 2;
            btn_one.Text = "1";
            btn_one.UseVisualStyleBackColor = true;
            btn_one.Click += btn_number;
            // 
            // btn_seven
            // 
            btn_seven.FlatAppearance.BorderColor = Color.Red;
            btn_seven.FlatAppearance.BorderSize = 2;
            btn_seven.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_seven.Location = new Point(16, 245);
            btn_seven.Name = "btn_seven";
            btn_seven.Size = new Size(60, 60);
            btn_seven.TabIndex = 4;
            btn_seven.Text = "7";
            btn_seven.UseVisualStyleBackColor = true;
            btn_seven.Click += btn_number;
            // 
            // btn_four
            // 
            btn_four.FlatAppearance.BorderColor = Color.Red;
            btn_four.FlatAppearance.BorderSize = 2;
            btn_four.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_four.Location = new Point(16, 311);
            btn_four.Name = "btn_four";
            btn_four.Size = new Size(60, 60);
            btn_four.TabIndex = 3;
            btn_four.Text = "4";
            btn_four.UseVisualStyleBackColor = true;
            btn_four.Click += btn_number;
            // 
            // btn_percenteg
            // 
            btn_percenteg.FlatAppearance.BorderColor = Color.Red;
            btn_percenteg.FlatAppearance.BorderSize = 2;
            btn_percenteg.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_percenteg.Location = new Point(16, 113);
            btn_percenteg.Name = "btn_percenteg";
            btn_percenteg.Size = new Size(60, 60);
            btn_percenteg.TabIndex = 6;
            btn_percenteg.Text = "%";
            btn_percenteg.UseVisualStyleBackColor = true;
            btn_percenteg.Click += btn_operations;
            // 
            // btn_Sqrt
            // 
            btn_Sqrt.FlatAppearance.BorderColor = Color.Red;
            btn_Sqrt.FlatAppearance.BorderSize = 2;
            btn_Sqrt.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Sqrt.Location = new Point(16, 179);
            btn_Sqrt.Name = "btn_Sqrt";
            btn_Sqrt.Size = new Size(60, 60);
            btn_Sqrt.TabIndex = 5;
            btn_Sqrt.Text = "√";
            btn_Sqrt.UseVisualStyleBackColor = true;
            // 
            // btn_CE
            // 
            btn_CE.FlatAppearance.BorderColor = Color.Red;
            btn_CE.FlatAppearance.BorderSize = 2;
            btn_CE.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_CE.Location = new Point(82, 113);
            btn_CE.Name = "btn_CE";
            btn_CE.Size = new Size(60, 60);
            btn_CE.TabIndex = 12;
            btn_CE.Text = "CE";
            btn_CE.UseVisualStyleBackColor = true;
            btn_CE.Click += btn_CE_Click;
            // 
            // btn_Lbracet
            // 
            btn_Lbracet.FlatAppearance.BorderColor = Color.Red;
            btn_Lbracet.FlatAppearance.BorderSize = 2;
            btn_Lbracet.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Lbracet.Location = new Point(82, 179);
            btn_Lbracet.Name = "btn_Lbracet";
            btn_Lbracet.Size = new Size(60, 60);
            btn_Lbracet.TabIndex = 11;
            btn_Lbracet.Text = "(";
            btn_Lbracet.UseVisualStyleBackColor = true;
            // 
            // btn_eight
            // 
            btn_eight.FlatAppearance.BorderColor = Color.Red;
            btn_eight.FlatAppearance.BorderSize = 2;
            btn_eight.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_eight.Location = new Point(82, 245);
            btn_eight.Name = "btn_eight";
            btn_eight.Size = new Size(60, 60);
            btn_eight.TabIndex = 10;
            btn_eight.Text = "8";
            btn_eight.UseVisualStyleBackColor = true;
            btn_eight.Click += btn_number;
            // 
            // btn_five
            // 
            btn_five.FlatAppearance.BorderColor = Color.Red;
            btn_five.FlatAppearance.BorderSize = 2;
            btn_five.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_five.Location = new Point(82, 311);
            btn_five.Name = "btn_five";
            btn_five.Size = new Size(60, 60);
            btn_five.TabIndex = 9;
            btn_five.Text = "5";
            btn_five.UseVisualStyleBackColor = true;
            btn_five.Click += btn_number;
            // 
            // btn_two
            // 
            btn_two.FlatAppearance.BorderColor = Color.Red;
            btn_two.FlatAppearance.BorderSize = 2;
            btn_two.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_two.Location = new Point(82, 377);
            btn_two.Name = "btn_two";
            btn_two.Size = new Size(60, 60);
            btn_two.TabIndex = 8;
            btn_two.Text = "2";
            btn_two.UseVisualStyleBackColor = true;
            btn_two.Click += btn_number;
            // 
            // btn_zero
            // 
            btn_zero.FlatAppearance.BorderColor = Color.Red;
            btn_zero.FlatAppearance.BorderSize = 2;
            btn_zero.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_zero.Location = new Point(82, 443);
            btn_zero.Name = "btn_zero";
            btn_zero.Size = new Size(60, 60);
            btn_zero.TabIndex = 7;
            btn_zero.Text = "0";
            btn_zero.UseVisualStyleBackColor = true;
            btn_zero.Click += btn_number;
            // 
            // btn_C
            // 
            btn_C.FlatAppearance.BorderColor = Color.Red;
            btn_C.FlatAppearance.BorderSize = 2;
            btn_C.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_C.Location = new Point(148, 113);
            btn_C.Name = "btn_C";
            btn_C.Size = new Size(60, 60);
            btn_C.TabIndex = 18;
            btn_C.Text = "C";
            btn_C.UseVisualStyleBackColor = true;
            btn_C.Click += btn_C_Click;
            // 
            // btn_Rbracket
            // 
            btn_Rbracket.FlatAppearance.BorderColor = Color.Red;
            btn_Rbracket.FlatAppearance.BorderSize = 2;
            btn_Rbracket.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Rbracket.Location = new Point(148, 179);
            btn_Rbracket.Name = "btn_Rbracket";
            btn_Rbracket.Size = new Size(60, 60);
            btn_Rbracket.TabIndex = 17;
            btn_Rbracket.Text = ")";
            btn_Rbracket.UseVisualStyleBackColor = true;
            // 
            // btn_nine
            // 
            btn_nine.FlatAppearance.BorderColor = Color.Red;
            btn_nine.FlatAppearance.BorderSize = 2;
            btn_nine.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_nine.Location = new Point(148, 242);
            btn_nine.Name = "btn_nine";
            btn_nine.Size = new Size(60, 60);
            btn_nine.TabIndex = 16;
            btn_nine.Text = "9";
            btn_nine.UseVisualStyleBackColor = true;
            btn_nine.Click += btn_number;
            // 
            // btn_six
            // 
            btn_six.FlatAppearance.BorderColor = Color.Red;
            btn_six.FlatAppearance.BorderSize = 2;
            btn_six.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_six.Location = new Point(148, 311);
            btn_six.Name = "btn_six";
            btn_six.Size = new Size(60, 60);
            btn_six.TabIndex = 15;
            btn_six.Text = "6";
            btn_six.UseVisualStyleBackColor = true;
            btn_six.Click += btn_number;
            // 
            // btn_three
            // 
            btn_three.FlatAppearance.BorderColor = Color.Red;
            btn_three.FlatAppearance.BorderSize = 2;
            btn_three.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_three.Location = new Point(148, 377);
            btn_three.Name = "btn_three";
            btn_three.Size = new Size(60, 60);
            btn_three.TabIndex = 14;
            btn_three.Text = "3";
            btn_three.UseVisualStyleBackColor = true;
            btn_three.Click += btn_number;
            // 
            // btn_Remove
            // 
            btn_Remove.FlatAppearance.BorderColor = Color.Red;
            btn_Remove.FlatAppearance.BorderSize = 2;
            btn_Remove.Font = new Font("Segoe UI Symbol", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Remove.Location = new Point(214, 113);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(60, 60);
            btn_Remove.TabIndex = 24;
            btn_Remove.Text = "←";
            btn_Remove.UseVisualStyleBackColor = true;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // btn_divid
            // 
            btn_divid.FlatAppearance.BorderColor = Color.Red;
            btn_divid.FlatAppearance.BorderSize = 2;
            btn_divid.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_divid.Location = new Point(214, 179);
            btn_divid.Name = "btn_divid";
            btn_divid.Size = new Size(60, 60);
            btn_divid.TabIndex = 23;
            btn_divid.Text = "/";
            btn_divid.UseVisualStyleBackColor = true;
            btn_divid.Click += btn_operations;
            // 
            // btn_by
            // 
            btn_by.FlatAppearance.BorderColor = Color.Red;
            btn_by.FlatAppearance.BorderSize = 2;
            btn_by.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_by.Location = new Point(214, 242);
            btn_by.Name = "btn_by";
            btn_by.Size = new Size(60, 60);
            btn_by.TabIndex = 22;
            btn_by.Text = "*";
            btn_by.UseVisualStyleBackColor = true;
            btn_by.Click += btn_operations;
            // 
            // btn_minis
            // 
            btn_minis.FlatAppearance.BorderColor = Color.Red;
            btn_minis.FlatAppearance.BorderSize = 2;
            btn_minis.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_minis.Location = new Point(214, 311);
            btn_minis.Name = "btn_minis";
            btn_minis.Size = new Size(60, 60);
            btn_minis.TabIndex = 21;
            btn_minis.Text = "-";
            btn_minis.UseVisualStyleBackColor = true;
            btn_minis.Click += btn_operations;
            // 
            // btn_plus
            // 
            btn_plus.FlatAppearance.BorderColor = Color.Red;
            btn_plus.FlatAppearance.BorderSize = 2;
            btn_plus.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_plus.Location = new Point(214, 377);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new Size(60, 60);
            btn_plus.TabIndex = 20;
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = true;
            btn_plus.Click += btn_operations;
            // 
            // btn_ecual
            // 
            btn_ecual.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ecual.Location = new Point(148, 443);
            btn_ecual.Name = "btn_ecual";
            btn_ecual.Size = new Size(126, 60);
            btn_ecual.TabIndex = 19;
            btn_ecual.Text = "=";
            btn_ecual.UseVisualStyleBackColor = true;
            btn_ecual.Click += btn_ecual_Click;
            // 
            // lbl_result
            // 
            lbl_result.AutoSize = true;
            lbl_result.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_result.ForeColor = SystemColors.HotTrack;
            lbl_result.Location = new Point(16, 79);
            lbl_result.Name = "lbl_result";
            lbl_result.Size = new Size(25, 30);
            lbl_result.TabIndex = 25;
            lbl_result.Text = "0";
            // 
            // btn_dot
            // 
            btn_dot.FlatAppearance.BorderColor = Color.Red;
            btn_dot.FlatAppearance.BorderSize = 2;
            btn_dot.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_dot.Location = new Point(16, 443);
            btn_dot.Name = "btn_dot";
            btn_dot.Size = new Size(60, 60);
            btn_dot.TabIndex = 26;
            btn_dot.Text = ".";
            btn_dot.UseVisualStyleBackColor = true;
            btn_dot.Click += dot;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(289, 24);
            menuStrip1.TabIndex = 27;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { standeredToolStripMenuItem, scientificToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // standeredToolStripMenuItem
            // 
            standeredToolStripMenuItem.Name = "standeredToolStripMenuItem";
            standeredToolStripMenuItem.Size = new Size(127, 22);
            standeredToolStripMenuItem.Text = "Standered";
            // 
            // scientificToolStripMenuItem
            // 
            scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            scientificToolStripMenuItem.Size = new Size(127, 22);
            scientificToolStripMenuItem.Text = "Scientific";
            // 
            // calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 554);
            Controls.Add(btn_dot);
            Controls.Add(lbl_result);
            Controls.Add(btn_Remove);
            Controls.Add(btn_divid);
            Controls.Add(btn_by);
            Controls.Add(btn_minis);
            Controls.Add(btn_plus);
            Controls.Add(btn_ecual);
            Controls.Add(btn_C);
            Controls.Add(btn_Rbracket);
            Controls.Add(btn_nine);
            Controls.Add(btn_six);
            Controls.Add(btn_three);
            Controls.Add(btn_CE);
            Controls.Add(btn_Lbracet);
            Controls.Add(btn_eight);
            Controls.Add(btn_five);
            Controls.Add(btn_two);
            Controls.Add(btn_zero);
            Controls.Add(btn_percenteg);
            Controls.Add(btn_Sqrt);
            Controls.Add(btn_seven);
            Controls.Add(btn_four);
            Controls.Add(btn_one);
            Controls.Add(btn_histore);
            Controls.Add(txt_input);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(305, 593);
            MinimumSize = new Size(305, 593);
            Name = "calculator";
            Text = "calculator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_input;
        private Button btn_histore;
        private Button btn_one;
        private Button btn_seven;
        private Button btn_four;
        private Button btn_percenteg;
        private Button btn_Sqrt;
        private Button btn_CE;
        private Button btn_Lbracet;
        private Button btn_eight;
        private Button btn_five;
        private Button btn_two;
        private Button btn_zero;
        private Button btn_C;
        private Button btn_Rbracket;
        private Button btn_nine;
        private Button btn_six;
        private Button btn_three;

        private Button btn_Remove;
        private Button btn_divid;
        private Button btn_by;
        private Button btn_minis;
        private Button btn_plus;
        private Button btn_ecual;
        private Label lbl_result;
        private Button button1;
        private Button btn_dot;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem standeredToolStripMenuItem;
        private ToolStripMenuItem scientificToolStripMenuItem;
    }
}