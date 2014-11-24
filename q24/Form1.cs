using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace rightsout
{
	public class Form1 : Form
	{
		private Button[] button;
		private bool[] state = new bool[25];
		private int[] hist = new int[8];
		private IContainer components;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Button button5;
		private Button button6;
		private Button button7;
		private Button button8;
		private Button button9;
		private Button button10;
		private Button button11;
		private Button button12;
		private Button button13;
		private Button button14;
		private Button button15;
		private Button button16;
		private Button button17;
		private Button button18;
		private Button button19;
		private Button button20;
		private Button button21;
		private Button button22;
		private Button button23;
		private Button button24;
		private Button button25;
		public Form1()
		{
			this.InitializeComponent();
			this.button = new Button[]
			{
				this.button1,
				this.button2,
				this.button3,
				this.button4,
				this.button5,
				this.button6,
				this.button7,
				this.button8,
				this.button9,
				this.button10,
				this.button11,
				this.button12,
				this.button13,
				this.button14,
				this.button15,
				this.button16,
				this.button17,
				this.button18,
				this.button19,
				this.button20,
				this.button21,
				this.button22,
				this.button23,
				this.button24,
				this.button25
			};
			for (int i = 0; i < 25; i++)
			{
				this.state[i] = true;
			}
			for (int j = 0; j < 8; j++)
			{
				this.hist[j] = -1;
			}
			this.update();
		}
		private void update()
		{
			for (int i = 0; i < 25; i++)
			{
				if (this.state[i])
				{
					this.button[i].Text = "→";
					this.button[i].BackColor = Color.FromArgb(240, 128, 128);
				}
				else
				{
					this.button[i].Text = "";
					this.button[i].BackColor = Color.FromArgb(100, 110, 120);
				}
			}
		}
		private void push(int p)
		{
			int num = p % 5;
			int num2 = p / 5;
			int[] array = new int[5];
			array[1] = 1;
			array[2] = -1;
			int[] array2 = array;
			int[] array3 = new int[]
			{
				0,
				0,
				0,
				1,
				-1
			};
			for (int i = 0; i < 5; i++)
			{
				int num3 = num + array2[i];
				int num4 = num2 + array3[i];
				if (0 <= num3 && num3 < 5 && 0 <= num4 && num4 < 5)
				{
					this.state[num4 * 5 + num3] = !this.state[num4 * 5 + num3];
				}
			}
		}
		private void check()
		{
			if (Array.IndexOf<bool>(this.state, true) < 0)
			{
				MessageBox.Show("Congratulations!");
				int[] array = new int[]
				{
					1,
					7,
					16,
					11,
					14,
					19,
					20,
					18
				};
				bool flag = true;
				for (int i = 0; i < 8; i++)
				{
					if (this.hist[i] != array[i])
					{
						flag = false;
					}
				}
				if (flag)
				{
					int[] array2 = new int[]
					{
						85,
						111,
						117,
						43,
						104,
						127,
						117,
						117,
						33,
						110,
						99,
						43,
						72,
						95,
						85,
						85,
						94,
						66,
						120,
						98,
						79,
						117,
						68,
						83,
						64,
						94,
						39,
						65,
						73,
						32,
						65,
						72,
						51
					};
					string text = "";
					for (int j = 0; j < array2.Length; j++)
					{
						text += (char)(array2[j] ^ array[j % array.Length]);
					}
					MessageBox.Show(text);
				}
			}
		}
		private void button_Click(object sender, EventArgs e)
		{
			int num = 0;
			for (int i = 0; i < 25; i++)
			{
				if (sender == this.button[i])
				{
					num = i;
				}
			}
			this.push(num);
			for (int j = 0; j < 7; j++)
			{
				this.hist[j] = this.hist[j + 1];
			}
			this.hist[7] = num;
			this.update();
			this.check();
		}
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
			this.button1 = new Button();
			this.button2 = new Button();
			this.button3 = new Button();
			this.button4 = new Button();
			this.button5 = new Button();
			this.button6 = new Button();
			this.button7 = new Button();
			this.button8 = new Button();
			this.button9 = new Button();
			this.button10 = new Button();
			this.button11 = new Button();
			this.button12 = new Button();
			this.button13 = new Button();
			this.button14 = new Button();
			this.button15 = new Button();
			this.button16 = new Button();
			this.button17 = new Button();
			this.button18 = new Button();
			this.button19 = new Button();
			this.button20 = new Button();
			this.button21 = new Button();
			this.button22 = new Button();
			this.button23 = new Button();
			this.button24 = new Button();
			this.button25 = new Button();
			base.SuspendLayout();
			this.button1.BackColor = SystemColors.Control;
			this.button1.Font = new Font("MS UI Gothic", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.button1.Location = new Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new Size(64, 64);
			this.button1.TabIndex = 0;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new EventHandler(this.button_Click);
			this.button2.BackColor = SystemColors.Control;
			this.button2.Font = new Font("MS UI Gothic", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.button2.Location = new Point(82, 12);
			this.button2.Name = "button2";
			this.button2.Size = new Size(64, 64);
			this.button2.TabIndex = 0;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new EventHandler(this.button_Click);
			this.button3.BackColor = SystemColors.Control;
			this.button3.Font = new Font("MS UI Gothic", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.button3.Location = new Point(152, 12);
			this.button3.Name = "button3";
			this.button3.Size = new Size(64, 64);
			this.button3.TabIndex = 0;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new EventHandler(this.button_Click);
			this.button4.BackColor = SystemColors.Control;
			this.button4.Font = new Font("MS UI Gothic", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.button4.Location = new Point(222, 12);
			this.button4.Name = "button4";
			this.button4.Size = new Size(64, 64);
			this.button4.TabIndex = 0;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new EventHandler(this.button_Click);
			this.button5.BackColor = SystemColors.Control;
			this.button5.Font = new Font("MS UI Gothic", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.button5.Location = new Point(292, 12);
			this.button5.Name = "button5";
			this.button5.Size = new Size(64, 64);
			this.button5.TabIndex = 0;
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new EventHandler(this.button_Click);
			this.button6.BackColor = SystemColors.Control;
			this.button6.Font = new Font("MS UI Gothic", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.button6.Location = new Point(12, 82);
			this.button6.Name = "button6";
			this.button6.Size = new Size(64, 64);
			this.button6.TabIndex = 0;
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new EventHandler(this.button_Click);
			this.button7.BackColor = SystemColors.Control;
			this.button7.Font = new Font("MS UI Gothic", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.button7.Location = new Point(82, 82);
			this.button7.Name = "button7";
			this.button7.Size = new Size(64, 64);
			this.button7.TabIndex = 0;
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new EventHandler(this.button_Click);
			this.button8.BackColor = SystemColors.Control;
			this.button8.Font = new Font("MS UI Gothic", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.button8.Location = new Point(152, 82);
			this.button8.Name = "button8";
			this.button8.Size = new Size(64, 64);
			this.button8.TabIndex = 0;
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new EventHandler(this.button_Click);
			this.button9.BackColor = SystemColors.Control;
			this.button9.Font = new Font("MS UI Gothic", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.button9.Location = new Point(222, 82);
			this.button9.Name = "button9";
			this.button9.Size = new Size(64, 64);
			this.button9.TabIndex = 0;
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new EventHandler(this.button_Click);
			this.button10.BackColor = SystemColors.Control;
			this.button10.Font = new Font("MS UI Gothic", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.button10.Location = new Point(292, 82);
			this.button10.Name = "button10";
			this.button10.Size = new Size(64, 64);
			this.button10.TabIndex = 0;
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += new EventHandler(this.button_Click);
			this.button11.BackColor = SystemColors.Control;
			this.button11.Font = new Font("MS UI Gothic", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.button11.Location = new Point(12, 152);
			this.button11.Name = "button11";
			this.button11.Size = new Size(64, 64);
			this.button11.TabIndex = 0;
			this.button11.UseVisualStyleBackColor = false;
			this.button11.Click += new EventHandler(this.button_Click);
			this.button12.BackColor = SystemColors.Control;
			this.button12.Font = new Font("MS UI Gothic", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.button12.Location = new Point(82, 152);
			this.button12.Name = "button12";
			this.button12.Size = new Size(64, 64);
			this.button12.TabIndex = 0;
			this.button12.UseVisualStyleBackColor = false;
			this.button12.Click += new EventHandler(this.button_Click);
			this.button13.BackColor = SystemColors.Control;
			this.button13.Font = new Font("MS UI Gothic", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.button13.Location = new Point(152, 152);
			this.button13.Name = "button13";
			this.button13.Size = new Size(64, 64);
			this.button13.TabIndex = 0;
			this.button13.UseVisualStyleBackColor = false;
			this.button13.Click += new EventHandler(this.button_Click);
			this.button14.BackColor = SystemColors.Control;
			this.button14.Font = new Font("MS UI Gothic", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.button14.Location = new Point(222, 152);
			this.button14.Name = "button14";
			this.button14.Size = new Size(64, 64);
			this.button14.TabIndex = 0;
			this.button14.UseVisualStyleBackColor = false;
			this.button14.Click += new EventHandler(this.button_Click);
			this.button15.BackColor = SystemColors.Control;
			this.button15.Font = new Font("MS UI Gothic", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.button15.Location = new Point(292, 152);
			this.button15.Name = "button15";
			this.button15.Size = new Size(64, 64);
			this.button15.TabIndex = 0;
			this.button15.UseVisualStyleBackColor = false;
			this.button15.Click += new EventHandler(this.button_Click);
			this.button16.BackColor = SystemColors.Control;
			this.button16.Font = new Font("MS UI Gothic", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.button16.Location = new Point(12, 222);
			this.button16.Name = "button16";
			this.button16.Size = new Size(64, 64);
			this.button16.TabIndex = 0;
			this.button16.UseVisualStyleBackColor = false;
			this.button16.Click += new EventHandler(this.button_Click);
			this.button17.BackColor = SystemColors.Control;
			this.button17.Font = new Font("MS UI Gothic", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.button17.Location = new Point(82, 222);
			this.button17.Name = "button17";
			this.button17.Size = new Size(64, 64);
			this.button17.TabIndex = 0;
			this.button17.UseVisualStyleBackColor = false;
			this.button17.Click += new EventHandler(this.button_Click);
			this.button18.BackColor = SystemColors.Control;
			this.button18.Font = new Font("MS UI Gothic", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.button18.Location = new Point(152, 222);
			this.button18.Name = "button18";
			this.button18.Size = new Size(64, 64);
			this.button18.TabIndex = 0;
			this.button18.UseVisualStyleBackColor = false;
			this.button18.Click += new EventHandler(this.button_Click);
			this.button19.BackColor = SystemColors.Control;
			this.button19.Font = new Font("MS UI Gothic", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.button19.Location = new Point(222, 222);
			this.button19.Name = "button19";
			this.button19.Size = new Size(64, 64);
			this.button19.TabIndex = 0;
			this.button19.UseVisualStyleBackColor = false;
			this.button19.Click += new EventHandler(this.button_Click);
			this.button20.BackColor = SystemColors.Control;
			this.button20.Font = new Font("MS UI Gothic", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.button20.Location = new Point(292, 222);
			this.button20.Name = "button20";
			this.button20.Size = new Size(64, 64);
			this.button20.TabIndex = 0;
			this.button20.UseVisualStyleBackColor = false;
			this.button20.Click += new EventHandler(this.button_Click);
			this.button21.BackColor = SystemColors.Control;
			this.button21.Font = new Font("MS UI Gothic", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.button21.Location = new Point(12, 292);
			this.button21.Name = "button21";
			this.button21.Size = new Size(64, 64);
			this.button21.TabIndex = 0;
			this.button21.UseVisualStyleBackColor = false;
			this.button21.Click += new EventHandler(this.button_Click);
			this.button22.BackColor = SystemColors.Control;
			this.button22.Font = new Font("MS UI Gothic", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.button22.Location = new Point(82, 292);
			this.button22.Name = "button22";
			this.button22.Size = new Size(64, 64);
			this.button22.TabIndex = 0;
			this.button22.UseVisualStyleBackColor = false;
			this.button22.Click += new EventHandler(this.button_Click);
			this.button23.BackColor = SystemColors.Control;
			this.button23.Font = new Font("MS UI Gothic", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.button23.Location = new Point(152, 292);
			this.button23.Name = "button23";
			this.button23.Size = new Size(64, 64);
			this.button23.TabIndex = 0;
			this.button23.UseVisualStyleBackColor = false;
			this.button23.Click += new EventHandler(this.button_Click);
			this.button24.BackColor = SystemColors.Control;
			this.button24.Font = new Font("MS UI Gothic", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.button24.Location = new Point(222, 292);
			this.button24.Name = "button24";
			this.button24.Size = new Size(64, 64);
			this.button24.TabIndex = 0;
			this.button24.UseVisualStyleBackColor = false;
			this.button24.Click += new EventHandler(this.button_Click);
			this.button25.BackColor = SystemColors.Control;
			this.button25.Font = new Font("MS UI Gothic", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.button25.Location = new Point(292, 292);
			this.button25.Name = "button25";
			this.button25.Size = new Size(64, 64);
			this.button25.TabIndex = 0;
			this.button25.UseVisualStyleBackColor = false;
			this.button25.Click += new EventHandler(this.button_Click);
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(373, 369);
			base.Controls.Add(this.button25);
			base.Controls.Add(this.button24);
			base.Controls.Add(this.button23);
			base.Controls.Add(this.button22);
			base.Controls.Add(this.button21);
			base.Controls.Add(this.button20);
			base.Controls.Add(this.button19);
			base.Controls.Add(this.button18);
			base.Controls.Add(this.button17);
			base.Controls.Add(this.button16);
			base.Controls.Add(this.button15);
			base.Controls.Add(this.button14);
			base.Controls.Add(this.button13);
			base.Controls.Add(this.button12);
			base.Controls.Add(this.button11);
			base.Controls.Add(this.button10);
			base.Controls.Add(this.button9);
			base.Controls.Add(this.button8);
			base.Controls.Add(this.button7);
			base.Controls.Add(this.button6);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.MaximizeBox = false;
			base.Name = "Form1";
			this.Text = "Rights out";
			base.ResumeLayout(false);
		}
	}
}
