
namespace B0226497_段昱如_PDPR_week6_2
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRESULT = new System.Windows.Forms.Label();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRESULT
            // 
            this.lblRESULT.AutoSize = true;
            this.lblRESULT.Location = new System.Drawing.Point(54, 193);
            this.lblRESULT.Name = "lblRESULT";
            this.lblRESULT.Size = new System.Drawing.Size(119, 24);
            this.lblRESULT.TabIndex = 7;
            this.lblRESULT.Text = "lblRESULT";
            // 
            // btnEXIT
            // 
            this.btnEXIT.Location = new System.Drawing.Point(226, 110);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(106, 40);
            this.btnEXIT.TabIndex = 6;
            this.btnEXIT.Text = "結束";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(58, 110);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(93, 40);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "建立";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "B0226497_段昱如_PDPR_week6_1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 530);
            this.Controls.Add(this.lblRESULT);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRESULT;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
    }
}

