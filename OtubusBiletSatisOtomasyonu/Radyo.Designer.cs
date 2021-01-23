namespace OtubusBiletSatisOtomasyonu
{
    partial class Radyo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Radyo));
            this.btnAlemFm = new System.Windows.Forms.Button();
            this.btnPowerFm = new System.Windows.Forms.Button();
            this.btnRadyoEge = new System.Windows.Forms.Button();
            this.btnShowRadyo = new System.Windows.Forms.Button();
            this.btnShowTurk = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnRadyoKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlemFm
            // 
            this.btnAlemFm.Location = new System.Drawing.Point(62, 51);
            this.btnAlemFm.Name = "btnAlemFm";
            this.btnAlemFm.Size = new System.Drawing.Size(153, 64);
            this.btnAlemFm.TabIndex = 0;
            this.btnAlemFm.Text = "Alem FM";
            this.btnAlemFm.UseVisualStyleBackColor = true;
            this.btnAlemFm.Click += new System.EventHandler(this.btnAlemFm_Click);
            // 
            // btnPowerFm
            // 
            this.btnPowerFm.Location = new System.Drawing.Point(62, 145);
            this.btnPowerFm.Name = "btnPowerFm";
            this.btnPowerFm.Size = new System.Drawing.Size(153, 64);
            this.btnPowerFm.TabIndex = 0;
            this.btnPowerFm.Text = "Power FM";
            this.btnPowerFm.UseVisualStyleBackColor = true;
            this.btnPowerFm.Click += new System.EventHandler(this.btnPowerFm_Click);
            // 
            // btnRadyoEge
            // 
            this.btnRadyoEge.Location = new System.Drawing.Point(62, 244);
            this.btnRadyoEge.Name = "btnRadyoEge";
            this.btnRadyoEge.Size = new System.Drawing.Size(153, 64);
            this.btnRadyoEge.TabIndex = 0;
            this.btnRadyoEge.Text = "Radyo Ege";
            this.btnRadyoEge.UseVisualStyleBackColor = true;
            this.btnRadyoEge.Click += new System.EventHandler(this.btnRadyoEge_Click);
            // 
            // btnShowRadyo
            // 
            this.btnShowRadyo.Location = new System.Drawing.Point(62, 350);
            this.btnShowRadyo.Name = "btnShowRadyo";
            this.btnShowRadyo.Size = new System.Drawing.Size(153, 64);
            this.btnShowRadyo.TabIndex = 0;
            this.btnShowRadyo.Text = "Show Radyo";
            this.btnShowRadyo.UseVisualStyleBackColor = true;
            this.btnShowRadyo.Click += new System.EventHandler(this.btnShowRadyo_Click);
            // 
            // btnShowTurk
            // 
            this.btnShowTurk.Location = new System.Drawing.Point(62, 455);
            this.btnShowTurk.Name = "btnShowTurk";
            this.btnShowTurk.Size = new System.Drawing.Size(153, 64);
            this.btnShowTurk.TabIndex = 0;
            this.btnShowTurk.Text = "Show Turk";
            this.btnShowTurk.UseVisualStyleBackColor = true;
            this.btnShowTurk.Click += new System.EventHandler(this.btnShowTurk_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(285, 47);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(556, 399);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // btnRadyoKapat
            // 
            this.btnRadyoKapat.Location = new System.Drawing.Point(902, 12);
            this.btnRadyoKapat.Name = "btnRadyoKapat";
            this.btnRadyoKapat.Size = new System.Drawing.Size(125, 49);
            this.btnRadyoKapat.TabIndex = 2;
            this.btnRadyoKapat.Text = "Kapat";
            this.btnRadyoKapat.UseVisualStyleBackColor = true;
            this.btnRadyoKapat.Click += new System.EventHandler(this.btnRadyoKapat_Click);
            // 
            // Radyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1029, 636);
            this.Controls.Add(this.btnRadyoKapat);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btnShowTurk);
            this.Controls.Add(this.btnShowRadyo);
            this.Controls.Add(this.btnRadyoEge);
            this.Controls.Add(this.btnPowerFm);
            this.Controls.Add(this.btnAlemFm);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Radyo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radyo";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlemFm;
        private System.Windows.Forms.Button btnPowerFm;
        private System.Windows.Forms.Button btnRadyoEge;
        private System.Windows.Forms.Button btnShowRadyo;
        private System.Windows.Forms.Button btnShowTurk;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnRadyoKapat;
    }
}