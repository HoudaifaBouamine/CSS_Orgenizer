namespace Sort_CSS_TAG_CLASS_ID
{
    partial class frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_Input = new TextBox();
            tb_Output = new TextBox();
            menuStrip1 = new MenuStrip();
            MenuStrip = new ToolStripMenuItem();
            changeColorsToolStripMenuItem = new ToolStripMenuItem();
            backGroundColorToolStripMenuItem = new ToolStripMenuItem();
            textBackGroundColorToolStripMenuItem = new ToolStripMenuItem();
            textFontColorToolStripMenuItem = new ToolStripMenuItem();
            changeFontToolStripMenuItem = new ToolStripMenuItem();
            color_Controler = new ColorDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tb_Input
            // 
            tb_Input.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_Input.BackColor = Color.FromArgb(50, 50, 50);
            tb_Input.ForeColor = Color.FromArgb(206, 206, 206);
            tb_Input.Location = new Point(12, 31);
            tb_Input.Multiline = true;
            tb_Input.Name = "tb_Input";
            tb_Input.Size = new Size(864, 199);
            tb_Input.TabIndex = 0;
            tb_Input.TextChanged += Input_TextChanged;
            // 
            // tb_Output
            // 
            tb_Output.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_Output.BackColor = Color.FromArgb(50, 50, 50);
            tb_Output.ForeColor = Color.FromArgb(206, 206, 206);
            tb_Output.Location = new Point(12, 254);
            tb_Output.Multiline = true;
            tb_Output.Name = "tb_Output";
            tb_Output.Size = new Size(864, 225);
            tb_Output.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(32, 32, 32);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuStrip });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(888, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuStrip
            // 
            MenuStrip.DropDownItems.AddRange(new ToolStripItem[] { changeColorsToolStripMenuItem, changeFontToolStripMenuItem });
            MenuStrip.ForeColor = Color.FromArgb(206, 206, 206);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(76, 24);
            MenuStrip.Text = "Settings";
            MenuStrip.TextDirection = ToolStripTextDirection.Horizontal;
            MenuStrip.Visible = false;
            MenuStrip.Click += MenuStrip_Click;
            // 
            // changeColorsToolStripMenuItem
            // 
            changeColorsToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32);
            changeColorsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { backGroundColorToolStripMenuItem, textBackGroundColorToolStripMenuItem, textFontColorToolStripMenuItem });
            changeColorsToolStripMenuItem.ForeColor = Color.FromArgb(206, 206, 206);
            changeColorsToolStripMenuItem.Name = "changeColorsToolStripMenuItem";
            changeColorsToolStripMenuItem.Size = new Size(188, 26);
            changeColorsToolStripMenuItem.Text = "Change Colors";
            changeColorsToolStripMenuItem.Click += changeColorsToolStripMenuItem_Click;
            // 
            // backGroundColorToolStripMenuItem
            // 
            backGroundColorToolStripMenuItem.Name = "backGroundColorToolStripMenuItem";
            backGroundColorToolStripMenuItem.Size = new Size(247, 26);
            backGroundColorToolStripMenuItem.Text = "Back Ground Color";
            backGroundColorToolStripMenuItem.Click += backGroundColorToolStripMenuItem_Click;
            // 
            // textBackGroundColorToolStripMenuItem
            // 
            textBackGroundColorToolStripMenuItem.Name = "textBackGroundColorToolStripMenuItem";
            textBackGroundColorToolStripMenuItem.Size = new Size(247, 26);
            textBackGroundColorToolStripMenuItem.Text = "Text Back Ground Color";
            textBackGroundColorToolStripMenuItem.Click += textBackGroundColorToolStripMenuItem_Click;
            // 
            // textFontColorToolStripMenuItem
            // 
            textFontColorToolStripMenuItem.Name = "textFontColorToolStripMenuItem";
            textFontColorToolStripMenuItem.Size = new Size(247, 26);
            textFontColorToolStripMenuItem.Text = "Text Font Color";
            textFontColorToolStripMenuItem.Click += textFontColorToolStripMenuItem_Click;
            // 
            // changeFontToolStripMenuItem
            // 
            changeFontToolStripMenuItem.BackColor = Color.FromArgb(32, 32, 32);
            changeFontToolStripMenuItem.ForeColor = Color.FromArgb(206, 206, 206);
            changeFontToolStripMenuItem.Name = "changeFontToolStripMenuItem";
            changeFontToolStripMenuItem.Size = new Size(188, 26);
            changeFontToolStripMenuItem.Text = "Change Font";
            // 
            // frm_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(888, 491);
            Controls.Add(tb_Output);
            Controls.Add(tb_Input);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frm_Main";
            Text = "CSS Sorter";
            Load += frm_Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_Input;
        private TextBox tb_Output;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuStrip;
        private ToolStripMenuItem changeColorsToolStripMenuItem;
        private ToolStripMenuItem changeFontToolStripMenuItem;
        private ColorDialog color_Controler;
        private ToolStripMenuItem backGroundColorToolStripMenuItem;
        private ToolStripMenuItem textBackGroundColorToolStripMenuItem;
        private ToolStripMenuItem textFontColorToolStripMenuItem;
    }
}