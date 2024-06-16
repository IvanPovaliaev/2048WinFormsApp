namespace _2048WinFormsApp
{
    partial class RulesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulesForm));
            titleLabel = new System.Windows.Forms.Label();
            okButton = new System.Windows.Forms.Button();
            rulesTextBox = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            titleLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            titleLabel.Location = new System.Drawing.Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(784, 44);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Правила игры";
            titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okButton
            // 
            okButton.BackColor = System.Drawing.Color.FromArgb(187, 173, 160);
            okButton.FlatAppearance.BorderSize = 0;
            okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            okButton.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            okButton.Location = new System.Drawing.Point(325, 500);
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(150, 40);
            okButton.TabIndex = 1;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = false;
            okButton.Click += okButton_Click;
            // 
            // rulesTextBox
            // 
            rulesTextBox.BackColor = System.Drawing.Color.FromArgb(250, 248, 239);
            rulesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            rulesTextBox.Font = new System.Drawing.Font("Montserrat Medium", 11F, System.Drawing.FontStyle.Bold);
            rulesTextBox.Location = new System.Drawing.Point(12, 47);
            rulesTextBox.Multiline = true;
            rulesTextBox.Name = "rulesTextBox";
            rulesTextBox.Size = new System.Drawing.Size(760, 447);
            rulesTextBox.TabIndex = 2;
            rulesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RulesForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(250, 248, 239);
            ClientSize = new System.Drawing.Size(784, 561);
            Controls.Add(rulesTextBox);
            Controls.Add(okButton);
            Controls.Add(titleLabel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(800, 600);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(800, 600);
            Name = "RulesForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "RulesForm";
            Load += RulesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox rulesTextBox;
    }
}