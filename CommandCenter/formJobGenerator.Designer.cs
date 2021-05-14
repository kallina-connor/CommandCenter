
namespace CommandCenter
{
    partial class formJobGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formJobGenerator));
            this.pictureBoxJobs = new System.Windows.Forms.PictureBox();
            this.containerOptions = new System.Windows.Forms.GroupBox();
            this.buttonExotic = new System.Windows.Forms.RadioButton();
            this.buttonCommon = new System.Windows.Forms.RadioButton();
            this.buttonRare = new System.Windows.Forms.RadioButton();
            this.buttonUncommon = new System.Windows.Forms.RadioButton();
            this.buttonFullRandom = new System.Windows.Forms.RadioButton();
            this.containerDropDownList = new System.Windows.Forms.GroupBox();
            this.labelBatchQuantity = new System.Windows.Forms.Label();
            this.comboBoxWeaponTypes = new System.Windows.Forms.ComboBox();
            this.batchQuantity = new System.Windows.Forms.NumericUpDown();
            this.containerButtons = new System.Windows.Forms.GroupBox();
            this.buttonConsole = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonAddToList = new System.Windows.Forms.Button();
            this.buttonRemoveFromList = new System.Windows.Forms.Button();
            this.buttonClearForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJobs)).BeginInit();
            this.containerOptions.SuspendLayout();
            this.containerDropDownList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchQuantity)).BeginInit();
            this.containerButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxJobs
            // 
            this.pictureBoxJobs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxJobs.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxJobs.Name = "pictureBoxJobs";
            this.pictureBoxJobs.Size = new System.Drawing.Size(350, 350);
            this.pictureBoxJobs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxJobs.TabIndex = 46;
            this.pictureBoxJobs.TabStop = false;
            // 
            // containerOptions
            // 
            this.containerOptions.Controls.Add(this.buttonExotic);
            this.containerOptions.Controls.Add(this.buttonCommon);
            this.containerOptions.Controls.Add(this.buttonRare);
            this.containerOptions.Controls.Add(this.buttonUncommon);
            this.containerOptions.Controls.Add(this.buttonFullRandom);
            this.containerOptions.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerOptions.ForeColor = System.Drawing.Color.Black;
            this.containerOptions.Location = new System.Drawing.Point(368, 12);
            this.containerOptions.Name = "containerOptions";
            this.containerOptions.Size = new System.Drawing.Size(250, 140);
            this.containerOptions.TabIndex = 47;
            this.containerOptions.TabStop = false;
            this.containerOptions.Text = "Generation Mode";
            // 
            // buttonExotic
            // 
            this.buttonExotic.AutoSize = true;
            this.buttonExotic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExotic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExotic.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExotic.Location = new System.Drawing.Point(16, 111);
            this.buttonExotic.Name = "buttonExotic";
            this.buttonExotic.Size = new System.Drawing.Size(126, 25);
            this.buttonExotic.TabIndex = 4;
            this.buttonExotic.Text = "Exotic Weapon";
            this.buttonExotic.UseVisualStyleBackColor = true;
            // 
            // buttonCommon
            // 
            this.buttonCommon.AutoSize = true;
            this.buttonCommon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCommon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCommon.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCommon.Location = new System.Drawing.Point(16, 42);
            this.buttonCommon.Name = "buttonCommon";
            this.buttonCommon.Size = new System.Drawing.Size(150, 25);
            this.buttonCommon.TabIndex = 1;
            this.buttonCommon.Text = "Common Weapon";
            this.buttonCommon.UseVisualStyleBackColor = true;
            // 
            // buttonRare
            // 
            this.buttonRare.AutoSize = true;
            this.buttonRare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRare.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRare.Location = new System.Drawing.Point(16, 88);
            this.buttonRare.Name = "buttonRare";
            this.buttonRare.Size = new System.Drawing.Size(117, 25);
            this.buttonRare.TabIndex = 3;
            this.buttonRare.Text = "Rare Weapon";
            this.buttonRare.UseVisualStyleBackColor = true;
            // 
            // buttonUncommon
            // 
            this.buttonUncommon.AutoSize = true;
            this.buttonUncommon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUncommon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUncommon.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUncommon.Location = new System.Drawing.Point(16, 65);
            this.buttonUncommon.Name = "buttonUncommon";
            this.buttonUncommon.Size = new System.Drawing.Size(166, 25);
            this.buttonUncommon.TabIndex = 2;
            this.buttonUncommon.Text = "Uncommon Weapon";
            this.buttonUncommon.UseVisualStyleBackColor = true;
            // 
            // buttonFullRandom
            // 
            this.buttonFullRandom.AutoSize = true;
            this.buttonFullRandom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFullRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFullRandom.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFullRandom.Location = new System.Drawing.Point(16, 19);
            this.buttonFullRandom.Name = "buttonFullRandom";
            this.buttonFullRandom.Size = new System.Drawing.Size(204, 25);
            this.buttonFullRandom.TabIndex = 0;
            this.buttonFullRandom.Text = "Fully Randomized Weapon";
            this.buttonFullRandom.UseVisualStyleBackColor = true;
            // 
            // containerDropDownList
            // 
            this.containerDropDownList.Controls.Add(this.labelBatchQuantity);
            this.containerDropDownList.Controls.Add(this.comboBoxWeaponTypes);
            this.containerDropDownList.Controls.Add(this.batchQuantity);
            this.containerDropDownList.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerDropDownList.ForeColor = System.Drawing.Color.Black;
            this.containerDropDownList.Location = new System.Drawing.Point(624, 12);
            this.containerDropDownList.Name = "containerDropDownList";
            this.containerDropDownList.Size = new System.Drawing.Size(400, 140);
            this.containerDropDownList.TabIndex = 48;
            this.containerDropDownList.TabStop = false;
            this.containerDropDownList.Text = "Choose Weapon Type";
            // 
            // labelBatchQuantity
            // 
            this.labelBatchQuantity.AutoSize = true;
            this.labelBatchQuantity.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBatchQuantity.Location = new System.Drawing.Point(175, 106);
            this.labelBatchQuantity.Name = "labelBatchQuantity";
            this.labelBatchQuantity.Size = new System.Drawing.Size(164, 21);
            this.labelBatchQuantity.TabIndex = 34;
            this.labelBatchQuantity.Text = "Specify Batch Quantity:";
            this.labelBatchQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxWeaponTypes
            // 
            this.comboBoxWeaponTypes.BackColor = System.Drawing.Color.White;
            this.comboBoxWeaponTypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxWeaponTypes.DropDownHeight = 100;
            this.comboBoxWeaponTypes.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWeaponTypes.ForeColor = System.Drawing.Color.Black;
            this.comboBoxWeaponTypes.FormattingEnabled = true;
            this.comboBoxWeaponTypes.IntegralHeight = false;
            this.comboBoxWeaponTypes.Items.AddRange(new object[] {
            "WeaponDictionary.catalog"});
            this.comboBoxWeaponTypes.Location = new System.Drawing.Point(6, 18);
            this.comboBoxWeaponTypes.Name = "comboBoxWeaponTypes";
            this.comboBoxWeaponTypes.Size = new System.Drawing.Size(388, 29);
            this.comboBoxWeaponTypes.TabIndex = 32;
            this.comboBoxWeaponTypes.TabStop = false;
            // 
            // batchQuantity
            // 
            this.batchQuantity.BackColor = System.Drawing.Color.White;
            this.batchQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.batchQuantity.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchQuantity.ForeColor = System.Drawing.Color.Black;
            this.batchQuantity.Location = new System.Drawing.Point(345, 107);
            this.batchQuantity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.batchQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.batchQuantity.Name = "batchQuantity";
            this.batchQuantity.ReadOnly = true;
            this.batchQuantity.Size = new System.Drawing.Size(49, 22);
            this.batchQuantity.TabIndex = 33;
            this.batchQuantity.TabStop = false;
            this.batchQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.batchQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // containerButtons
            // 
            this.containerButtons.Controls.Add(this.buttonConsole);
            this.containerButtons.Controls.Add(this.buttonExit);
            this.containerButtons.Controls.Add(this.buttonGenerate);
            this.containerButtons.Controls.Add(this.buttonAddToList);
            this.containerButtons.Controls.Add(this.buttonRemoveFromList);
            this.containerButtons.Controls.Add(this.buttonClearForm);
            this.containerButtons.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerButtons.ForeColor = System.Drawing.Color.Black;
            this.containerButtons.Location = new System.Drawing.Point(1030, 12);
            this.containerButtons.Name = "containerButtons";
            this.containerButtons.Size = new System.Drawing.Size(450, 140);
            this.containerButtons.TabIndex = 49;
            this.containerButtons.TabStop = false;
            this.containerButtons.Text = "Options";
            // 
            // buttonConsole
            // 
            this.buttonConsole.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonConsole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConsole.FlatAppearance.BorderSize = 0;
            this.buttonConsole.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonConsole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsole.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsole.ForeColor = System.Drawing.Color.Black;
            this.buttonConsole.Location = new System.Drawing.Point(229, 21);
            this.buttonConsole.Name = "buttonConsole";
            this.buttonConsole.Size = new System.Drawing.Size(200, 32);
            this.buttonConsole.TabIndex = 32;
            this.buttonConsole.TabStop = false;
            this.buttonConsole.Text = "Toggle Console";
            this.buttonConsole.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(229, 97);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(200, 32);
            this.buttonExit.TabIndex = 31;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "Exit to Command Center";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGenerate.FlatAppearance.BorderSize = 0;
            this.buttonGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerate.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.ForeColor = System.Drawing.Color.Black;
            this.buttonGenerate.Location = new System.Drawing.Point(21, 21);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(200, 32);
            this.buttonGenerate.TabIndex = 27;
            this.buttonGenerate.TabStop = false;
            this.buttonGenerate.Text = "Generate Weapon";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            // 
            // buttonAddToList
            // 
            this.buttonAddToList.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonAddToList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddToList.FlatAppearance.BorderSize = 0;
            this.buttonAddToList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonAddToList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonAddToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddToList.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToList.ForeColor = System.Drawing.Color.Black;
            this.buttonAddToList.Location = new System.Drawing.Point(21, 59);
            this.buttonAddToList.Name = "buttonAddToList";
            this.buttonAddToList.Size = new System.Drawing.Size(200, 32);
            this.buttonAddToList.TabIndex = 29;
            this.buttonAddToList.TabStop = false;
            this.buttonAddToList.Text = "Add to History";
            this.buttonAddToList.UseVisualStyleBackColor = false;
            // 
            // buttonRemoveFromList
            // 
            this.buttonRemoveFromList.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonRemoveFromList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveFromList.FlatAppearance.BorderSize = 0;
            this.buttonRemoveFromList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonRemoveFromList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonRemoveFromList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveFromList.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveFromList.ForeColor = System.Drawing.Color.Black;
            this.buttonRemoveFromList.Location = new System.Drawing.Point(21, 97);
            this.buttonRemoveFromList.Name = "buttonRemoveFromList";
            this.buttonRemoveFromList.Size = new System.Drawing.Size(200, 32);
            this.buttonRemoveFromList.TabIndex = 30;
            this.buttonRemoveFromList.TabStop = false;
            this.buttonRemoveFromList.Text = "Remove from History";
            this.buttonRemoveFromList.UseVisualStyleBackColor = false;
            // 
            // buttonClearForm
            // 
            this.buttonClearForm.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonClearForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearForm.FlatAppearance.BorderSize = 0;
            this.buttonClearForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonClearForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearForm.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearForm.ForeColor = System.Drawing.Color.Black;
            this.buttonClearForm.Location = new System.Drawing.Point(229, 59);
            this.buttonClearForm.Name = "buttonClearForm";
            this.buttonClearForm.Size = new System.Drawing.Size(200, 32);
            this.buttonClearForm.TabIndex = 28;
            this.buttonClearForm.TabStop = false;
            this.buttonClearForm.Text = "Reset Form Fields";
            this.buttonClearForm.UseVisualStyleBackColor = false;
            // 
            // formJobGenerator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.containerButtons);
            this.Controls.Add(this.containerDropDownList);
            this.Controls.Add(this.containerOptions);
            this.Controls.Add(this.pictureBoxJobs);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "formJobGenerator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Job Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJobs)).EndInit();
            this.containerOptions.ResumeLayout(false);
            this.containerOptions.PerformLayout();
            this.containerDropDownList.ResumeLayout(false);
            this.containerDropDownList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchQuantity)).EndInit();
            this.containerButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxJobs;
        private System.Windows.Forms.GroupBox containerOptions;
        private System.Windows.Forms.RadioButton buttonExotic;
        private System.Windows.Forms.RadioButton buttonCommon;
        private System.Windows.Forms.RadioButton buttonRare;
        private System.Windows.Forms.RadioButton buttonUncommon;
        private System.Windows.Forms.RadioButton buttonFullRandom;
        private System.Windows.Forms.GroupBox containerDropDownList;
        private System.Windows.Forms.Label labelBatchQuantity;
        private System.Windows.Forms.ComboBox comboBoxWeaponTypes;
        private System.Windows.Forms.NumericUpDown batchQuantity;
        private System.Windows.Forms.GroupBox containerButtons;
        private System.Windows.Forms.Button buttonConsole;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonAddToList;
        private System.Windows.Forms.Button buttonRemoveFromList;
        private System.Windows.Forms.Button buttonClearForm;
    }
}