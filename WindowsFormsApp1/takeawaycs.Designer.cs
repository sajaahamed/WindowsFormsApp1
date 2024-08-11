namespace WindowsFormsApp1
{
    partial class takeawaycs
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
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Button = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Button
            // 
            this.guna2Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button.BackColor = System.Drawing.Color.MintCream;
            this.guna2Button.BorderRadius = 12;
            this.guna2Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button.FillColor = System.Drawing.Color.LimeGreen;
            this.guna2Button.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2Button.ForeColor = System.Drawing.Color.White;
            this.guna2Button.Location = new System.Drawing.Point(508, 312);
            this.guna2Button.Name = "guna2Button";
            this.guna2Button.Size = new System.Drawing.Size(145, 51);
            this.guna2Button.TabIndex = 7;
            this.guna2Button.Text = "Menu";
            this.guna2Button.Click += new System.EventHandler(this.guna2Button_Click);
            // 
            // takeawaycs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "takeawaycs";
            this.Text = "takeawaycs";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button guna2Button;
    }
}