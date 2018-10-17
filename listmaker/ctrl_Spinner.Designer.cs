namespace listmaker
{
	partial class ctrl_Spinner
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_Up = new System.Windows.Forms.Button();
			this.btn_Down = new System.Windows.Forms.Button();
			this.tb_Text = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btn_Up
			// 
			this.btn_Up.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btn_Up.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Up.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_Up.FlatAppearance.BorderSize = 0;
			this.btn_Up.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btn_Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Up.Image = global::listmaker.Properties.Resources._up;
			this.btn_Up.Location = new System.Drawing.Point(0, 0);
			this.btn_Up.Name = "btn_Up";
			this.btn_Up.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Up.Size = new System.Drawing.Size(20, 10);
			this.btn_Up.TabIndex = 0;
			this.btn_Up.UseVisualStyleBackColor = false;
			this.btn_Up.Click += new System.EventHandler(this.btn_Up_Click);
			// 
			// btn_Down
			// 
			this.btn_Down.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btn_Down.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Down.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btn_Down.FlatAppearance.BorderSize = 0;
			this.btn_Down.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btn_Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Down.Image = global::listmaker.Properties.Resources._down;
			this.btn_Down.Location = new System.Drawing.Point(0, 30);
			this.btn_Down.Name = "btn_Down";
			this.btn_Down.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Down.Size = new System.Drawing.Size(20, 10);
			this.btn_Down.TabIndex = 1;
			this.btn_Down.UseVisualStyleBackColor = false;
			this.btn_Down.Click += new System.EventHandler(this.btn_Down_Click);
			// 
			// tb_Text
			// 
			this.tb_Text.BackColor = System.Drawing.Color.White;
			this.tb_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tb_Text.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tb_Text.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tb_Text.Location = new System.Drawing.Point(0, 10);
			this.tb_Text.MaxLength = 1;
			this.tb_Text.Multiline = true;
			this.tb_Text.Name = "tb_Text";
			this.tb_Text.ReadOnly = true;
			this.tb_Text.Size = new System.Drawing.Size(20, 20);
			this.tb_Text.TabIndex = 2;
			this.tb_Text.Text = "A";
			this.tb_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tb_Text.MouseEnter += new System.EventHandler(this.tb_Text_MouseEnter);
			this.tb_Text.MouseLeave += new System.EventHandler(this.tb_Text_MouseLeave);
			// 
			// ctrl_Spinner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Chartreuse;
			this.Controls.Add(this.tb_Text);
			this.Controls.Add(this.btn_Down);
			this.Controls.Add(this.btn_Up);
			this.Name = "ctrl_Spinner";
			this.Size = new System.Drawing.Size(20, 40);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Up;
		private System.Windows.Forms.Button btn_Down;
		private System.Windows.Forms.TextBox tb_Text;
	}
}
