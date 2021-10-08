using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Axenta.Modules;
using Axenta.Modules.Combat;
using Axenta.Modules.Visuals;
using Axenta.Properties;
using ColorSlider;
using ToggleButton;

namespace Axenta
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000003 RID: 3
		[DllImport("user32.dll")]
		private static extern short GetAsyncKeyState(Keys vKey);

		// Token: 0x06000004 RID: 4
		[DllImport("user32")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000005 RID: 5
		[DllImport("User32.Dll", EntryPoint = "PostMessageA")]
		private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

		// Token: 0x06000006 RID: 6
		[DllImport("user32.dll", SetLastError = true)]
		private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		// Token: 0x06000007 RID: 7
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

		// Token: 0x06000008 RID: 8
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern int GetWindowTextLength(IntPtr hWnd);

		// Token: 0x06000009 RID: 9 RVA: 0x0015E9CC File Offset: 0x00159BCC
		public Form1()
		{
			this.InitializeComponent();
			this.pnlSidebar.BringToFront();
			this.mcHWND = Form1.FindWindow("LWJGL", null);
			this.pnlSettings.Hide();
			this.pnlVisuals.Hide();
			this.pnlCombat.Location = new Point(35, -14);
			this.pnlCombat.Show();
			this.bgwScan.RunWorkerAsync();
			this.bgwWrite.RunWorkerAsync();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0015EAB4 File Offset: 0x00159CB4
		private void Form1_MouseEnter(object sender, EventArgs e)
		{
			this.sidebarHovered = true;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0015EAC8 File Offset: 0x00159CC8
		private void Form1_MouseLeave(object sender, EventArgs e)
		{
			this.sidebarHovered = false;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0015EADC File Offset: 0x00159CDC
		private void sidebarFix_Tick(object sender, EventArgs e)
		{
			if (this.sidebarHovered)
			{
				if (this.pnlSidebar.Width < this.sidebarOpenWidth)
				{
					this.pnlSidebar.Width += 5;
				}
			}
			else if (this.pnlSidebar.Width > this.sidebarClosedWidth)
			{
				this.pnlSidebar.Width -= 5;
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0015EB48 File Offset: 0x00159D48
		private void MouseMoveVoid(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Form1.ReleaseCapture();
				Form1.PostMessage(base.Handle, 161U, 2, 0);
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0015EB80 File Offset: 0x00159D80
		private void btnCombat_Click(object sender, EventArgs e)
		{
			this.pnlSettings.Hide();
			this.pnlVisuals.Hide();
			this.pnlCombat.Location = new Point(35, -14);
			this.pnlCombat.Show();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0015EBC4 File Offset: 0x00159DC4
		private void sldCPS_Scroll(object sender, ScrollEventArgs e)
		{
			this.lblCPS.Text = "Average CPS: " + this.sldCPS.Value.ToString();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0015EBFC File Offset: 0x00159DFC
		private void btnACBind_Click(object sender, EventArgs e)
		{
			this.btnACBind.Text = "[...]";
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0015EC1C File Offset: 0x00159E1C
		private void btnACBind_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Escape)
			{
				if (this.btnACBind.Text == "[...]")
				{
					this.btnACBind.Text = "[" + e.KeyCode.ToString() + "]";
				}
			}
			else
			{
				this.btnACBind.Text = "[BIND]";
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0015EC90 File Offset: 0x00159E90
		private void tmrBinds_Tick(object sender, EventArgs e)
		{
			string text = this.btnACBind.Text;
			KeysConverter keysConverter = new KeysConverter();
			if (text != "[BIND]" && text != "[...]")
			{
				text = text.Remove(0, 1);
				text = text.Remove(text.Length - 1, 1);
				Keys vKey = (Keys)keysConverter.ConvertFromString(text);
				if (Form1.GetAsyncKeyState(vKey) < 0)
				{
					this.tglAC.IsOn = !this.tglAC.IsOn;
				}
			}
			string text2 = this.btnRBind.Text;
			if (text2 != "[BIND]" && text2 != "[...]")
			{
				text2 = text2.Remove(0, 1);
				text2 = text2.Remove(text2.Length - 1, 1);
				Keys vKey2 = (Keys)keysConverter.ConvertFromString(text2);
				if (Form1.GetAsyncKeyState(vKey2) < 0)
				{
					this.tglReach.IsOn = !this.tglReach.IsOn;
				}
			}
			string text3 = this.btnVeloBind.Text;
			if (text3 != "[BIND]" && text3 != "[...]")
			{
				text3 = text3.Remove(0, 1);
				text3 = text3.Remove(text3.Length - 1, 1);
				Keys vKey3 = (Keys)keysConverter.ConvertFromString(text3);
				if (Form1.GetAsyncKeyState(vKey3) < 0)
				{
					this.tglVelo.IsOn = !this.tglVelo.IsOn;
				}
			}
			string text4 = this.btnNameTagsBind.Text;
			if (text4 != "[BIND]" && text4 != "[...]")
			{
				text4 = text4.Remove(0, 1);
				text4 = text4.Remove(text4.Length - 1, 1);
				Keys vKey4 = (Keys)keysConverter.ConvertFromString(text4);
				if (Form1.GetAsyncKeyState(vKey4) < 0)
				{
					this.tglNametag.IsOn = !this.tglNametag.IsOn;
				}
			}
			string text5 = this.btnNameESPBind.Text;
			if (text5 != "[BIND]" && text5 != "[...]")
			{
				text5 = text5.Remove(0, 1);
				text5 = text5.Remove(text5.Length - 1, 1);
				Keys vKey5 = (Keys)keysConverter.ConvertFromString(text5);
				if (Form1.GetAsyncKeyState(vKey5) < 0)
				{
					this.tglNameESP.IsOn = !this.tglNameESP.IsOn;
				}
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0015EF08 File Offset: 0x0015A108
		private void sldReachMin_Scroll(object sender, ScrollEventArgs e)
		{
			this.lblReachMin.Text = "Min: " + ((float)this.sldReachMin.Value / 100f).ToString("F");
			if (this.sldReachMin.Value > this.sldReachMax.Value)
			{
				this.sldReachMax.Value = this.sldReachMin.Value;
				this.lblReachMax.Text = "Max: " + ((float)this.sldReachMax.Value / 100f).ToString("F");
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0015EFBC File Offset: 0x0015A1BC
		private void sldReachMax_Scroll(object sender, ScrollEventArgs e)
		{
			this.lblReachMax.Text = "Min: " + ((float)this.sldReachMax.Value / 100f).ToString("F");
			if (this.sldReachMin.Value > this.sldReachMax.Value)
			{
				this.sldReachMin.Value = this.sldReachMax.Value;
				this.lblReachMin.Text = "Min: " + ((float)this.sldReachMin.Value / 100f).ToString("F");
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0015F070 File Offset: 0x0015A270
		private void sldVeloMin_Scroll(object sender, ScrollEventArgs e)
		{
			this.lblVeloMin.Text = "Min: " + this.sldVeloMin.Value.ToString();
			if (this.sldVeloMin.Value > this.sldVeloMax.Value)
			{
				this.sldVeloMax.Value = this.sldVeloMin.Value;
				this.lblVeloMax.Text = "Max: " + this.sldVeloMax.Value.ToString();
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0015F100 File Offset: 0x0015A300
		private void sldVeloMax_Scroll(object sender, ScrollEventArgs e)
		{
			this.lblVeloMax.Text = "Max: " + this.sldVeloMax.Value.ToString();
			if (this.sldVeloMin.Value > this.sldVeloMax.Value)
			{
				this.sldVeloMin.Value = this.sldVeloMax.Value;
				this.lblVeloMin.Text = "Min: " + this.sldVeloMin.Value.ToString();
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0015F190 File Offset: 0x0015A390
		private void sldNMultiplier_Scroll(object sender, ScrollEventArgs e)
		{
			this.lblMultiplier.Text = "Multiplier: " + ((float)(this.sldNMultiplier.Value / 10m)).ToString();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0015F1D8 File Offset: 0x0015A3D8
		private void btnVisuals_Click(object sender, EventArgs e)
		{
			this.pnlSettings.Hide();
			this.pnlCombat.Hide();
			this.pnlVisuals.Location = new Point(35, -14);
			this.pnlVisuals.Show();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0015F21C File Offset: 0x0015A41C
		private void btnSettings_Click(object sender, EventArgs e)
		{
			this.pnlVisuals.Hide();
			this.pnlCombat.Hide();
			this.pnlSettings.Location = new Point(35, -14);
			this.pnlSettings.Show();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0015F260 File Offset: 0x0015A460
		private void btnExit_Click(object sender, EventArgs e)
		{
			this.isDestrucing = true;
			this.bgwDestruct.RunWorkerAsync();
			base.Hide();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0015F288 File Offset: 0x0015A488
		
		private void bgwScan_DoWork(object sender, DoWorkEventArgs e)
		{
			Form1.<bgwScan_DoWork>d__35 <bgwScan_DoWork>d__ = new Form1.<bgwScan_DoWork>d__35();
			<bgwScan_DoWork>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<bgwScan_DoWork>d__.<>4__this = this;
			<bgwScan_DoWork>d__.sender = sender;
			<bgwScan_DoWork>d__.e = e;
			<bgwScan_DoWork>d__.<>1__state = -1;
			<bgwScan_DoWork>d__.<>t__builder.Start<Form1.<bgwScan_DoWork>d__35>(ref <bgwScan_DoWork>d__);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0015F2D0 File Offset: 0x0015A4D0
		
		private void bgwScan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			Form1.<bgwScan_RunWorkerCompleted>d__36 <bgwScan_RunWorkerCompleted>d__ = new Form1.<bgwScan_RunWorkerCompleted>d__36();
			<bgwScan_RunWorkerCompleted>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<bgwScan_RunWorkerCompleted>d__.<>4__this = this;
			<bgwScan_RunWorkerCompleted>d__.sender = sender;
			<bgwScan_RunWorkerCompleted>d__.e = e;
			<bgwScan_RunWorkerCompleted>d__.<>1__state = -1;
			<bgwScan_RunWorkerCompleted>d__.<>t__builder.Start<Form1.<bgwScan_RunWorkerCompleted>d__36>(ref <bgwScan_RunWorkerCompleted>d__);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0015F318 File Offset: 0x0015A518
		
		private void bgwWrite_DoWork(object sender, DoWorkEventArgs e)
		{
			Form1.<bgwWrite_DoWork>d__37 <bgwWrite_DoWork>d__ = new Form1.<bgwWrite_DoWork>d__37();
			<bgwWrite_DoWork>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<bgwWrite_DoWork>d__.<>4__this = this;
			<bgwWrite_DoWork>d__.sender = sender;
			<bgwWrite_DoWork>d__.e = e;
			<bgwWrite_DoWork>d__.<>1__state = -1;
			<bgwWrite_DoWork>d__.<>t__builder.Start<Form1.<bgwWrite_DoWork>d__37>(ref <bgwWrite_DoWork>d__);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0015F360 File Offset: 0x0015A560
		
		private void bgwWrite_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			Form1.<bgwWrite_RunWorkerCompleted>d__38 <bgwWrite_RunWorkerCompleted>d__ = new Form1.<bgwWrite_RunWorkerCompleted>d__38();
			<bgwWrite_RunWorkerCompleted>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<bgwWrite_RunWorkerCompleted>d__.<>4__this = this;
			<bgwWrite_RunWorkerCompleted>d__.sender = sender;
			<bgwWrite_RunWorkerCompleted>d__.e = e;
			<bgwWrite_RunWorkerCompleted>d__.<>1__state = -1;
			<bgwWrite_RunWorkerCompleted>d__.<>t__builder.Start<Form1.<bgwWrite_RunWorkerCompleted>d__38>(ref <bgwWrite_RunWorkerCompleted>d__);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0015F3A8 File Offset: 0x0015A5A8
		
		private void tmrAC_Tick(object sender, EventArgs e)
		{
			Form1.<tmrAC_Tick>d__46 <tmrAC_Tick>d__ = new Form1.<tmrAC_Tick>d__46();
			<tmrAC_Tick>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<tmrAC_Tick>d__.<>4__this = this;
			<tmrAC_Tick>d__.sender = sender;
			<tmrAC_Tick>d__.e = e;
			<tmrAC_Tick>d__.<>1__state = -1;
			<tmrAC_Tick>d__.<>t__builder.Start<Form1.<tmrAC_Tick>d__46>(ref <tmrAC_Tick>d__);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0015F3F0 File Offset: 0x0015A5F0
		
		private void bgwDestruct_DoWork(object sender, DoWorkEventArgs e)
		{
			Form1.<bgwDestruct_DoWork>d__48 <bgwDestruct_DoWork>d__ = new Form1.<bgwDestruct_DoWork>d__48();
			<bgwDestruct_DoWork>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<bgwDestruct_DoWork>d__.<>4__this = this;
			<bgwDestruct_DoWork>d__.sender = sender;
			<bgwDestruct_DoWork>d__.e = e;
			<bgwDestruct_DoWork>d__.<>1__state = -1;
			<bgwDestruct_DoWork>d__.<>t__builder.Start<Form1.<bgwDestruct_DoWork>d__48>(ref <bgwDestruct_DoWork>d__);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0015F438 File Offset: 0x0015A638
		private void btnRBind_Click(object sender, EventArgs e)
		{
			this.btnRBind.Text = "[...]";
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0015F458 File Offset: 0x0015A658
		private void btnRBind_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Escape)
			{
				if (this.btnRBind.Text == "[...]")
				{
					this.btnRBind.Text = "[" + e.KeyCode.ToString() + "]";
				}
			}
			else
			{
				this.btnRBind.Text = "[BIND]";
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0015F4CC File Offset: 0x0015A6CC
		private void btnVeloBind_Click(object sender, EventArgs e)
		{
			this.btnVeloBind.Text = "[...]";
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0015F4EC File Offset: 0x0015A6EC
		private void btnVeloBind_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Escape)
			{
				if (this.btnVeloBind.Text == "[...]")
				{
					this.btnVeloBind.Text = "[" + e.KeyCode.ToString() + "]";
				}
			}
			else
			{
				this.btnVeloBind.Text = "[BIND]";
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0015F560 File Offset: 0x0015A760
		private void btnNameTagsBind_Click(object sender, EventArgs e)
		{
			this.btnNameTagsBind.Text = "[...]";
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0015F580 File Offset: 0x0015A780
		private void btnNameTagsBind_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Escape)
			{
				if (this.btnNameTagsBind.Text == "[...]")
				{
					this.btnNameTagsBind.Text = "[" + e.KeyCode.ToString() + "]";
				}
			}
			else
			{
				this.btnNameTagsBind.Text = "[BIND]";
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0015F5F4 File Offset: 0x0015A7F4
		private void btnNameESPBind_Click(object sender, EventArgs e)
		{
			this.btnNameESPBind.Text = "[...]";
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0015F614 File Offset: 0x0015A814
		private void btnNameESPBind_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Escape)
			{
				if (this.btnNameESPBind.Text == "[...]")
				{
					this.btnNameESPBind.Text = "[" + e.KeyCode.ToString() + "]";
				}
			}
			else
			{
				this.btnNameESPBind.Text = "[BIND]";
			}
		}

		// Token: 0x04000001 RID: 1
		public Random rnd = new Random();

		// Token: 0x04000002 RID: 2
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000003 RID: 3
		public const int HT_CAPTION = 2;

		// Token: 0x04000004 RID: 4
		private bool sidebarHovered = false;

		// Token: 0x04000005 RID: 5
		private int sidebarClosedWidth = 45;

		// Token: 0x04000006 RID: 6
		private int sidebarOpenWidth = 135;

		// Token: 0x04000007 RID: 7
		private bool isDestrucing = false;

		// Token: 0x04000008 RID: 8
		private IntPtr mcHWND;

		// Token: 0x04000009 RID: 9
		private Nametags namets = new Nametags();

		// Token: 0x0400000A RID: 10
		private Reach reach = new Reach();

		// Token: 0x0400000B RID: 11
		private Velocity velo = new Velocity();

		// Token: 0x0400000C RID: 12
		private bool shifting = false;

		// Token: 0x0400000D RID: 13
		private bool rmb;

		// Token: 0x0400000E RID: 14
		private bool inv;

		// Token: 0x0400000F RID: 15
		public const int WM_LBUTTONDOWN = 513;

		// Token: 0x04000010 RID: 16
		public const int WM_LBUTTONUP = 514;

		// Token: 0x04000011 RID: 17
		public const int WM_RBUTTONDOWN = 516;

		// Token: 0x04000012 RID: 18
		public const int WM_RBUTTONUP = 517;

		// Token: 0x04000013 RID: 19
		private Destruct Des = new Destruct();
	}
}
