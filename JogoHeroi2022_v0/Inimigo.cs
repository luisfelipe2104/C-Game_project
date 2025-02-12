﻿/*
 * Created by SharpDevelop.
 * User: Joaquim
 * Date: 27/10/2022
 * Time: 21:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JogoHeroi2022_v0
{
	/// <summary>
	/// Description of Inimigo.
	/// </summary>
	/// 
	
	public class Inimigo : Personagem
	{
		public Inimigo()
		{
			Load("enemy.png");
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Width = 70;
			Height = 70;
			Top = 0;
			Left = MainForm.fundo.Width;
			
			
			timer.Enabled = true;
			timer.Interval = 100;
			timer.Tick += Movimento;
		}
		
		public Timer timer = new Timer();
		public int dano;
		
		
		
		void Movimento(object sender, EventArgs e)
		{
			Left -= 15;
			if (Left < - 100)
			{
				this.timer.Enabled = false;
				this.Dispose();
			}
		}
	}
}
