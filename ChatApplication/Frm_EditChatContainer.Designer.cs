
namespace ChatApplication
{
    partial class Frm_EditChatContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EditChatContainer));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.Elp_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Pnl_Main = new System.Windows.Forms.Panel();
            this.Lbl_ErrorFill = new Bunifu.UI.WinForms.BunifuLabel();
            this.Btn_Cancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Btn_Edit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Txt_Name = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.Pb_Image = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.Lbl_Title = new Bunifu.UI.WinForms.BunifuLabel();
            this.Pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Image)).BeginInit();
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
            this.Pnl_Main.Controls.Add(this.Lbl_ErrorFill);
            this.Pnl_Main.Controls.Add(this.Btn_Cancel);
            this.Pnl_Main.Controls.Add(this.Btn_Edit);
            this.Pnl_Main.Controls.Add(this.Txt_Name);
            this.Pnl_Main.Controls.Add(this.Pb_Image);
            this.Pnl_Main.Controls.Add(this.Lbl_Title);
            this.Pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Main.Name = "Pnl_Main";
            this.Pnl_Main.Size = new System.Drawing.Size(400, 400);
            this.Pnl_Main.TabIndex = 2;
            // 
            // Lbl_ErrorFill
            // 
            this.Lbl_ErrorFill.AutoEllipsis = false;
            this.Lbl_ErrorFill.CursorType = null;
            this.Lbl_ErrorFill.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.Lbl_ErrorFill.Location = new System.Drawing.Point(107, 360);
            this.Lbl_ErrorFill.Name = "Lbl_ErrorFill";
            this.Lbl_ErrorFill.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_ErrorFill.Size = new System.Drawing.Size(178, 19);
            this.Lbl_ErrorFill.TabIndex = 9;
            this.Lbl_ErrorFill.Text = "Please fill all of the information";
            this.Lbl_ErrorFill.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Lbl_ErrorFill.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.Lbl_ErrorFill.Visible = false;
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
            this.Btn_Cancel.DisabledBorderColor = System.Drawing.Color.Empty;
            this.Btn_Cancel.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Btn_Cancel.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Btn_Cancel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Btn_Cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
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
            this.Btn_Cancel.Location = new System.Drawing.Point(230, 303);
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
            this.Btn_Cancel.Size = new System.Drawing.Size(115, 45);
            this.Btn_Cancel.TabIndex = 4;
            this.Btn_Cancel.TabStop = false;
            this.Btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Cancel.TextMarginLeft = 0;
            this.Btn_Cancel.UseDefaultRadiusAndThickness = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.AllowToggling = false;
            this.Btn_Edit.AnimationSpeed = 200;
            this.Btn_Edit.AutoGenerateColors = false;
            this.Btn_Edit.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Edit.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.Btn_Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Edit.BackgroundImage")));
            this.Btn_Edit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Edit.ButtonText = "Edit";
            this.Btn_Edit.ButtonTextMarginLeft = 0;
            this.Btn_Edit.ColorContrastOnClick = 45;
            this.Btn_Edit.ColorContrastOnHover = 45;
            this.Btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.Btn_Edit.CustomizableEdges = borderEdges2;
            this.Btn_Edit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Edit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Btn_Edit.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Btn_Edit.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Btn_Edit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Btn_Edit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.Btn_Edit.ForeColor = System.Drawing.Color.White;
            this.Btn_Edit.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Edit.IconMarginLeft = 11;
            this.Btn_Edit.IconPadding = 10;
            this.Btn_Edit.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Edit.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Edit.IdleBorderRadius = 3;
            this.Btn_Edit.IdleBorderThickness = 1;
            this.Btn_Edit.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Edit.IdleIconLeftImage = null;
            this.Btn_Edit.IdleIconRightImage = null;
            this.Btn_Edit.IndicateFocus = false;
            this.Btn_Edit.Location = new System.Drawing.Point(47, 303);
            this.Btn_Edit.Name = "Btn_Edit";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.BorderRadius = 3;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.Btn_Edit.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 3;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.Btn_Edit.OnPressedState = stateProperties4;
            this.Btn_Edit.Size = new System.Drawing.Size(115, 45);
            this.Btn_Edit.TabIndex = 3;
            this.Btn_Edit.TabStop = false;
            this.Btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Edit.TextMarginLeft = 0;
            this.Btn_Edit.UseDefaultRadiusAndThickness = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Txt_Name
            // 
            this.Txt_Name.AcceptsReturn = false;
            this.Txt_Name.AcceptsTab = false;
            this.Txt_Name.AnimationSpeed = 200;
            this.Txt_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Txt_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Txt_Name.BackColor = System.Drawing.Color.White;
            this.Txt_Name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Txt_Name.BackgroundImage")));
            this.Txt_Name.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.Txt_Name.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Txt_Name.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Txt_Name.BorderColorIdle = System.Drawing.Color.Silver;
            this.Txt_Name.BorderRadius = 1;
            this.Txt_Name.BorderThickness = 1;
            this.Txt_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Name.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.Txt_Name.DefaultText = "";
            this.Txt_Name.FillColor = System.Drawing.Color.White;
            this.Txt_Name.HideSelection = true;
            this.Txt_Name.IconLeft = null;
            this.Txt_Name.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Name.IconPadding = 10;
            this.Txt_Name.IconRight = null;
            this.Txt_Name.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Name.Lines = new string[0];
            this.Txt_Name.Location = new System.Drawing.Point(47, 200);
            this.Txt_Name.MaxLength = 32767;
            this.Txt_Name.MinimumSize = new System.Drawing.Size(100, 35);
            this.Txt_Name.Modified = false;
            this.Txt_Name.Multiline = false;
            this.Txt_Name.Name = "Txt_Name";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Txt_Name.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Txt_Name.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Txt_Name.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Txt_Name.OnIdleState = stateProperties8;
            this.Txt_Name.PasswordChar = '\0';
            this.Txt_Name.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Txt_Name.PlaceholderText = "Name";
            this.Txt_Name.ReadOnly = false;
            this.Txt_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Name.SelectedText = "";
            this.Txt_Name.SelectionLength = 0;
            this.Txt_Name.SelectionStart = 0;
            this.Txt_Name.ShortcutsEnabled = true;
            this.Txt_Name.Size = new System.Drawing.Size(298, 35);
            this.Txt_Name.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.Txt_Name.TabIndex = 1;
            this.Txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txt_Name.TextMarginBottom = 0;
            this.Txt_Name.TextMarginLeft = 5;
            this.Txt_Name.TextMarginTop = 0;
            this.Txt_Name.TextPlaceholder = "Name";
            this.Txt_Name.UseSystemPasswordChar = false;
            this.Txt_Name.WordWrap = true;
            this.Txt_Name.TextChange += new System.EventHandler(this.Txt_Name_TextChange);
            // 
            // Pb_Image
            // 
            this.Pb_Image.AllowFocused = false;
            this.Pb_Image.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pb_Image.BorderRadius = 32;
            this.Pb_Image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb_Image.Image = ((System.Drawing.Image)(resources.GetObject("Pb_Image.Image")));
            this.Pb_Image.IsCircle = false;
            this.Pb_Image.Location = new System.Drawing.Point(168, 83);
            this.Pb_Image.Name = "Pb_Image";
            this.Pb_Image.Size = new System.Drawing.Size(64, 64);
            this.Pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_Image.TabIndex = 1;
            this.Pb_Image.TabStop = false;
            this.Pb_Image.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            this.Pb_Image.Click += new System.EventHandler(this.Pb_Image_Click);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoEllipsis = false;
            this.Lbl_Title.CursorType = null;
            this.Lbl_Title.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.Location = new System.Drawing.Point(45, 35);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_Title.Size = new System.Drawing.Size(177, 22);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "Please edit the information";
            this.Lbl_Title.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Lbl_Title.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Frm_EditChatContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.Pnl_Main);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_EditChatContainer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Pnl_Main.ResumeLayout(false);
            this.Pnl_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elp_Form;
        private System.Windows.Forms.Panel Pnl_Main;
        private Bunifu.UI.WinForms.BunifuLabel Lbl_ErrorFill;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Btn_Cancel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Btn_Edit;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txt_Name;
        private Bunifu.UI.WinForms.BunifuPictureBox Pb_Image;
        private Bunifu.UI.WinForms.BunifuLabel Lbl_Title;
    }
}