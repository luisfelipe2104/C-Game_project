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
		public bool ahead = false;
		public bool sky = false;
		public int counter = 1;
		public string rightImage = "personagemRight.gif";
		public string leftImage = "personagemLeft.gif";
		public int tiros = 0;
		public bool vivo = true;
		
		// hero methods
		public void Right(){
			if(counter == 3 && Left >= MainForm.fundo.Width - MainForm.fundo.Width/4){
				
			}
			else{
				Left += speed;
			}
			
			if (!ahead)
			{
				// hero changed the direction
				ahead = true;
				Load(rightImage);
				
				
			}
			
			if (Left > MainForm.fundo.Width - this.Width)
			{
				Left = 0;
				if (counter < 3){
					counter ++;
				}
				if(!sky){
					MainForm.fundo.Load("cenario" + counter + ".jpg");
				}
				
			}
			
		}
		
		public void Lefts(){
			if(counter == 1 && Left < 0 + (this.Width/2) ){
					
			}
			else{
				Left -= speed;
			}
			
			if(ahead){
				ahead = false;
				Load(leftImage);
				
				
			}
			if (Left < 0){
				Left = MainForm.fundo.Width - this.Width;
				if(counter > 1){
					counter--;
				}
				
				if(!sky){
					MainForm.fundo.Load("cenario" + counter + ".jpg");
				}
				
			}
		}
		
		public void Up(){
			if(Top + this.Height < 0){
					
					sky = true;
					MainForm.fundo.Load("ceu.jpg");
					Top = MainForm.fundo.Height;
					
				}
				
				if(sky && Top >= 0 || !sky){
					Top -= speed;
				}
		}
		
		public void Down(){
			
			if(sky){
					Top += speed;
					if(Top > MainForm.fundo.Height){
						sky = false;
						Top = 0;
						MainForm.fundo.Load("cenario" + counter + ".jpg");
					}
				}
				if(Top + this.Height < MainForm.fundo.Height){
					Top += speed;
				}
		}
		
		public void Shot(int top, int left, PictureBox fundo)
		{
			Tiro tiro = new Tiro();
			tiro.Parent = fundo;
			tiro.Top =  top + 75;
			tiro.Left = left;
			this.tiros ++;
		}
	}
}
