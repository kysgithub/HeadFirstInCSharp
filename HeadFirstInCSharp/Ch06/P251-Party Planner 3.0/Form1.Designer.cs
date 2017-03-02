namespace P251_Party_Planner_3
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
            this.dinnerPeople = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dinnerFancyDecorations = new System.Windows.Forms.CheckBox();
            this.dinnerHealthy = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dinnerCost = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.birthdayCost = new System.Windows.Forms.Label();
            this.birthdayPeople = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.birthdayFancyDecorations = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.birthdayCakeWriting = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dinnerPeople)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // dinnerPeople
            // 
            this.dinnerPeople.Location = new System.Drawing.Point(17, 40);
            this.dinnerPeople.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.dinnerPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dinnerPeople.Name = "dinnerPeople";
            this.dinnerPeople.Size = new System.Drawing.Size(120, 21);
            this.dinnerPeople.TabIndex = 0;
            this.dinnerPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of People";
            // 
            // dinnerFancyDecorations
            // 
            this.dinnerFancyDecorations.AutoSize = true;
            this.dinnerFancyDecorations.Location = new System.Drawing.Point(17, 82);
            this.dinnerFancyDecorations.Name = "dinnerFancyDecorations";
            this.dinnerFancyDecorations.Size = new System.Drawing.Size(126, 16);
            this.dinnerFancyDecorations.TabIndex = 3;
            this.dinnerFancyDecorations.Text = "Fancy Decorations";
            this.dinnerFancyDecorations.UseVisualStyleBackColor = true;
            // 
            // dinnerHealthy
            // 
            this.dinnerHealthy.AutoSize = true;
            this.dinnerHealthy.Location = new System.Drawing.Point(17, 118);
            this.dinnerHealthy.Name = "dinnerHealthy";
            this.dinnerHealthy.Size = new System.Drawing.Size(108, 16);
            this.dinnerHealthy.TabIndex = 3;
            this.dinnerHealthy.Text = "Healthy Option";
            this.dinnerHealthy.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(17, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cost";
            // 
            // dinnerCost
            // 
            this.dinnerCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dinnerCost.Location = new System.Drawing.Point(57, 154);
            this.dinnerCost.Name = "dinnerCost";
            this.dinnerCost.Size = new System.Drawing.Size(80, 23);
            this.dinnerCost.TabIndex = 5;
            this.dinnerCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(166, 225);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dinnerCost);
            this.tabPage1.Controls.Add(this.dinnerPeople);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dinnerFancyDecorations);
            this.tabPage1.Controls.Add(this.dinnerHealthy);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(158, 199);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.birthdayCakeWriting);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.birthdayCost);
            this.tabPage2.Controls.Add(this.birthdayPeople);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.birthdayFancyDecorations);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(158, 199);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of People";
            // 
            // birthdayCost
            // 
            this.birthdayCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.birthdayCost.Location = new System.Drawing.Point(57, 154);
            this.birthdayCost.Name = "birthdayCost";
            this.birthdayCost.Size = new System.Drawing.Size(80, 23);
            this.birthdayCost.TabIndex = 11;
            this.birthdayCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // birthdayPeople
            // 
            this.birthdayPeople.Location = new System.Drawing.Point(17, 40);
            this.birthdayPeople.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.birthdayPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.birthdayPeople.Name = "birthdayPeople";
            this.birthdayPeople.Size = new System.Drawing.Size(120, 21);
            this.birthdayPeople.TabIndex = 6;
            this.birthdayPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(17, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cost";
            // 
            // birthdayFancyDecorations
            // 
            this.birthdayFancyDecorations.AutoSize = true;
            this.birthdayFancyDecorations.Location = new System.Drawing.Point(17, 72);
            this.birthdayFancyDecorations.Name = "birthdayFancyDecorations";
            this.birthdayFancyDecorations.Size = new System.Drawing.Size(126, 16);
            this.birthdayFancyDecorations.TabIndex = 8;
            this.birthdayFancyDecorations.Text = "Fancy Decorations";
            this.birthdayFancyDecorations.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cake writing";
            // 
            // birthdayCakeWriting
            // 
            this.birthdayCakeWriting.Location = new System.Drawing.Point(17, 122);
            this.birthdayCakeWriting.Name = "birthdayCakeWriting";
            this.birthdayCakeWriting.Size = new System.Drawing.Size(120, 21);
            this.birthdayCakeWriting.TabIndex = 13;
            this.birthdayCakeWriting.Text = "Happy Birthday";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 225);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner 2.0";
            ((System.ComponentModel.ISupportInitialize)(this.dinnerPeople)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown dinnerPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox dinnerFancyDecorations;
        private System.Windows.Forms.CheckBox dinnerHealthy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dinnerCost;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox birthdayCakeWriting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label birthdayCost;
        private System.Windows.Forms.NumericUpDown birthdayPeople;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox birthdayFancyDecorations;
    }
}

