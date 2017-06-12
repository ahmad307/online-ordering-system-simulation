namespace Online_Ordering_System.Front_end
{
    partial class ItemPopUp
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
            this.NameTxT = new System.Windows.Forms.TextBox();
            this.PriceTxT = new System.Windows.Forms.TextBox();
            this.QuantityTxT = new System.Windows.Forms.TextBox();
            this.TypeTxT = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTxT
            // 
            this.NameTxT.Location = new System.Drawing.Point(26, 39);
            this.NameTxT.Name = "NameTxT";
            this.NameTxT.Size = new System.Drawing.Size(100, 20);
            this.NameTxT.TabIndex = 0;
            // 
            // PriceTxT
            // 
            this.PriceTxT.Location = new System.Drawing.Point(141, 39);
            this.PriceTxT.Name = "PriceTxT";
            this.PriceTxT.Size = new System.Drawing.Size(100, 20);
            this.PriceTxT.TabIndex = 1;
            // 
            // QuantityTxT
            // 
            this.QuantityTxT.Location = new System.Drawing.Point(260, 39);
            this.QuantityTxT.Name = "QuantityTxT";
            this.QuantityTxT.Size = new System.Drawing.Size(100, 20);
            this.QuantityTxT.TabIndex = 2;
            // 
            // TypeTxT
            // 
            this.TypeTxT.Location = new System.Drawing.Point(380, 39);
            this.TypeTxT.Name = "TypeTxT";
            this.TypeTxT.Size = new System.Drawing.Size(100, 20);
            this.TypeTxT.TabIndex = 3;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(524, 33);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(102, 26);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(524, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(102, 26);
            this.EditButton.TabIndex = 9;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(524, 67);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(102, 26);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ItemPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 97);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.TypeTxT);
            this.Controls.Add(this.QuantityTxT);
            this.Controls.Add(this.PriceTxT);
            this.Controls.Add(this.NameTxT);
            this.Name = "ItemPopUp";
            this.Text = "ItemPopUp";
            this.Load += new System.EventHandler(this.ItemPopUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTxT;
        private System.Windows.Forms.TextBox PriceTxT;
        private System.Windows.Forms.TextBox QuantityTxT;
        private System.Windows.Forms.TextBox TypeTxT;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button BackButton;
    }
}