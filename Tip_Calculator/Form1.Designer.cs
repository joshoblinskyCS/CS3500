namespace Tip_Calculator
{
    partial class tipCalculator
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
            this.billLabel = new System.Windows.Forms.Label();
            this.billTextbox = new System.Windows.Forms.TextBox();
            this.computeTextbox = new System.Windows.Forms.TextBox();
            this.computeLabel = new System.Windows.Forms.Label();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.percentageTextbox = new System.Windows.Forms.TextBox();
            this.percentSignLabel = new System.Windows.Forms.Label();
            this.dollarSignLabel = new System.Windows.Forms.Label();
            this.dollarSignLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // billLabel
            // 
            this.billLabel.AutoSize = true;
            this.billLabel.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billLabel.Location = new System.Drawing.Point(10, 27);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(163, 23);
            this.billLabel.TabIndex = 2;
            this.billLabel.Text = "Enter Total Bill:";
            this.billLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // billTextbox
            // 
            this.billTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.billTextbox.Location = new System.Drawing.Point(215, 25);
            this.billTextbox.Name = "billTextbox";
            this.billTextbox.Size = new System.Drawing.Size(112, 26);
            this.billTextbox.TabIndex = 3;
            this.billTextbox.TextChanged += new System.EventHandler(this.billTextbox_TextChanged);
            // 
            // computeTextbox
            // 
            this.computeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.computeTextbox.Location = new System.Drawing.Point(258, 262);
            this.computeTextbox.Name = "computeTextbox";
            this.computeTextbox.Size = new System.Drawing.Size(147, 30);
            this.computeTextbox.TabIndex = 4;
            // 
            // computeLabel
            // 
            this.computeLabel.AutoSize = true;
            this.computeLabel.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computeLabel.Location = new System.Drawing.Point(144, 265);
            this.computeLabel.Name = "computeLabel";
            this.computeLabel.Size = new System.Drawing.Size(89, 27);
            this.computeLabel.TabIndex = 5;
            this.computeLabel.Text = "Result:";
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentageLabel.Location = new System.Drawing.Point(16, 70);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(158, 23);
            this.percentageLabel.TabIndex = 6;
            this.percentageLabel.Text = "Tip Percentage:";
            // 
            // percentageTextbox
            // 
            this.percentageTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.percentageTextbox.Location = new System.Drawing.Point(215, 68);
            this.percentageTextbox.Name = "percentageTextbox";
            this.percentageTextbox.Size = new System.Drawing.Size(112, 26);
            this.percentageTextbox.TabIndex = 7;
            this.percentageTextbox.TextChanged += new System.EventHandler(this.percentageTextbox_TextChanged);
            // 
            // percentSignLabel
            // 
            this.percentSignLabel.AutoSize = true;
            this.percentSignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.percentSignLabel.Location = new System.Drawing.Point(333, 71);
            this.percentSignLabel.Name = "percentSignLabel";
            this.percentSignLabel.Size = new System.Drawing.Size(24, 20);
            this.percentSignLabel.TabIndex = 8;
            this.percentSignLabel.Text = "%";
            // 
            // dollarSignLabel
            // 
            this.dollarSignLabel.AutoSize = true;
            this.dollarSignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dollarSignLabel.Location = new System.Drawing.Point(191, 28);
            this.dollarSignLabel.Name = "dollarSignLabel";
            this.dollarSignLabel.Size = new System.Drawing.Size(18, 20);
            this.dollarSignLabel.TabIndex = 9;
            this.dollarSignLabel.Text = "$";
            // 
            // dollarSignLabel2
            // 
            this.dollarSignLabel2.AutoSize = true;
            this.dollarSignLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dollarSignLabel2.Location = new System.Drawing.Point(239, 265);
            this.dollarSignLabel2.Name = "dollarSignLabel2";
            this.dollarSignLabel2.Size = new System.Drawing.Size(23, 25);
            this.dollarSignLabel2.TabIndex = 10;
            this.dollarSignLabel2.Text = "$";
            // 
            // tipCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(417, 301);
            this.Controls.Add(this.dollarSignLabel2);
            this.Controls.Add(this.dollarSignLabel);
            this.Controls.Add(this.percentSignLabel);
            this.Controls.Add(this.percentageTextbox);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.computeLabel);
            this.Controls.Add(this.computeTextbox);
            this.Controls.Add(this.billTextbox);
            this.Controls.Add(this.billLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "tipCalculator";
            this.Text = "Tip Calculator 5000";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label billLabel;
        private System.Windows.Forms.TextBox billTextbox;
        private System.Windows.Forms.TextBox computeTextbox;
        private System.Windows.Forms.Label computeLabel;
        private System.Windows.Forms.Label percentageLabel;
        private System.Windows.Forms.TextBox percentageTextbox;
        private System.Windows.Forms.Label percentSignLabel;
        private System.Windows.Forms.Label dollarSignLabel;
        private System.Windows.Forms.Label dollarSignLabel2;
    }
}

