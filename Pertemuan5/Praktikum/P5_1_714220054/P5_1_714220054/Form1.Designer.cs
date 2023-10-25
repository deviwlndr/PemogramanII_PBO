namespace P5_1_714220054
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
            this.OutputLabel = new System.Windows.Forms.Label();
            this.HellooButton = new System.Windows.Forms.Button();
            this.ExittButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutputLabel
            // 
            this.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputLabel.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(73, 47);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(410, 37);
            this.OutputLabel.TabIndex = 0;
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HellooButton
            // 
            this.HellooButton.Location = new System.Drawing.Point(73, 146);
            this.HellooButton.Name = "HellooButton";
            this.HellooButton.Size = new System.Drawing.Size(106, 41);
            this.HellooButton.TabIndex = 1;
            this.HellooButton.Text = "&Say Hello";
            this.HellooButton.UseVisualStyleBackColor = true;
            this.HellooButton.Click += new System.EventHandler(this.HellooButton_Click);
            // 
            // ExittButton
            // 
            this.ExittButton.Location = new System.Drawing.Point(371, 146);
            this.ExittButton.Name = "ExittButton";
            this.ExittButton.Size = new System.Drawing.Size(100, 41);
            this.ExittButton.TabIndex = 2;
            this.ExittButton.Text = "E&xit";
            this.ExittButton.UseVisualStyleBackColor = true;
            this.ExittButton.Click += new System.EventHandler(this.ExittButton_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(560, 244);
            this.Controls.Add(this.ExittButton);
            this.Controls.Add(this.HellooButton);
            this.Controls.Add(this.OutputLabel);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HelloButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button HellooButton;
        private System.Windows.Forms.Button ExittButton;
    }
}

