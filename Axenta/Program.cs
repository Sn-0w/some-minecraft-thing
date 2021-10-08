using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Colorful;
using Console = Colorful.Console;

namespace Axenta
{
	// Token: 0x0200000B RID: 11
	public static class Program
	{
		// Token: 0x06000045 RID: 69
		[DllImport("kernel32.dll")]
		private static extern IntPtr GetConsoleWindow();

		// Token: 0x06000046 RID: 70
		[DllImport("user32.dll")]
		private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		// Token: 0x06000047 RID: 71
		[DllImport("user32.dll", SetLastError = true)]
		private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		// Token: 0x06000048 RID: 72
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool AllocConsole();

		// Token: 0x06000049 RID: 73
		[DllImport("user32.dll")]
		public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

		// Token: 0x0600004A RID: 74
		[DllImport("user32.dll")]
		private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

		// Token: 0x0600004B RID: 75 RVA: 0x00163D48 File Offset: 0x0015EF48
		private static void printLogo()
		{
			string text = "MMMMMMMMMMMMMMMMMoMNMMMMNNMMMMMMMMMMMMMMMMMMMMMMMM";
			string text2 = "MMMMMMMMMMMMMMMMNh+dMMMNssmMMMmohNMMMMMMMMMMMMMMMM";
			string text3 = "MMMMMMMMMMMMMMmo.`hMMMms++smMMMd..omMMMMMMMMMMMMMM";
			string text4 = "MMMMMMMMMMMNh:``:dMmNms++++smNmMd:``:hNMMMMMMMMMMM";
			string text5 = "MMMMMMMNMmo. .omNhsdms++++++smdshNmo. .omMMMMMMMMM";
			string text6 = "MMMMMMNy:``/hNdsosdmo++++++++omdsosdNh/``:yNMMMMMM";
			string text7 = "MMMMd+` .smmyoshNMmo++++++++++omMNhsoymms- `/dMMMM";
			string text8 = "MNs- `/hmhooymMMMmo+++++oo+++++omMMMmyoohmh/` -sNM";
			string text9 = "Mm. -mNsoymNMMMMmo+++++ommo+++++omMMMMNdsoyNm: .dM";
			string text10 = "MMs `hMh+hMMMMMmo+++++omMMmo+++++omMMMMMh+hMd` sMM";
			string text11 = "MMN: :NNsomMMMdo+++++omMMMMmo+++++omMMMmosNN: :NMM";
			string text12 = "MMMh` sMdosNMdo+++++omMMMMMMmo+++++omMNsomMs``hMMM";
			string text13 = "MMMN+ .mMyomdo+++++smMMMMMMMMms+++++odmohMm. +NMMM";
			string text14 = "MMMMm. yMNmdo+++++smNhhhhhhhhhs++++++odmNMy .mMMMM";
			string text15 = "MMMMMs/NMMdo+++++smMdo++++++++++++++++odMMN/sMMMMM";
			string text16 = "MMMMMMNMMdo+++++smMMdo+++++++++++++++++odMMMMMMMMM";
			string text17 = "MMMMMMMMdoooooosNMMMmoooooooooooooooooooodMMMMMMMM";
			string text18 = "MMMMMMMMMNNNNddNMMMMMNNNNNNNNNNNNNNddNNNNNMMMMMMMM";
			string text19 = "MMMMMMMMMMMMNyossssssssssssssssssssoyMMMMMMMMMMMMM";
			string text20 = "MMMMMMMMMMMMMNmmmmmmmmmmmmmmmmmmmmmmNMMMMMMMMMMMMM";
			Console.WriteLine("");
			Console.WriteLine(string.Format("{0," + (Console.WindowWidth / 2 + text.Length / 2).ToString() + "}", text));
			Console.WriteLine(string.Format("{0," + (Console.WindowWidth / 2 + text2.Length / 2).ToString() + "}", text2));
			Console.WriteLine(string.Format("{0," + (Console.WindowWidth / 2 + text3.Length / 2).ToString() + "}", text3));
			Console.WriteLine(string.Format("{0," + (Console.WindowWidth / 2 + text4.Length / 2).ToString() + "}", text4));
			Console.WriteLine(string.Format("{0," + (Console.WindowWidth / 2 + text5.Length / 2).ToString() + "}", text5));
			Console.WriteLine(string.Format("{0," + (Console.WindowWidth / 2 + text6.Length / 2).ToString() + "}", text6));
			Console.WriteLine(string.Format("{0," + (Console.WindowWidth / 2 + text7.Length / 2).ToString() + "}", text7));
			Console.WriteLine(string.Format("{0," + (Console.WindowWidth / 2 + text8.Length / 2).ToString() + "}", text8));
			Console.WriteLine(string.Format("{0," + (Console.WindowWidth / 2 + text9.Length / 2).ToString() + "}", text9));
			Console.WriteLine(string.Format("{0," + (Console.WindowWidth / 2 + text10.Length / 2).ToString() + "}", text10));
			Console.WriteLine(string.Format("{0," + (Console.WindowWidth / 2 + text11.Length / 2).ToString() + "}", text11));
			Console.WriteLine(string.Format("{0," + (Console.WindowWidth / 2 + text12.Length / 2).ToString() + "}", text12));
			Console.WriteLine(string.Format("{0," + (Console.WindowWidth / 2 + text13.Length / 2).ToString() + "}", text13));
			Console.WriteLine(string.Format("{0," + (Console.WindowWidth / 2 + text14.Length / 2).ToString() + "}", text14));
			Console.WriteLine(string.Format("{0," + (Console.WindowWidth / 2 + text15.Length / 2).ToString() + "}", text15));
			Console.WriteLine(string.Format("{0," + (Console.WindowWidth / 2 + text16.Length / 2).ToString() + "}", text16));
			Console.WriteLine(string.Format("{0," + (Console.WindowWidth / 2 + text17.Length / 2).ToString() + "}", text17));
			Console.WriteLine(string.Format("{0," + (Console.WindowWidth / 2 + text18.Length / 2).ToString() + "}", text18));
			Console.WriteLine(string.Format("{0," + (Console.WindowWidth / 2 + text19.Length / 2).ToString() + "}", text19));
			Console.WriteLine(string.Format("{0," + (Console.WindowWidth / 2 + text20.Length / 2).ToString() + "}", text20));
			Console.WriteLine("");
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00164210 File Offset: 0x0015F410
		private static string randomName()
		{
			string text = "";
			for (int i = 0; i <= Program.random.Next(5, 32); i++)
			{
				int num = Program.random.Next(1, 10);
				text += Program.chars[num].ToString();
			}
			return text;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00164270 File Offset: 0x0015F470
		private static void drawTextProgressBar(int progress, int total)
		{
			Console.CursorLeft = 23;
			Console.CursorLeft = 55;
			Console.CursorLeft = 1;
			float num = 31f / (float)total;
			int num2 = 24;
			int num3 = 0;
			while ((float)num3 < num * (float)progress)
			{
				Console.BackgroundColor = Color.FromArgb(82, 120, 252);
				Console.CursorLeft = num2++;
				Console.Write(" ");
				num3++;
			}
			for (int i = num2; i <= 54; i++)
			{
				Console.BackgroundColor = Color.Gray;
				Console.CursorLeft = num2++;
				Console.Write(" ");
			}
			Console.CursorLeft = 58;
			Console.BackgroundColor = Color.FromName("Gainsboro");
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00164318 File Offset: 0x0015F518
		[STAThread]
		private static void Main()
		{
			Costura.AssemblyLoader.Attach();
			Console.Title = Program.randomName();
			Program.AllocConsole();
			Console.BackgroundColor = Color.FromName("Gainsboro");
			Console.CursorVisible = false;
			IntPtr consoleWindow = Program.GetConsoleWindow();
			IntPtr systemMenu = Program.GetSystemMenu(consoleWindow, false);
			Program.DeleteMenu(systemMenu, 61488, 0);
			Program.DeleteMenu(systemMenu, 61440, 0);
			Console.SetWindowSize(80, 25);
			Console.SetBufferSize(80, 25);
			Console.ForegroundColor = Color.FromArgb(82, 141, 252);
			Program.printLogo();
			string text = "Initializing...";
			Console.WriteLine(string.Format("{0," + (Console.WindowWidth / 2 + (text.Length + 1) / 2).ToString() + "}", text));
			Console.WriteLine("");
			for (int i = 0; i < 241; i++)
			{
				Program.drawTextProgressBar(i, 240);
				if (i == 150)
				{
					Program.mcHWND = Program.FindWindow("LWJGL", null);
				}
			}
			if (Program.mcHWND.ToString() == "0")
			{
				MessageBox.Show("Minecraft Not Found");
				Environment.Exit(12);
			}
			Console.BackgroundColor = Color.FromArgb(220, 220, 220);
			Program.ShowWindow(Program.GetConsoleWindow(), 0);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(true);
			Application.Run(new Form1());
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00164488 File Offset: 0x0015F688
		// Note: this type is marked as 'beforefieldinit'.
		static Program()
		{
		}

		// Token: 0x0400007E RID: 126
		public const int SC_MAXIMIZE = 61488;

		// Token: 0x0400007F RID: 127
		public const int SC_SIZE = 61440;

		// Token: 0x04000080 RID: 128
		private const int MF_BYCOMMAND = 0;

		// Token: 0x04000081 RID: 129
		private static Random random = new Random();

		// Token: 0x04000082 RID: 130
		private static char[] chars = "小麼心多天而能好都然".ToCharArray();

		// Token: 0x04000083 RID: 131
		private static IntPtr mcHWND;
	}
}
