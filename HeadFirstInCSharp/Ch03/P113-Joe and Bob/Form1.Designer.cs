namespace P113_Joe_and_Bob
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
            this.joeCashlabel = new System.Windows.Forms.Label();
            this.bobCashlabel = new System.Windows.Forms.Label();
            this.bankCashlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.joeGivesToBob = new System.Windows.Forms.Button();
            this.bobGivesToJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joeCashlabel
            // 
            this.joeCashlabel.AutoSize = true;
            this.joeCashlabel.Location = new System.Drawing.Point(20, 9);
            this.joeCashlabel.Name = "joeCashlabel";
            this.joeCashlabel.Size = new System.Drawing.Size(41, 12);
            this.joeCashlabel.TabIndex = 0;
            this.joeCashlabel.Text = "label1";
            // 
            // bobCashlabel
            // 
            this.bobCashlabel.AutoSize = true;
            this.bobCashlabel.Location = new System.Drawing.Point(20, 42);
            this.bobCashlabel.Name = "bobCashlabel";
            this.bobCashlabel.Size = new System.Drawing.Size(41, 12);
            this.bobCashlabel.TabIndex = 0;
            this.bobCashlabel.Text = "label1";
            // 
            // bankCashlabel
            // 
            this.bankCashlabel.AutoSize = true;
            this.bankCashlabel.Location = new System.Drawing.Point(20, 75);
            this.bankCashlabel.Name = "bankCashlabel";
            this.bankCashlabel.Size = new System.Drawing.Size(41, 12);
            this.bankCashlabel.TabIndex = 0;
            this.bankCashlabel.Text = "label1";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(17, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Give $10 to Joe";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Location = new System.Drawing.Point(121, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "Receive $5 from Bob";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // joeGivesToBob
            // 
            this.joeGivesToBob.Location = new System.Drawing.Point(17, 175);
            this.joeGivesToBob.Name = "joeGivesToBob";
            this.joeGivesToBob.Size = new System.Drawing.Size(92, 62);
            this.joeGivesToBob.TabIndex = 2;
            this.joeGivesToBob.Text = "Joe gives $10 to Bob";
            this.joeGivesToBob.UseVisualStyleBackColor = true;
            // 
            // bobGivesToJoe
            // 
            this.bobGivesToJoe.Location = new System.Drawing.Point(121, 175);
            this.bobGivesToJoe.Name = "bobGivesToJoe";
            this.bobGivesToJoe.Size = new System.Drawing.Size(92, 62);
            this.bobGivesToJoe.TabIndex = 2;
            this.bobGivesToJoe.Text = "Bob gives $5 to Joe";
            this.bobGivesToJoe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 251);
            this.Controls.Add(this.bobGivesToJoe);
            this.Controls.Add(this.joeGivesToBob);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bankCashlabel);
            this.Controls.Add(this.bobCashlabel);
            this.Controls.Add(this.joeCashlabel);
            this.Name = "Form1";
            this.Text = "Fun with Joe and Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joeCashlabel;
        private System.Windows.Forms.Label bobCashlabel;
        private System.Windows.Forms.Label bankCashlabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button joeGivesToBob;
        private System.Windows.Forms.Button bobGivesToJoe;
    }
}

