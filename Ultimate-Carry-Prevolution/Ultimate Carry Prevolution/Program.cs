using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;
using SharpDX.Direct3D9;
using Color = System.Drawing.Color;

namespace Ultimate_Carry_Prevolution
{
	class Program
	{

		static void Main(string[] args)
		{
			Events.Game.OnGameStart += OnGameStart;
			
			Game.OnWndProc += Game_OnWndProc;
			Drawing.OnDraw += Draw_Credits;
			Drawing.OnPreReset += DrawOnPreReset;
			Drawing.OnPostReset += DrawOnPostReset;
			
		}

		private static void Game_OnWndProc(WndEventArgs args)
		{

		}
		private static void OnDomainUnload(object sender, EventArgs e)
		{
		}

		private static void DrawOnPostReset(EventArgs args)
		{
		}

		private static void DrawOnPreReset(EventArgs args)
		{
		}
		private static void Draw_Credits(EventArgs args)
		{
			Drawing.DrawText(10, 10, Color.White, "Ultimate Carry Prevolution");
			Drawing.DrawText(10, 30, Color.White, "Coded and Developed by");
			Drawing.DrawText(10, 50, Color.White, "Lexxes & xSalice");
		}

		private static void OnGameStart(EventArgs args)
		{
			try
			{
				Game.OnWndProc -= Game_OnWndProc;
				Drawing.OnDraw -= Draw_Credits;
				Drawing.OnDraw -= Draw_Credits;
				Drawing.OnPreReset -= DrawOnPreReset;
				Drawing.OnPostReset -= DrawOnPostReset;
				AppDomain.CurrentDomain.DomainUnload -= OnDomainUnload;
				AppDomain.CurrentDomain.ProcessExit -= OnDomainUnload;

			}
			catch(Exception)
			{

			}
			LoadUC();
		}

		private static void LoadUC()
		{
			new Loader();
		}
	}
}
