using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IngilizceKelimeOgren
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection baglanti = new SqlConnection(@"Data Source=emin\SQLEXPRESS;Initial Catalog=TryCopy;Integrated Security=True;Encrypt=False");
		Random rast = new Random();
		int sure = 90;
		int kelime = 0;

		void getir()
		{
			int sayi;
			sayi = rast.Next(1, 2490);

			baglanti.Open();
			SqlCommand komut = new SqlCommand("SELECT * from dictionary where id=@p1", baglanti);
			komut.Parameters.AddWithValue("@p1", (rast.Next(1, 2490)));
			SqlDataReader dr = komut.ExecuteReader();

			while (dr.Read())
			{
				Txtİngilizce.Text = dr[1].ToString();
				LblCevap.Text = dr[2].ToString();
				LblCevap.Text = LblCevap.Text.ToLower();
			}
			baglanti.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			getir();
			TxtTurkce.Focus();
			timer1.Start();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			if(TxtTurkce.Text==LblCevap.Text)
			{
				kelime++;
				LblKelime.Text = kelime.ToString();
				getir();
				TxtTurkce.Clear();
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			sure--;
			LblSure.Text = sure.ToString();	
			if( sure == 0)
			{
				TxtTurkce.Enabled = false;
				Txtİngilizce.Enabled = false;
				timer1.Stop();
			}
		}
	}
}
