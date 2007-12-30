namespace bbs2html
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該公開 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                        | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.textBox1.Location = new System.Drawing.Point( 12, 11 );
            this.textBox1.Margin = new System.Windows.Forms.Padding( 3, 2, 3, 2 );
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size( 268, 220 );
            this.textBox1.TabIndex = 0;
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btnConvert.Location = new System.Drawing.Point( 205, 236 );
            this.btnConvert.Margin = new System.Windows.Forms.Padding( 3, 2, 3, 2 );
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size( 75, 23 );
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "轉換";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler( this.btnConvert_Click );
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "索引檔案 (.DIR)|.DIR|所有檔案 (*.*)|*.*";
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.btnOpen.Location = new System.Drawing.Point( 12, 236 );
            this.btnOpen.Margin = new System.Windows.Forms.Padding( 3, 2, 3, 2 );
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size( 75, 23 );
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "開啟檔案";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler( this.btnOpen_Click );
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 12F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 292, 270 );
            this.Controls.Add( this.btnOpen );
            this.Controls.Add( this.btnConvert );
            this.Controls.Add( this.textBox1 );
            this.Margin = new System.Windows.Forms.Padding( 3, 2, 3, 2 );
            this.Name = "Form1";
            this.Text = "bbs2html";
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpen;
    }
}

