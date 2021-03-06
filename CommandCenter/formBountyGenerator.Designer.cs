
namespace CommandCenter
{
    partial class formBountyGenerator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBountyGenerator));
            this.containerConditions = new System.Windows.Forms.GroupBox();
            this.conditionsFalse = new System.Windows.Forms.RadioButton();
            this.conditionsTrue = new System.Windows.Forms.RadioButton();
            this.labelParty = new System.Windows.Forms.Label();
            this.labelTargets = new System.Windows.Forms.Label();
            this.targetCounter = new System.Windows.Forms.NumericUpDown();
            this.partyCounter = new System.Windows.Forms.NumericUpDown();
            this.riskHigh = new System.Windows.Forms.RadioButton();
            this.riskModerate = new System.Windows.Forms.RadioButton();
            this.riskLow = new System.Windows.Forms.RadioButton();
            this.textBoxReadout = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.containerRisks = new System.Windows.Forms.GroupBox();
            this.containerButtons = new System.Windows.Forms.GroupBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.containerValues = new System.Windows.Forms.GroupBox();
            this.tablePreviousBounties = new System.Windows.Forms.DataGridView();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRisk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTargets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnReward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBounty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxPreviousBounty = new System.Windows.Forms.TextBox();
            this.pictureBoxBounty = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.containerConditions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyCounter)).BeginInit();
            this.containerRisks.SuspendLayout();
            this.containerButtons.SuspendLayout();
            this.containerValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePreviousBounties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBounty)).BeginInit();
            this.SuspendLayout();
            // 
            // containerConditions
            // 
            this.containerConditions.Controls.Add(this.conditionsFalse);
            this.containerConditions.Controls.Add(this.conditionsTrue);
            this.containerConditions.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerConditions.ForeColor = System.Drawing.Color.Black;
            this.containerConditions.Location = new System.Drawing.Point(14, 501);
            this.containerConditions.Margin = new System.Windows.Forms.Padding(5);
            this.containerConditions.Name = "containerConditions";
            this.containerConditions.Padding = new System.Windows.Forms.Padding(5);
            this.containerConditions.Size = new System.Drawing.Size(350, 90);
            this.containerConditions.TabIndex = 21;
            this.containerConditions.TabStop = false;
            this.containerConditions.Text = "Mission Parameters";
            // 
            // conditionsFalse
            // 
            this.conditionsFalse.AutoSize = true;
            this.conditionsFalse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.conditionsFalse.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.conditionsFalse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.conditionsFalse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.conditionsFalse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conditionsFalse.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionsFalse.Location = new System.Drawing.Point(10, 56);
            this.conditionsFalse.Margin = new System.Windows.Forms.Padding(5);
            this.conditionsFalse.Name = "conditionsFalse";
            this.conditionsFalse.Size = new System.Drawing.Size(173, 25);
            this.conditionsFalse.TabIndex = 4;
            this.conditionsFalse.Text = "No Special Conditions";
            this.conditionsFalse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.conditionsFalse.UseVisualStyleBackColor = true;
            this.conditionsFalse.CheckedChanged += new System.EventHandler(this.conditionsFalse_CheckedChanged);
            // 
            // conditionsTrue
            // 
            this.conditionsTrue.AutoSize = true;
            this.conditionsTrue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.conditionsTrue.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.conditionsTrue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.conditionsTrue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.conditionsTrue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conditionsTrue.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionsTrue.Location = new System.Drawing.Point(10, 23);
            this.conditionsTrue.Margin = new System.Windows.Forms.Padding(5);
            this.conditionsTrue.Name = "conditionsTrue";
            this.conditionsTrue.Size = new System.Drawing.Size(202, 25);
            this.conditionsTrue.TabIndex = 3;
            this.conditionsTrue.Text = "Include Special Conditions";
            this.conditionsTrue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.conditionsTrue.UseVisualStyleBackColor = true;
            this.conditionsTrue.CheckedChanged += new System.EventHandler(this.conditionsTrue_CheckedChanged);
            // 
            // labelParty
            // 
            this.labelParty.AutoSize = true;
            this.labelParty.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParty.ForeColor = System.Drawing.Color.Black;
            this.labelParty.Location = new System.Drawing.Point(68, 61);
            this.labelParty.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelParty.Name = "labelParty";
            this.labelParty.Size = new System.Drawing.Size(186, 21);
            this.labelParty.TabIndex = 16;
            this.labelParty.Text = "Number of Party Members";
            // 
            // labelTargets
            // 
            this.labelTargets.AutoSize = true;
            this.labelTargets.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTargets.ForeColor = System.Drawing.Color.Black;
            this.labelTargets.Location = new System.Drawing.Point(68, 27);
            this.labelTargets.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTargets.Name = "labelTargets";
            this.labelTargets.Size = new System.Drawing.Size(132, 21);
            this.labelTargets.TabIndex = 15;
            this.labelTargets.Text = "Number of Targets";
            // 
            // targetCounter
            // 
            this.targetCounter.BackColor = System.Drawing.Color.White;
            this.targetCounter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.targetCounter.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetCounter.ForeColor = System.Drawing.Color.Black;
            this.targetCounter.Location = new System.Drawing.Point(10, 28);
            this.targetCounter.Margin = new System.Windows.Forms.Padding(5);
            this.targetCounter.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.targetCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.targetCounter.Name = "targetCounter";
            this.targetCounter.Size = new System.Drawing.Size(50, 22);
            this.targetCounter.TabIndex = 17;
            this.targetCounter.TabStop = false;
            this.targetCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.targetCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.targetCounter.ValueChanged += new System.EventHandler(this.targetCounter_ValueChanged);
            // 
            // partyCounter
            // 
            this.partyCounter.BackColor = System.Drawing.Color.White;
            this.partyCounter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.partyCounter.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partyCounter.ForeColor = System.Drawing.Color.Black;
            this.partyCounter.Location = new System.Drawing.Point(10, 62);
            this.partyCounter.Margin = new System.Windows.Forms.Padding(5);
            this.partyCounter.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.partyCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.partyCounter.Name = "partyCounter";
            this.partyCounter.Size = new System.Drawing.Size(50, 22);
            this.partyCounter.TabIndex = 18;
            this.partyCounter.TabStop = false;
            this.partyCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.partyCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.partyCounter.ValueChanged += new System.EventHandler(this.partyCounter_ValueChanged);
            // 
            // riskHigh
            // 
            this.riskHigh.AutoSize = true;
            this.riskHigh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.riskHigh.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.riskHigh.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.riskHigh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.riskHigh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.riskHigh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.riskHigh.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.riskHigh.Location = new System.Drawing.Point(13, 88);
            this.riskHigh.Margin = new System.Windows.Forms.Padding(5);
            this.riskHigh.Name = "riskHigh";
            this.riskHigh.Size = new System.Drawing.Size(138, 25);
            this.riskHigh.TabIndex = 2;
            this.riskHigh.Text = "High Risk Targets";
            this.riskHigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.riskHigh.UseVisualStyleBackColor = true;
            this.riskHigh.CheckedChanged += new System.EventHandler(this.riskHigh_CheckedChanged);
            // 
            // riskModerate
            // 
            this.riskModerate.AutoSize = true;
            this.riskModerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.riskModerate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.riskModerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.riskModerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.riskModerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.riskModerate.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.riskModerate.Location = new System.Drawing.Point(13, 55);
            this.riskModerate.Margin = new System.Windows.Forms.Padding(5);
            this.riskModerate.Name = "riskModerate";
            this.riskModerate.Size = new System.Drawing.Size(171, 25);
            this.riskModerate.TabIndex = 1;
            this.riskModerate.Text = "Moderate Risk Targets";
            this.riskModerate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.riskModerate.UseVisualStyleBackColor = true;
            this.riskModerate.CheckedChanged += new System.EventHandler(this.riskModerate_CheckedChanged);
            // 
            // riskLow
            // 
            this.riskLow.AutoSize = true;
            this.riskLow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.riskLow.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.riskLow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.riskLow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.riskLow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.riskLow.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.riskLow.Location = new System.Drawing.Point(13, 22);
            this.riskLow.Margin = new System.Windows.Forms.Padding(5);
            this.riskLow.Name = "riskLow";
            this.riskLow.Size = new System.Drawing.Size(133, 25);
            this.riskLow.TabIndex = 0;
            this.riskLow.Text = "Low Risk Targets";
            this.riskLow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.riskLow.UseVisualStyleBackColor = true;
            this.riskLow.CheckedChanged += new System.EventHandler(this.riskLow_CheckedChanged);
            // 
            // textBoxReadout
            // 
            this.textBoxReadout.BackColor = System.Drawing.Color.White;
            this.textBoxReadout.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxReadout.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReadout.ForeColor = System.Drawing.Color.Black;
            this.textBoxReadout.Location = new System.Drawing.Point(391, 12);
            this.textBoxReadout.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxReadout.Multiline = true;
            this.textBoxReadout.Name = "textBoxReadout";
            this.textBoxReadout.ReadOnly = true;
            this.textBoxReadout.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReadout.Size = new System.Drawing.Size(600, 1011);
            this.textBoxReadout.TabIndex = 23;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.Black;
            this.buttonClear.Location = new System.Drawing.Point(25, 218);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(300, 35);
            this.buttonClear.TabIndex = 22;
            this.buttonClear.TabStop = false;
            this.buttonClear.Text = "Reset Form Fields";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
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
            this.buttonGenerate.Location = new System.Drawing.Point(25, 30);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(300, 35);
            this.buttonGenerate.TabIndex = 19;
            this.buttonGenerate.TabStop = false;
            this.buttonGenerate.Text = "Generate Bounty";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(25, 124);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(300, 35);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.TabStop = false;
            this.buttonAdd.Text = "Add to History";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // containerRisks
            // 
            this.containerRisks.Controls.Add(this.riskHigh);
            this.containerRisks.Controls.Add(this.riskModerate);
            this.containerRisks.Controls.Add(this.riskLow);
            this.containerRisks.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerRisks.ForeColor = System.Drawing.Color.Black;
            this.containerRisks.Location = new System.Drawing.Point(14, 371);
            this.containerRisks.Margin = new System.Windows.Forms.Padding(5);
            this.containerRisks.Name = "containerRisks";
            this.containerRisks.Padding = new System.Windows.Forms.Padding(5);
            this.containerRisks.Size = new System.Drawing.Size(350, 120);
            this.containerRisks.TabIndex = 14;
            this.containerRisks.TabStop = false;
            this.containerRisks.Text = "Mission Risk Factor";
            // 
            // containerButtons
            // 
            this.containerButtons.Controls.Add(this.buttonRemove);
            this.containerButtons.Controls.Add(this.buttonExit);
            this.containerButtons.Controls.Add(this.buttonAdd);
            this.containerButtons.Controls.Add(this.buttonGenerate);
            this.containerButtons.Controls.Add(this.buttonRandom);
            this.containerButtons.Controls.Add(this.buttonClear);
            this.containerButtons.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerButtons.ForeColor = System.Drawing.Color.Black;
            this.containerButtons.Location = new System.Drawing.Point(14, 698);
            this.containerButtons.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.containerButtons.Name = "containerButtons";
            this.containerButtons.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.containerButtons.Size = new System.Drawing.Size(350, 325);
            this.containerButtons.TabIndex = 24;
            this.containerButtons.TabStop = false;
            this.containerButtons.Text = "Options";
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.Color.Black;
            this.buttonRemove.Location = new System.Drawing.Point(25, 171);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(300, 35);
            this.buttonRemove.TabIndex = 24;
            this.buttonRemove.TabStop = false;
            this.buttonRemove.Text = "Remove from History";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
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
            this.buttonExit.Location = new System.Drawing.Point(25, 265);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(300, 35);
            this.buttonExit.TabIndex = 23;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "Exit to Command Center";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonRandom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRandom.FlatAppearance.BorderSize = 0;
            this.buttonRandom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonRandom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRandom.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandom.ForeColor = System.Drawing.Color.Black;
            this.buttonRandom.Location = new System.Drawing.Point(25, 77);
            this.buttonRandom.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(300, 35);
            this.buttonRandom.TabIndex = 24;
            this.buttonRandom.TabStop = false;
            this.buttonRandom.Text = "Generate Random";
            this.buttonRandom.UseVisualStyleBackColor = false;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // containerValues
            // 
            this.containerValues.Controls.Add(this.labelTargets);
            this.containerValues.Controls.Add(this.partyCounter);
            this.containerValues.Controls.Add(this.targetCounter);
            this.containerValues.Controls.Add(this.labelParty);
            this.containerValues.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerValues.ForeColor = System.Drawing.Color.Black;
            this.containerValues.Location = new System.Drawing.Point(14, 600);
            this.containerValues.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.containerValues.Name = "containerValues";
            this.containerValues.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.containerValues.Size = new System.Drawing.Size(350, 90);
            this.containerValues.TabIndex = 25;
            this.containerValues.TabStop = false;
            this.containerValues.Text = "Other Mission Values";
            // 
            // tablePreviousBounties
            // 
            this.tablePreviousBounties.AllowUserToAddRows = false;
            this.tablePreviousBounties.AllowUserToDeleteRows = false;
            this.tablePreviousBounties.AllowUserToResizeColumns = false;
            this.tablePreviousBounties.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tablePreviousBounties.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablePreviousBounties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablePreviousBounties.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablePreviousBounties.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablePreviousBounties.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablePreviousBounties.ColumnHeadersHeight = 35;
            this.tablePreviousBounties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablePreviousBounties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnID,
            this.columnLocation,
            this.columnRisk,
            this.columnTargets,
            this.columnReward,
            this.columnBounty});
            this.tablePreviousBounties.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablePreviousBounties.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablePreviousBounties.GridColor = System.Drawing.Color.Black;
            this.tablePreviousBounties.Location = new System.Drawing.Point(1010, 12);
            this.tablePreviousBounties.Margin = new System.Windows.Forms.Padding(0);
            this.tablePreviousBounties.MultiSelect = false;
            this.tablePreviousBounties.Name = "tablePreviousBounties";
            this.tablePreviousBounties.ReadOnly = true;
            this.tablePreviousBounties.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tablePreviousBounties.RowHeadersVisible = false;
            this.tablePreviousBounties.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablePreviousBounties.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tablePreviousBounties.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablePreviousBounties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablePreviousBounties.Size = new System.Drawing.Size(880, 537);
            this.tablePreviousBounties.TabIndex = 38;
            this.tablePreviousBounties.TabStop = false;
            this.tablePreviousBounties.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablePreviousBounties_CellClick);
            // 
            // columnID
            // 
            this.columnID.HeaderText = "ID";
            this.columnID.Name = "columnID";
            this.columnID.ReadOnly = true;
            // 
            // columnLocation
            // 
            this.columnLocation.HeaderText = "Location";
            this.columnLocation.Name = "columnLocation";
            this.columnLocation.ReadOnly = true;
            // 
            // columnRisk
            // 
            this.columnRisk.HeaderText = "Risk";
            this.columnRisk.Name = "columnRisk";
            this.columnRisk.ReadOnly = true;
            // 
            // columnTargets
            // 
            this.columnTargets.HeaderText = "Targets";
            this.columnTargets.Name = "columnTargets";
            this.columnTargets.ReadOnly = true;
            // 
            // columnReward
            // 
            this.columnReward.HeaderText = "Reward";
            this.columnReward.Name = "columnReward";
            this.columnReward.ReadOnly = true;
            // 
            // columnBounty
            // 
            this.columnBounty.HeaderText = "BOUNTY INVISIBLE";
            this.columnBounty.Name = "columnBounty";
            this.columnBounty.ReadOnly = true;
            this.columnBounty.Visible = false;
            // 
            // textBoxPreviousBounty
            // 
            this.textBoxPreviousBounty.BackColor = System.Drawing.Color.White;
            this.textBoxPreviousBounty.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxPreviousBounty.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPreviousBounty.ForeColor = System.Drawing.Color.Black;
            this.textBoxPreviousBounty.Location = new System.Drawing.Point(1010, 600);
            this.textBoxPreviousBounty.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPreviousBounty.Multiline = true;
            this.textBoxPreviousBounty.Name = "textBoxPreviousBounty";
            this.textBoxPreviousBounty.ReadOnly = true;
            this.textBoxPreviousBounty.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPreviousBounty.Size = new System.Drawing.Size(880, 423);
            this.textBoxPreviousBounty.TabIndex = 39;
            // 
            // pictureBoxBounty
            // 
            this.pictureBoxBounty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxBounty.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxBounty.Name = "pictureBoxBounty";
            this.pictureBoxBounty.Size = new System.Drawing.Size(350, 350);
            this.pictureBoxBounty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBounty.TabIndex = 26;
            this.pictureBoxBounty.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1006, 570);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Readout of Selected Entry:";
            // 
            // formBountyGenerator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPreviousBounty);
            this.Controls.Add(this.tablePreviousBounties);
            this.Controls.Add(this.pictureBoxBounty);
            this.Controls.Add(this.containerValues);
            this.Controls.Add(this.containerButtons);
            this.Controls.Add(this.containerConditions);
            this.Controls.Add(this.textBoxReadout);
            this.Controls.Add(this.containerRisks);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "formBountyGenerator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bounty Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formBountyGenerator_FormClosing);
            this.containerConditions.ResumeLayout(false);
            this.containerConditions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyCounter)).EndInit();
            this.containerRisks.ResumeLayout(false);
            this.containerRisks.PerformLayout();
            this.containerButtons.ResumeLayout(false);
            this.containerValues.ResumeLayout(false);
            this.containerValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePreviousBounties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBounty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox containerConditions;
        private System.Windows.Forms.RadioButton conditionsFalse;
        private System.Windows.Forms.RadioButton conditionsTrue;
        private System.Windows.Forms.Label labelParty;
        private System.Windows.Forms.Label labelTargets;
        private System.Windows.Forms.NumericUpDown targetCounter;
        private System.Windows.Forms.NumericUpDown partyCounter;
        private System.Windows.Forms.RadioButton riskHigh;
        private System.Windows.Forms.RadioButton riskModerate;
        private System.Windows.Forms.RadioButton riskLow;
        public System.Windows.Forms.TextBox textBoxReadout;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox containerRisks;
        private System.Windows.Forms.GroupBox containerButtons;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox containerValues;
        private System.Windows.Forms.PictureBox pictureBoxBounty;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.DataGridView tablePreviousBounties;
        public System.Windows.Forms.TextBox textBoxPreviousBounty;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRisk;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTargets;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnReward;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBounty;
        private System.Windows.Forms.Label label1;
    }
}