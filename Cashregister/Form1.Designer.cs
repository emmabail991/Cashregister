
namespace Cashregister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputReceipt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.baldefadeInput = new System.Windows.Forms.TextBox();
            this.BowlcutInput = new System.Windows.Forms.TextBox();
            this.BuzzcutInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calculateTotalbutton2 = new System.Windows.Forms.Button();
            this.totalOutput = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.amountpayedInput = new System.Windows.Forms.TextBox();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.PrintReceiptButton = new System.Windows.Forms.Button();
            this.changeAmountOutput = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputReceipt
            // 
            this.outputReceipt.BackColor = System.Drawing.Color.White;
            this.outputReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputReceipt.Location = new System.Drawing.Point(276, 107);
            this.outputReceipt.Name = "outputReceipt";
            this.outputReceipt.Size = new System.Drawing.Size(260, 428);
            this.outputReceipt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(524, 82);
            this.label2.TabIndex = 1;
            this.label2.Text = "Online Barber Shop";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // baldefadeInput
            // 
            this.baldefadeInput.Location = new System.Drawing.Point(170, 132);
            this.baldefadeInput.Name = "baldefadeInput";
            this.baldefadeInput.Size = new System.Drawing.Size(100, 20);
            this.baldefadeInput.TabIndex = 2;
            this.baldefadeInput.Text = "0";
            // 
            // BowlcutInput
            // 
            this.BowlcutInput.Location = new System.Drawing.Point(170, 184);
            this.BowlcutInput.Name = "BowlcutInput";
            this.BowlcutInput.Size = new System.Drawing.Size(100, 20);
            this.BowlcutInput.TabIndex = 3;
            this.BowlcutInput.Text = "0";
            // 
            // BuzzcutInput
            // 
            this.BuzzcutInput.Location = new System.Drawing.Point(170, 158);
            this.BuzzcutInput.Name = "BuzzcutInput";
            this.BuzzcutInput.Size = new System.Drawing.Size(100, 20);
            this.BuzzcutInput.TabIndex = 4;
            this.BuzzcutInput.Text = "0";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "\"We are in parallel universe and everyone has multiple heads\"";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bald fades....$25";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Buzz cuts......$15";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bowl cuts......$60";
            // 
            // calculateTotalbutton2
            // 
            this.calculateTotalbutton2.Location = new System.Drawing.Point(50, 210);
            this.calculateTotalbutton2.Name = "calculateTotalbutton2";
            this.calculateTotalbutton2.Size = new System.Drawing.Size(155, 33);
            this.calculateTotalbutton2.TabIndex = 9;
            this.calculateTotalbutton2.Text = "Calculate Total ";
            this.calculateTotalbutton2.UseVisualStyleBackColor = true;
            this.calculateTotalbutton2.Click += new System.EventHandler(this.calculateTotalbutton2_Click);
            // 
            // totalOutput
            // 
            this.totalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(12, 258);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(193, 127);
            this.totalOutput.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Amount payed";
            // 
            // amountpayedInput
            // 
            this.amountpayedInput.Location = new System.Drawing.Point(120, 399);
            this.amountpayedInput.Name = "amountpayedInput";
            this.amountpayedInput.Size = new System.Drawing.Size(100, 20);
            this.amountpayedInput.TabIndex = 12;
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.Location = new System.Drawing.Point(50, 425);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(155, 33);
            this.calculateChangeButton.TabIndex = 13;
            this.calculateChangeButton.Text = "Calculate Change";
            this.calculateChangeButton.UseVisualStyleBackColor = true;
            this.calculateChangeButton.Click += new System.EventHandler(this.calculateChangeButton_Click);
            // 
            // PrintReceiptButton
            // 
            this.PrintReceiptButton.Location = new System.Drawing.Point(50, 537);
            this.PrintReceiptButton.Name = "PrintReceiptButton";
            this.PrintReceiptButton.Size = new System.Drawing.Size(155, 33);
            this.PrintReceiptButton.TabIndex = 14;
            this.PrintReceiptButton.Text = "Print Receipt";
            this.PrintReceiptButton.UseVisualStyleBackColor = true;
            this.PrintReceiptButton.Click += new System.EventHandler(this.PrintReceiptButton_Click);
            // 
            // changeAmountOutput
            // 
            this.changeAmountOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeAmountOutput.Location = new System.Drawing.Point(6, 487);
            this.changeAmountOutput.Name = "changeAmountOutput";
            this.changeAmountOutput.Size = new System.Drawing.Size(264, 23);
            this.changeAmountOutput.TabIndex = 15;
            this.changeAmountOutput.Text = " ";
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(279, 542);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(257, 23);
            this.newOrderButton.TabIndex = 16;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(548, 579);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.changeAmountOutput);
            this.Controls.Add(this.PrintReceiptButton);
            this.Controls.Add(this.calculateChangeButton);
            this.Controls.Add(this.amountpayedInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.calculateTotalbutton2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuzzcutInput);
            this.Controls.Add(this.BowlcutInput);
            this.Controls.Add(this.baldefadeInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputReceipt);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputReceipt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox baldefadeInput;
        private System.Windows.Forms.TextBox BowlcutInput;
        private System.Windows.Forms.TextBox BuzzcutInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calculateTotalbutton2;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox amountpayedInput;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.Button PrintReceiptButton;
        private System.Windows.Forms.Label changeAmountOutput;
        private System.Windows.Forms.Button newOrderButton;
    }
}

