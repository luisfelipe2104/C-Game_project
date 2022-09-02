/*
 * Created by SharpDevelop.
 * User: Joaquim
 * Date: 01/09/2022
 * Time: 23:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace JogoHeroi2022_v0
{
	/// <summary>
	/// Description of Personagem.
	/// </summary>
	public class Personagem: PictureBox
	{
		public Personagem()
		{
			this.SizeMode = PictureBoxSizeMode.StretchImage;
		}
		
		// character properties
		public int hp = 100;
		public int ataque = 30;
		public int escudo = 50;
		public int xp = 0;
		public int speed = 15;
	}
}
