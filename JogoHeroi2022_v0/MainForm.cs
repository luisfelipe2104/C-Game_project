/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 18/08/2022
 * Time: 21:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JogoHeroi2022_v0
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
			// sets the height and width of the game
			this.Height = Screen.PrimaryScreen.Bounds.Height / 2 + Screen.PrimaryScreen.Bounds.Height / 4 + 150;
			this.Width = Screen.PrimaryScreen.Bounds.Width / 2 + Screen.PrimaryScreen.Bounds.Width / 4;
			
			pictureBox1.Left = this.Width/4;
			pictureBox1.Top = this.Height/4;		
		}
	
		public static PictureBox fundo = new PictureBox();
		
		public static Heroi heroi = new Heroi();
		Inimigo inimigo = new Inimigo();
		int counter = 1;
		bool sky = false;
//		List<Inimigo> arrayInimigo = new List<Inimigo>;
		Inimigo [] arrayInimigo = new Inimigo[1000];
		
		void MainFormKeyDown(object sender, KeyEventArgs e) // Programar as teclas de movimento.
		{
			// checks the key that is being pressed and moves the hero
			
			if(e.KeyCode == Keys.W || e.KeyCode == Keys.Up){
				heroi.Up();
			}

			if(e.KeyCode == Keys.A || e.KeyCode == Keys.Left){
				heroi.Lefts();	
			}
				
			if(e.KeyCode == Keys.S || e.KeyCode == Keys.Down){
				heroi.Down();
			}
				
			if(e.KeyCode == Keys.D || e.KeyCode == Keys.Right){
				heroi.Right();
			}
			
			if(e.KeyCode == Keys.Space && heroi.tiros <= 2 && heroi.vivo){
				heroi.Shot(heroi.Top, heroi.Left, fundo);
			}
					
			// e.KeyCode == Keys. Selecionar qualquer tecla
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			
			Random rnd = new Random();
			int percent = rnd.Next(1, 101);
			if(percent < 10){
				Inimigo inimigo = new Inimigo();
				inimigo.Parent = fundo;
				int chance = rnd.Next(1, 4);
				int positionY = 0;
				
				// determines the top position randomly
				if (chance == 1) positionY = 100;
				else if (chance == 2) positionY = 300;
				else if (chance == 3) positionY = 500;
				inimigo.Top = positionY;
//				arrayInimigo.
				
			
			
			
			if (heroi.Bounds.IntersectsWith(inimigo.Bounds))
			{
				inimigo.timer.Enabled = false;
				timer1.Enabled = false;
				inimigo.Dispose();
				heroi.vivo = false;
				heroi.Dispose();
				MessageBox.Show("COLIDIU");
			}
			}
			
			
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
			this.KeyPreview = true;
			
			pictureBox1.Visible = false;
			pictureBox1.Enabled = false;
			
			// Tela de fundo (Cenário)
			
			fundo.Parent = this;
			fundo.Width = this.Width;
			fundo.Height = this.Height - 150;
			fundo.Load("cenario1.jpg");
			fundo.SizeMode = PictureBoxSizeMode.StretchImage;
			
			// Heroi 
			
			heroi.Parent = fundo;
			heroi.Left = 50;
			heroi.Top = fundo.Height/2 + fundo.Height/14;
			heroi.SizeMode = PictureBoxSizeMode.StretchImage;
			heroi.BackColor = Color.Transparent;
			
			heroi.Load("personagemRight.gif");
			
			heroi.Width = 200;
			heroi.Height = 200;
			
			timer1.Enabled = true;
			
			

					
		}
		void Timer2Tick(object sender, EventArgs e)
		{
	
		}
		
	}
}
