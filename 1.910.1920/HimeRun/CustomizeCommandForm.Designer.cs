namespace HimeRun {
    partial class CustomizeCommandForm {
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
            this.LName = new System.Windows.Forms.Label();
            this.TName = new System.Windows.Forms.TextBox();
            this.LDiscrib = new System.Windows.Forms.Label();
            this.TDiscrib = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TCode = new System.Windows.Forms.TextBox();
            this.BCancel = new System.Windows.Forms.Button();
            this.BSubmit = new System.Windows.Forms.Button();
            this.BClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(50, 42);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(77, 12);
            this.LName.TabIndex = 0;
            this.LName.Text = "Command Name";
            // 
            // TName
            // 
            this.TName.Location = new System.Drawing.Point(142, 37);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(661, 21);
            this.TName.TabIndex = 1;
            this.TName.TextChanged += new System.EventHandler(this.NameInput);
            // 
            // LDiscrib
            // 
            this.LDiscrib.AutoSize = true;
            this.LDiscrib.Location = new System.Drawing.Point(50, 69);
            this.LDiscrib.Name = "LDiscrib";
            this.LDiscrib.Size = new System.Drawing.Size(47, 12);
            this.LDiscrib.TabIndex = 0;
            this.LDiscrib.Text = "Discrib";
            // 
            // TDiscrib
            // 
            this.TDiscrib.Location = new System.Drawing.Point(142, 64);
            this.TDiscrib.Name = "TDiscrib";
            this.TDiscrib.Size = new System.Drawing.Size(661, 21);
            this.TDiscrib.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code(BAT)";
            // 
            // TCode
            // 
            this.TCode.Location = new System.Drawing.Point(142, 91);
            this.TCode.Multiline = true;
            this.TCode.Name = "TCode";
            this.TCode.Size = new System.Drawing.Size(661, 356);
            this.TCode.TabIndex = 1;
            // 
            // BCancel
            // 
            this.BCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BCancel.Location = new System.Drawing.Point(728, 472);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.TabIndex = 2;
            this.BCancel.Text = "Cancel";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.Close);
            // 
            // BSubmit
            // 
            this.BSubmit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BSubmit.Location = new System.Drawing.Point(647, 472);
            this.BSubmit.Name = "BSubmit";
            this.BSubmit.Size = new System.Drawing.Size(75, 23);
            this.BSubmit.TabIndex = 2;
            this.BSubmit.Text = "Submit";
            this.BSubmit.UseVisualStyleBackColor = true;
            this.BSubmit.Click += new System.EventHandler(this.Submit);
            // 
            // BClear
            // 
            this.BClear.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BClear.Location = new System.Drawing.Point(52, 472);
            this.BClear.Name = "BClear";
            this.BClear.Size = new System.Drawing.Size(75, 23);
            this.BClear.TabIndex = 2;
            this.BClear.Text = "Clear";
            this.BClear.UseVisualStyleBackColor = true;
            this.BClear.Click += new System.EventHandler(this.Clear);
            // 
            // CustomizeCommandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 519);
            this.Controls.Add(this.BClear);
            this.Controls.Add(this.BSubmit);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.TCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TDiscrib);
            this.Controls.Add(this.LDiscrib);
            this.Controls.Add(this.TName);
            this.Controls.Add(this.LName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomizeCommandForm";
            this.Text = "Customize Command";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.TextBox TName;
        private System.Windows.Forms.Label LDiscrib;
        private System.Windows.Forms.TextBox TDiscrib;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TCode;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.Button BSubmit;
        private System.Windows.Forms.Button BClear;
    }
}