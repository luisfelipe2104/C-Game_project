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
			
			this.Height = Screen.PrimaryScreen.Bounds.Height / 2 + Screen.PrimaryScreen.Bounds.Height / 4 + 150;
			this.Width = Screen.PrimaryScreen.Bounds.Width / 2 + Screen.PrimaryScreen.Bounds.Width / 4;
			
			pictureBox1.Left = this.Width/4;
			pictureBox1.Top = this.Height/4;
			
		}
	
		PictureBox heroi = new PictureBox();
		PictureBox fundo = new PictureBox();
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			this.KeyPreview = true;
			
			pictureBox1.Visible = false;
			
			// Tela de fundo (cenário)
			
			
			fundo.Parent = this;
			fundo.Width = this.Width;
			fundo.Height = this.Height - 150;
			fundo.Load("cenario2.jpg");
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
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                heroi.Top -= 15;
            if(e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                heroi.Left -= 15;
            if(e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            	if(heroi.Top + heroi.Height < fundo.Height)
                	heroi.Top += 15;
            if(e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                heroi.Left += 15;
            
		}
		
	}
}
