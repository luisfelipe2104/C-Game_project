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
			
			pictureBox1.Visible = false;
			pictureBox2.Visible = false;
		}
		void Button2Click(object sender, EventArgs e)
		{
			button2.Visible = false;
			pictureBox1.Visible = true;
			pictureBox2.Visible = true;
			pictureBox2.Parent = pictureBox1;
		}
		
	}
}
