namespace ReflectionExample
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TypeNameValue = new System.Windows.Forms.TextBox();
            this.DiscoverBtn = new System.Windows.Forms.Button();
            this.Properties = new System.Windows.Forms.ListBox();
            this.Methods = new System.Windows.Forms.ListBox();
            this.Constructors = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TypeNameValue
            // 
            this.TypeNameValue.Location = new System.Drawing.Point(146, 13);
            this.TypeNameValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TypeNameValue.Name = "TypeNameValue";
            this.TypeNameValue.Size = new System.Drawing.Size(365, 23);
            this.TypeNameValue.TabIndex = 1;
            // 
            // DiscoverBtn
            // 
            this.DiscoverBtn.ForeColor = System.Drawing.Color.White;
            this.DiscoverBtn.Location = new System.Drawing.Point(534, 13);
            this.DiscoverBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DiscoverBtn.Name = "DiscoverBtn";
            this.DiscoverBtn.Size = new System.Drawing.Size(236, 23);
            this.DiscoverBtn.TabIndex = 2;
            this.DiscoverBtn.Text = "Discover Type Info";
            this.DiscoverBtn.UseVisualStyleBackColor = true;
            this.DiscoverBtn.UseWaitCursor = true;
            this.DiscoverBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Properties
            // 
            this.Properties.FormattingEnabled = true;
            this.Properties.ItemHeight = 17;
            this.Properties.Location = new System.Drawing.Point(18, 77);
            this.Properties.Name = "Properties";
            this.Properties.Size = new System.Drawing.Size(233, 378);
            this.Properties.TabIndex = 3;
            // 
            // Methods
            // 
            this.Methods.FormattingEnabled = true;
            this.Methods.ItemHeight = 17;
            this.Methods.Location = new System.Drawing.Point(278, 77);
            this.Methods.Name = "Methods";
            this.Methods.Size = new System.Drawing.Size(233, 378);
            this.Methods.TabIndex = 4;
            // 
            // Constructors
            // 
            this.Constructors.FormattingEnabled = true;
            this.Constructors.ItemHeight = 17;
            this.Constructors.Location = new System.Drawing.Point(537, 77);
            this.Constructors.Name = "Constructors";
            this.Constructors.Size = new System.Drawing.Size(233, 378);
            this.Constructors.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Properties:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(274, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Method:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(533, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Constructors:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 462);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Constructors);
            this.Controls.Add(this.Methods);
            this.Controls.Add(this.Properties);
            this.Controls.Add(this.DiscoverBtn);
            this.Controls.Add(this.TypeNameValue);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TypeNameValue;
        private System.Windows.Forms.Button DiscoverBtn;
        private System.Windows.Forms.ListBox Properties;
        private System.Windows.Forms.ListBox Methods;
        private System.Windows.Forms.ListBox Constructors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

