using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Colorful;
using Memory;

namespace Axenta.Modules.Combat
{
	// Token: 0x02000029 RID: 41
	internal class Velocity
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x00168488 File Offset: 0x00163688
		
		public void scan(bool destructing)
		{
			Velocity.<scan>d__6 <scan>d__ = new Velocity.<scan>d__6();
			<scan>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<scan>d__.<>4__this = this;
			<scan>d__.destructing = destructing;
			<scan>d__.<>1__state = -1;
			<scan>d__.<>t__builder.Start<Velocity.<scan>d__6>(ref <scan>d__);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x001684C8 File Offset: 0x001636C8
		
		public void write(bool enabled, double writeval, bool isDestructing)
		{
			Velocity.<write>d__7 <write>d__ = new Velocity.<write>d__7();
			<write>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<write>d__.<>4__this = this;
			<write>d__.enabled = enabled;
			<write>d__.writeval = writeval;
			<write>d__.isDestructing = isDestructing;
			<write>d__.<>1__state = -1;
			<write>d__.<>t__builder.Start<Velocity.<write>d__7>(ref <write>d__);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00168518 File Offset: 0x00163718
		public Velocity()
		{
		}

		// Token: 0x04000131 RID: 305
		public Mem M = new Mem();

		// Token: 0x04000132 RID: 306
		private string arrayVelocity = "00 00 00 00 00 40 BF 40";

		// Token: 0x04000133 RID: 307
		private bool isScanning = false;

		// Token: 0x04000134 RID: 308
		private IEnumerable<long> aVelocity;

		// Token: 0x04000135 RID: 309
		private List<long> lVelocity = new List<long>();

		// Token: 0x04000136 RID: 310
		private List<string> lastWrittedValues = new List<string>();

		// Token: 0x0200002A RID: 42
		[CompilerGenerated]
		private sealed class <scan>d__6 : IAsyncStateMachine
		{
			// Token: 0x060000B7 RID: 183 RVA: 0x0015E0B2 File Offset: 0x001592B2
			public <scan>d__6()
			{
			}

			// Token: 0x060000B8 RID: 184 RVA: 0x00168560 File Offset: 0x00163760
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					TaskAwaiter<IEnumerable<long>> awaiter;
					if (num != 0)
					{
						if (this.destructing)
						{
							goto IL_189;
						}
						this.<>4__this.M.OpenProcess("javaw");
						awaiter = this.<>4__this.M.AoBScan(33554432L, 1490038176L, this.<>4__this.arrayVelocity, true, true, "").GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.<>1__state = num2;
							this.<>u__1 = awaiter;
							Velocity.<scan>d__6 <scan>d__ = this;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<long>>, Velocity.<scan>d__6>(ref awaiter, ref <scan>d__);
							return;
						}
					}
					else
					{
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter<IEnumerable<long>>);
						int num3 = -1;
						num = -1;
						this.<>1__state = num3;
					}
					this.<>s__2 = awaiter.GetResult();
					this.<>4__this.aVelocity = this.<>s__2;
					this.<>s__2 = null;
					this.<i>5__1 = 0;
					this.<>s__3 = this.<>4__this.aVelocity.GetEnumerator();
					try
					{
						while (this.<>s__3.MoveNext())
						{
							this.<addr>5__4 = this.<>s__3.Current;
							int num4 = this.<i>5__1;
							this.<i>5__1 = num4 + 1;
							if (!this.<>4__this.lVelocity.Contains(this.<addr>5__4))
							{
								this.<>4__this.lVelocity.Add(this.<addr>5__4);
							}
						}
					}
					finally
					{
						if (num < 0 && this.<>s__3 != null)
						{
							this.<>s__3.Dispose();
						}
					}
					this.<>s__3 = null;
					IL_189:;
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

			// Token: 0x060000B9 RID: 185 RVA: 0x0015E0BB File Offset: 0x001592BB
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000137 RID: 311
			public int <>1__state;

			// Token: 0x04000138 RID: 312
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000139 RID: 313
			public bool destructing;

			// Token: 0x0400013A RID: 314
			public Velocity <>4__this;

			// Token: 0x0400013B RID: 315
			private int <i>5__1;

			// Token: 0x0400013C RID: 316
			private IEnumerable<long> <>s__2;

			// Token: 0x0400013D RID: 317
			private IEnumerator<long> <>s__3;

			// Token: 0x0400013E RID: 318
			private long <addr>5__4;

			// Token: 0x0400013F RID: 319
			private TaskAwaiter<IEnumerable<long>> <>u__1;
		}

		// Token: 0x0200002B RID: 43
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x060000BA RID: 186 RVA: 0x0015E0B2 File Offset: 0x001592B2
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x04000140 RID: 320
			public Velocity <>4__this;

