namespace P182_Party_Planner
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.fancyCheckBox = new System.Windows.Forms.CheckBox();
            this.healthyCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(27, 40);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of People";
            // 
            // fancyCheckBox
            // 
            this.fancyCheckBox.AutoSize = true;
            this.fancyCheckBox.Location = new System.Drawing.Point(27, 82);
            this.fancyCheckBox.Name = "fancyCheckBox";
            this.fancyCheckBox.Size = new System.Drawing.Size(126, 16);
            this.fancyCheckBox.TabIndex = 3;
            this.fancyCheckBox.Text = "Fancy Decorations";
            this.fancyCheckBox.UseVisualStyleBackColor = true;
            // 
            // healthyCheckBox
            // 
            this.healthyCheckBox.AutoSize = true;
            this.healthyCheckBox.Location = new System.Drawing.Point(27, 118);
            this.healthyCheckBox.Name = "healthyCheckBox";
            this.healthyCheckBox.Size = new System.Drawing.Size(108, 16);
            this.healthyCheckBox.TabIndex = 3;
            this.healthyCheckBox.Text = "Healthy Option";
            this.healthyCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(27, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cost";
            // 
            // costLabel
            // 
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabel.Location = new System.Drawing.Point(67, 154);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(68, 23);
            this.costLabel.TabIndex = 5;
            this.costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 198);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.healthyCheckBox);
            this.Controls.Add(this.fancyCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox fancyCheckBox;
        private System.Windows.Forms.CheckBox healthyCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label costLabel;
    }
}

