namespace Axenta
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000029 RID: 41 RVA: 0x0015F688 File Offset: 0x0015A888
		protected override void Dispose(bool disposing)
		{
			if (((!disposing) ? -1013212808 : ((this.components != null) ? 1 : 0)) != 0)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0015F6BC File Offset: 0x0015A8BC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Axenta.Form1));
			this.pnlSidebar = new global::System.Windows.Forms.Panel();
			this.btnSettings = new global::System.Windows.Forms.Button();
			this.btnExit = new global::System.Windows.Forms.Button();
			this.btnVisuals = new global::System.Windows.Forms.Button();
			this.btnCombat = new global::System.Windows.Forms.Button();
			this.sidebarFix = new global::System.Windows.Forms.Timer(this.components);
			this.pnlCombat = new global::System.Windows.Forms.Panel();
			this.pnlVelocity = new global::System.Windows.Forms.Panel();
			this.lblVeloMax = new global::System.Windows.Forms.Label();
			this.sldVeloMax = new global::ColorSlider.ColorSlider();
			this.lblVeloMin = new global::System.Windows.Forms.Label();
			this.tglVelo = new global::ToggleButton.toggleswitch();
			this.sldVeloMin = new global::ColorSlider.ColorSlider();
			this.btnVeloBind = new global::System.Windows.Forms.Button();
			this.lblVelocity = new global::System.Windows.Forms.Label();
			this.pnlReach = new global::System.Windows.Forms.Panel();
			this.lblReachMax = new global::System.Windows.Forms.Label();
			this.sldReachMax = new global::ColorSlider.ColorSlider();
			this.lblReachMin = new global::System.Windows.Forms.Label();
			this.tglReach = new global::ToggleButton.toggleswitch();
			this.lblReach = new global::System.Windows.Forms.Label();
			this.sldReachMin = new global::ColorSlider.ColorSlider();
			this.btnRBind = new global::System.Windows.Forms.Button();
			this.pnlAC = new global::System.Windows.Forms.Panel();
			this.cbSmartMode = new global::System.Windows.Forms.CheckBox();
			this.cbRMBLock = new global::System.Windows.Forms.CheckBox();
			this.cbShiftDisable = new global::System.Windows.Forms.CheckBox();
			this.lblCPS = new global::System.Windows.Forms.Label();
			this.tglAC = new global::ToggleButton.toggleswitch();
			this.label1 = new global::System.Windows.Forms.Label();
			this.sldCPS = new global::ColorSlider.ColorSlider();
			this.btnACBind = new global::System.Windows.Forms.Button();
			this.tmrBinds = new global::System.Windows.Forms.Timer(this.components);
			this.pnlVisuals = new global::System.Windows.Forms.Panel();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.tglNameESP = new global::ToggleButton.toggleswitch();
			this.lblNameESP = new global::System.Windows.Forms.Label();
			this.btnNameESPBind = new global::System.Windows.Forms.Button();
			this.pnlNametags = new global::System.Windows.Forms.Panel();
			this.lblMultiplier = new global::System.Windows.Forms.Label();
			this.tglNametag = new global::ToggleButton.toggleswitch();
			this.label9 = new global::System.Windows.Forms.Label();
			this.sldNMultiplier = new global::ColorSlider.ColorSlider();
			this.btnNameTagsBind = new global::System.Windows.Forms.Button();
			this.bgwScan = new global::System.ComponentModel.BackgroundWorker();
			this.bgwWrite = new global::System.ComponentModel.BackgroundWorker();
			this.tmrAC = new global::System.Windows.Forms.Timer(this.components);
			this.pnlSettings = new global::System.Windows.Forms.Panel();
			this.pnlUISet = new global::System.Windows.Forms.Panel();
			this.lblUISets = new global::System.Windows.Forms.Label();
			this.pnlDestruct = new global::System.Windows.Forms.Panel();
			this.cbUSN = new global::System.Windows.Forms.CheckBox();
			this.cbClearStrings = new global::System.Windows.Forms.CheckBox();
			this.cbPrefetch = new global::System.Windows.Forms.CheckBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.bgwDestruct = new global::System.ComponentModel.BackgroundWorker();
			this.pnlSidebar.SuspendLayout();
			this.pnlCombat.SuspendLayout();
			this.pnlVelocity.SuspendLayout();
			this.pnlReach.SuspendLayout();
			this.pnlAC.SuspendLayout();
			this.pnlVisuals.SuspendLayout();
			this.panel4.SuspendLayout();
			this.pnlNametags.SuspendLayout();
			this.pnlSettings.SuspendLayout();
			this.pnlUISet.SuspendLayout();
			this.pnlDestruct.SuspendLayout();
			base.SuspendLayout();
			this.pnlSidebar.BackColor = global::System.Drawing.Color.FromArgb(200, 200, 200);
			this.pnlSidebar.Controls.Add(this.btnSettings);
			this.pnlSidebar.Controls.Add(this.btnExit);
			this.pnlSidebar.Controls.Add(this.btnVisuals);
			this.pnlSidebar.Controls.Add(this.btnCombat);
			this.pnlSidebar.Location = new global::System.Drawing.Point(-9, -14);
			this.pnlSidebar.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pnlSidebar.Name = "pnlSidebar";
			this.pnlSidebar.Size = new global::System.Drawing.Size(45, 820);
			this.pnlSidebar.TabIndex = 0;
			this.pnlSidebar.MouseEnter += new global::System.EventHandler(this.Form1_MouseEnter);
			this.pnlSidebar.MouseLeave += new global::System.EventHandler(this.Form1_MouseLeave);
			this.btnSettings.BackColor = global::System.Drawing.Color.Transparent;
			this.btnSettings.FlatAppearance.BorderSize = 0;
			this.btnSettings.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.btnSettings.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.btnSettings.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnSettings.Font = new global::System.Drawing.Font("Trebuchet MS", 12.5f, global::System.Drawing.FontStyle.Bold);
			this.btnSettings.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.btnSettings.Image = global::Axenta.Properties.Resources.settings_28px;
			this.btnSettings.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSettings.Location = new global::System.Drawing.Point(8, 103);
			this.btnSettings.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.btnSettings.Size = new global::System.Drawing.Size(118, 35);
			this.btnSettings.TabIndex = 4;
			this.btnSettings.TabStop = false;
			this.btnSettings.Text = "       Settings";
			this.btnSettings.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSettings.UseVisualStyleBackColor = false;
			this.btnSettings.Click += new global::System.EventHandler(this.btnSettings_Click);
			this.btnSettings.MouseEnter += new global::System.EventHandler(this.Form1_MouseEnter);
			this.btnExit.BackColor = global::System.Drawing.Color.Transparent;
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.btnExit.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.btnExit.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new global::System.Drawing.Font("Trebuchet MS", 12.5f, global::System.Drawing.FontStyle.Bold);
			this.btnExit.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.btnExit.Image = global::Axenta.Properties.Resources.cancel_28px;
			this.btnExit.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExit.Location = new global::System.Drawing.Point(8, 480);
			this.btnExit.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnExit.Name = "btnExit";
			this.btnExit.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.btnExit.Size = new global::System.Drawing.Size(118, 35);
			this.btnExit.TabIndex = 3;
			this.btnExit.TabStop = false;
			this.btnExit.Text = "       Destruct";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new global::System.EventHandler(this.btnExit_Click);
			this.btnExit.MouseEnter += new global::System.EventHandler(this.Form1_MouseEnter);
			this.btnVisuals.BackColor = global::System.Drawing.Color.Transparent;
			this.btnVisuals.FlatAppearance.BorderSize = 0;
			this.btnVisuals.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.btnVisuals.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.btnVisuals.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnVisuals.Font = new global::System.Drawing.Font("Trebuchet MS", 12.5f, global::System.Drawing.FontStyle.Bold);
			this.btnVisuals.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.btnVisuals.Image = global::Axenta.Properties.Resources.eye_32px1;
			this.btnVisuals.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnVisuals.Location = new global::System.Drawing.Point(8, 65);
			this.btnVisuals.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnVisuals.Name = "btnVisuals";
			this.btnVisuals.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.btnVisuals.Size = new global::System.Drawing.Size(110, 35);
			this.btnVisuals.TabIndex = 2;
			this.btnVisuals.TabStop = false;
			this.btnVisuals.Text = "       Visuals";
			this.btnVisuals.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnVisuals.UseVisualStyleBackColor = false;
			this.btnVisuals.Click += new global::System.EventHandler(this.btnVisuals_Click);
			this.btnVisuals.MouseEnter += new global::System.EventHandler(this.Form1_MouseEnter);
			this.btnCombat.BackColor = global::System.Drawing.Color.Transparent;
			this.btnCombat.FlatAppearance.BorderSize = 0;
			this.btnCombat.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.btnCombat.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.btnCombat.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCombat.Font = new global::System.Drawing.Font("Trebuchet MS", 12.5f, global::System.Drawing.FontStyle.Bold);
			this.btnCombat.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.btnCombat.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnCombat.Image");
			this.btnCombat.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCombat.Location = new global::System.Drawing.Point(8, 28);
			this.btnCombat.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCombat.Name = "btnCombat";
			this.btnCombat.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.btnCombat.Size = new global::System.Drawing.Size(110, 37);
			this.btnCombat.TabIndex = 1;
			this.btnCombat.TabStop = false;
			this.btnCombat.Text = "      Combat";
			this.btnCombat.UseVisualStyleBackColor = false;
			this.btnCombat.Click += new global::System.EventHandler(this.btnCombat_Click);
			this.btnCombat.MouseEnter += new global::System.EventHandler(this.Form1_MouseEnter);
			this.sidebarFix.Enabled = true;
			this.sidebarFix.Interval = 1;
			this.sidebarFix.Tick += new global::System.EventHandler(this.sidebarFix_Tick);
			this.pnlCombat.BackColor = global::System.Drawing.Color.FromArgb(231, 231, 231);
			this.pnlCombat.Controls.Add(this.pnlVelocity);
			this.pnlCombat.Controls.Add(this.pnlReach);
			this.pnlCombat.Controls.Add(this.pnlAC);
			this.pnlCombat.Location = new global::System.Drawing.Point(70, 51);
			this.pnlCombat.Name = "pnlCombat";
			this.pnlCombat.Size = new global::System.Drawing.Size(500, 549);
			this.pnlCombat.TabIndex = 1;
			this.pnlCombat.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.MouseMoveVoid);
			this.pnlVelocity.AccessibleName = "";
			this.pnlVelocity.BackColor = global::System.Drawing.Color.Gainsboro;
			this.pnlVelocity.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlVelocity.Controls.Add(this.lblVeloMax);
			this.pnlVelocity.Controls.Add(this.sldVeloMax);
			this.pnlVelocity.Controls.Add(this.lblVeloMin);
			this.pnlVelocity.Controls.Add(this.tglVelo);
			this.pnlVelocity.Controls.Add(this.sldVeloMin);
			this.pnlVelocity.Controls.Add(this.btnVeloBind);
			this.pnlVelocity.Controls.Add(this.lblVelocity);
			this.pnlVelocity.Location = new global::System.Drawing.Point(16, 272);
			this.pnlVelocity.Name = "pnlVelocity";
			this.pnlVelocity.Size = new global::System.Drawing.Size(224, 233);
			this.pnlVelocity.TabIndex = 3;
			this.pnlVelocity.Visible = false;
			this.lblVeloMax.AutoSize = true;
			this.lblVeloMax.Font = new global::System.Drawing.Font("Trebuchet MS", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblVeloMax.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.lblVeloMax.Location = new global::System.Drawing.Point(10, 89);
			this.lblVeloMax.Name = "lblVeloMax";
			this.lblVeloMax.Size = new global::System.Drawing.Size(65, 18);
			this.lblVeloMax.TabIndex = 6;
			this.lblVeloMax.Text = "Max: 100";
			this.sldVeloMax.BackColor = global::System.Drawing.Color.Transparent;
			this.sldVeloMax.BarInnerColor = global::System.Drawing.Color.FromArgb(200, 200, 200);
			this.sldVeloMax.BarPenColorBottom = global::System.Drawing.Color.FromArgb(200, 200, 200);
			this.sldVeloMax.BarPenColorTop = global::System.Drawing.Color.FromArgb(200, 200, 200);
			this.sldVeloMax.BorderRoundRectSize = new global::System.Drawing.Size(7, 7);
			this.sldVeloMax.ElapsedInnerColor = global::System.Drawing.Color.FromArgb(2, 130, 255);
			this.sldVeloMax.ElapsedPenColorBottom = global::System.Drawing.Color.FromArgb(2, 130, 255);
			this.sldVeloMax.ElapsedPenColorTop = global::System.Drawing.Color.FromArgb(2, 130, 255);
			this.sldVeloMax.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6f);
			this.sldVeloMax.ForeColor = global::System.Drawing.Color.White;
			global::ColorSlider.ColorSlider colorSlider = this.sldVeloMax;
			int[] array = new int[4];
			array[0] = 1;
			colorSlider.LargeChange = new decimal(array);
			this.sldVeloMax.Location = new global::System.Drawing.Point(13, 94);
			global::ColorSlider.ColorSlider colorSlider2 = this.sldVeloMax;
			int[] array2 = new int[4];
			array2[0] = 100;
			colorSlider2.Maximum = new decimal(array2);
			global::ColorSlider.ColorSlider colorSlider3 = this.sldVeloMax;
			int[] array3 = new int[4];
			array3[0] = 1;
			colorSlider3.Minimum = new decimal(array3);
			this.sldVeloMax.Name = "sldVeloMax";
			global::ColorSlider.ColorSlider colorSlider4 = this.sldVeloMax;
			int[] array4 = new int[4];
			array4[0] = 10;
			colorSlider4.ScaleDivisions = new decimal(array4);
			global::ColorSlider.ColorSlider colorSlider5 = this.sldVeloMax;
			int[] array5 = new int[4];
			array5[0] = 5;
			colorSlider5.ScaleSubDivisions = new decimal(array5);
			this.sldVeloMax.ShowDivisionsText = true;
			this.sldVeloMax.ShowSmallScale = false;
			this.sldVeloMax.Size = new global::System.Drawing.Size(200, 48);
			global::ColorSlider.ColorSlider colorSlider6 = this.sldVeloMax;
			int[] array6 = new int[4];
			array6[0] = 1;
			colorSlider6.SmallChange = new decimal(array6);
			this.sldVeloMax.TabIndex = 5;
			this.sldVeloMax.ThumbInnerColor = global::System.Drawing.Color.FromArgb(2, 152, 252);
			this.sldVeloMax.ThumbOuterColor = global::System.Drawing.Color.FromArgb(2, 152, 252);
			this.sldVeloMax.ThumbPenColor = global::System.Drawing.Color.FromArgb(2, 130, 252);
			this.sldVeloMax.ThumbRoundRectSize = new global::System.Drawing.Size(15, 15);
			this.sldVeloMax.ThumbSize = new global::System.Drawing.Size(14, 14);
			this.sldVeloMax.TickAdd = 0f;
			this.sldVeloMax.TickColor = global::System.Drawing.Color.White;
			this.sldVeloMax.TickDivide = 0f;
			this.sldVeloMax.TickStyle = global::System.Windows.Forms.TickStyle.None;
			global::ColorSlider.ColorSlider colorSlider7 = this.sldVeloMax;
			int[] array7 = new int[4];
			array7[0] = 100;
			colorSlider7.Value = new decimal(array7);
			this.sldVeloMax.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.sldVeloMax_Scroll);
			this.lblVeloMin.AutoSize = true;
			this.lblVeloMin.Font = new global::System.Drawing.Font("Trebuchet MS", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblVeloMin.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.lblVeloMin.Location = new global::System.Drawing.Point(9, 39);
			this.lblVeloMin.Name = "lblVeloMin";
			this.lblVeloMin.Size = new global::System.Drawing.Size(63, 18);
			this.lblVeloMin.TabIndex = 3;
			this.lblVeloMin.Text = "Min: 100";
			this.tglVelo.BorderColor = global::System.Drawing.Color.LightGray;
			this.tglVelo.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.tglVelo.ForeColor = global::System.Drawing.Color.White;
			this.tglVelo.IsOn = false;
			this.tglVelo.Location = new global::System.Drawing.Point(178, 9);
			this.tglVelo.Name = "tglVelo";
			this.tglVelo.OffColor = global::System.Drawing.Color.DarkGray;
			this.tglVelo.OffText = "";
			this.tglVelo.OnColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.tglVelo.OnText = "";
			this.tglVelo.Size = new global::System.Drawing.Size(34, 19);
			this.tglVelo.TabIndex = 2;
			this.tglVelo.TextEnabled = true;
			this.sldVeloMin.BackColor = global::System.Drawing.Color.Transparent;
			this.sldVeloMin.BarInnerColor = global::System.Drawing.Color.FromArgb(200, 200, 200);
			this.sldVeloMin.BarPenColorBottom = global::System.Drawing.Color.FromArgb(200, 200, 200);
			this.sldVeloMin.BarPenColorTop = global::System.Drawing.Color.FromArgb(200, 200, 200);
			this.sldVeloMin.BorderRoundRectSize = new global::System.Drawing.Size(7, 7);
			this.sldVeloMin.ElapsedInnerColor = global::System.Drawing.Color.FromArgb(2, 130, 255);
			this.sldVeloMin.ElapsedPenColorBottom = global::System.Drawing.Color.FromArgb(2, 130, 255);
			this.sldVeloMin.ElapsedPenColorTop = global::System.Drawing.Color.FromArgb(2, 130, 255);
			this.sldVeloMin.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6f);
			this.sldVeloMin.ForeColor = global::System.Drawing.Color.White;
			global::ColorSlider.ColorSlider colorSlider8 = this.sldVeloMin;
			int[] array8 = new int[4];
			array8[0] = 1;
			colorSlider8.LargeChange = new decimal(array8);
			this.sldVeloMin.Location = new global::System.Drawing.Point(12, 44);
			global::ColorSlider.ColorSlider colorSlider9 = this.sldVeloMin;
			int[] array9 = new int[4];
			array9[0] = 100;
			colorSlider9.Maximum = new decimal(array9);
			global::ColorSlider.ColorSlider colorSlider10 = this.sldVeloMin;
			int[] array10 = new int[4];
			array10[0] = 1;
			colorSlider10.Minimum = new decimal(array10);
			this.sldVeloMin.Name = "sldVeloMin";
			global::ColorSlider.ColorSlider colorSlider11 = this.sldVeloMin;
			int[] array11 = new int[4];
			array11[0] = 10;
			colorSlider11.ScaleDivisions = new decimal(array11);
			global::ColorSlider.ColorSlider colorSlider12 = this.sldVeloMin;
			int[] array12 = new int[4];
			array12[0] = 5;
			colorSlider12.ScaleSubDivisions = new decimal(array12);
			this.sldVeloMin.ShowDivisionsText = true;
			this.sldVeloMin.ShowSmallScale = false;
			this.sldVeloMin.Size = new global::System.Drawing.Size(200, 48);
			global::ColorSlider.ColorSlider colorSlider13 = this.sldVeloMin;
			int[] array13 = new int[4];
			array13[0] = 1;
			colorSlider13.SmallChange = new decimal(array13);
			this.sldVeloMin.TabIndex = 0;
			this.sldVeloMin.ThumbInnerColor = global::System.Drawing.Color.FromArgb(2, 152, 252);
			this.sldVeloMin.ThumbOuterColor = global::System.Drawing.Color.FromArgb(2, 152, 252);
			this.sldVeloMin.ThumbPenColor = global::System.Drawing.Color.FromArgb(2, 130, 252);
			this.sldVeloMin.ThumbRoundRectSize = new global::System.Drawing.Size(15, 15);
			this.sldVeloMin.ThumbSize = new global::System.Drawing.Size(14, 14);
			this.sldVeloMin.TickAdd = 0f;
			this.sldVeloMin.TickColor = global::System.Drawing.Color.White;
			this.sldVeloMin.TickDivide = 0f;
			this.sldVeloMin.TickStyle = global::System.Windows.Forms.TickStyle.None;
			global::ColorSlider.ColorSlider colorSlider14 = this.sldVeloMin;
			int[] array14 = new int[4];
			array14[0] = 100;
			colorSlider14.Value = new decimal(array14);
			this.sldVeloMin.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.sldVeloMin_Scroll);
			this.btnVeloBind.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.btnVeloBind.FlatAppearance.BorderSize = 0;
			this.btnVeloBind.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Gainsboro;
			this.btnVeloBind.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Gainsboro;
			this.btnVeloBind.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnVeloBind.Font = new global::System.Drawing.Font("Trebuchet MS", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnVeloBind.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.btnVeloBind.Location = new global::System.Drawing.Point(75, 5);
			this.btnVeloBind.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnVeloBind.Name = "btnVeloBind";
			this.btnVeloBind.Size = new global::System.Drawing.Size(57, 26);
			this.btnVeloBind.TabIndex = 4;
			this.btnVeloBind.Text = "[BIND]";
			this.btnVeloBind.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnVeloBind.UseVisualStyleBackColor = true;
			this.btnVeloBind.Click += new global::System.EventHandler(this.btnVeloBind_Click);
			this.btnVeloBind.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.btnVeloBind_KeyDown);
			this.lblVelocity.AutoSize = true;
			this.lblVelocity.Font = new global::System.Drawing.Font("Trebuchet MS", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblVelocity.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.lblVelocity.Location = new global::System.Drawing.Point(8, 7);
			this.lblVelocity.Name = "lblVelocity";
			this.lblVelocity.Size = new global::System.Drawing.Size(70, 22);
			this.lblVelocity.TabIndex = 1;
			this.lblVelocity.Text = "Velocity";
			this.pnlReach.AccessibleName = "";
			this.pnlReach.BackColor = global::System.Drawing.Color.Gainsboro;
			this.pnlReach.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlReach.Controls.Add(this.lblReachMax);
			this.pnlReach.Controls.Add(this.sldReachMax);
			this.pnlReach.Controls.Add(this.lblReachMin);
			this.pnlReach.Controls.Add(this.tglReach);
			this.pnlReach.Controls.Add(this.lblReach);
			this.pnlReach.Controls.Add(this.sldReachMin);
			this.pnlReach.Controls.Add(this.btnRBind);
			this.pnlReach.Location = new global::System.Drawing.Point(258, 26);
			this.pnlReach.Name = "pnlReach";
			this.pnlReach.Size = new global::System.Drawing.Size(224, 233);
			this.pnlReach.TabIndex = 2;
			this.lblReachMax.AutoSize = true;
			this.lblReachMax.Font = new global::System.Drawing.Font("Trebuchet MS", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblReachMax.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.lblReachMax.Location = new global::System.Drawing.Point(10, 89);
			this.lblReachMax.Name = "lblReachMax";
			this.lblReachMax.Size = new global::System.Drawing.Size(70, 18);
			this.lblReachMax.TabIndex = 6;
			this.lblReachMax.Text = "Max: 3.00";
			this.sldReachMax.BackColor = global::System.Drawing.Color.Transparent;
			this.sldReachMax.BarInnerColor = global::System.Drawing.Color.FromArgb(200, 200, 200);
			this.sldReachMax.BarPenColorBottom = global::System.Drawing.Color.FromArgb(200, 200, 200);
			this.sldReachMax.BarPenColorTop = global::System.Drawing.Color.FromArgb(200, 200, 200);
			this.sldReachMax.BorderRoundRectSize = new global::System.Drawing.Size(7, 7);
			this.sldReachMax.ElapsedInnerColor = global::System.Drawing.Color.FromArgb(2, 130, 255);
			this.sldReachMax.ElapsedPenColorBottom = global::System.Drawing.Color.FromArgb(2, 130, 255);
			this.sldReachMax.ElapsedPenColorTop = global::System.Drawing.Color.FromArgb(2, 130, 255);
			this.sldReachMax.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6f);
			this.sldReachMax.ForeColor = global::System.Drawing.Color.White;
			global::ColorSlider.ColorSlider colorSlider15 = this.sldReachMax;
			int[] array15 = new int[4];
			array15[0] = 1;
			colorSlider15.LargeChange = new decimal(array15);
			this.sldReachMax.Location = new global::System.Drawing.Point(13, 94);
			global::ColorSlider.ColorSlider colorSlider16 = this.sldReachMax;
			int[] array16 = new int[4];
			array16[0] = 600;
			colorSlider16.Maximum = new decimal(array16);
			global::ColorSlider.ColorSlider colorSlider17 = this.sldReachMax;
			int[] array17 = new int[4];
			array17[0] = 300;
			colorSlider17.Minimum = new decimal(array17);
			this.sldReachMax.Name = "sldReachMax";
			global::ColorSlider.ColorSlider colorSlider18 = this.sldReachMax;
			int[] array18 = new int[4];
			array18[0] = 10;
			colorSlider18.ScaleDivisions = new decimal(array18);
			global::ColorSlider.ColorSlider colorSlider19 = this.sldReachMax;
			int[] array19 = new int[4];
			array19[0] = 5;
			colorSlider19.ScaleSubDivisions = new decimal(array19);
			this.sldReachMax.ShowDivisionsText = true;
			this.sldReachMax.ShowSmallScale = false;
			this.sldReachMax.Size = new global::System.Drawing.Size(200, 48);
			global::ColorSlider.ColorSlider colorSlider20 = this.sldReachMax;
			int[] array20 = new int[4];
			array20[0] = 1;
			colorSlider20.SmallChange = new decimal(array20);
			this.sldReachMax.TabIndex = 5;
			this.sldReachMax.ThumbInnerColor = global::System.Drawing.Color.FromArgb(2, 152, 252);
			this.sldReachMax.ThumbOuterColor = global::System.Drawing.Color.FromArgb(2, 152, 252);
			this.sldReachMax.ThumbPenColor = global::System.Drawing.Color.FromArgb(2, 130, 252);
			this.sldReachMax.ThumbRoundRectSize = new global::System.Drawing.Size(15, 15);
			this.sldReachMax.ThumbSize = new global::System.Drawing.Size(14, 14);
			this.sldReachMax.TickAdd = 0f;
			this.sldReachMax.TickColor = global::System.Drawing.Color.White;
			this.sldReachMax.TickDivide = 0f;
			this.sldReachMax.TickStyle = global::System.Windows.Forms.TickStyle.None;
			global::ColorSlider.ColorSlider colorSlider21 = this.sldReachMax;
			int[] array21 = new int[4];
			array21[0] = 300;
			colorSlider21.Value = new decimal(array21);
			this.sldReachMax.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.sldReachMax_Scroll);
			this.lblReachMin.AutoSize = true;
			this.lblReachMin.Font = new global::System.Drawing.Font("Trebuchet MS", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblReachMin.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.lblReachMin.Location = new global::System.Drawing.Point(9, 39);
			this.lblReachMin.Name = "lblReachMin";
			this.lblReachMin.Size = new global::System.Drawing.Size(68, 18);
			this.lblReachMin.TabIndex = 3;
			this.lblReachMin.Text = "Min: 3.00";
			this.tglReach.BorderColor = global::System.Drawing.Color.LightGray;
			this.tglReach.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.tglReach.ForeColor = global::System.Drawing.Color.White;
			this.tglReach.IsOn = false;
			this.tglReach.Location = new global::System.Drawing.Point(178, 9);
			this.tglReach.Name = "tglReach";
			this.tglReach.OffColor = global::System.Drawing.Color.DarkGray;
			this.tglReach.OffText = "";
			this.tglReach.OnColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.tglReach.OnText = "";
			this.tglReach.Size = new global::System.Drawing.Size(34, 19);
			this.tglReach.TabIndex = 2;
			this.tglReach.TextEnabled = true;
			this.lblReach.AutoSize = true;
			this.lblReach.Font = new global::System.Drawing.Font("Trebuchet MS", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblReach.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.lblReach.Location = new global::System.Drawing.Point(8, 7);
			this.lblReach.Name = "lblReach";
			this.lblReach.Size = new global::System.Drawing.Size(56, 22);
			this.lblReach.TabIndex = 1;
			this.lblReach.Text = "Reach";
			this.sldReachMin.BackColor = global::System.Drawing.Color.Transparent;
			this.sldReachMin.BarInnerColor = global::System.Drawing.Color.FromArgb(200, 200, 200);
			this.sldReachMin.BarPenColorBottom = global::System.Drawing.Color.FromArgb(200, 200, 200);
			this.sldReachMin.BarPenColorTop = global::System.Drawing.Color.FromArgb(200, 200, 200);
			this.sldReachMin.BorderRoundRectSize = new global::System.Drawing.Size(7, 7);
			this.sldReachMin.ElapsedInnerColor = global::System.Drawing.Color.FromArgb(2, 130, 255);
			this.sldReachMin.ElapsedPenColorBottom = global::System.Drawing.Color.FromArgb(2, 130, 255);
			this.sldReachMin.ElapsedPenColorTop = global::System.Drawing.Color.FromArgb(2, 130, 255);
			this.sldReachMin.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6f);
			this.sldReachMin.ForeColor = global::System.Drawing.Color.White;
			global::ColorSlider.ColorSlider colorSlider22 = this.sldReachMin;
			int[] array22 = new int[4];
			array22[0] = 1;
			colorSlider22.LargeChange = new decimal(array22);
			this.sldReachMin.Location = new global::System.Drawing.Point(12, 44);
			global::ColorSlider.ColorSlider colorSlider23 = this.sldReachMin;
			int[] array23 = new int[4];
			array23[0] = 600;
			colorSlider23.Maximum = new decimal(array23);
			global::ColorSlider.ColorSlider colorSlider24 = this.sldReachMin;
			int[] array24 = new int[4];
			array24[0] = 300;
			colorSlider24.Minimum = new decimal(array24);
			this.sldReachMin.Name = "sldReachMin";
			global::ColorSlider.ColorSlider colorSlider25 = this.sldReachMin;
			int[] array25 = new int[4];
			array25[0] = 10;
			colorSlider25.ScaleDivisions = new decimal(array25);
			global::ColorSlider.ColorSlider colorSlider26 = this.sldReachMin;
			int[] array26 = new int[4];
			array26[0] = 5;
			colorSlider26.ScaleSubDivisions = new decimal(array26);
			this.sldReachMin.ShowDivisionsText = true;
			this.sldReachMin.ShowSmallScale = false;
			this.sldReachMin.Size = new global::System.Drawing.Size(200, 48);
			global::ColorSlider.ColorSlider colorSlider27 = this.sldReachMin;
			int[] array27 = new int[4];
			array27[0] = 1;
			colorSlider27.SmallChange = new decimal(array27);
			this.sldReachMin.TabIndex = 0;
			this.sldReachMin.ThumbInnerColor = global::System.Drawing.Color.FromArgb(2, 152, 252);
			this.sldReachMin.ThumbOuterColor = global::System.Drawing.Color.FromArgb(2, 152, 252);
			this.sldReachMin.ThumbPenColor = global::System.Drawing.Color.FromArgb(2, 130, 252);
			this.sldReachMin.ThumbRoundRectSize = new global::System.Drawing.Size(15, 15);
			this.sldReachMin.ThumbSize = new global::System.Drawing.Size(14, 14);
			this.sldReachMin.TickAdd = 0f;
			this.sldReachMin.TickColor = global::System.Drawing.Color.White;
			this.sldReachMin.TickDivide = 0f;
			this.sldReachMin.TickStyle = global::System.Windows.Forms.TickStyle.None;
			global::ColorSlider.ColorSlider colorSlider28 = this.sldReachMin;
			int[] array28 = new int[4];
			array28[0] = 300;
			colorSlider28.Value = new decimal(array28);
			this.sldReachMin.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.sldReachMin_Scroll);
			this.btnRBind.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.btnRBind.FlatAppearance.BorderSize = 0;
			this.btnRBind.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Gainsboro;
			this.btnRBind.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Gainsboro;
			this.btnRBind.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnRBind.Font = new global::System.Drawing.Font("Trebuchet MS", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnRBind.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.btnRBind.Location = new global::System.Drawing.Point(60, 5);
			this.btnRBind.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnRBind.Name = "btnRBind";
			this.btnRBind.Size = new global::System.Drawing.Size(57, 26);
			this.btnRBind.TabIndex = 4;
			this.btnRBind.Text = "[BIND]";
			this.btnRBind.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRBind.UseVisualStyleBackColor = true;
			this.btnRBind.Click += new global::System.EventHandler(this.btnRBind_Click);
			this.btnRBind.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.btnRBind_KeyDown);
			this.pnlAC.BackColor = global::System.Drawing.Color.Gainsboro;
			this.pnlAC.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlAC.Controls.Add(this.cbSmartMode);
			this.pnlAC.Controls.Add(this.cbRMBLock);
			this.pnlAC.Controls.Add(this.cbShiftDisable);
			this.pnlAC.Controls.Add(this.lblCPS);
			this.pnlAC.Controls.Add(this.tglAC);
			this.pnlAC.Controls.Add(this.label1);
			this.pnlAC.Controls.Add(this.sldCPS);
			this.pnlAC.Controls.Add(this.btnACBind);
			this.pnlAC.Location = new global::System.Drawing.Point(16, 28);
			this.pnlAC.Name = "pnlAC";
			this.pnlAC.Size = new global::System.Drawing.Size(224, 233);
			this.pnlAC.TabIndex = 1;
			this.cbSmartMode.AutoSize = true;
			this.cbSmartMode.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.cbSmartMode.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.cbSmartMode.Location = new global::System.Drawing.Point(12, 138);
			this.cbSmartMode.Name = "cbSmartMode";
			this.cbSmartMode.Size = new global::System.Drawing.Size(137, 24);
			this.cbSmartMode.TabIndex = 7;
			this.cbSmartMode.Text = "Disable in Menus";
			this.cbSmartMode.UseVisualStyleBackColor = true;
			this.cbRMBLock.AutoSize = true;
			this.cbRMBLock.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.cbRMBLock.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.cbRMBLock.Location = new global::System.Drawing.Point(12, 110);
			this.cbRMBLock.Name = "cbRMBLock";
			this.cbRMBLock.Size = new global::System.Drawing.Size(92, 24);
			this.cbRMBLock.TabIndex = 6;
			this.cbRMBLock.Text = "RMB Lock";
			this.cbRMBLock.UseVisualStyleBackColor = true;
			this.cbShiftDisable.AutoSize = true;
			this.cbShiftDisable.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.cbShiftDisable.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.cbShiftDisable.Location = new global::System.Drawing.Point(12, 82);
			this.cbShiftDisable.Name = "cbShiftDisable";
			this.cbShiftDisable.Size = new global::System.Drawing.Size(110, 24);
			this.cbShiftDisable.TabIndex = 5;
			this.cbShiftDisable.Text = "Shift Disable";
			this.cbShiftDisable.UseVisualStyleBackColor = true;
			this.lblCPS.AutoSize = true;
			this.lblCPS.Font = new global::System.Drawing.Font("Trebuchet MS", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblCPS.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.lblCPS.Location = new global::System.Drawing.Point(9, 39);
			this.lblCPS.Name = "lblCPS";
			this.lblCPS.Size = new global::System.Drawing.Size(109, 18);
			this.lblCPS.TabIndex = 3;
			this.lblCPS.Text = "Average CPS: 14";
			this.tglAC.BorderColor = global::System.Drawing.Color.LightGray;
			this.tglAC.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.tglAC.ForeColor = global::System.Drawing.Color.White;
			this.tglAC.IsOn = false;
			this.tglAC.Location = new global::System.Drawing.Point(178, 9);
			this.tglAC.Name = "tglAC";
			this.tglAC.OffColor = global::System.Drawing.Color.DarkGray;
			this.tglAC.OffText = "";
			this.tglAC.OnColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.tglAC.OnText = "";
			this.tglAC.Size = new global::System.Drawing.Size(34, 19);
			this.tglAC.TabIndex = 2;
			this.tglAC.TextEnabled = true;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Trebuchet MS", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.label1.Location = new global::System.Drawing.Point(8, 7);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(98, 22);
			this.label1.TabIndex = 1;
			this.label1.Text = "Autoclicker";
			this.sldCPS.BackColor = global::System.Drawing.Color.Transparent;
			this.sldCPS.BarInnerColor = global::System.Drawing.Color.FromArgb(200, 200, 200);
			this.sldCPS.BarPenColorBottom = global::System.Drawing.Color.FromArgb(200, 200, 200);
			this.sldCPS.BarPenColorTop = global::System.Drawing.Color.FromArgb(200, 200, 200);
			this.sldCPS.BorderRoundRectSize = new global::System.Drawing.Size(7, 7);
			this.sldCPS.ElapsedInnerColor = global::System.Drawing.Color.FromArgb(2, 130, 255);
			this.sldCPS.ElapsedPenColorBottom = global::System.Drawing.Color.FromArgb(2, 130, 255);
			this.sldCPS.ElapsedPenColorTop = global::System.Drawing.Color.FromArgb(2, 130, 255);
			this.sldCPS.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6f);
			this.sldCPS.ForeColor = global::System.Drawing.Color.White;
			global::ColorSlider.ColorSlider colorSlider29 = this.sldCPS;
			int[] array29 = new int[4];
			array29[0] = 1;
			colorSlider29.LargeChange = new decimal(array29);
			this.sldCPS.Location = new global::System.Drawing.Point(12, 44);
			global::ColorSlider.ColorSlider colorSlider30 = this.sldCPS;
			int[] array30 = new int[4];
			array30[0] = 20;
			colorSlider30.Maximum = new decimal(array30);
			global::ColorSlider.ColorSlider colorSlider31 = this.sldCPS;
			int[] array31 = new int[4];
			array31[0] = 5;
			colorSlider31.Minimum = new decimal(array31);
			this.sldCPS.Name = "sldCPS";
			global::ColorSlider.ColorSlider colorSlider32 = this.sldCPS;
			int[] array32 = new int[4];
			array32[0] = 10;
			colorSlider32.ScaleDivisions = new decimal(array32);
			global::ColorSlider.ColorSlider colorSlider33 = this.sldCPS;
			int[] array33 = new int[4];
			array33[0] = 5;
			colorSlider33.ScaleSubDivisions = new decimal(array33);
			this.sldCPS.ShowDivisionsText = true;
			this.sldCPS.ShowSmallScale = false;
			this.sldCPS.Size = new global::System.Drawing.Size(200, 48);
			global::ColorSlider.ColorSlider colorSlider34 = this.sldCPS;
			int[] array34 = new int[4];
			array34[0] = 1;
			colorSlider34.SmallChange = new decimal(array34);
			this.sldCPS.TabIndex = 0;
			this.sldCPS.ThumbInnerColor = global::System.Drawing.Color.FromArgb(2, 152, 252);
			this.sldCPS.ThumbOuterColor = global::System.Drawing.Color.FromArgb(2, 152, 252);
			this.sldCPS.ThumbPenColor = global::System.Drawing.Color.FromArgb(2, 130, 252);
			this.sldCPS.ThumbRoundRectSize = new global::System.Drawing.Size(15, 15);
			this.sldCPS.ThumbSize = new global::System.Drawing.Size(14, 14);
			this.sldCPS.TickAdd = 0f;
			this.sldCPS.TickColor = global::System.Drawing.Color.White;
			this.sldCPS.TickDivide = 0f;
			this.sldCPS.TickStyle = global::System.Windows.Forms.TickStyle.None;
			global::ColorSlider.ColorSlider colorSlider35 = this.sldCPS;
			int[] array35 = new int[4];
			array35[0] = 14;
			colorSlider35.Value = new decimal(array35);
			this.sldCPS.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.sldCPS_Scroll);
			this.btnACBind.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.btnACBind.FlatAppearance.BorderSize = 0;
			this.btnACBind.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Gainsboro;
			this.btnACBind.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Gainsboro;
			this.btnACBind.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnACBind.Font = new global::System.Drawing.Font("Trebuchet MS", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnACBind.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.btnACBind.Location = new global::System.Drawing.Point(102, 5);
			this.btnACBind.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnACBind.Name = "btnACBind";
			this.btnACBind.Size = new global::System.Drawing.Size(57, 26);
			this.btnACBind.TabIndex = 4;
			this.btnACBind.Text = "[BIND]";
			this.btnACBind.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnACBind.UseVisualStyleBackColor = true;
			this.btnACBind.Click += new global::System.EventHandler(this.btnACBind_Click);
			this.btnACBind.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.btnACBind_KeyDown);
			this.tmrBinds.Enabled = true;
			this.tmrBinds.Interval = 125;
			this.tmrBinds.Tick += new global::System.EventHandler(this.tmrBinds_Tick);
			this.pnlVisuals.BackColor = global::System.Drawing.Color.FromArgb(231, 231, 231);
			this.pnlVisuals.Controls.Add(this.panel4);
			this.pnlVisuals.Controls.Add(this.pnlNametags);
			this.pnlVisuals.Location = new global::System.Drawing.Point(139, 125);
			this.pnlVisuals.Name = "pnlVisuals";
			this.pnlVisuals.Size = new global::System.Drawing.Size(500, 549);
			this.pnlVisuals.TabIndex = 2;
			this.pnlVisuals.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.MouseMoveVoid);
			this.panel4.BackColor = global::System.Drawing.Color.Gainsboro;
			this.panel4.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.tglNameESP);
			this.panel4.Controls.Add(this.lblNameESP);
			this.panel4.Controls.Add(this.btnNameESPBind);
			this.panel4.Location = new global::System.Drawing.Point(258, 26);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(224, 233);
			this.panel4.TabIndex = 2;
			this.tglNameESP.BorderColor = global::System.Drawing.Color.LightGray;
			this.tglNameESP.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.tglNameESP.ForeColor = global::System.Drawing.Color.White;
			this.tglNameESP.IsOn = false;
			this.tglNameESP.Location = new global::System.Drawing.Point(178, 9);
			this.tglNameESP.Name = "tglNameESP";
			this.tglNameESP.OffColor = global::System.Drawing.Color.DarkGray;
			this.tglNameESP.OffText = "";
			this.tglNameESP.OnColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.tglNameESP.OnText = "";
			this.tglNameESP.Size = new global::System.Drawing.Size(34, 19);
			this.tglNameESP.TabIndex = 2;
			this.tglNameESP.TextEnabled = true;
			this.lblNameESP.AutoSize = true;
			this.lblNameESP.Font = new global::System.Drawing.Font("Trebuchet MS", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblNameESP.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.lblNameESP.Location = new global::System.Drawing.Point(8, 7);
			this.lblNameESP.Name = "lblNameESP";
			this.lblNameESP.Size = new global::System.Drawing.Size(79, 22);
			this.lblNameESP.TabIndex = 1;
			this.lblNameESP.Text = "NameESP";
			this.btnNameESPBind.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.btnNameESPBind.FlatAppearance.BorderSize = 0;
			this.btnNameESPBind.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Gainsboro;
			this.btnNameESPBind.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Gainsboro;
			this.btnNameESPBind.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnNameESPBind.Font = new global::System.Drawing.Font("Trebuchet MS", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnNameESPBind.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.btnNameESPBind.Location = new global::System.Drawing.Point(84, 5);
			this.btnNameESPBind.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnNameESPBind.Name = "btnNameESPBind";
			this.btnNameESPBind.Size = new global::System.Drawing.Size(57, 26);
			this.btnNameESPBind.TabIndex = 4;
			this.btnNameESPBind.Text = "[BIND]";
			this.btnNameESPBind.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNameESPBind.UseVisualStyleBackColor = true;
			this.btnNameESPBind.Click += new global::System.EventHandler(this.btnNameESPBind_Click);
			this.btnNameESPBind.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.btnNameESPBind_KeyDown);
			this.pnlNametags.BackColor = global::System.Drawing.Color.Gainsboro;
			this.pnlNametags.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlNametags.Controls.Add(this.lblMultiplier);
			this.pnlNametags.Controls.Add(this.tglNametag);
			this.pnlNametags.Controls.Add(this.label9);
			this.pnlNametags.Controls.Add(this.sldNMultiplier);
			this.pnlNametags.Controls.Add(this.btnNameTagsBind);
			this.pnlNametags.Location = new global::System.Drawing.Point(16, 28);
			this.pnlNametags.Name = "pnlNametags";
			this.pnlNametags.Size = new global::System.Drawing.Size(224, 233);
			this.pnlNametags.TabIndex = 1;
			this.lblMultiplier.AutoSize = true;
			this.lblMultiplier.Font = new global::System.Drawing.Font("Trebuchet MS", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblMultiplier.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.lblMultiplier.Location = new global::System.Drawing.Point(9, 39);
			this.lblMultiplier.Name = "lblMultiplier";
			this.lblMultiplier.Size = new global::System.Drawing.Size(98, 18);
			this.lblMultiplier.TabIndex = 3;
			this.lblMultiplier.Text = "Multiplier: 1.0";
			this.tglNametag.BorderColor = global::System.Drawing.Color.LightGray;
			this.tglNametag.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.tglNametag.ForeColor = global::System.Drawing.Color.White;
			this.tglNametag.IsOn = false;
			this.tglNametag.Location = new global::System.Drawing.Point(178, 9);
			this.tglNametag.Name = "tglNametag";
			this.tglNametag.OffColor = global::System.Drawing.Color.DarkGray;
			this.tglNametag.OffText = "";
			this.tglNametag.OnColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.tglNametag.OnText = "";
			this.tglNametag.Size = new global::System.Drawing.Size(34, 19);
			this.tglNametag.TabIndex = 2;
			this.tglNametag.TextEnabled = true;
			this.label9.AutoSize = true;
			this.label9.Font = new global::System.Drawing.Font("Trebuchet MS", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label9.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.label9.Location = new global::System.Drawing.Point(8, 7);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(84, 22);
			this.label9.TabIndex = 1;
			this.label9.Text = "Nametags";
			this.sldNMultiplier.BackColor = global::System.Drawing.Color.Transparent;
			this.sldNMultiplier.BarInnerColor = global::System.Drawing.Color.FromArgb(200, 200, 200);
			this.sldNMultiplier.BarPenColorBottom = global::System.Drawing.Color.FromArgb(200, 200, 200);
			this.sldNMultiplier.BarPenColorTop = global::System.Drawing.Color.FromArgb(200, 200, 200);
			this.sldNMultiplier.BorderRoundRectSize = new global::System.Drawing.Size(7, 7);
			this.sldNMultiplier.ElapsedInnerColor = global::System.Drawing.Color.FromArgb(2, 130, 255);
			this.sldNMultiplier.ElapsedPenColorBottom = global::System.Drawing.Color.FromArgb(2, 130, 255);
			this.sldNMultiplier.ElapsedPenColorTop = global::System.Drawing.Color.FromArgb(2, 130, 255);
			this.sldNMultiplier.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6f);
			this.sldNMultiplier.ForeColor = global::System.Drawing.Color.White;
			global::ColorSlider.ColorSlider colorSlider36 = this.sldNMultiplier;
			int[] array36 = new int[4];
			array36[0] = 1;
			colorSlider36.LargeChange = new decimal(array36);
			this.sldNMultiplier.Location = new global::System.Drawing.Point(12, 44);
			global::ColorSlider.ColorSlider colorSlider37 = this.sldNMultiplier;
			int[] array37 = new int[4];
			array37[0] = 50;
			colorSlider37.Maximum = new decimal(array37);
			global::ColorSlider.ColorSlider colorSlider38 = this.sldNMultiplier;
			int[] array38 = new int[4];
			array38[0] = 10;
			colorSlider38.Minimum = new decimal(array38);
			this.sldNMultiplier.Name = "sldNMultiplier";
			global::ColorSlider.ColorSlider colorSlider39 = this.sldNMultiplier;
			int[] array39 = new int[4];
			array39[0] = 10;
			colorSlider39.ScaleDivisions = new decimal(array39);
			global::ColorSlider.ColorSlider colorSlider40 = this.sldNMultiplier;
			int[] array40 = new int[4];
			array40[0] = 5;
			colorSlider40.ScaleSubDivisions = new decimal(array40);
			this.sldNMultiplier.ShowDivisionsText = true;
			this.sldNMultiplier.ShowSmallScale = false;
			this.sldNMultiplier.Size = new global::System.Drawing.Size(200, 48);
			global::ColorSlider.ColorSlider colorSlider41 = this.sldNMultiplier;
			int[] array41 = new int[4];
			array41[0] = 1;
			colorSlider41.SmallChange = new decimal(array41);
			this.sldNMultiplier.TabIndex = 0;
			this.sldNMultiplier.ThumbInnerColor = global::System.Drawing.Color.FromArgb(2, 152, 252);
			this.sldNMultiplier.ThumbOuterColor = global::System.Drawing.Color.FromArgb(2, 152, 252);
			this.sldNMultiplier.ThumbPenColor = global::System.Drawing.Color.FromArgb(2, 130, 252);
			this.sldNMultiplier.ThumbRoundRectSize = new global::System.Drawing.Size(15, 15);
			this.sldNMultiplier.ThumbSize = new global::System.Drawing.Size(14, 14);
			this.sldNMultiplier.TickAdd = 0f;
			this.sldNMultiplier.TickColor = global::System.Drawing.Color.White;
			this.sldNMultiplier.TickDivide = 0f;
			this.sldNMultiplier.TickStyle = global::System.Windows.Forms.TickStyle.None;
			global::ColorSlider.ColorSlider colorSlider42 = this.sldNMultiplier;
			int[] array42 = new int[4];
			array42[0] = 10;
			colorSlider42.Value = new decimal(array42);
			this.sldNMultiplier.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.sldNMultiplier_Scroll);
			this.btnNameTagsBind.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.btnNameTagsBind.FlatAppearance.BorderSize = 0;
			this.btnNameTagsBind.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Gainsboro;
			this.btnNameTagsBind.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Gainsboro;
			this.btnNameTagsBind.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnNameTagsBind.Font = new global::System.Drawing.Font("Trebuchet MS", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnNameTagsBind.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.btnNameTagsBind.Location = new global::System.Drawing.Point(88, 5);
			this.btnNameTagsBind.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnNameTagsBind.Name = "btnNameTagsBind";
			this.btnNameTagsBind.Size = new global::System.Drawing.Size(57, 26);
			this.btnNameTagsBind.TabIndex = 4;
			this.btnNameTagsBind.Text = "[BIND]";
			this.btnNameTagsBind.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNameTagsBind.UseVisualStyleBackColor = true;
			this.btnNameTagsBind.Click += new global::System.EventHandler(this.btnNameTagsBind_Click);
			this.btnNameTagsBind.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.btnNameTagsBind_KeyDown);
			this.bgwScan.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.bgwScan_DoWork);
			this.bgwScan.RunWorkerCompleted += new global::System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwScan_RunWorkerCompleted);
			this.bgwWrite.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.bgwWrite_DoWork);
			this.bgwWrite.RunWorkerCompleted += new global::System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwWrite_RunWorkerCompleted);
			this.tmrAC.Enabled = true;
			this.tmrAC.Interval = 1;
			this.tmrAC.Tick += new global::System.EventHandler(this.tmrAC_Tick);
			this.pnlSettings.BackColor = global::System.Drawing.Color.FromArgb(231, 231, 231);
			this.pnlSettings.Controls.Add(this.pnlUISet);
			this.pnlSettings.Controls.Add(this.pnlDestruct);
			this.pnlSettings.Location = new global::System.Drawing.Point(290, 503);
			this.pnlSettings.Name = "pnlSettings";
			this.pnlSettings.Size = new global::System.Drawing.Size(500, 549);
			this.pnlSettings.TabIndex = 3;
			this.pnlSettings.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.MouseMoveVoid);
			this.pnlUISet.BackColor = global::System.Drawing.Color.Gainsboro;
			this.pnlUISet.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlUISet.Controls.Add(this.lblUISets);
			this.pnlUISet.Location = new global::System.Drawing.Point(258, 26);
			this.pnlUISet.Name = "pnlUISet";
			this.pnlUISet.Size = new global::System.Drawing.Size(224, 233);
			this.pnlUISet.TabIndex = 2;
			this.lblUISets.AutoSize = true;
			this.lblUISets.Font = new global::System.Drawing.Font("Trebuchet MS", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblUISets.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.lblUISets.Location = new global::System.Drawing.Point(8, 7);
			this.lblUISets.Name = "lblUISets";
			this.lblUISets.Size = new global::System.Drawing.Size(89, 22);
			this.lblUISets.TabIndex = 1;
			this.lblUISets.Text = "UI Settings";
			this.pnlDestruct.BackColor = global::System.Drawing.Color.Gainsboro;
			this.pnlDestruct.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlDestruct.Controls.Add(this.cbUSN);
			this.pnlDestruct.Controls.Add(this.cbClearStrings);
			this.pnlDestruct.Controls.Add(this.cbPrefetch);
			this.pnlDestruct.Controls.Add(this.label4);
			this.pnlDestruct.Location = new global::System.Drawing.Point(16, 28);
			this.pnlDestruct.Name = "pnlDestruct";
			this.pnlDestruct.Size = new global::System.Drawing.Size(224, 233);
			this.pnlDestruct.TabIndex = 1;
			this.cbUSN.AutoSize = true;
			this.cbUSN.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.cbUSN.Location = new global::System.Drawing.Point(12, 98);
			this.cbUSN.Name = "cbUSN";
			this.cbUSN.Size = new global::System.Drawing.Size(147, 24);
			this.cbUSN.TabIndex = 4;
			this.cbUSN.Text = "Clear USN Journal";
			this.cbUSN.UseVisualStyleBackColor = true;
			this.cbClearStrings.AutoSize = true;
			this.cbClearStrings.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.cbClearStrings.Location = new global::System.Drawing.Point(12, 69);
			this.cbClearStrings.Name = "cbClearStrings";
			this.cbClearStrings.Size = new global::System.Drawing.Size(112, 24);
			this.cbClearStrings.TabIndex = 3;
			this.cbClearStrings.Text = "Clear Strings";
			this.cbClearStrings.UseVisualStyleBackColor = true;
			this.cbPrefetch.AutoSize = true;
			this.cbPrefetch.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.cbPrefetch.Location = new global::System.Drawing.Point(12, 40);
			this.cbPrefetch.Name = "cbPrefetch";
			this.cbPrefetch.Size = new global::System.Drawing.Size(131, 24);
			this.cbPrefetch.TabIndex = 2;
			this.cbPrefetch.Text = "Delete Prefetch";
			this.cbPrefetch.UseVisualStyleBackColor = true;
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Trebuchet MS", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.FromArgb(91, 91, 91);
			this.label4.Location = new global::System.Drawing.Point(8, 7);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(73, 22);
			this.label4.TabIndex = 1;
			this.label4.Text = "Destruct";
			this.bgwDestruct.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.bgwDestruct_DoWork);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(231, 231, 231);
			base.ClientSize = new global::System.Drawing.Size(533, 514);
			base.Controls.Add(this.pnlSidebar);
			base.Controls.Add(this.pnlSettings);
			base.Controls.Add(this.pnlVisuals);
			base.Controls.Add(this.pnlCombat);
			this.Font = new global::System.Drawing.Font("Trebuchet MS", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "Form1";
			base.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.MouseMoveVoid);
			this.pnlSidebar.ResumeLayout(false);
			this.pnlCombat.ResumeLayout(false);
			this.pnlVelocity.ResumeLayout(false);
			this.pnlVelocity.PerformLayout();
			this.pnlReach.ResumeLayout(false);
			this.pnlReach.PerformLayout();
			this.pnlAC.ResumeLayout(false);
			this.pnlAC.PerformLayout();
			this.pnlVisuals.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.pnlNametags.ResumeLayout(false);
			this.pnlNametags.PerformLayout();
			this.pnlSettings.ResumeLayout(false);
			this.pnlUISet.ResumeLayout(false);
			this.pnlUISet.PerformLayout();
			this.pnlDestruct.ResumeLayout(false);
			this.pnlDestruct.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000014 RID: 20
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Button btnCombat;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.Timer sidebarFix;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Panel pnlCombat;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Panel pnlSidebar;

		// Token: 0x04000019 RID: 25
		private global::ColorSlider.ColorSlider sldCPS;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Panel pnlAC;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400001C RID: 28
		private global::ToggleButton.toggleswitch tglAC;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Label lblCPS;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Button btnACBind;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Timer tmrBinds;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.CheckBox cbShiftDisable;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.CheckBox cbRMBLock;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.CheckBox cbSmartMode;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Panel pnlReach;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Label lblReachMin;

		// Token: 0x04000025 RID: 37
		private global::ToggleButton.toggleswitch tglReach;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Label lblReach;

		// Token: 0x04000027 RID: 39
		private global::ColorSlider.ColorSlider sldReachMin;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Button btnRBind;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Label lblReachMax;

		// Token: 0x0400002A RID: 42
		private global::ColorSlider.ColorSlider sldReachMax;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Panel pnlVelocity;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Label lblVeloMax;

		// Token: 0x0400002D RID: 45
		private global::ColorSlider.ColorSlider sldVeloMax;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Label lblVeloMin;

		// Token: 0x0400002F RID: 47
		private global::ToggleButton.toggleswitch tglVelo;

		// Token: 0x04000030 RID: 48
		private global::ColorSlider.ColorSlider sldVeloMin;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Button btnVeloBind;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.Label lblVelocity;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.Button btnVisuals;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Panel pnlVisuals;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.Panel pnlNametags;

		// Token: 0x04000036 RID: 54
		private global::ToggleButton.toggleswitch tglNametag;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.Button btnNameTagsBind;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.Label lblMultiplier;

		// Token: 0x0400003A RID: 58
		private global::ColorSlider.ColorSlider sldNMultiplier;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.Button btnExit;

		// Token: 0x0400003C RID: 60
		private global::System.ComponentModel.BackgroundWorker bgwScan;

		// Token: 0x0400003D RID: 61
		private global::System.ComponentModel.BackgroundWorker bgwWrite;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x0400003F RID: 63
		private global::ToggleButton.toggleswitch tglNameESP;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.Label lblNameESP;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.Button btnNameESPBind;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Timer tmrAC;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Button btnSettings;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Panel pnlSettings;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Panel pnlUISet;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Label lblUISets;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Panel pnlDestruct;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.CheckBox cbClearStrings;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.CheckBox cbPrefetch;

		// Token: 0x0400004B RID: 75
		private global::System.ComponentModel.BackgroundWorker bgwDestruct;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.CheckBox cbUSN;
	}
}