			// Token: 0x04000141 RID: 321
			public double writeval;
		}

		// Token: 0x0200002C RID: 44
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_1
		{
			// Token: 0x060000BB RID: 187 RVA: 0x0015E0B2 File Offset: 0x001592B2
			public <>c__DisplayClass7_1()
			{
			}

			// Token: 0x060000BC RID: 188 RVA: 0x00168758 File Offset: 0x00163958
			internal bool <write>b__0()
			{
				return this.CS$<>8__locals1.<>4__this.M.WriteMemory(this.aVelocity.ToString("X"), "double", this.CS$<>8__locals1.writeval.ToString(), "", null);
			}

			// Token: 0x060000BD RID: 189 RVA: 0x001687A8 File Offset: 0x001639A8
			internal bool <write>b__1()
			{
				return this.CS$<>8__locals1.<>4__this.M.WriteMemory(this.aVelocity.ToString("X"), "double", "8000", "", null);
			}

			// Token: 0x04000142 RID: 322
			public long aVelocity;

			// Token: 0x04000143 RID: 323
			public Velocity.<>c__DisplayClass7_0 CS$<>8__locals1;
		}

		// Token: 0x0200002D RID: 45
		[CompilerGenerated]
		private sealed class <write>d__7 : IAsyncStateMachine
		{
			// Token: 0x060000BE RID: 190 RVA: 0x0015E0B2 File Offset: 0x001592B2
			public <write>d__7()
			{
			}

			// Token: 0x060000BF RID: 191 RVA: 0x001687EC File Offset: 0x001639EC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				try
				{
					if (num > 1)
					{
					}
					this.<>8__1 = new Velocity.<>c__DisplayClass7_0();
					this.<>8__1.<>4__this = this.<>4__this;
					this.<>8__1.writeval = this.writeval;
					this.<velocityList>5__2 = new List<long>();
					this.<>s__3 = this.<>4__this.lVelocity.ToList<long>().GetEnumerator();
					try
					{
						while (this.<>s__3.MoveNext())
						{
							this.<addr>5__4 = this.<>s__3.Current;
							if (!this.<velocityList>5__2.Contains(this.<addr>5__4))
							{
								this.<velocityList>5__2.Add(this.<addr>5__4);
							}
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)this.<>s__3).Dispose();
						}
					}
					this.<>s__3 = default(List<long>.Enumerator);
					Console.WriteLine(this.<>8__1.writeval.ToString());
					if (this.<>4__this.M.OpenProcess("javaw"))
					{
						this.<>s__5 = this.<velocityList>5__2.ToList<long>().GetEnumerator();
						try
						{
							while (num == 0)
							{
							}
							if (num != 1)
							{
								goto IL_2ED;
							}
							TaskAwaiter<bool> awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter<bool>);
							int num2 = -1;
							num = -1;
							this.<>1__state = num2;
							IL_2DD:
							awaiter.GetResult();
							IL_2E5:
							IL_2E6:
							this.<>8__6 = null;
							IL_2ED:
							if (this.<>s__5.MoveNext())
							{
								this.<>8__6 = new Velocity.<>c__DisplayClass7_1();
								this.<>8__6.CS$<>8__locals1 = this.<>8__1;
								this.<>8__6.aVelocity = this.<>s__5.Current;
								this.<velocityVal>5__7 = this.<>4__this.M.ReadDouble(this.<>8__6.aVelocity.ToString("X"), "", true);
								if (!(this.<velocityVal>5__7.ToString() == "8000") && !this.<>4__this.lastWrittedValues.Contains(this.<velocityVal>5__7.ToString("F")))
								{
									goto IL_2E6;
								}
								if (this.enabled && !this.isDestructing)
								{
									TaskAwaiter<bool> awaiter2 = Task.Run<bool>(new Func<bool>(this.<>8__6.<write>b__0)).GetAwaiter();
									if (!awaiter2.IsCompleted)
									{
										int num3 = 0;
										num = 0;
										this.<>1__state = num3;
										this.<>u__1 = awaiter2;
										Velocity.<write>d__7 <write>d__ = this;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Velocity.<write>d__7>(ref awaiter2, ref <write>d__);
										return;
									}
									awaiter2.GetResult();
									bool flag = (this.<>4__this.lastWrittedValues.Contains(this.<>8__6.CS$<>8__locals1.writeval.ToString("F")) ? 1 : 0) == int.MinValue;
									goto IL_2E5;
								}
								else
								{
									awaiter = Task.Run<bool>(new Func<bool>(this.<>8__6.<write>b__1)).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										int num4 = 1;
										num = 1;
										this.<>1__state = num4;
										this.<>u__1 = awaiter;
										Velocity.<write>d__7 <write>d__ = this;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Velocity.<write>d__7>(ref awaiter, ref <write>d__);
										return;
									}
									goto IL_2DD;
								}
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)this.<>s__5).Dispose();
							}
						}
						this.<>s__5 = default(List<long>.Enumerator);
					}
				}
				catch (Exception exception)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<velocityList>5__2 = null;
					this.<>t__builder.SetException(exception);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<velocityList>5__2 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060000C0 RID: 192 RVA: 0x0015E0BB File Offset: 0x001592BB
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000144 RID: 324
			public int <>1__state;

			// Token: 0x04000145 RID: 325
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000146 RID: 326
			public bool enabled;

			// Token: 0x04000147 RID: 327
			public double writeval;

			// Token: 0x04000148 RID: 328
			public bool isDestructing;

			// Token: 0x04000149 RID: 329
			public Velocity <>4__this;

			// Token: 0x0400014A RID: 330
			private Velocity.<>c__DisplayClass7_0 <>8__1;

			// Token: 0x0400014B RID: 331
			private List<long> <velocityList>5__2;

			// Token: 0x0400014C RID: 332
			private List<long>.Enumerator <>s__3;

			// Token: 0x0400014D RID: 333
			private long <addr>5__4;

			// Token: 0x0400014E RID: 334
			private List<long>.Enumerator <>s__5;

			// Token: 0x0400014F RID: 335
			private Velocity.<>c__DisplayClass7_1 <>8__6;

			// Token: 0x04000150 RID: 336
			private double <velocityVal>5__7;

			// Token: 0x04000151 RID: 337
			private TaskAwaiter<bool> <>u__1;
		}
	}
}
