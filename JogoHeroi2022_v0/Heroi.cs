/*
 * Created by SharpDevelop.
 * User: Joaquim
 * Date: 01/09/2022
 * Time: 23:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JogoHeroi2022_v0
{
	/// <summary>
	/// Description of Heroi.
	/// </summary>
	public class Heroi: Personagem
	{
		public Heroi()
		{
			// constructor, the hero is created with those properties already set
			this.Width = 100;
			this.Height = 100;
			this.Left = 50;
			this.Top = 100;
			
			this.BackColor = Color.Transparent;
		}
		
		// hero variables
		public int xp = 0;
		public int nivel = 0;
		
		// hero methods
		public void Right(){
			Left += speed;
		}
		
		public void Lefts(){
			Left -= speed;
		}
		
		public void Up(){
			Top -= speed;
		}
		
		public void Down(){
			Top += speed;
		}
	}
}
