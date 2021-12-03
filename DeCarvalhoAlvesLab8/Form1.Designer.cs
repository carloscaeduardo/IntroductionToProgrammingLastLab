
namespace DeCarvalhoAlvesLab8
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
            this.grpSelect = new System.Windows.Forms.GroupBox();
            this.chkAnalysis = new System.Windows.Forms.CheckBox();
            this.chkFormula = new System.Windows.Forms.CheckBox();
            this.grpFormula = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radCombination = new System.Windows.Forms.RadioButton();
            this.radPermutation = new System.Windows.Forms.RadioButton();
            this.nudSelect = new System.Windows.Forms.NumericUpDown();
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAnalysis = new System.Windows.Forms.GroupBox();
            this.lstClassSize = new System.Windows.Forms.ListBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClassroom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picCombinationPermutation = new System.Windows.Forms.PictureBox();
            this.grpSelect.SuspendLayout();
            this.grpFormula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            this.grpAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCombinationPermutation)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSelect
            // 
            this.grpSelect.BackColor = System.Drawing.Color.PaleGreen;
            this.grpSelect.Controls.Add(this.chkAnalysis);
            this.grpSelect.Controls.Add(this.chkFormula);
            this.grpSelect.Location = new System.Drawing.Point(12, 12);
            this.grpSelect.Name = "grpSelect";
            this.grpSelect.Size = new System.Drawing.Size(650, 80);
            this.grpSelect.TabIndex = 0;
            this.grpSelect.TabStop = false;
            this.grpSelect.Text = "Select from...";
            // 
            // chkAnalysis
            // 
            this.chkAnalysis.AutoSize = true;
            this.chkAnalysis.Location = new System.Drawing.Point(412, 40);
            this.chkAnalysis.Name = "chkAnalysis";
            this.chkAnalysis.Size = new System.Drawing.Size(83, 23);
            this.chkAnalysis.TabIndex = 1;
            this.chkAnalysis.Text = "Analysis";
            this.chkAnalysis.UseVisualStyleBackColor = true;
            this.chkAnalysis.CheckedChanged += new System.EventHandler(this.chkAnalysis_CheckedChanged);
            // 
            // chkFormula
            // 
            this.chkFormula.AutoSize = true;
            this.chkFormula.Location = new System.Drawing.Point(77, 40);
            this.chkFormula.Name = "chkFormula";
            this.chkFormula.Size = new System.Drawing.Size(84, 23);
            this.chkFormula.TabIndex = 0;
            this.chkFormula.Text = "Formula";
            this.chkFormula.UseVisualStyleBackColor = true;
            this.chkFormula.CheckedChanged += new System.EventHandler(this.chkFormula_CheckedChanged);
            // 
            // grpFormula
            // 
            this.grpFormula.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpFormula.Controls.Add(this.picCombinationPermutation);
            this.grpFormula.Controls.Add(this.btnReset);
            this.grpFormula.Controls.Add(this.btnCalculate);
            this.grpFormula.Controls.Add(this.lblAnswer);
            this.grpFormula.Controls.Add(this.label3);
            this.grpFormula.Controls.Add(this.radCombination);
            this.grpFormula.Controls.Add(this.radPermutation);
            this.grpFormula.Controls.Add(this.nudSelect);
            this.grpFormula.Controls.Add(this.nudTotal);
            this.grpFormula.Controls.Add(this.label2);
            this.grpFormula.Controls.Add(this.label1);
            this.grpFormula.Location = new System.Drawing.Point(12, 98);
            this.grpFormula.Name = "grpFormula";
            this.grpFormula.Size = new System.Drawing.Size(360, 300);
            this.grpFormula.TabIndex = 1;
            this.grpFormula.TabStop = false;
            this.grpFormula.Text = "Formula";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(197, 240);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 39);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(21, 240);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(122, 39);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer.Location = new System.Drawing.Point(77, 167);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(157, 29);
            this.lblAnswer.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Answer:";
            // 
            // radCombination
            // 
            this.radCombination.AutoSize = true;
            this.radCombination.Location = new System.Drawing.Point(7, 133);
            this.radCombination.Name = "radCombination";
            this.radCombination.Size = new System.Drawing.Size(114, 23);
            this.radCombination.TabIndex = 3;
            this.radCombination.TabStop = true;
            this.radCombination.Text = "Combination";
            this.radCombination.UseVisualStyleBackColor = true;
            this.radCombination.CheckedChanged += new System.EventHandler(this.radCombination_CheckedChanged);
            // 
            // radPermutation
            // 
            this.radPermutation.AutoSize = true;
            this.radPermutation.Location = new System.Drawing.Point(7, 104);
            this.radPermutation.Name = "radPermutation";
            this.radPermutation.Size = new System.Drawing.Size(113, 23);
            this.radPermutation.TabIndex = 2;
            this.radPermutation.TabStop = true;
            this.radPermutation.Text = "Permutation";
            this.radPermutation.UseVisualStyleBackColor = true;
            this.radPermutation.CheckedChanged += new System.EventHandler(this.radPermutation_CheckedChanged);
            // 
            // nudSelect
            // 
            this.nudSelect.Location = new System.Drawing.Point(77, 56);
            this.nudSelect.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudSelect.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSelect.Name = "nudSelect";
            this.nudSelect.Size = new System.Drawing.Size(84, 27);
            this.nudSelect.TabIndex = 1;
            this.nudSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSelect.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // nudTotal
            // 
            this.nudTotal.Location = new System.Drawing.Point(77, 21);
            this.nudTotal.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudTotal.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudTotal.Name = "nudTotal";
            this.nudTotal.Size = new System.Drawing.Size(84, 27);
            this.nudTotal.TabIndex = 0;
            this.nudTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTotal.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total:";
            // 
            // grpAnalysis
            // 
            this.grpAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpAnalysis.Controls.Add(this.lstClassSize);
            this.grpAnalysis.Controls.Add(this.btnGenerate);
            this.grpAnalysis.Controls.Add(this.lblAverage);
            this.grpAnalysis.Controls.Add(this.label7);
            this.grpAnalysis.Controls.Add(this.lblSum);
            this.grpAnalysis.Controls.Add(this.label5);
            this.grpAnalysis.Controls.Add(this.txtClassroom);
            this.grpAnalysis.Controls.Add(this.label4);
            this.grpAnalysis.Location = new System.Drawing.Point(379, 99);
            this.grpAnalysis.Name = "grpAnalysis";
            this.grpAnalysis.Size = new System.Drawing.Size(283, 299);
            this.grpAnalysis.TabIndex = 2;
            this.grpAnalysis.TabStop = false;
            this.grpAnalysis.Text = "Analysis";
            // 
            // lstClassSize
            // 
            this.lstClassSize.FormattingEnabled = true;
            this.lstClassSize.ItemHeight = 19;
            this.lstClassSize.Location = new System.Drawing.Point(176, 20);
            this.lstClassSize.Name = "lstClassSize";
            this.lstClassSize.Size = new System.Drawing.Size(101, 213);
            this.lstClassSize.TabIndex = 15;
            this.lstClassSize.TabStop = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(84, 239);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(122, 39);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverage.Location = new System.Drawing.Point(84, 131);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(86, 29);
            this.lblAverage.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Average:";
            // 
            // lblSum
            // 
            this.lblSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSum.Location = new System.Drawing.Point(84, 78);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(86, 29);
            this.lblSum.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sum:";
            // 
            // txtClassroom
            // 
            this.txtClassroom.Location = new System.Drawing.Point(101, 20);
            this.txtClassroom.Name = "txtClassroom";
            this.txtClassroom.Size = new System.Drawing.Size(69, 27);
            this.txtClassroom.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Classrooms:";
            // 
            // picCombinationPermutation
            // 
            this.picCombinationPermutation.Location = new System.Drawing.Point(180, 25);
            this.picCombinationPermutation.MaximumSize = new System.Drawing.Size(150, 80);
            this.picCombinationPermutation.Name = "picCombinationPermutation";
            this.picCombinationPermutation.Size = new System.Drawing.Size(150, 80);
            this.picCombinationPermutation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCombinationPermutation.TabIndex = 8;
            this.picCombinationPermutation.TabStop = false;
            this.picCombinationPermutation.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(674, 411);
            this.Controls.Add(this.grpAnalysis);
            this.Controls.Add(this.grpFormula);
            this.Controls.Add(this.grpSelect);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Last Lab by";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSelect.ResumeLayout(false);
            this.grpSelect.PerformLayout();
            this.grpFormula.ResumeLayout(false);
            this.grpFormula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            this.grpAnalysis.ResumeLayout(false);
            this.grpAnalysis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCombinationPermutation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSelect;
        private System.Windows.Forms.CheckBox chkFormula;
        private System.Windows.Forms.CheckBox chkAnalysis;
        private System.Windows.Forms.GroupBox grpFormula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTotal;
        private System.Windows.Forms.NumericUpDown nudSelect;
        private System.Windows.Forms.RadioButton radPermutation;
        private System.Windows.Forms.RadioButton radCombination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpAnalysis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClassroom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListBox lstClassSize;
        private System.Windows.Forms.PictureBox picCombinationPermutation;
    }
}

