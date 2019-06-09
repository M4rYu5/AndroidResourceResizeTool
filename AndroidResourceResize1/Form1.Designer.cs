namespace AndroidResourceResize1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.widthValue = new System.Windows.Forms.NumericUpDown();
            this.heightValue = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBoxWidth = new System.Windows.Forms.CheckBox();
            this.checkBoxHeight = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.original = new System.Windows.Forms.CheckBox();
            this.mdpi = new System.Windows.Forms.CheckBox();
            this.hdpi = new System.Windows.Forms.CheckBox();
            this.xhdpi = new System.Windows.Forms.CheckBox();
            this.xxhdpi = new System.Windows.Forms.CheckBox();
            this.xxxhdpi = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.widthValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height";
            // 
            // widthValue
            // 
            this.widthValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.widthValue.Location = new System.Drawing.Point(64, 17);
            this.widthValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.widthValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthValue.Name = "widthValue";
            this.widthValue.Size = new System.Drawing.Size(120, 20);
            this.widthValue.TabIndex = 3;
            this.widthValue.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // heightValue
            // 
            this.heightValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.heightValue.Location = new System.Drawing.Point(64, 44);
            this.heightValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.heightValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heightValue.Name = "heightValue";
            this.heightValue.Size = new System.Drawing.Size(120, 20);
            this.heightValue.TabIndex = 4;
            this.heightValue.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // listBox1
            // 
            this.listBox1.AccessibleName = "";
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(439, 277);
            this.listBox1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(376, 455);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Export";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBoxWidth
            // 
            this.checkBoxWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxWidth.AutoSize = true;
            this.checkBoxWidth.Checked = true;
            this.checkBoxWidth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWidth.Location = new System.Drawing.Point(190, 21);
            this.checkBoxWidth.Name = "checkBoxWidth";
            this.checkBoxWidth.Size = new System.Drawing.Size(15, 14);
            this.checkBoxWidth.TabIndex = 10;
            this.checkBoxWidth.UseVisualStyleBackColor = true;
            // 
            // checkBoxHeight
            // 
            this.checkBoxHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxHeight.AutoSize = true;
            this.checkBoxHeight.Checked = true;
            this.checkBoxHeight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHeight.Location = new System.Drawing.Point(190, 48);
            this.checkBoxHeight.Name = "checkBoxHeight";
            this.checkBoxHeight.Size = new System.Drawing.Size(15, 14);
            this.checkBoxHeight.TabIndex = 11;
            this.checkBoxHeight.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.checkBoxHeight);
            this.groupBox1.Controls.Add(this.checkBoxWidth);
            this.groupBox1.Controls.Add(this.heightValue);
            this.groupBox1.Controls.Add(this.widthValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(144, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 79);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Constraints:";
            // 
            // original
            // 
            this.original.AutoSize = true;
            this.original.Location = new System.Drawing.Point(6, 13);
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(111, 17);
            this.original.TabIndex = 16;
            this.original.Text = "drawable (original)";
            this.original.UseVisualStyleBackColor = true;
            // 
            // mdpi
            // 
            this.mdpi.AutoSize = true;
            this.mdpi.Checked = true;
            this.mdpi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mdpi.Location = new System.Drawing.Point(6, 36);
            this.mdpi.Name = "mdpi";
            this.mdpi.Size = new System.Drawing.Size(94, 17);
            this.mdpi.TabIndex = 18;
            this.mdpi.Text = "drawable-mdpi";
            this.mdpi.UseVisualStyleBackColor = true;
            // 
            // hdpi
            // 
            this.hdpi.AutoSize = true;
            this.hdpi.Checked = true;
            this.hdpi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hdpi.Location = new System.Drawing.Point(6, 59);
            this.hdpi.Name = "hdpi";
            this.hdpi.Size = new System.Drawing.Size(92, 17);
            this.hdpi.TabIndex = 20;
            this.hdpi.Text = "drawable-hdpi";
            this.hdpi.UseVisualStyleBackColor = true;
            // 
            // xhdpi
            // 
            this.xhdpi.AutoSize = true;
            this.xhdpi.Checked = true;
            this.xhdpi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xhdpi.Location = new System.Drawing.Point(6, 82);
            this.xhdpi.Name = "xhdpi";
            this.xhdpi.Size = new System.Drawing.Size(97, 17);
            this.xhdpi.TabIndex = 22;
            this.xhdpi.Text = "drawable-xhdpi";
            this.xhdpi.UseVisualStyleBackColor = true;
            // 
            // xxhdpi
            // 
            this.xxhdpi.AutoSize = true;
            this.xxhdpi.Checked = true;
            this.xxhdpi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xxhdpi.Location = new System.Drawing.Point(6, 107);
            this.xxhdpi.Name = "xxhdpi";
            this.xxhdpi.Size = new System.Drawing.Size(102, 17);
            this.xxhdpi.TabIndex = 24;
            this.xxhdpi.Text = "drawable-xxhdpi";
            this.xxhdpi.UseVisualStyleBackColor = true;
            // 
            // xxxhdpi
            // 
            this.xxxhdpi.AutoSize = true;
            this.xxxhdpi.Checked = true;
            this.xxxhdpi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xxxhdpi.Location = new System.Drawing.Point(6, 130);
            this.xxxhdpi.Name = "xxxhdpi";
            this.xxxhdpi.Size = new System.Drawing.Size(107, 17);
            this.xxxhdpi.TabIndex = 26;
            this.xxxhdpi.Text = "drawable-xxxhdpi";
            this.xxxhdpi.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.xxxhdpi);
            this.groupBox2.Controls.Add(this.xxhdpi);
            this.groupBox2.Controls.Add(this.xhdpi);
            this.groupBox2.Controls.Add(this.hdpi);
            this.groupBox2.Controls.Add(this.mdpi);
            this.groupBox2.Controls.Add(this.original);
            this.groupBox2.Location = new System.Drawing.Point(12, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 154);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resources:";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 484);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(437, 23);
            this.progressBar1.TabIndex = 29;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(365, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(461, 515);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(302, 300);
            this.Name = "Form1";
            this.Text = "Resize Android Resources";
            ((System.ComponentModel.ISupportInitialize)(this.widthValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown widthValue;
        private System.Windows.Forms.NumericUpDown heightValue;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBoxWidth;
        private System.Windows.Forms.CheckBox checkBoxHeight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox original;
        private System.Windows.Forms.CheckBox mdpi;
        private System.Windows.Forms.CheckBox hdpi;
        private System.Windows.Forms.CheckBox xhdpi;
        private System.Windows.Forms.CheckBox xxhdpi;
        private System.Windows.Forms.CheckBox xxxhdpi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button4;
    }
}

