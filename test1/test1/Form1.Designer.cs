namespace test1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtyears = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.btngetbonus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year of Service:";
            // 
            // txtyears
            // 
            this.txtyears.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyears.Location = new System.Drawing.Point(411, 154);
            this.txtyears.Name = "txtyears";
            this.txtyears.Size = new System.Drawing.Size(201, 41);
            this.txtyears.TabIndex = 1;
            this.txtyears.TextChanged += new System.EventHandler(this.txtyears_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Salary:";
            // 
            // txtsalary
            // 
            this.txtsalary.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalary.Location = new System.Drawing.Point(411, 217);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(201, 41);
            this.txtsalary.TabIndex = 3;
            this.txtsalary.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btngetbonus
            // 
            this.btngetbonus.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngetbonus.Location = new System.Drawing.Point(309, 285);
            this.btngetbonus.Name = "btngetbonus";
            this.btngetbonus.Size = new System.Drawing.Size(194, 43);
            this.btngetbonus.TabIndex = 4;
            this.btngetbonus.Text = "GET BONUS";
            this.btngetbonus.UseVisualStyleBackColor = true;
            this.btngetbonus.Click += new System.EventHandler(this.btngetbonus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "YEAR-END BONUS CALCULATOR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btngetbonus);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtyears);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtyears;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.Button btngetbonus;
        private System.Windows.Forms.Label label3;
    }
}

