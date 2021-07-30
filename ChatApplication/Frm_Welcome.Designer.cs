
namespace ChatApplication
{
    partial class Frm_Welcome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Welcome));
            this.Elp_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Drg_Border = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Pnl_Border = new System.Windows.Forms.Panel();
            this.Pb_Minimize = new System.Windows.Forms.PictureBox();
            this.Pb_Close = new System.Windows.Forms.PictureBox();
            this.Pnl_Main = new System.Windows.Forms.Panel();
            this.Pnl_Bottom = new System.Windows.Forms.Panel();
            this.Pnl_Middle = new System.Windows.Forms.Panel();
            this.Pnl_Top = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Pb_Telegram = new System.Windows.Forms.PictureBox();
            this.Pnl_Border.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Close)).BeginInit();
            this.Pnl_Main.SuspendLayout();
            this.Pnl_Bottom.SuspendLayout();
            this.Pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Telegram)).BeginInit();
            this.SuspendLayout();
            // 
            // Elp_Form
            // 
            this.Elp_Form.ElipseRadius = 30;
            this.Elp_Form.TargetControl = this;
            // 
            // Drg_Border
            // 
            this.Drg_Border.Fixed = true;
            this.Drg_Border.Horizontal = true;
            this.Drg_Border.TargetControl = this.Pnl_Border;
            this.Drg_Border.Vertical = true;
            // 
            // Pnl_Border
            // 
            this.Pnl_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.Pnl_Border.Controls.Add(this.Pb_Minimize);
            this.Pnl_Border.Controls.Add(this.Pb_Close);
            this.Pnl_Border.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Border.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Border.Name = "Pnl_Border";
            this.Pnl_Border.Size = new System.Drawing.Size(1500, 30);
            this.Pnl_Border.TabIndex = 0;
            // 
            // Pb_Minimize
            // 
            this.Pb_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Pb_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Pb_Minimize.Image")));
            this.Pb_Minimize.Location = new System.Drawing.Point(1452, 7);
            this.Pb_Minimize.Name = "Pb_Minimize";
            this.Pb_Minimize.Size = new System.Drawing.Size(15, 15);
            this.Pb_Minimize.TabIndex = 0;
            this.Pb_Minimize.TabStop = false;
            this.Pb_Minimize.Click += new System.EventHandler(this.Pb_Minimize_Click);
            // 
            // Pb_Close
            // 
            this.Pb_Close.BackColor = System.Drawing.Color.Transparent;
            this.Pb_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb_Close.Image = ((System.Drawing.Image)(resources.GetObject("Pb_Close.Image")));
            this.Pb_Close.Location = new System.Drawing.Point(1473, 7);
            this.Pb_Close.Name = "Pb_Close";
            this.Pb_Close.Size = new System.Drawing.Size(15, 15);
            this.Pb_Close.TabIndex = 0;
            this.Pb_Close.TabStop = false;
            this.Pb_Close.Click += new System.EventHandler(this.Pb_Close_Click);
            // 
            // Pnl_Main
            // 
            this.Pnl_Main.Controls.Add(this.Pnl_Bottom);
            this.Pnl_Main.Controls.Add(this.Pnl_Top);
            this.Pnl_Main.Controls.Add(this.Pnl_Border);
            this.Pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Main.Name = "Pnl_Main";
            this.Pnl_Main.Size = new System.Drawing.Size(1500, 700);
            this.Pnl_Main.TabIndex = 1;
            // 
            // Pnl_Bottom
            // 
            this.Pnl_Bottom.Controls.Add(this.Pnl_Middle);
            this.Pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Bottom.Location = new System.Drawing.Point(0, 230);
            this.Pnl_Bottom.Name = "Pnl_Bottom";
            this.Pnl_Bottom.Size = new System.Drawing.Size(1500, 470);
            this.Pnl_Bottom.TabIndex = 2;
            // 
            // Pnl_Middle
            // 
            this.Pnl_Middle.Location = new System.Drawing.Point(549, 35);
            this.Pnl_Middle.Name = "Pnl_Middle";
            this.Pnl_Middle.Size = new System.Drawing.Size(400, 400);
            this.Pnl_Middle.TabIndex = 0;
            // 
            // Pnl_Top
            // 
            this.Pnl_Top.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pnl_Top.BackgroundImage")));
            this.Pnl_Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pnl_Top.Controls.Add(this.Pb_Telegram);
            this.Pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Top.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Pnl_Top.GradientBottomRight = System.Drawing.Color.Lavender;
            this.Pnl_Top.GradientTopLeft = System.Drawing.Color.Cyan;
            this.Pnl_Top.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Pnl_Top.Location = new System.Drawing.Point(0, 30);
            this.Pnl_Top.Name = "Pnl_Top";
            this.Pnl_Top.Quality = 10;
            this.Pnl_Top.Size = new System.Drawing.Size(1500, 200);
            this.Pnl_Top.TabIndex = 1;
            // 
            // Pb_Telegram
            // 
            this.Pb_Telegram.BackColor = System.Drawing.Color.Transparent;
            this.Pb_Telegram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pb_Telegram.BackgroundImage")));
            this.Pb_Telegram.Location = new System.Drawing.Point(686, 36);
            this.Pb_Telegram.Name = "Pb_Telegram";
            this.Pb_Telegram.Size = new System.Drawing.Size(128, 128);
            this.Pb_Telegram.TabIndex = 0;
            this.Pb_Telegram.TabStop = false;
            // 
            // Frm_Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 700);
            this.Controls.Add(this.Pnl_Main);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Welcome";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.Frm_Welcome_Shown);
            this.VisibleChanged += new System.EventHandler(this.Frm_Welcome_VisibleChanged);
            this.Pnl_Border.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Close)).EndInit();
            this.Pnl_Main.ResumeLayout(false);
            this.Pnl_Bottom.ResumeLayout(false);
            this.Pnl_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Telegram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elp_Form;
        private System.Windows.Forms.Panel Pnl_Main;
        private System.Windows.Forms.Panel Pnl_Bottom;
        private Bunifu.Framework.UI.BunifuGradientPanel Pnl_Top;
        private System.Windows.Forms.PictureBox Pb_Telegram;
        private System.Windows.Forms.Panel Pnl_Border;
        private System.Windows.Forms.PictureBox Pb_Minimize;
        private System.Windows.Forms.PictureBox Pb_Close;
        private Bunifu.Framework.UI.BunifuDragControl Drg_Border;
        private System.Windows.Forms.Panel Pnl_Middle;
    }
}

