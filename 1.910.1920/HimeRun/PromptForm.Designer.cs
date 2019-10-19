namespace HimeRun {
    partial class PromptForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.TValue = new System.Windows.Forms.TextBox();
            this.BSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TValue
            // 
            this.TValue.Location = new System.Drawing.Point(22, 12);
            this.TValue.Name = "TValue";
            this.TValue.Size = new System.Drawing.Size(348, 21);
            this.TValue.TabIndex = 0;
            // 
            // BSubmit
            // 
            this.BSubmit.Location = new System.Drawing.Point(376, 11);
            this.BSubmit.Name = "BSubmit";
            this.BSubmit.Size = new System.Drawing.Size(75, 23);
            this.BSubmit.TabIndex = 1;
            this.BSubmit.Text = "OK";
            this.BSubmit.UseVisualStyleBackColor = true;
            this.BSubmit.Click += new System.EventHandler(this.Submit);
            // 
            // FormPropt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 46);
            this.Controls.Add(this.BSubmit);
            this.Controls.Add(this.TValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPropt";
            this.Text = "FormPropt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TValue;
        private System.Windows.Forms.Button BSubmit;
    }
}