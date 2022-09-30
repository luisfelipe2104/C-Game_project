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
		public int direction = 1; // may be 1 or -1
		public int counter = 1;
		public string rightImage = "personagemRight.gif";
		public string leftImage = "personagemLeft.gif";
		
		// hero methods
		public void Right(){
			if(counter == 3 && Left >= MainForm.fundo.Width - MainForm.fundo.Width/4){
				
			}
			else{
				Left += speed;
			}
			
			if (direction != 1)
			{
				// hero changed the direction
				direction = 1;
				Load(rightImage);
			}
			
			if (Left > MainForm.fundo.Width - this.Width)
			{
				Left = 0;
				if (counter < 3){
					counter ++;
				}
				
				MainForm.fundo.Load("cenario" + counter + ".jpg");
			}
			
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
