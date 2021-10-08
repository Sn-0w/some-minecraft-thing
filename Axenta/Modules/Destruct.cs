using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Colorful;
using Memory;

namespace Axenta.Modules
{
	// Token: 0x02000011 RID: 17
	internal class Destruct
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00164738 File Offset: 0x0015F938
		private string stringtoaobs(string a)
		{
			string text = "";
			byte[] bytes = Encoding.UTF8.GetBytes(a);
			int num = bytes.Count<byte>();
			int num2 = 0;
			foreach (byte b in bytes)
			{
				num2++;
				if (text == "")
				{
					text += b.ToString("X");
				}
				else if (num2 - 1 == num)
				{
					text = text + " " + b.ToString("X");
				}
				else
				{
					text = text + " 00 " + b.ToString("X");
				}
			}
			return text;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x001647F0 File Offset: 0x0015F9F0
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

		// Token: 0x06000065 RID: 101
		[DllImport("kernel32.dll")]
		private static extern IntPtr GetConsoleWindow();

		// Token: 0x06000066 RID: 102
		[DllImport("user32.dll")]
		private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		// Token: 0x06000067 RID: 103 RVA: 0x00164CB8 File Offset: 0x0015FEB8
		
		public void destruct(bool clearPrefetch, bool clearStrings, bool USNJournal)
		{
			Destruct.<destruct>d__5 <destruct>d__ = new Destruct.<destruct>d__5();
			<destruct>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<destruct>d__.<>4__this = this;
			<destruct>d__.clearPrefetch = clearPrefetch;
			<destruct>d__.clearStrings = clearStrings;
			<destruct>d__.USNJournal = USNJournal;
			<destruct>d__.<>1__state = -1;
			<destruct>d__.<>t__builder.Start<Destruct.<destruct>d__5>(ref <destruct>d__);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00164D08 File Offset: 0x0015FF08
		private int dpsprocessid()
		{
			ManagementObject managementObject = new ManagementObject("Win32_Service.Name='DPS'");
			managementObject.Get();
			return Convert.ToInt32(managementObject["ProcessId"]);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00164D3C File Offset: 0x0015FF3C
		
		private void clearStringMemory()
		{
			Destruct.<clearStringMemory>d__12 <clearStringMemory>d__ = new Destruct.<clearStringMemory>d__12();
			<clearStringMemory>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<clearStringMemory>d__.<>4__this = this;
			<clearStringMemory>d__.<>1__state = -1;
			<clearStringMemory>d__.<>t__builder.Start<Destruct.<clearStringMemory>d__12>(ref <clearStringMemory>d__);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00164D78 File Offset: 0x0015FF78
		
		private void clearPrefetchVoid()
		{
			Destruct.<clearPrefetchVoid>d__13 <clearPrefetchVoid>d__ = new Destruct.<clearPrefetchVoid>d__13();
			<clearPrefetchVoid>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<clearPrefetchVoid>d__.<>4__this = this;
			<clearPrefetchVoid>d__.<>1__state = -1;
			<clearPrefetchVoid>d__.<>t__builder.Start<Destruct.<clearPrefetchVoid>d__13>(ref <clearPrefetchVoid>d__);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00164DB4 File Offset: 0x0015FFB4
		
		private void clearUSNJournal()
		{
			Destruct.<clearUSNJournal>d__14 <clearUSNJournal>d__ = new Destruct.<clearUSNJournal>d__14();
			<clearUSNJournal>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<clearUSNJournal>d__.<>4__this = this;
			<clearUSNJournal>d__.<>1__state = -1;
			<clearUSNJournal>d__.<>t__builder.Start<Destruct.<clearUSNJournal>d__14>(ref <clearUSNJournal>d__);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00164DF0 File Offset: 0x0015FFF0
		public Destruct()
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00164E28 File Offset: 0x00160028
		[CompilerGenerated]
		private void <destruct>b__5_0()
		{
			this.clearStringMemory();
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00164E3C File Offset: 0x0016003C
		[CompilerGenerated]
		private void <destruct>b__5_1()
		{
			this.clearPrefetchVoid();
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00164E50 File Offset: 0x00160050
		[CompilerGenerated]
		private void <destruct>b__5_2()
		{
			this.clearUSNJournal();
		}

		// Token: 0x0400008D RID: 141
		private Mem M = new Mem();

		// Token: 0x0400008E RID: 142
		private byte[] replace = new byte[8];

		// Token: 0x0400008F RID: 143
		private byte[] replace2 = new byte[57];

		// Token: 0x04000090 RID: 144
		private IEnumerable<long> strings;

		// Token: 0x04000091 RID: 145
		private long min;

		// Token: 0x04000092 RID: 146
		private long max;

		// Token: 0x02000012 RID: 18
		[CompilerGenerated]
		private sealed class <destruct>d__5 : IAsyncStateMachine
		{
			// Token: 0x06000070 RID: 112 RVA: 0x0015E0B2 File Offset: 0x001592B2
			public <destruct>d__5()
			{
			}

			// Token: 0x06000071 RID: 113 RVA: 0x00164E64 File Offset: 0x00160064
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter awaiter2;
					TaskAwaiter awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_19D;
					case 2:
						awaiter3 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1F6;
					default:
						Console.Clear();
						Destruct.ShowWindow(Destruct.GetConsoleWindow(), 1);
						Destruct.printLogo();
						this.<des>5__1 = "Detructing please wait.";
						Console.WriteLine(string.Format("{0," + (Console.WindowWidth / 2 + this.<des>5__1.Length / 2).ToString() + "}", this.<des>5__1));
						Console.WriteLine("");
						if (!this.clearStrings)
						{
							goto IL_148;
						}
						awaiter = Task.Run(delegate()
						{
							base.clearStringMemory();
						}).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							Destruct.<destruct>d__5 <destruct>d__ = this;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Destruct.<destruct>d__5>(ref awaiter, ref <destruct>d__);
							return;
						}
						break;
					}
					awaiter.GetResult();
					IL_148:
					if (!this.clearPrefetch)
					{
						goto IL_1A4;
					}
					awaiter2 = Task.Run(delegate()
					{
						base.clearPrefetchVoid();
					}).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter2;
						Destruct.<destruct>d__5 <destruct>d__ = this;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Destruct.<destruct>d__5>(ref awaiter2, ref <destruct>d__);
						return;
					}
					IL_19D:
					awaiter2.GetResult();
					IL_1A4:
					if (!this.USNJournal)
					{
						goto IL_1FD;
					}
					awaiter3 = Task.Run(delegate()
					{
						base.clearUSNJournal();
					}).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter3;
						Destruct.<destruct>d__5 <destruct>d__ = this;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Destruct.<destruct>d__5>(ref awaiter3, ref <destruct>d__);
						return;
					}
					IL_1F6:
					awaiter3.GetResult();
					IL_1FD:
					Environment.Exit(4);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<des>5__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<des>5__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06000072 RID: 114 RVA: 0x0015E0BB File Offset: 0x001592BB
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000093 RID: 147
			public int <>1__state;

			// Token: 0x04000094 RID: 148
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000095 RID: 149
			public bool clearPrefetch;

			// Token: 0x04000096 RID: 150
			public bool clearStrings;

			// Token: 0x04000097 RID: 151
			public bool USNJournal;

			// Token: 0x04000098 RID: 152
			public Destruct <>4__this;

			// Token: 0x04000099 RID: 153
			private string <des>5__1;

			// Token: 0x0400009A RID: 154
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000013 RID: 19
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06000073 RID: 115 RVA: 0x0015E0B2 File Offset: 0x001592B2
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x06000074 RID: 116 RVA: 0x001650CC File Offset: 0x001602CC
			internal void <clearStringMemory>b__0()
			{
				this.<>4__this.M.WriteBytes(this.a.ToString("X"), this.<>4__this.replace, "");
			}

			// Token: 0x0400009B RID: 155
			public long a;

			// Token: 0x0400009C RID: 156
			public Destruct <>4__this;
		}

		// Token: 0x02000014 RID: 20
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_1
		{
			// Token: 0x06000075 RID: 117 RVA: 0x0015E0B2 File Offset: 0x001592B2
			public <>c__DisplayClass12_1()
			{
			}

			// Token: 0x06000076 RID: 118 RVA: 0x0016510C File Offset: 0x0016030C
			internal void <clearStringMemory>b__1()
			{
				this.<>4__this.M.WriteBytes(this.a.ToString("X"), this.<>4__this.replace2, "");
			}

			// Token: 0x0400009D RID: 157
			public long a;

			// Token: 0x0400009E RID: 158
			public Destruct <>4__this;
		}

		// Token: 0x02000015 RID: 21
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_2
		{
			// Token: 0x06000077 RID: 119 RVA: 0x0015E0B2 File Offset: 0x001592B2
			public <>c__DisplayClass12_2()
			{
			}

			// Token: 0x06000078 RID: 120 RVA: 0x0016514C File Offset: 0x0016034C
			internal void <clearStringMemory>b__2()
			{
				this.<>4__this.M.WriteBytes(this.a.ToString("X"), this.<>4__this.replace, "");
			}

			// Token: 0x0400009F RID: 159
			public long a;

			// Token: 0x040000A0 RID: 160
			public Destruct <>4__this;
		}

		// Token: 0x02000016 RID: 22
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_3
		{
			// Token: 0x06000079 RID: 121 RVA: 0x0015E0B2 File Offset: 0x001592B2
			public <>c__DisplayClass12_3()
			{
			}

			// Token: 0x0600007A RID: 122 RVA: 0x0016518C File Offset: 0x0016038C
			internal void <clearStringMemory>b__3()
			{
				this.<>4__this.M.WriteBytes(this.a.ToString("X"), this.<>4__this.replace, "");
			}

			// Token: 0x040000A1 RID: 161
			public long a;

			// Token: 0x040000A2 RID: 162
			public Destruct <>4__this;
		}

		// Token: 0x02000017 RID: 23
		[CompilerGenerated]
		private sealed class <clearStringMemory>d__12 : IAsyncStateMachine
		{
			// Token: 0x0600007B RID: 123 RVA: 0x0015E0B2 File Offset: 0x001592B2
			public <clearStringMemory>d__12()
			{
			}

			// Token: 0x0600007C RID: 124 RVA: 0x001651CC File Offset: 0x001603CC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					for (;;)
					{
						switch (num)
						{
						case 0:
							continue;
						case 1:
							goto IL_58;
						case 2:
							goto IL_5E;
						case 3:
							goto IL_64;
						case 4:
							goto IL_6A;
						case 5:
							goto IL_8C;
						case 6:
							goto IL_92;
						case 7:
							goto IL_B4;
						}
						break;
					}
					this.<dpsprocid>5__1 = this.<>4__this.dpsprocessid();
					this.<>s__2 = Process.GetProcesses();
					this.<>s__3 = 0;
					goto IL_920;
					IL_58:
					goto IL_349;
					IL_5E:
					goto IL_4A0;
					IL_64:
					goto IL_4F2;
					IL_6A:
					TaskAwaiter<IEnumerable<long>> awaiter = this.<>u__1;
					this.<>u__1 = default(TaskAwaiter<IEnumerable<long>>);
					int num2 = -1;
					num = -1;
					this.<>1__state = num2;
					goto IL_648;
					IL_8C:
					goto IL_683;
					IL_92:
					TaskAwaiter<IEnumerable<long>> awaiter2 = this.<>u__1;
					this.<>u__1 = default(TaskAwaiter<IEnumerable<long>>);
					int num3 = -1;
					num = -1;
					this.<>1__state = num3;
					goto IL_7E4;
					IL_B4:
					goto IL_81F;
					IL_349:
					Destruct.<clearStringMemory>d__12 <clearStringMemory>d__;
					try
					{
						if (num != 1)
						{
							goto IL_404;
						}
						TaskAwaiter awaiter3 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter);
						int num4 = -1;
						num = -1;
						this.<>1__state = num4;
						IL_3F6:
						awaiter3.GetResult();
						this.<>8__8 = null;
						IL_404:
						if (this.<>s__7.MoveNext())
						{
							this.<>8__8 = new Destruct.<>c__DisplayClass12_0();
							this.<>8__8.<>4__this = this.<>4__this;
							this.<>8__8.a = this.<>s__7.Current;
							awaiter3 = Task.Run(new Action(this.<>8__8.<clearStringMemory>b__0)).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num5 = 1;
								num = 1;
								this.<>1__state = num5;
								this.<>u__2 = awaiter3;
								<clearStringMemory>d__ = this;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Destruct.<clearStringMemory>d__12>(ref awaiter3, ref <clearStringMemory>d__);
								return;
							}
							goto IL_3F6;
						}
					}
					finally
					{
						if (num < 0 && this.<>s__7 != null)
						{
							this.<>s__7.Dispose();
						}
					}
					this.<>s__7 = null;
					TaskAwaiter<IEnumerable<long>> awaiter4 = this.<>4__this.M.AoBScan(this.<>4__this.min, this.<>4__this.max, this.<>4__this.stringtoaobs("TRACE,0000,0000,PcaClient,MonitorProcess," + Application.ExecutablePath + ",Time,0"), true, true, "").GetAwaiter();
					if (awaiter4.IsCompleted)
					{
						this.<>s__9 = awaiter4.GetResult();
						this.<>4__this.strings = this.<>s__9;
						this.<>s__9 = null;
						this.<>s__10 = this.<>4__this.strings.GetEnumerator();
						goto IL_4F2;
					}
					int num6 = 2;
					num = 2;
					this.<>1__state = num6;
					this.<>u__1 = awaiter4;
					IL_4A0:
					<clearStringMemory>d__ = this;
					this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<long>>, Destruct.<clearStringMemory>d__12>(ref awaiter4, ref <clearStringMemory>d__);
					return;
					IL_4F2:
					try
					{
						if (num != 3)
						{
							goto IL_5AD;
						}
						TaskAwaiter awaiter5 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter);
						int num7 = -1;
						num = -1;
						this.<>1__state = num7;
						IL_59F:
						awaiter5.GetResult();
						this.<>8__11 = null;
						IL_5AD:
						if (this.<>s__10.MoveNext())
						{
							this.<>8__11 = new Destruct.<>c__DisplayClass12_1();
							this.<>8__11.<>4__this = this.<>4__this;
							this.<>8__11.a = this.<>s__10.Current;
							awaiter5 = Task.Run(new Action(this.<>8__11.<clearStringMemory>b__1)).GetAwaiter();
							if (!awaiter5.IsCompleted)
							{
								int num8 = 3;
								num = 3;
								this.<>1__state = num8;
								this.<>u__2 = awaiter5;
								<clearStringMemory>d__ = this;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Destruct.<clearStringMemory>d__12>(ref awaiter5, ref <clearStringMemory>d__);
								return;
							}
							goto IL_59F;
						}
					}
					finally
					{
						if (num < 0 && this.<>s__10 != null)
						{
							this.<>s__10.Dispose();
						}
					}
					this.<>s__10 = null;
					IL_5DE:
					awaiter = this.<>4__this.M.AoBScan(this.<>4__this.min, this.<>4__this.max, "41 78 65 6e 74 61", true, true, "").GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num9 = 4;
						num = 4;
						this.<>1__state = num9;
						this.<>u__1 = awaiter;
						<clearStringMemory>d__ = this;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<long>>, Destruct.<clearStringMemory>d__12>(ref awaiter, ref <clearStringMemory>d__);
						return;
					}
					IL_648:
					this.<>s__12 = awaiter.GetResult();
					this.<>4__this.strings = this.<>s__12;
					this.<>s__12 = null;
					this.<>s__13 = this.<>4__this.strings.GetEnumerator();
					IL_683:
					try
					{
						if (num != 5)
						{
							goto IL_73E;
						}
						TaskAwaiter awaiter6 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter);
						int num10 = -1;
						num = -1;
						this.<>1__state = num10;
						IL_730:
						awaiter6.GetResult();
						this.<>8__14 = null;
						IL_73E:
						if (this.<>s__13.MoveNext())
						{
							this.<>8__14 = new Destruct.<>c__DisplayClass12_2();
							this.<>8__14.<>4__this = this.<>4__this;
							this.<>8__14.a = this.<>s__13.Current;
							awaiter6 = Task.Run(new Action(this.<>8__14.<clearStringMemory>b__2)).GetAwaiter();
							if (!awaiter6.IsCompleted)
							{
								int num11 = 5;
								num = 5;
								this.<>1__state = num11;
								this.<>u__2 = awaiter6;
								<clearStringMemory>d__ = this;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Destruct.<clearStringMemory>d__12>(ref awaiter6, ref <clearStringMemory>d__);
								return;
							}
							goto IL_730;
						}
					}
					finally
					{
						if (num < 0 && this.<>s__13 != null)
						{
							this.<>s__13.Dispose();
						}
					}
					this.<>s__13 = null;
					awaiter2 = this.<>4__this.M.AoBScan(this.<>4__this.min, this.<>4__this.max, this.<>4__this.stringtoaobs("Axenta"), true, true, "").GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						int num12 = 6;
						num = 6;
						this.<>1__state = num12;
						this.<>u__1 = awaiter2;
						<clearStringMemory>d__ = this;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<long>>, Destruct.<clearStringMemory>d__12>(ref awaiter2, ref <clearStringMemory>d__);
						return;
					}
					IL_7E4:
					this.<>s__15 = awaiter2.GetResult();
					this.<>4__this.strings = this.<>s__15;
					this.<>s__15 = null;
					this.<>s__16 = this.<>4__this.strings.GetEnumerator();
					IL_81F:
					try
					{
						if (num != 7)
						{
							goto IL_8DA;
						}
						TaskAwaiter awaiter7 = this.<>u__2;
						this.<>u__2 = default(TaskAwaiter);
						int num13 = -1;
						num = -1;
						this.<>1__state = num13;
						IL_8CC:
						awaiter7.GetResult();
						this.<>8__17 = null;
						IL_8DA:
						if (this.<>s__16.MoveNext())
						{
							this.<>8__17 = new Destruct.<>c__DisplayClass12_3();
							this.<>8__17.<>4__this = this.<>4__this;
							this.<>8__17.a = this.<>s__16.Current;
							awaiter7 = Task.Run(new Action(this.<>8__17.<clearStringMemory>b__3)).GetAwaiter();
							if (!awaiter7.IsCompleted)
							{
								int num14 = 7;
								num = 7;
								this.<>1__state = num14;
								this.<>u__2 = awaiter7;
								<clearStringMemory>d__ = this;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Destruct.<clearStringMemory>d__12>(ref awaiter7, ref <clearStringMemory>d__);
								return;
							}
							goto IL_8CC;
						}
					}
					finally
					{
						if (num < 0 && this.<>s__16 != null)
						{
							this.<>s__16.Dispose();
						}
					}
					this.<>s__16 = null;
					IL_90B:
					this.<process>5__4 = null;
					IL_912:
					this.<>s__3++;
					IL_920:
					if (this.<>s__3 >= this.<>s__2.Length)
					{
						this.<>s__2 = null;
					}
					else
					{
						this.<process>5__4 = this.<>s__2[this.<>s__3];
						if (!this.<process>5__4.ProcessName.Equals("explorer") && !this.<process>5__4.ProcessName.Equals("javaw") && !this.<process>5__4.ProcessName.Equals("SearchIndexer") && !this.<process>5__4.ProcessName.Equals("svchost"))
						{
							goto IL_90B;
						}
						if (this.<process>5__4.ProcessName == "svchost")
						{
							if (this.<process>5__4.Id != this.<dpsprocid>5__1)
							{
								goto IL_912;
							}
						}
						string processName = this.<process>5__4.ProcessName;
						this.<>s__5 = processName;
						string a = this.<>s__5;
						if (!(a == "javaw"))
						{
							if (!(a == "explorer"))
							{
								if (!(a == "SearchIndexer"))
								{
									if (a == "svchost")
									{
										this.<>4__this.min = 272465000000L;
										this.<>4__this.max = 2724680000000L;
									}
								}
								else
								{
									this.<>4__this.min = 1366816000000L;
									this.<>4__this.max = 1369000000000L;
								}
							}
							else
							{
								this.<>4__this.min = 10000000L;
								this.<>4__this.max = 450000000L;
							}
						}
						else
						{
							this.<>4__this.min = 15000000L;
							this.<>4__this.max = 30000000L;
						}
						this.<>s__5 = null;
						this.<>4__this.M.OpenProcess(this.<process>5__4.ProcessName);
						if (!this.<process>5__4.ProcessName.Equals("explorer"))
						{
							goto IL_5DE;
						}
						TaskAwaiter<IEnumerable<long>> awaiter8 = this.<>4__this.M.AoBScan(this.<>4__this.min, 450000000L, "64 00 6f 00 77 00 20 00 28 00 41 00 78 00 65 00 6e 00 74 00 61 00 2e 00 65 00 78 00 65 00 29", true, true, "").GetAwaiter();
						if (!awaiter8.IsCompleted)
						{
							int num15 = 0;
							num = 0;
							this.<>1__state = num15;
							this.<>u__1 = awaiter8;
							<clearStringMemory>d__ = this;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<long>>, Destruct.<clearStringMemory>d__12>(ref awaiter8, ref <clearStringMemory>d__);
							return;
						}
						this.<>s__6 = awaiter8.GetResult();
						this.<>4__this.strings = this.<>s__6;
						this.<>s__6 = null;
						this.<>s__7 = this.<>4__this.strings.GetEnumerator();
						goto IL_349;
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x0600007D RID: 125 RVA: 0x0015E0BB File Offset: 0x001592BB
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x040000A3 RID: 163
			public int <>1__state;

			// Token: 0x040000A4 RID: 164
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040000A5 RID: 165
			public Destruct <>4__this;

			// Token: 0x040000A6 RID: 166
			private int <dpsprocid>5__1;

			// Token: 0x040000A7 RID: 167
			private Process[] <>s__2;

			// Token: 0x040000A8 RID: 168
			private int <>s__3;

			// Token: 0x040000A9 RID: 169
			private Process <process>5__4;

			// Token: 0x040000AA RID: 170
			private string <>s__5;

			// Token: 0x040000AB RID: 171
			private IEnumerable<long> <>s__6;

			// Token: 0x040000AC RID: 172
			private IEnumerator<long> <>s__7;

			// Token: 0x040000AD RID: 173
			private Destruct.<>c__DisplayClass12_0 <>8__8;

			// Token: 0x040000AE RID: 174
			private IEnumerable<long> <>s__9;

			// Token: 0x040000AF RID: 175
			private IEnumerator<long> <>s__10;

			// Token: 0x040000B0 RID: 176
			private Destruct.<>c__DisplayClass12_1 <>8__11;

			// Token: 0x040000B1 RID: 177
			private IEnumerable<long> <>s__12;

			// Token: 0x040000B2 RID: 178
			private IEnumerator<long> <>s__13;

			// Token: 0x040000B3 RID: 179
			private Destruct.<>c__DisplayClass12_2 <>8__14;

			// Token: 0x040000B4 RID: 180
			private IEnumerable<long> <>s__15;

			// Token: 0x040000B5 RID: 181
			private IEnumerator<long> <>s__16;

			// Token: 0x040000B6 RID: 182
			private Destruct.<>c__DisplayClass12_3 <>8__17;

			// Token: 0x040000B7 RID: 183
			private TaskAwaiter<IEnumerable<long>> <>u__1;

			// Token: 0x040000B8 RID: 184
			private TaskAwaiter <>u__2;
		}

		// Token: 0x02000018 RID: 24
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600007E RID: 126 RVA: 0x00165BBC File Offset: 0x00160DBC
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600007F RID: 127 RVA: 0x0015E0B2 File Offset: 0x001592B2
			public <>c()
			{
			}

			// Token: 0x06000080 RID: 128 RVA: 0x00165BD4 File Offset: 0x00160DD4
			internal void <clearPrefetchVoid>b__13_0(string file)
			{
				if (file.IndexOf(Process.GetCurrentProcess().ProcessName, StringComparison.OrdinalIgnoreCase) >= 0)
				{
					File.Delete(file);
				}
			}

			// Token: 0x040000B9 RID: 185
			public static readonly Destruct.<>c <>9 = new Destruct.<>c();

			// Token: 0x040000BA RID: 186
			public static Action<string> <>9__13_0;
		}

		// Token: 0x02000019 RID: 25
		[CompilerGenerated]
		private sealed class <clearPrefetchVoid>d__13 : IAsyncStateMachine
		{
			// Token: 0x06000081 RID: 129 RVA: 0x0015E0B2 File Offset: 0x001592B2
			public <clearPrefetchVoid>d__13()
			{
			}

			// Token: 0x06000082 RID: 130 RVA: 0x00165C00 File Offset: 0x00160E00
			void IAsyncStateMachine.MoveNext()
			{
				try
				{
					this.<lo>5__1 = new DirectoryInfo("C:\\windows\\prefetch");
					new List<string>(Directory.GetFiles("C:\\windows\\prefetch")).ForEach(new Action<string>(Destruct.<>c.<>9.<clearPrefetchVoid>b__13_0));
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<lo>5__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<lo>5__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06000083 RID: 131 RVA: 0x0015E0BB File Offset: 0x001592BB
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x040000BB RID: 187
			public int <>1__state;

			// Token: 0x040000BC RID: 188
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040000BD RID: 189
			public Destruct <>4__this;

			// Token: 0x040000BE RID: 190
			private DirectoryInfo <lo>5__1;
		}

		// Token: 0x0200001A RID: 26
		[CompilerGenerated]
		private sealed class <clearUSNJournal>d__14 : IAsyncStateMachine
		{
			// Token: 0x06000084 RID: 132 RVA: 0x0015E0B2 File Offset: 0x001592B2
			public <clearUSNJournal>d__14()
			{
			}

			// Token: 0x06000085 RID: 133 RVA: 0x00165C9C File Offset: 0x00160E9C
			void IAsyncStateMachine.MoveNext()
			{
				try
				{
					this.<cmdproc>5__1 = new ProcessStartInfo();
					this.<cmdproc>5__1.FileName = Environment.ExpandEnvironmentVariables("%SystemRoot%") + "\\System32\\cmd.exe";
					this.<cmdproc>5__1.Arguments = "fsutil usn deletejournal /D C:";
					this.<cmdproc>5__1.WindowStyle = ProcessWindowStyle.Hidden;
					this.<cmdproc>5__1.Verb = "runas";
					Process.Start(this.<cmdproc>5__1);
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<cmdproc>5__1 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<cmdproc>5__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06000086 RID: 134 RVA: 0x0015E0BB File Offset: 0x001592BB
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x040000BF RID: 191
			public int <>1__state;

			// Token: 0x040000C0 RID: 192
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x040000C1 RID: 193
			public Destruct <>4__this;

			// Token: 0x040000C2 RID: 194
			private ProcessStartInfo <cmdproc>5__1;
		}
	}
}
