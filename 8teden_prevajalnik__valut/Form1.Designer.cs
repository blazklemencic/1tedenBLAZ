namespace _8teden_prevajalnik__valut
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
            unit_sel_1 = new ComboBox();
            value1 = new TextBox();
            value2 = new TextBox();
            unit_sel_2 = new ComboBox();
            SuspendLayout();
            // 
            // unit_sel_1
            // 
            unit_sel_1.FormattingEnabled = true;
            unit_sel_1.Location = new Point(109, 99);
            unit_sel_1.Name = "unit_sel_1";
            unit_sel_1.Size = new Size(121, 23);
            unit_sel_1.TabIndex = 0;
            unit_sel_1.SelectedIndexChanged += unit_sel_1_SelectedIndexChanged;
            // 
            // value1
            // 
            value1.Location = new Point(109, 128);
            value1.Name = "value1";
            value1.Size = new Size(121, 23);
            value1.TabIndex = 1;
            value1.TextChanged += value1_TextChanged;
            // 
            // value2
            // 
            value2.Location = new Point(301, 128);
            value2.Name = "value2";
            value2.Size = new Size(121, 23);
            value2.TabIndex = 3;
            value2.TextChanged += value2_TextChanged;
            // 
            // unit_sel_2
            // 
            unit_sel_2.FormattingEnabled = true;
            unit_sel_2.Location = new Point(301, 99);
            unit_sel_2.Name = "unit_sel_2";
            unit_sel_2.Size = new Size(121, 23);
            unit_sel_2.TabIndex = 2;
            unit_sel_2.SelectedIndexChanged += unit_sel_2_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(value2);
            Controls.Add(unit_sel_2);
            Controls.Add(value1);
            Controls.Add(unit_sel_1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox unit_sel_1;
        private TextBox value1;
        private TextBox value2;
        private ComboBox unit_sel_2;
    }
}
