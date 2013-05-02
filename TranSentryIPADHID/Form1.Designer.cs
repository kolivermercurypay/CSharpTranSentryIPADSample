namespace TranSentryIPADHID
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
            this.btnSwiped = new System.Windows.Forms.Button();
            this.btnKeyed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSwiped
            // 
            this.btnSwiped.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwiped.Location = new System.Drawing.Point(13, 13);
            this.btnSwiped.Name = "btnSwiped";
            this.btnSwiped.Size = new System.Drawing.Size(140, 101);
            this.btnSwiped.TabIndex = 0;
            this.btnSwiped.Text = "Swiped";
            this.btnSwiped.UseVisualStyleBackColor = true;
            this.btnSwiped.Click += new System.EventHandler(this.btnSwiped_Click);
            // 
            // btnKeyed
            // 
            this.btnKeyed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeyed.Location = new System.Drawing.Point(12, 120);
            this.btnKeyed.Name = "btnKeyed";
            this.btnKeyed.Size = new System.Drawing.Size(140, 101);
            this.btnKeyed.TabIndex = 1;
            this.btnKeyed.Text = "Keyed";
            this.btnKeyed.UseVisualStyleBackColor = true;
            this.btnKeyed.Click += new System.EventHandler(this.btnKeyed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(165, 234);
            this.Controls.Add(this.btnKeyed);
            this.Controls.Add(this.btnSwiped);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSwiped;
        private System.Windows.Forms.Button btnKeyed;
    }
}

