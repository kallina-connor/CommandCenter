
namespace CommandCenter
{
    partial class formCommandCenter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCommandCenter));
            this.buttonWeapon = new System.Windows.Forms.Button();
            this.buttonJob = new System.Windows.Forms.Button();
            this.buttonBounty = new System.Windows.Forms.Button();
            this.labelSecret = new System.Windows.Forms.Label();
            this.pictureBoxJob = new System.Windows.Forms.PictureBox();
            this.pictureBoxWeapon = new System.Windows.Forms.PictureBox();
            this.pictureBoxBounty = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBounty)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonWeapon
            // 
            this.buttonWeapon.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonWeapon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWeapon.FlatAppearance.BorderSize = 0;
            this.buttonWeapon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonWeapon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonWeapon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWeapon.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWeapon.ForeColor = System.Drawing.Color.Black;
            this.buttonWeapon.Location = new System.Drawing.Point(150, 540);
            this.buttonWeapon.Margin = new System.Windows.Forms.Padding(0);
            this.buttonWeapon.Name = "buttonWeapon";
            this.buttonWeapon.Size = new System.Drawing.Size(350, 105);
            this.buttonWeapon.TabIndex = 3;
            this.buttonWeapon.Text = "Launch Weapon Generator";
            this.buttonWeapon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonWeapon.UseVisualStyleBackColor = false;
            this.buttonWeapon.Click += new System.EventHandler(this.buttonWeapon_Click);
            // 
            // buttonJob
            // 
            this.buttonJob.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonJob.FlatAppearance.BorderSize = 0;
            this.buttonJob.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonJob.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJob.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJob.ForeColor = System.Drawing.Color.Black;
            this.buttonJob.Location = new System.Drawing.Point(777, 540);
            this.buttonJob.Margin = new System.Windows.Forms.Padding(0);
            this.buttonJob.Name = "buttonJob";
            this.buttonJob.Size = new System.Drawing.Size(350, 105);
            this.buttonJob.TabIndex = 4;
            this.buttonJob.Text = "Launch Job Generator";
            this.buttonJob.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonJob.UseVisualStyleBackColor = false;
            // 
            // buttonBounty
            // 
            this.buttonBounty.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonBounty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBounty.FlatAppearance.BorderSize = 0;
            this.buttonBounty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonBounty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonBounty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBounty.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBounty.ForeColor = System.Drawing.Color.Black;
            this.buttonBounty.Location = new System.Drawing.Point(1410, 540);
            this.buttonBounty.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBounty.Name = "buttonBounty";
            this.buttonBounty.Size = new System.Drawing.Size(350, 105);
            this.buttonBounty.TabIndex = 5;
            this.buttonBounty.Text = "Launch Bounty Generator";
            this.buttonBounty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBounty.UseVisualStyleBackColor = false;
            this.buttonBounty.Click += new System.EventHandler(this.buttonBounty_Click);
            // 
            // labelSecret
            // 
            this.labelSecret.AutoSize = true;
            this.labelSecret.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSecret.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecret.Location = new System.Drawing.Point(1820, 1020);
            this.labelSecret.Name = "labelSecret";
            this.labelSecret.Size = new System.Drawing.Size(67, 17);
            this.labelSecret.TabIndex = 6;
            this.labelSecret.Text = "Version 1.0";
            this.labelSecret.Click += new System.EventHandler(this.labelSecret_Click);
            // 
            // pictureBoxJob
            // 
            this.pictureBoxJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxJob.Location = new System.Drawing.Point(777, 150);
            this.pictureBoxJob.Name = "pictureBoxJob";
            this.pictureBoxJob.Size = new System.Drawing.Size(350, 350);
            this.pictureBoxJob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxJob.TabIndex = 2;
            this.pictureBoxJob.TabStop = false;
            // 
            // pictureBoxWeapon
            // 
            this.pictureBoxWeapon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxWeapon.Location = new System.Drawing.Point(150, 150);
            this.pictureBoxWeapon.Name = "pictureBoxWeapon";
            this.pictureBoxWeapon.Size = new System.Drawing.Size(350, 350);
            this.pictureBoxWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWeapon.TabIndex = 1;
            this.pictureBoxWeapon.TabStop = false;
            // 
            // pictureBoxBounty
            // 
            this.pictureBoxBounty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxBounty.Location = new System.Drawing.Point(1410, 150);
            this.pictureBoxBounty.Name = "pictureBoxBounty";
            this.pictureBoxBounty.Size = new System.Drawing.Size(350, 350);
            this.pictureBoxBounty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBounty.TabIndex = 0;
            this.pictureBoxBounty.TabStop = false;
            // 
            // formCommandCenter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.labelSecret);
            this.Controls.Add(this.buttonBounty);
            this.Controls.Add(this.buttonJob);
            this.Controls.Add(this.buttonWeapon);
            this.Controls.Add(this.pictureBoxJob);
            this.Controls.Add(this.pictureBoxWeapon);
            this.Controls.Add(this.pictureBoxBounty);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "formCommandCenter";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Command Center";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formCommandCenter_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBounty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBounty;
        private System.Windows.Forms.PictureBox pictureBoxWeapon;
        private System.Windows.Forms.PictureBox pictureBoxJob;
        private System.Windows.Forms.Button buttonWeapon;
        private System.Windows.Forms.Button buttonJob;
        private System.Windows.Forms.Button buttonBounty;
        private System.Windows.Forms.Label labelSecret;
    }
}

