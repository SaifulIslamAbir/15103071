namespace MyWinApp
{
    partial class SumForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberTwoTextBox = new System.Windows.Forms.TextBox();
            this.NumberOneTextBox = new System.Windows.Forms.TextBox();
            this.SumButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number 2";
            // 
            // NumberTwoTextBox
            // 
            this.NumberTwoTextBox.Location = new System.Drawing.Point(309, 133);
            this.NumberTwoTextBox.Name = "NumberTwoTextBox";
            this.NumberTwoTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumberTwoTextBox.TabIndex = 2;
            // 
            // NumberOneTextBox
            // 
            this.NumberOneTextBox.Location = new System.Drawing.Point(309, 88);
            this.NumberOneTextBox.Name = "NumberOneTextBox";
            this.NumberOneTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumberOneTextBox.TabIndex = 3;
            // 
            // SumButton
            // 
            this.SumButton.Location = new System.Drawing.Point(309, 175);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(75, 23);
            this.SumButton.TabIndex = 4;
            this.SumButton.Text = "Add";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sum";
            // 
            // SumTextBox
            // 
            this.SumTextBox.Location = new System.Drawing.Point(309, 262);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.Size = new System.Drawing.Size(100, 20);
            this.SumTextBox.TabIndex = 6;
            // 
            // SumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SumButton);
            this.Controls.Add(this.NumberOneTextBox);
            this.Controls.Add(this.NumberTwoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SumForm";
            this.Text = "Sum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumberTwoTextBox;
        private System.Windows.Forms.TextBox NumberOneTextBox;
        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SumTextBox;
    }
}