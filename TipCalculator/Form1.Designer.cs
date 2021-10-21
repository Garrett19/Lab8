
namespace TipCalculator
{
    partial class Form1
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
            this.CalcTotal = new System.Windows.Forms.Button();
            this.CalculatedTotalBox = new System.Windows.Forms.TextBox();
            this.TipAmountBox = new System.Windows.Forms.TextBox();
            this.TipPercentageBox = new System.Windows.Forms.TextBox();
            this.TotalBillBox = new System.Windows.Forms.TextBox();
            this.TotalBill = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TipAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalcTotal
            // 
            this.CalcTotal.Location = new System.Drawing.Point(153, 293);
            this.CalcTotal.Name = "CalcTotal";
            this.CalcTotal.Size = new System.Drawing.Size(144, 23);
            this.CalcTotal.TabIndex = 0;
            this.CalcTotal.Text = "Calculate Tip and Total Bill";
            this.CalcTotal.UseVisualStyleBackColor = true;
            this.CalcTotal.Click += new System.EventHandler(this.CalcTotal_Click);
            // 
            // CalculatedTotalBox
            // 
            this.CalculatedTotalBox.Location = new System.Drawing.Point(313, 293);
            this.CalculatedTotalBox.Name = "CalculatedTotalBox";
            this.CalculatedTotalBox.Size = new System.Drawing.Size(100, 20);
            this.CalculatedTotalBox.TabIndex = 1;
            this.CalculatedTotalBox.TextChanged += new System.EventHandler(this.CalculatedTotalBox_TextChanged);
            // 
            // TipAmountBox
            // 
            this.TipAmountBox.Location = new System.Drawing.Point(313, 243);
            this.TipAmountBox.Name = "TipAmountBox";
            this.TipAmountBox.Size = new System.Drawing.Size(100, 20);
            this.TipAmountBox.TabIndex = 2;
            this.TipAmountBox.TextChanged += new System.EventHandler(this.TipAmountBox_TextChanged);
            // 
            // TipPercentageBox
            // 
            this.TipPercentageBox.Location = new System.Drawing.Point(313, 184);
            this.TipPercentageBox.Name = "TipPercentageBox";
            this.TipPercentageBox.Size = new System.Drawing.Size(100, 20);
            this.TipPercentageBox.TabIndex = 3;
            this.TipPercentageBox.TextChanged += new System.EventHandler(this.TipPercentageBox_TextChanged);
            // 
            // TotalBillBox
            // 
            this.TotalBillBox.Location = new System.Drawing.Point(313, 123);
            this.TotalBillBox.Name = "TotalBillBox";
            this.TotalBillBox.Size = new System.Drawing.Size(100, 20);
            this.TotalBillBox.TabIndex = 4;
            this.TotalBillBox.TextChanged += new System.EventHandler(this.TotalBillBox_TextChanged);
            // 
            // TotalBill
            // 
            this.TotalBill.AutoSize = true;
            this.TotalBill.Location = new System.Drawing.Point(153, 123);
            this.TotalBill.Name = "TotalBill";
            this.TotalBill.Size = new System.Drawing.Size(75, 13);
            this.TotalBill.TabIndex = 5;
            this.TotalBill.Text = "Enter Total Bill";
            this.TotalBill.Click += new System.EventHandler(this.TotalBill_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Tip Percentage:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TipAmount
            // 
            this.TipAmount.AutoSize = true;
            this.TipAmount.Location = new System.Drawing.Point(153, 243);
            this.TipAmount.Name = "TipAmount";
            this.TipAmount.Size = new System.Drawing.Size(61, 13);
            this.TipAmount.TabIndex = 7;
            this.TipAmount.Text = "Tip Amount";
            this.TipAmount.Click += new System.EventHandler(this.TipAmount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TipAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalBill);
            this.Controls.Add(this.TotalBillBox);
            this.Controls.Add(this.TipPercentageBox);
            this.Controls.Add(this.TipAmountBox);
            this.Controls.Add(this.CalculatedTotalBox);
            this.Controls.Add(this.CalcTotal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcTotal;
        private System.Windows.Forms.TextBox CalculatedTotalBox;
        private System.Windows.Forms.TextBox TipAmountBox;
        private System.Windows.Forms.TextBox TipPercentageBox;
        private System.Windows.Forms.TextBox TotalBillBox;
        private System.Windows.Forms.Label TotalBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TipAmount;
    }
}

