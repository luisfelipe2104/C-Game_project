﻿/*
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
		
		Heroi heroi = new Heroi();
		int counter = 1;
		bool sky = false;
		
		void MainFormKeyDown(object sender, KeyEventArgs e) // Programar as teclas de movimento.
		{
			// checks the key that is being pressed and moves the hero
			
			if(e.KeyCode == Keys.W || e.KeyCode == Keys.Up){
				if(heroi.Top + heroi.Height < 0){
					
					sky = true;
					fundo.Load("ceu.jpg");
					heroi.Top = fundo.Height;
					
				}
				
				if(sky && heroi.Top >= 0 || !sky){
					heroi.Up();
				}
			}

			if(e.KeyCode == Keys.A || e.KeyCode == Keys.Left){
				if(heroi.Left < 0){
					heroi.Left = fundo.Width - heroi.Width;
					if(counter > 1){
						counter--;
					}
					if(!sky){
						fundo.Load("cenario" + counter + ".jpg");
					}
					
				}
				if(counter == 1 && heroi.Left < 0 + (heroi.Width/2) ){
					
				}
				else{
					heroi.Load("personagemLeft.gif");
					heroi.Lefts();
				}
				
			}
				
			if(e.KeyCode == Keys.S || e.KeyCode == Keys.Down){
				if(sky){
					heroi.Down();
					if(heroi.Top > fundo.Height){
						sky = false;
						heroi.Top = 0;
						fundo.Load("cenario" + counter + ".jpg");
					}
				}
				if(heroi.Top + heroi.Height < fundo.Height){
					heroi.Down();
				}
					
			}
				
			if(e.KeyCode == Keys.D || e.KeyCode == Keys.Right){
				heroi.Right();
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
			
			heroi.Load("personagemRight.gif");
			
			heroi.Width = 200;
			heroi.Height = 200;

					
		}
		
	}
}
