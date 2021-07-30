
namespace ChatApplication
{
    partial class Frm_RemoveMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RemoveMember));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.Elp_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Pnl_Main = new System.Windows.Forms.Panel();
            this.Pnl_Middle = new System.Windows.Forms.Panel();
            this.Pnl_Bottom = new System.Windows.Forms.Panel();
            this.Btn_Cancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Pnl_Top = new System.Windows.Forms.Panel();
            this.Lbl_Title = new Bunifu.UI.WinForms.BunifuLabel();
            this.Pnl_Main.SuspendLayout();
            this.Pnl_Bottom.SuspendLayout();
            this.Pnl_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elp_Form
            // 
            this.Elp_Form.ElipseRadius = 30;
            this.Elp_Form.TargetControl = this;
            // 
            // Pnl_Main
            // 
            this.Pnl_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.Pnl_Main.Controls.Add(this.Pnl_Middle);
            this.Pnl_Main.Controls.Add(this.Pnl_Bottom);
            this.Pnl_Main.Controls.Add(this.Pnl_Top);
            this.Pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Main.Name = "Pnl_Main";
            this.Pnl_Main.Size = new System.Drawing.Size(400, 500);
            this.Pnl_Main.TabIndex = 1;
            // 
            // Pnl_Middle
            // 
            this.Pnl_Middle.AutoScroll = true;
            this.Pnl_Middle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Middle.Location = new System.Drawing.Point(0, 66);
            this.Pnl_Middle.Name = "Pnl_Middle";
            this.Pnl_Middle.Size = new System.Drawing.Size(400, 377);
            this.Pnl_Middle.TabIndex = 6;
            // 
            // Pnl_Bottom
            // 
            this.Pnl_Bottom.Controls.Add(this.Btn_Cancel);
            this.Pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_Bottom.Location = new System.Drawing.Point(0, 443);
            this.Pnl_Bottom.Name = "Pnl_Bottom";
            this.Pnl_Bottom.Size = new System.Drawing.Size(400, 57);
            this.Pnl_Bottom.TabIndex = 5;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.AllowToggling = false;
            this.Btn_Cancel.AnimationSpeed = 200;
            this.Btn_Cancel.AutoGenerateColors = false;
            this.Btn_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Cancel.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.Btn_Cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Cancel.BackgroundImage")));
            this.Btn_Cancel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Cancel.ButtonText = "Cancel";
            this.Btn_Cancel.ButtonTextMarginLeft = 0;
            this.Btn_Cancel.ColorContrastOnClick = 45;
            this.Btn_Cancel.ColorContrastOnHover = 45;
            this.Btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Btn_Cancel.CustomizableEdges = borderEdges1;
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Cancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Btn_Cancel.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Btn_Cancel.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Btn_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Cancel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Btn_Cancel.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.Btn_Cancel.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cancel.IconMarginLeft = 11;
            this.Btn_Cancel.IconPadding = 10;
            this.Btn_Cancel.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cancel.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Cancel.IdleBorderRadius = 3;
            this.Btn_Cancel.IdleBorderThickness = 1;
            this.Btn_Cancel.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Cancel.IdleIconLeftImage = null;
            this.Btn_Cancel.IdleIconRightImage = null;
            this.Btn_Cancel.IndicateFocus = false;
            this.Btn_Cancel.Location = new System.Drawing.Point(0, 0);
            this.Btn_Cancel.Name = "Btn_Cancel";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.Btn_Cancel.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.Btn_Cancel.OnPressedState = stateProperties2;
            this.Btn_Cancel.Size = new System.Drawing.Size(400, 57);
            this.Btn_Cancel.TabIndex = 8;
            this.Btn_Cancel.TabStop = false;
            this.Btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Cancel.TextMarginLeft = 0;
            this.Btn_Cancel.UseDefaultRadiusAndThickness = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Pnl_Top
            // 
            this.Pnl_Top.Controls.Add(this.Lbl_Title);
            this.Pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Top.Name = "Pnl_Top";
            this.Pnl_Top.Size = new System.Drawing.Size(400, 66);
            this.Pnl_Top.TabIndex = 2;
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoEllipsis = false;
            this.Lbl_Title.CursorType = null;
            this.Lbl_Title.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.Location = new System.Drawing.Point(15, 22);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_Title.Size = new System.Drawing.Size(338, 22);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "Please choose the contact that you want to remove";
            this.Lbl_Title.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Lbl_Title.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Frm_RemoveMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.Pnl_Main);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_RemoveMember";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Pnl_Main.ResumeLayout(false);
            this.Pnl_Bottom.ResumeLayout(false);
            this.Pnl_Top.ResumeLayout(false);
            this.Pnl_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elp_Form;
        private System.Windows.Forms.Panel Pnl_Main;
        private System.Windows.Forms.Panel Pnl_Middle;
        private System.Windows.Forms.Panel Pnl_Bottom;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Btn_Cancel;
        private System.Windows.Forms.Panel Pnl_Top;
        private Bunifu.UI.WinForms.BunifuLabel Lbl_Title;
    }
}