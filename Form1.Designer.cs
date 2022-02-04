
namespace degree
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
            this.lblen = new System.Windows.Forms.Label();
            this.txten = new System.Windows.Forms.TextBox();
            this.btnshowdgree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblen
            // 
            this.lblen.Location = new System.Drawing.Point(536, 156);
            this.lblen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblen.Name = "lblen";
            this.lblen.Size = new System.Drawing.Size(207, 41);
            this.lblen.TabIndex = 0;
            this.lblen.Text = "ادخل مجموع مادة الانجليزي";
            this.lblen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblen.Click += new System.EventHandler(this.lblen_Click);
            // 
            // txten
            // 
            this.txten.Location = new System.Drawing.Point(400, 167);
            this.txten.Name = "txten";
            this.txten.Size = new System.Drawing.Size(127, 30);
            this.txten.TabIndex = 1;
            this.txten.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnshowdgree
            // 
            this.btnshowdgree.Location = new System.Drawing.Point(400, 269);
            this.btnshowdgree.Name = "btnshowdgree";
            this.btnshowdgree.Size = new System.Drawing.Size(127, 34);
            this.btnshowdgree.TabIndex = 2;
            this.btnshowdgree.Text = "اظهر النتيجة";
            this.btnshowdgree.UseVisualStyleBackColor = true;
            this.btnshowdgree.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1015, 534);
            this.Controls.Add(this.btnshowdgree);
            this.Controls.Add(this.txten);
            this.Controls.Add(this.lblen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblen;
        private System.Windows.Forms.TextBox txten;
        private System.Windows.Forms.Button btnshowdgree;
    }
}

