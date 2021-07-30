
namespace ChatApplication
{
    partial class Frm_NewContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NewContact));
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
            this.Lbl_CantAddYourself = new Bunifu.UI.WinForms.BunifuLabel();
            this.Lbl_NoUserFound = new Bunifu.UI.WinForms.BunifuLabel();
            this.Lbl_AlreadyInContacts = new Bunifu.UI.WinForms.BunifuLabel();
            this.Lbl_ErrorFill = new Bunifu.UI.WinForms.BunifuLabel();
            this.Btn_Cancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Btn_Add = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Txt_PhoneNumber = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.Lbl_Title = new Bunifu.UI.WinForms.BunifuLabel();
            this.Pnl_Main.SuspendLayout();
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
            this.Pnl_Main.Controls.Add(this.Lbl_CantAddYourself);
            this.Pnl_Main.Controls.Add(this.Lbl_NoUserFound);
            this.Pnl_Main.Controls.Add(this.Lbl_AlreadyInContacts);
            this.Pnl_Main.Controls.Add(this.Lbl_ErrorFill);
            this.Pnl_Main.Controls.Add(this.Btn_Cancel);
            this.Pnl_Main.Controls.Add(this.Btn_Add);
            this.Pnl_Main.Controls.Add(this.Txt_PhoneNumber);
            this.Pnl_Main.Controls.Add(this.Lbl_Title);
            this.Pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Main.Name = "Pnl_Main";
            this.Pnl_Main.Size = new System.Drawing.Size(400, 400);
            this.Pnl_Main.TabIndex = 1;
            // 
            // Lbl_CantAddYourself
            // 
            this.Lbl_CantAddYourself.AutoEllipsis = false;
            this.Lbl_CantAddYourself.CursorType = null;
            this.Lbl_CantAddYourself.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.Lbl_CantAddYourself.Location = new System.Drawing.Point(88, 359);
            this.Lbl_CantAddYourself.Name = "Lbl_CantAddYourself";
            this.Lbl_CantAddYourself.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_CantAddYourself.Size = new System.Drawing.Size(220, 19);
            this.Lbl_CantAddYourself.TabIndex = 8;
            this.Lbl_CantAddYourself.Text = "You can\'t add yourself to your contacts";
            this.Lbl_CantAddYourself.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Lbl_CantAddYourself.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.Lbl_CantAddYourself.Visible = false;
            // 
            // Lbl_NoUserFound
            // 
            this.Lbl_NoUserFound.AutoEllipsis = false;
            this.Lbl_NoUserFound.CursorType = null;
            this.Lbl_NoUserFound.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.Lbl_NoUserFound.Location = new System.Drawing.Point(89, 359);
            this.Lbl_NoUserFound.Name = "Lbl_NoUserFound";
            this.Lbl_NoUserFound.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_NoUserFound.Size = new System.Drawing.Size(218, 19);
            this.Lbl_NoUserFound.TabIndex = 8;
            this.Lbl_NoUserFound.Text = "No user found with this phone number";
            this.Lbl_NoUserFound.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Lbl_NoUserFound.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.Lbl_NoUserFound.Visible = false;
            // 
            // Lbl_AlreadyInContacts
            // 
            this.Lbl_AlreadyInContacts.AutoEllipsis = false;
            this.Lbl_AlreadyInContacts.CursorType = null;
            this.Lbl_AlreadyInContacts.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.Lbl_AlreadyInContacts.Location = new System.Drawing.Point(109, 359);
            this.Lbl_AlreadyInContacts.Name = "Lbl_AlreadyInContacts";
            this.Lbl_AlreadyInContacts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_AlreadyInContacts.Size = new System.Drawing.Size(177, 19);
            this.Lbl_AlreadyInContacts.TabIndex = 8;
            this.Lbl_AlreadyInContacts.Text = "User is already in your contacts";
            this.Lbl_AlreadyInContacts.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Lbl_AlreadyInContacts.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.Lbl_AlreadyInContacts.Visible = false;
            // 
            // Lbl_ErrorFill
            // 
            this.Lbl_ErrorFill.AutoEllipsis = false;
            this.Lbl_ErrorFill.CursorType = null;
            this.Lbl_ErrorFill.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.Lbl_ErrorFill.Location = new System.Drawing.Point(108, 359);
            this.Lbl_ErrorFill.Name = "Lbl_ErrorFill";
            this.Lbl_ErrorFill.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_ErrorFill.Size = new System.Drawing.Size(178, 19);
            this.Lbl_ErrorFill.TabIndex = 8;
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
            this.Btn_Cancel.Location = new System.Drawing.Point(231, 299);
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
            this.Btn_Cancel.TabIndex = 3;
            this.Btn_Cancel.TabStop = false;
            this.Btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Cancel.TextMarginLeft = 0;
            this.Btn_Cancel.UseDefaultRadiusAndThickness = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.AllowToggling = false;
            this.Btn_Add.AnimationSpeed = 200;
            this.Btn_Add.AutoGenerateColors = false;
            this.Btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Add.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.Btn_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Add.BackgroundImage")));
            this.Btn_Add.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Add.ButtonText = "Add";
            this.Btn_Add.ButtonTextMarginLeft = 0;
            this.Btn_Add.ColorContrastOnClick = 45;
            this.Btn_Add.ColorContrastOnHover = 45;
            this.Btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.Btn_Add.CustomizableEdges = borderEdges2;
            this.Btn_Add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Add.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Btn_Add.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Btn_Add.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Btn_Add.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Btn_Add.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.Btn_Add.ForeColor = System.Drawing.Color.White;
            this.Btn_Add.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Add.IconMarginLeft = 11;
            this.Btn_Add.IconPadding = 10;
            this.Btn_Add.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Add.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Add.IdleBorderRadius = 3;
            this.Btn_Add.IdleBorderThickness = 1;
            this.Btn_Add.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Add.IdleIconLeftImage = null;
            this.Btn_Add.IdleIconRightImage = null;
            this.Btn_Add.IndicateFocus = false;
            this.Btn_Add.Location = new System.Drawing.Point(48, 299);
            this.Btn_Add.Name = "Btn_Add";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.BorderRadius = 3;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.Btn_Add.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 3;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.Btn_Add.OnPressedState = stateProperties4;
            this.Btn_Add.Size = new System.Drawing.Size(115, 45);
            this.Btn_Add.TabIndex = 2;
            this.Btn_Add.TabStop = false;
            this.Btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Add.TextMarginLeft = 0;
            this.Btn_Add.UseDefaultRadiusAndThickness = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Txt_PhoneNumber
            // 
            this.Txt_PhoneNumber.AcceptsReturn = false;
            this.Txt_PhoneNumber.AcceptsTab = false;
            this.Txt_PhoneNumber.AnimationSpeed = 200;
            this.Txt_PhoneNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Txt_PhoneNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Txt_PhoneNumber.BackColor = System.Drawing.Color.White;
            this.Txt_PhoneNumber.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Txt_PhoneNumber.BackgroundImage")));
            this.Txt_PhoneNumber.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.Txt_PhoneNumber.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Txt_PhoneNumber.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Txt_PhoneNumber.BorderColorIdle = System.Drawing.Color.Silver;
            this.Txt_PhoneNumber.BorderRadius = 1;
            this.Txt_PhoneNumber.BorderThickness = 1;
            this.Txt_PhoneNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Txt_PhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_PhoneNumber.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.Txt_PhoneNumber.DefaultText = "";
            this.Txt_PhoneNumber.FillColor = System.Drawing.Color.White;
            this.Txt_PhoneNumber.HideSelection = true;
            this.Txt_PhoneNumber.IconLeft = null;
            this.Txt_PhoneNumber.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_PhoneNumber.IconPadding = 10;
            this.Txt_PhoneNumber.IconRight = null;
            this.Txt_PhoneNumber.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_PhoneNumber.Lines = new string[0];
            this.Txt_PhoneNumber.Location = new System.Drawing.Point(48, 160);
            this.Txt_PhoneNumber.MaxLength = 32767;
            this.Txt_PhoneNumber.MinimumSize = new System.Drawing.Size(100, 35);
            this.Txt_PhoneNumber.Modified = false;
            this.Txt_PhoneNumber.Multiline = false;
            this.Txt_PhoneNumber.Name = "Txt_PhoneNumber";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Txt_PhoneNumber.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Txt_PhoneNumber.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Txt_PhoneNumber.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Txt_PhoneNumber.OnIdleState = stateProperties8;
            this.Txt_PhoneNumber.PasswordChar = '\0';
            this.Txt_PhoneNumber.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Txt_PhoneNumber.PlaceholderText = "Phone number";
            this.Txt_PhoneNumber.ReadOnly = false;
            this.Txt_PhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_PhoneNumber.SelectedText = "";
            this.Txt_PhoneNumber.SelectionLength = 0;
            this.Txt_PhoneNumber.SelectionStart = 0;
            this.Txt_PhoneNumber.ShortcutsEnabled = true;
            this.Txt_PhoneNumber.Size = new System.Drawing.Size(298, 35);
            this.Txt_PhoneNumber.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.Txt_PhoneNumber.TabIndex = 1;
            this.Txt_PhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txt_PhoneNumber.TextMarginBottom = 0;
            this.Txt_PhoneNumber.TextMarginLeft = 5;
            this.Txt_PhoneNumber.TextMarginTop = 0;
            this.Txt_PhoneNumber.TextPlaceholder = "Phone number";
            this.Txt_PhoneNumber.UseSystemPasswordChar = false;
            this.Txt_PhoneNumber.WordWrap = true;
            this.Txt_PhoneNumber.TextChange += new System.EventHandler(this.Txt_PhoneNumber_TextChanged);
            this.Txt_PhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_PhoneNumber_KeyPress);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoEllipsis = false;
            this.Lbl_Title.CursorType = null;
            this.Lbl_Title.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.Location = new System.Drawing.Point(48, 35);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_Title.Size = new System.Drawing.Size(236, 22);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "Please enter contact phone number";
            this.Lbl_Title.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Lbl_Title.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Frm_NewContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.Pnl_Main);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_NewContact";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Pnl_Main.ResumeLayout(false);
            this.Pnl_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elp_Form;
        private System.Windows.Forms.Panel Pnl_Main;
        private Bunifu.UI.WinForms.BunifuLabel Lbl_CantAddYourself;
        private Bunifu.UI.WinForms.BunifuLabel Lbl_NoUserFound;
        private Bunifu.UI.WinForms.BunifuLabel Lbl_AlreadyInContacts;
        private Bunifu.UI.WinForms.BunifuLabel Lbl_ErrorFill;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Btn_Cancel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Btn_Add;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txt_PhoneNumber;
        private Bunifu.UI.WinForms.BunifuLabel Lbl_Title;
    }
}