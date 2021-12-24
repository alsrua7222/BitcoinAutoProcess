namespace BitcoinSettingGUI.Forms
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.labelLine1 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelTelegram = new System.Windows.Forms.Label();
            this.labelUpbit = new System.Windows.Forms.Label();
            this.labelBinanace = new System.Windows.Forms.Label();
            this.labelTelegramState = new System.Windows.Forms.Label();
            this.labelUpbitState = new System.Windows.Forms.Label();
            this.labelBinanaceState = new System.Windows.Forms.Label();
            this.labelLine2 = new System.Windows.Forms.Label();
            this.labelLine3 = new System.Windows.Forms.Label();
            this.labelAPI = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelUpdateTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.timerNetwork = new System.Windows.Forms.Timer(this.components);
            this.labelNetwork = new System.Windows.Forms.Label();
            this.labelNetworkName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLine1
            // 
            this.labelLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLine1.Location = new System.Drawing.Point(32, 197);
            this.labelLine1.Name = "labelLine1";
            this.labelLine1.Size = new System.Drawing.Size(290, 2);
            this.labelLine1.TabIndex = 0;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(12, 9);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(133, 38);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Status";
            // 
            // labelTelegram
            // 
            this.labelTelegram.AutoSize = true;
            this.labelTelegram.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelegram.Location = new System.Drawing.Point(28, 220);
            this.labelTelegram.Name = "labelTelegram";
            this.labelTelegram.Size = new System.Drawing.Size(171, 22);
            this.labelTelegram.TabIndex = 2;
            this.labelTelegram.Text = "TELEGRAM TOKEN";
            // 
            // labelUpbit
            // 
            this.labelUpbit.AutoSize = true;
            this.labelUpbit.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpbit.Location = new System.Drawing.Point(28, 252);
            this.labelUpbit.Name = "labelUpbit";
            this.labelUpbit.Size = new System.Drawing.Size(104, 22);
            this.labelUpbit.TabIndex = 3;
            this.labelUpbit.Text = "UPBIT API";
            // 
            // labelBinanace
            // 
            this.labelBinanace.AutoSize = true;
            this.labelBinanace.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBinanace.Location = new System.Drawing.Point(28, 285);
            this.labelBinanace.Name = "labelBinanace";
            this.labelBinanace.Size = new System.Drawing.Size(128, 22);
            this.labelBinanace.TabIndex = 4;
            this.labelBinanace.Text = "BINANCE API";
            // 
            // labelTelegramState
            // 
            this.labelTelegramState.AutoSize = true;
            this.labelTelegramState.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelegramState.ForeColor = System.Drawing.Color.Red;
            this.labelTelegramState.Location = new System.Drawing.Point(297, 216);
            this.labelTelegramState.Name = "labelTelegramState";
            this.labelTelegramState.Size = new System.Drawing.Size(25, 26);
            this.labelTelegramState.TabIndex = 5;
            this.labelTelegramState.Text = "X";
            // 
            // labelUpbitState
            // 
            this.labelUpbitState.AutoSize = true;
            this.labelUpbitState.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpbitState.ForeColor = System.Drawing.Color.Lime;
            this.labelUpbitState.Location = new System.Drawing.Point(297, 249);
            this.labelUpbitState.Name = "labelUpbitState";
            this.labelUpbitState.Size = new System.Drawing.Size(28, 26);
            this.labelUpbitState.TabIndex = 6;
            this.labelUpbitState.Text = "O";
            // 
            // labelBinanaceState
            // 
            this.labelBinanaceState.AutoSize = true;
            this.labelBinanaceState.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBinanaceState.ForeColor = System.Drawing.Color.Red;
            this.labelBinanaceState.Location = new System.Drawing.Point(297, 282);
            this.labelBinanaceState.Name = "labelBinanaceState";
            this.labelBinanaceState.Size = new System.Drawing.Size(25, 26);
            this.labelBinanaceState.TabIndex = 7;
            this.labelBinanaceState.Text = "X";
            // 
            // labelLine2
            // 
            this.labelLine2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLine2.Location = new System.Drawing.Point(339, 18);
            this.labelLine2.Name = "labelLine2";
            this.labelLine2.Size = new System.Drawing.Size(2, 422);
            this.labelLine2.TabIndex = 8;
            // 
            // labelLine3
            // 
            this.labelLine3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLine3.Location = new System.Drawing.Point(32, 329);
            this.labelLine3.Name = "labelLine3";
            this.labelLine3.Size = new System.Drawing.Size(290, 2);
            this.labelLine3.TabIndex = 9;
            // 
            // labelAPI
            // 
            this.labelAPI.AutoSize = true;
            this.labelAPI.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAPI.Location = new System.Drawing.Point(22, 175);
            this.labelAPI.Name = "labelAPI";
            this.labelAPI.Size = new System.Drawing.Size(116, 22);
            this.labelAPI.TabIndex = 10;
            this.labelAPI.Text = "API STATUS";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(32, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 2);
            this.label2.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "TEST MODE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "LOG ON/OFF";
            // 
            // labelUpdateTime
            // 
            this.labelUpdateTime.AutoSize = true;
            this.labelUpdateTime.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateTime.Location = new System.Drawing.Point(28, 399);
            this.labelUpdateTime.Name = "labelUpdateTime";
            this.labelUpdateTime.Size = new System.Drawing.Size(131, 22);
            this.labelUpdateTime.TabIndex = 12;
            this.labelUpdateTime.Text = "UPDATE TIME";
            this.labelUpdateTime.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(32, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(290, 2);
            this.label9.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(165, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "0.001 Second";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(297, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "O";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(297, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "GLOBAL SETTINGS";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComment.Location = new System.Drawing.Point(355, 9);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(165, 38);
            this.labelComment.TabIndex = 20;
            this.labelComment.Text = "Comment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 22);
            this.label8.TabIndex = 22;
            this.label8.Text = "Server Connect";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(32, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(290, 2);
            this.label10.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 22);
            this.label11.TabIndex = 23;
            this.label11.Text = "UPBIT SERVER";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(166, 22);
            this.label12.TabIndex = 24;
            this.label12.Text = "BINANCE SERVER";
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(32, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(290, 2);
            this.label13.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Lime;
            this.label14.Location = new System.Drawing.Point(297, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 26);
            this.label14.TabIndex = 27;
            this.label14.Text = "O";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(297, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 26);
            this.label15.TabIndex = 26;
            this.label15.Text = "X";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(22, 539);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 22);
            this.label16.TabIndex = 28;
            this.label16.Text = "Networking";
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(32, 560);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(290, 2);
            this.label17.TabIndex = 29;
            // 
            // timerNetwork
            // 
            this.timerNetwork.Enabled = true;
            this.timerNetwork.Interval = 1000;
            this.timerNetwork.Tick += new System.EventHandler(this.timerNetwork_Tick);
            // 
            // labelNetwork
            // 
            this.labelNetwork.AutoSize = true;
            this.labelNetwork.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelNetwork.ForeColor = System.Drawing.Color.DarkGray;
            this.labelNetwork.Location = new System.Drawing.Point(27, 595);
            this.labelNetwork.Name = "labelNetwork";
            this.labelNetwork.Size = new System.Drawing.Size(65, 26);
            this.labelNetwork.TabIndex = 31;
            this.labelNetwork.Text = "0 bps";
            // 
            // labelNetworkName
            // 
            this.labelNetworkName.AutoSize = true;
            this.labelNetworkName.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNetworkName.Location = new System.Drawing.Point(28, 579);
            this.labelNetworkName.Name = "labelNetworkName";
            this.labelNetworkName.Size = new System.Drawing.Size(96, 16);
            this.labelNetworkName.TabIndex = 32;
            this.labelNetworkName.Text = "Module Name";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1074, 661);
            this.Controls.Add(this.labelNetworkName);
            this.Controls.Add(this.labelNetwork);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelUpdateTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelAPI);
            this.Controls.Add(this.labelLine3);
            this.Controls.Add(this.labelLine2);
            this.Controls.Add(this.labelBinanaceState);
            this.Controls.Add(this.labelUpbitState);
            this.Controls.Add(this.labelTelegramState);
            this.Controls.Add(this.labelBinanace);
            this.Controls.Add(this.labelUpbit);
            this.Controls.Add(this.labelTelegram);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelLine1);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLine1;
        private System.Windows.Forms.Label labelStatus;
        public System.Windows.Forms.Label labelTelegram;
        public System.Windows.Forms.Label labelUpbit;
        public System.Windows.Forms.Label labelBinanace;
        public System.Windows.Forms.Label labelTelegramState;
        public System.Windows.Forms.Label labelUpbitState;
        public System.Windows.Forms.Label labelBinanaceState;
        private System.Windows.Forms.Label labelLine2;
        private System.Windows.Forms.Label labelLine3;
        public System.Windows.Forms.Label labelAPI;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label labelUpdateTime;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelComment;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Timer timerNetwork;
        private System.Windows.Forms.Label labelNetwork;
        public System.Windows.Forms.Label labelNetworkName;
    }
}