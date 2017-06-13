namespace Online_Ordering_System.Front_end
{
    partial class Advanced_Filter
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
            this.button1 = new System.Windows.Forms.Button();
            this.Filter_From_txt = new System.Windows.Forms.TextBox();
            this.Filter_to_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Filter_SearchWord_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Filter_WholeWord_check = new System.Windows.Forms.CheckBox();
            this.Filter_MatchCase_check = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Filter_From_txt
            // 
            this.Filter_From_txt.Location = new System.Drawing.Point(70, 49);
            this.Filter_From_txt.Name = "Filter_From_txt";
            this.Filter_From_txt.Size = new System.Drawing.Size(64, 20);
            this.Filter_From_txt.TabIndex = 1;
            // 
            // Filter_to_txt
            // 
            this.Filter_to_txt.Location = new System.Drawing.Point(185, 49);
            this.Filter_to_txt.Name = "Filter_to_txt";
            this.Filter_to_txt.Size = new System.Drawing.Size(67, 20);
            this.Filter_to_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Price Range";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(151, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(22, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(20, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Filtering";
            // 
            // Filter_SearchWord_txt
            // 
            this.Filter_SearchWord_txt.Location = new System.Drawing.Point(102, 134);
            this.Filter_SearchWord_txt.Name = "Filter_SearchWord_txt";
            this.Filter_SearchWord_txt.Size = new System.Drawing.Size(163, 20);
            this.Filter_SearchWord_txt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(5, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Enter item Name";
            // 
            // Filter_WholeWord_check
            // 
            this.Filter_WholeWord_check.AutoSize = true;
            this.Filter_WholeWord_check.BackColor = System.Drawing.Color.Transparent;
            this.Filter_WholeWord_check.Location = new System.Drawing.Point(40, 183);
            this.Filter_WholeWord_check.Name = "Filter_WholeWord_check";
            this.Filter_WholeWord_check.Size = new System.Drawing.Size(85, 17);
            this.Filter_WholeWord_check.TabIndex = 9;
            this.Filter_WholeWord_check.Text = "Whole Word";
            this.Filter_WholeWord_check.UseVisualStyleBackColor = false;
            // 
            // Filter_MatchCase_check
            // 
            this.Filter_MatchCase_check.AutoSize = true;
            this.Filter_MatchCase_check.BackColor = System.Drawing.Color.Transparent;
            this.Filter_MatchCase_check.Location = new System.Drawing.Point(154, 183);
            this.Filter_MatchCase_check.Name = "Filter_MatchCase_check";
            this.Filter_MatchCase_check.Size = new System.Drawing.Size(82, 17);
            this.Filter_MatchCase_check.TabIndex = 10;
            this.Filter_MatchCase_check.Text = "Match Case";
            this.Filter_MatchCase_check.UseVisualStyleBackColor = false;
            // 
            // Advanced_Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Online_Ordering_System.Properties.Resources.pattern_s;
            this.ClientSize = new System.Drawing.Size(292, 274);
            this.Controls.Add(this.Filter_MatchCase_check);
            this.Controls.Add(this.Filter_WholeWord_check);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Filter_SearchWord_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Filter_to_txt);
            this.Controls.Add(this.Filter_From_txt);
            this.Controls.Add(this.button1);
            this.Name = "Advanced_Filter";
            this.Text = "Advanced_Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Filter_From_txt;
        private System.Windows.Forms.TextBox Filter_to_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Filter_SearchWord_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Filter_WholeWord_check;
        private System.Windows.Forms.CheckBox Filter_MatchCase_check;
    }
}