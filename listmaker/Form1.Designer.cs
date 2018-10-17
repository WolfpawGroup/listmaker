namespace listmaker
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ctrl_From_1 = new listmaker.ctrl_Spinner();
			this.ctrl_To_5 = new listmaker.ctrl_Spinner();
			this.ctrl_To_4 = new listmaker.ctrl_Spinner();
			this.ctrl_To_3 = new listmaker.ctrl_Spinner();
			this.ctrl_To_2 = new listmaker.ctrl_Spinner();
			this.ctrl_To_1 = new listmaker.ctrl_Spinner();
			this.ctrl_To_0 = new listmaker.ctrl_Spinner();
			this.ctrl_From_5 = new listmaker.ctrl_Spinner();
			this.ctrl_From_4 = new listmaker.ctrl_Spinner();
			this.ctrl_From_3 = new listmaker.ctrl_Spinner();
			this.ctrl_From_2 = new listmaker.ctrl_Spinner();
			this.ctrl_From_0 = new listmaker.ctrl_Spinner();
			this.num_MaxLength = new System.Windows.Forms.NumericUpDown();
			this.btn_Start = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lv_List = new System.Windows.Forms.ListView();
			((System.ComponentModel.ISupportInitialize)(this.num_MaxLength)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "From: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "To: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Max: ";
			// 
			// ctrl_From_1
			// 
			this.ctrl_From_1.BackColor = System.Drawing.Color.Chartreuse;
			this.ctrl_From_1.CurrentCharC = 'A';
			this.ctrl_From_1.CurrentCharI = 65;
			this.ctrl_From_1.Location = new System.Drawing.Point(74, 12);
			this.ctrl_From_1.Mode = listmaker.mode.ALPHA;
			this.ctrl_From_1.Name = "ctrl_From_1";
			this.ctrl_From_1.Size = new System.Drawing.Size(20, 40);
			this.ctrl_From_1.TabIndex = 27;
			// 
			// ctrl_To_5
			// 
			this.ctrl_To_5.BackColor = System.Drawing.Color.Chartreuse;
			this.ctrl_To_5.CurrentCharC = '0';
			this.ctrl_To_5.CurrentCharI = 48;
			this.ctrl_To_5.Location = new System.Drawing.Point(154, 62);
			this.ctrl_To_5.Mode = listmaker.mode.NUMERIC;
			this.ctrl_To_5.Name = "ctrl_To_5";
			this.ctrl_To_5.Size = new System.Drawing.Size(20, 40);
			this.ctrl_To_5.TabIndex = 26;
			// 
			// ctrl_To_4
			// 
			this.ctrl_To_4.BackColor = System.Drawing.Color.Chartreuse;
			this.ctrl_To_4.CurrentCharC = '0';
			this.ctrl_To_4.CurrentCharI = 48;
			this.ctrl_To_4.Location = new System.Drawing.Point(134, 62);
			this.ctrl_To_4.Mode = listmaker.mode.NUMERIC;
			this.ctrl_To_4.Name = "ctrl_To_4";
			this.ctrl_To_4.Size = new System.Drawing.Size(20, 40);
			this.ctrl_To_4.TabIndex = 25;
			// 
			// ctrl_To_3
			// 
			this.ctrl_To_3.BackColor = System.Drawing.Color.Chartreuse;
			this.ctrl_To_3.CurrentCharC = '0';
			this.ctrl_To_3.CurrentCharI = 48;
			this.ctrl_To_3.Location = new System.Drawing.Point(114, 62);
			this.ctrl_To_3.Mode = listmaker.mode.NUMERIC;
			this.ctrl_To_3.Name = "ctrl_To_3";
			this.ctrl_To_3.Size = new System.Drawing.Size(20, 40);
			this.ctrl_To_3.TabIndex = 24;
			// 
			// ctrl_To_2
			// 
			this.ctrl_To_2.BackColor = System.Drawing.Color.Chartreuse;
			this.ctrl_To_2.CurrentCharC = '0';
			this.ctrl_To_2.CurrentCharI = 48;
			this.ctrl_To_2.Location = new System.Drawing.Point(94, 62);
			this.ctrl_To_2.Mode = listmaker.mode.NUMERIC;
			this.ctrl_To_2.Name = "ctrl_To_2";
			this.ctrl_To_2.Size = new System.Drawing.Size(20, 40);
			this.ctrl_To_2.TabIndex = 23;
			// 
			// ctrl_To_1
			// 
			this.ctrl_To_1.BackColor = System.Drawing.Color.Chartreuse;
			this.ctrl_To_1.CurrentCharC = 'A';
			this.ctrl_To_1.CurrentCharI = 65;
			this.ctrl_To_1.Location = new System.Drawing.Point(74, 62);
			this.ctrl_To_1.Mode = listmaker.mode.ALPHA;
			this.ctrl_To_1.Name = "ctrl_To_1";
			this.ctrl_To_1.Size = new System.Drawing.Size(20, 40);
			this.ctrl_To_1.TabIndex = 22;
			// 
			// ctrl_To_0
			// 
			this.ctrl_To_0.BackColor = System.Drawing.Color.Chartreuse;
			this.ctrl_To_0.CurrentCharC = '0';
			this.ctrl_To_0.CurrentCharI = 48;
			this.ctrl_To_0.Location = new System.Drawing.Point(54, 62);
			this.ctrl_To_0.Mode = listmaker.mode.NUMERIC;
			this.ctrl_To_0.Name = "ctrl_To_0";
			this.ctrl_To_0.Size = new System.Drawing.Size(20, 40);
			this.ctrl_To_0.TabIndex = 21;
			// 
			// ctrl_From_5
			// 
			this.ctrl_From_5.BackColor = System.Drawing.Color.Chartreuse;
			this.ctrl_From_5.CurrentCharC = '0';
			this.ctrl_From_5.CurrentCharI = 48;
			this.ctrl_From_5.Location = new System.Drawing.Point(154, 12);
			this.ctrl_From_5.Mode = listmaker.mode.NUMERIC;
			this.ctrl_From_5.Name = "ctrl_From_5";
			this.ctrl_From_5.Size = new System.Drawing.Size(20, 40);
			this.ctrl_From_5.TabIndex = 20;
			// 
			// ctrl_From_4
			// 
			this.ctrl_From_4.BackColor = System.Drawing.Color.Chartreuse;
			this.ctrl_From_4.CurrentCharC = '0';
			this.ctrl_From_4.CurrentCharI = 48;
			this.ctrl_From_4.Location = new System.Drawing.Point(134, 12);
			this.ctrl_From_4.Mode = listmaker.mode.NUMERIC;
			this.ctrl_From_4.Name = "ctrl_From_4";
			this.ctrl_From_4.Size = new System.Drawing.Size(20, 40);
			this.ctrl_From_4.TabIndex = 19;
			// 
			// ctrl_From_3
			// 
			this.ctrl_From_3.BackColor = System.Drawing.Color.Chartreuse;
			this.ctrl_From_3.CurrentCharC = '0';
			this.ctrl_From_3.CurrentCharI = 48;
			this.ctrl_From_3.Location = new System.Drawing.Point(114, 12);
			this.ctrl_From_3.Mode = listmaker.mode.NUMERIC;
			this.ctrl_From_3.Name = "ctrl_From_3";
			this.ctrl_From_3.Size = new System.Drawing.Size(20, 40);
			this.ctrl_From_3.TabIndex = 18;
			// 
			// ctrl_From_2
			// 
			this.ctrl_From_2.BackColor = System.Drawing.Color.Chartreuse;
			this.ctrl_From_2.CurrentCharC = '0';
			this.ctrl_From_2.CurrentCharI = 48;
			this.ctrl_From_2.Location = new System.Drawing.Point(94, 12);
			this.ctrl_From_2.Mode = listmaker.mode.NUMERIC;
			this.ctrl_From_2.Name = "ctrl_From_2";
			this.ctrl_From_2.Size = new System.Drawing.Size(20, 40);
			this.ctrl_From_2.TabIndex = 17;
			// 
			// ctrl_From_0
			// 
			this.ctrl_From_0.BackColor = System.Drawing.Color.Chartreuse;
			this.ctrl_From_0.CurrentCharC = '0';
			this.ctrl_From_0.CurrentCharI = 48;
			this.ctrl_From_0.Location = new System.Drawing.Point(54, 12);
			this.ctrl_From_0.Mode = listmaker.mode.ALPHANUMERIC;
			this.ctrl_From_0.Name = "ctrl_From_0";
			this.ctrl_From_0.Size = new System.Drawing.Size(20, 40);
			this.ctrl_From_0.TabIndex = 16;
			// 
			// num_MaxLength
			// 
			this.num_MaxLength.Location = new System.Drawing.Point(54, 126);
			this.num_MaxLength.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
			this.num_MaxLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.num_MaxLength.Name = "num_MaxLength";
			this.num_MaxLength.Size = new System.Drawing.Size(120, 20);
			this.num_MaxLength.TabIndex = 28;
			this.num_MaxLength.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			// 
			// btn_Start
			// 
			this.btn_Start.Location = new System.Drawing.Point(15, 165);
			this.btn_Start.Name = "btn_Start";
			this.btn_Start.Size = new System.Drawing.Size(159, 23);
			this.btn_Start.TabIndex = 29;
			this.btn_Start.Text = "Start";
			this.btn_Start.UseVisualStyleBackColor = true;
			// 
			// btn_Exit
			// 
			this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btn_Exit.Location = new System.Drawing.Point(0, 193);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(312, 23);
			this.btn_Exit.TabIndex = 30;
			this.btn_Exit.Text = "Exit";
			this.btn_Exit.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel1.Location = new System.Drawing.Point(180, -25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(4, 249);
			this.panel1.TabIndex = 31;
			// 
			// lv_List
			// 
			this.lv_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lv_List.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lv_List.Location = new System.Drawing.Point(190, 5);
			this.lv_List.Name = "lv_List";
			this.lv_List.Size = new System.Drawing.Size(122, 183);
			this.lv_List.TabIndex = 32;
			this.lv_List.UseCompatibleStateImageBehavior = false;
			this.lv_List.View = System.Windows.Forms.View.List;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(312, 216);
			this.Controls.Add(this.lv_List);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.btn_Start);
			this.Controls.Add(this.num_MaxLength);
			this.Controls.Add(this.ctrl_From_1);
			this.Controls.Add(this.ctrl_To_5);
			this.Controls.Add(this.ctrl_To_4);
			this.Controls.Add(this.ctrl_To_3);
			this.Controls.Add(this.ctrl_To_2);
			this.Controls.Add(this.ctrl_To_1);
			this.Controls.Add(this.ctrl_To_0);
			this.Controls.Add(this.ctrl_From_5);
			this.Controls.Add(this.ctrl_From_4);
			this.Controls.Add(this.ctrl_From_3);
			this.Controls.Add(this.ctrl_From_2);
			this.Controls.Add(this.ctrl_From_0);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.num_MaxLength)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private ctrl_Spinner ctrl_From_1;
		private ctrl_Spinner ctrl_To_5;
		private ctrl_Spinner ctrl_To_4;
		private ctrl_Spinner ctrl_To_3;
		private ctrl_Spinner ctrl_To_2;
		private ctrl_Spinner ctrl_To_1;
		private ctrl_Spinner ctrl_To_0;
		private ctrl_Spinner ctrl_From_5;
		private ctrl_Spinner ctrl_From_4;
		private ctrl_Spinner ctrl_From_3;
		private ctrl_Spinner ctrl_From_2;
		private ctrl_Spinner ctrl_From_0;
		private System.Windows.Forms.NumericUpDown num_MaxLength;
		private System.Windows.Forms.Button btn_Start;
		private System.Windows.Forms.Button btn_Exit;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListView lv_List;
	}
}

