namespace BitcoinSettingGUI
{
    partial class Form2
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
            this.buttonNewCreate = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewCreate
            // 
            this.buttonNewCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(74)))));
            this.buttonNewCreate.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonNewCreate.Font = new System.Drawing.Font("휴먼둥근헤드라인", 13F);
            this.buttonNewCreate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonNewCreate.Location = new System.Drawing.Point(20, 30);
            this.buttonNewCreate.Margin = new System.Windows.Forms.Padding(10);
            this.buttonNewCreate.Name = "buttonNewCreate";
            this.buttonNewCreate.Size = new System.Drawing.Size(200, 200);
            this.buttonNewCreate.TabIndex = 3;
            this.buttonNewCreate.Text = "신규 생성";
            this.buttonNewCreate.UseVisualStyleBackColor = false;
            this.buttonNewCreate.Click += new System.EventHandler(this.buttonNewCreate_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(74)))));
            this.buttonLoad.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonLoad.Font = new System.Drawing.Font("휴먼둥근헤드라인", 13F);
            this.buttonLoad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLoad.Location = new System.Drawing.Point(280, 30);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(10);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(200, 200);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "자동 열기";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.ControlBox = false;
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonNewCreate);
            this.DisplayHeader = false;
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonNewCreate;
        private System.Windows.Forms.Button buttonLoad;
    }
}