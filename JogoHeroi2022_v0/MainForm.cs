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
			
//			PictureBox button1 = new PictureBox();
			
			
			
			
			InitializeComponent();
			
			// sets the height and width of the game
			this.Height = Screen.PrimaryScreen.Bounds.Height / 2 + Screen.PrimaryScreen.Bounds.Height / 4 + 150;
			this.Width = Screen.PrimaryScreen.Bounds.Width / 2 + Screen.PrimaryScreen.Bounds.Width / 4;
			
			pictureBox1.Left = this.Width/4;
			pictureBox1.Top = this.Height/4;		

//			button1.Width = 250;
//			button1.Height = 50;
//			
//			button1.Top = 50;
//			button1.Left= 50;
//			
//			button1.Parent = this;	
//			button1.Load("butao2.png");
		}
	
//		PictureBox heroi = new PictureBox();
		PictureBox fundo = new PictureBox();
		
		Heroi heroi = new Heroi();
		int counter = 1;
		
		void MainFormKeyDown(object sender, KeyEventArgs e) // Programar as teclas de movimento.
		{
			// checks the key that is being pressed and moves the hero
			if(e.KeyCode == Keys.W || e.KeyCode == Keys.Up){
				if(heroi.Top + heroi.Height < 0){
					fundo.Load("ceu.png");
					heroi.Top = fundo.Height;
				}
				heroi.Up();
			}
				
				
			if(e.KeyCode == Keys.A || e.KeyCode == Keys.Left){
				if(heroi.Left < 0){
					if(counter > 1){
						counter--;
					}
					fundo.Load("cenario" + counter + ".jpg");
					
					heroi.Left = fundo.Width - heroi.Width;
					
				}
				if(counter == 1 && heroi.Left < 0 + (heroi.Width/2) ){
					
				}
				else{
					heroi.Lefts();
				}
				
			}
				
			if(e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
				if(heroi.Top + heroi.Height < fundo.Height)
					heroi.Down();
			if(e.KeyCode == Keys.D || e.KeyCode == Keys.Right){
				if(heroi.Left > fundo.Width){
					if(counter < 3){
						counter++;
					}
					fundo.Load("cenario" + counter + ".jpg");
					
					
					heroi.Left = 0;
					
					
				}
				if(counter == 3 && heroi.Left > fundo.Width - heroi.Width * 1.5){
					
				}
				else{
					heroi.Right();
				}
			}
			
			
			
			// e.KeyCode == Keys. Selecionar qualquer tecla
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
			
			heroi.Load("heroi.gif");
			heroi.Width = 80;
			heroi.Height = 170;
					
		}
		
	}
}
