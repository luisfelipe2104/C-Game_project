﻿/*
 * Created by SharpDevelop.
 * User: Joaquim
 * Date: 27/10/2022
 * Time: 22:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JogoHeroi2022_v0 
{
	/// <summary>
	/// Description of Tiro.
	/// </summary>
	public class Tiro : Personagem
	{
		public Tiro()
		{
			Load("especial2.png");
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Width = 50;
			Height = 50;
			Top = 200;
			Left = 1200;
			
			timer2.Enabled = true;
			timer2.Interval = 100;
			timer2.Tick += Movimento;
		}
		
		public Timer timer2 = new Timer();
		public int dano;
		public bool ahead;
		
		Random rnd = new Random();
		
		void Movimento(object sender, EventArgs e)
		{
			if (ahead) Left += 25;
			else Left -= 25;
			if (Left > MainForm.fundo.Width || Left < 0)
			{
				this.timer2.Enabled = false;
				this.Dispose();
				MainForm.heroi.tiros--;
			}
		}
	}
}
