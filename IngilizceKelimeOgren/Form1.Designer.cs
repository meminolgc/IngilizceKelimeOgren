namespace IngilizceKelimeOgren
{
	partial class Form1
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
			this.Txtİngilizce1 = new System.Windows.Forms.Label();
			this.TxtTurkce1 = new System.Windows.Forms.Label();
			this.Txtİngilizce = new System.Windows.Forms.TextBox();
			this.TxtTurkce = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.LblSure = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.LblKelime = new System.Windows.Forms.Label();
			this.LblCevap = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// Txtİngilizce1
			// 
			this.Txtİngilizce1.AutoSize = true;
			this.Txtİngilizce1.Location = new System.Drawing.Point(16, 33);
			this.Txtİngilizce1.Name = "Txtİngilizce1";
			this.Txtİngilizce1.Size = new System.Drawing.Size(71, 18);
			this.Txtİngilizce1.TabIndex = 0;
			this.Txtİngilizce1.Text = "İngilizce:";
			// 
			// TxtTurkce1
			// 
			this.TxtTurkce1.AutoSize = true;
			this.TxtTurkce1.Location = new System.Drawing.Point(23, 95);
			this.TxtTurkce1.Name = "TxtTurkce1";
			this.TxtTurkce1.Size = new System.Drawing.Size(64, 18);
			this.TxtTurkce1.TabIndex = 1;
			this.TxtTurkce1.Text = "Türkçe:";
			// 
			// Txtİngilizce
			// 
			this.Txtİngilizce.Location = new System.Drawing.Point(93, 30);
			this.Txtİngilizce.Name = "Txtİngilizce";
			this.Txtİngilizce.Size = new System.Drawing.Size(196, 26);
			this.Txtİngilizce.TabIndex = 10;
			// 
			// TxtTurkce
			// 
			this.TxtTurkce.Location = new System.Drawing.Point(93, 92);
			this.TxtTurkce.Name = "TxtTurkce";
			this.TxtTurkce.Size = new System.Drawing.Size(196, 26);
			this.TxtTurkce.TabIndex = 1;
			this.TxtTurkce.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(364, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 18);
			this.label3.TabIndex = 4;
			this.label3.Text = "Süre:";
			// 
			// LblSure
			// 
			this.LblSure.AutoSize = true;
			this.LblSure.Location = new System.Drawing.Point(435, 33);
			this.LblSure.Name = "LblSure";
			this.LblSure.Size = new System.Drawing.Size(27, 18);
			this.LblSure.TabIndex = 5;
			this.LblSure.Text = "90";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(348, 95);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 18);
			this.label5.TabIndex = 6;
			this.label5.Text = "Kelime:";
			// 
			// LblKelime
			// 
			this.LblKelime.AutoSize = true;
			this.LblKelime.Location = new System.Drawing.Point(435, 95);
			this.LblKelime.Name = "LblKelime";
			this.LblKelime.Size = new System.Drawing.Size(18, 18);
			this.LblKelime.TabIndex = 7;
			this.LblKelime.Text = "0";
			// 
			// LblCevap
			// 
			this.LblCevap.AutoSize = true;
			this.LblCevap.Location = new System.Drawing.Point(156, 144);
			this.LblCevap.Name = "LblCevap";
			this.LblCevap.Size = new System.Drawing.Size(49, 18);
			this.LblCevap.TabIndex = 8;
			this.LblCevap.Text = "label7";
			this.LblCevap.Visible = false;
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 181);
			this.Controls.Add(this.LblCevap);
			this.Controls.Add(this.LblKelime);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.LblSure);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TxtTurkce);
			this.Controls.Add(this.Txtİngilizce);
			this.Controls.Add(this.TxtTurkce1);
			this.Controls.Add(this.Txtİngilizce1);
			this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "KelimeOyunu";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Txtİngilizce1;
		private System.Windows.Forms.Label TxtTurkce1;
		private System.Windows.Forms.TextBox Txtİngilizce;
		private System.Windows.Forms.TextBox TxtTurkce;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label LblSure;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label LblKelime;
		private System.Windows.Forms.Label LblCevap;
		private System.Windows.Forms.Timer timer1;
	}
}

