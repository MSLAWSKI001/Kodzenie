
namespace FisrstWinFormsApp
{
    partial class MainForm1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonHello = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonHelloName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFirst
            // 
            this.buttonFirst.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonFirst.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonFirst.Location = new System.Drawing.Point(68, 423);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(208, 136);
            this.buttonFirst.TabIndex = 0;
            this.buttonFirst.Text = "Przycisk";
            this.buttonFirst.UseVisualStyleBackColor = false;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonHello
            // 
            this.buttonHello.BackColor = System.Drawing.SystemColors.MenuText;
            this.buttonHello.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHello.Location = new System.Drawing.Point(376, 423);
            this.buttonHello.Name = "buttonHello";
            this.buttonHello.Size = new System.Drawing.Size(194, 136);
            this.buttonHello.TabIndex = 1;
            this.buttonHello.Text = "Hello";
            this.buttonHello.UseVisualStyleBackColor = false;
            this.buttonHello.Click += new System.EventHandler(this.button_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxName.Location = new System.Drawing.Point(68, 118);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(301, 29);
            this.textBoxName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.WindowText;
            this.labelName.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelName.Location = new System.Drawing.Point(68, 72);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(155, 43);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Podaj imie:";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // buttonHelloName
            // 
            this.buttonHelloName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonHelloName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonHelloName.Location = new System.Drawing.Point(68, 153);
            this.buttonHelloName.Name = "buttonHelloName";
            this.buttonHelloName.Size = new System.Drawing.Size(134, 41);
            this.buttonHelloName.TabIndex = 4;
            this.buttonHelloName.Text = "Przywitaj się";
            this.buttonHelloName.UseVisualStyleBackColor = false;
            this.buttonHelloName.Click += new System.EventHandler(this.buttonHelloName_Click);
            this.buttonHelloName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonHelloName_MouseClick);
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 607);
            this.Controls.Add(this.buttonHelloName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonHello);
            this.Controls.Add(this.buttonFirst);
            this.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "MainForm1";
            this.Text = "Pierwszy program okienkowy";
            this.Load += new System.EventHandler(this.MainForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonHello;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonHelloName;
    }
}

