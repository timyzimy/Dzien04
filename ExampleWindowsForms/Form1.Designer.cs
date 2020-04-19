namespace ExampleWindowsForms
{
    partial class frmMain
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
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnName = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(102, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Podaj imie:";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(222, 40);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(354, 31);
            this.tbName.TabIndex = 1;
            this.tbName.Text = "bla bla";
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // btnName
            // 
            this.btnName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnName.Location = new System.Drawing.Point(332, 104);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(134, 49);
            this.btnName.TabIndex = 2;
            this.btnName.Text = "Zastosuj";
            this.btnName.UseVisualStyleBackColor = false;
            this.btnName.Click += new System.EventHandler(this.clickButtonEvent);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(39, 177);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(735, 248);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "sadasdasd";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Label lblResult;
    }
}

