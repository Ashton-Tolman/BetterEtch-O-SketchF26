using System.IO.Ports;
using System.Media;
using System.Drawing;

namespace BetterEtch_O_SketchF26
{
    partial class BetterEtchOSketchForm
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
            components = new System.ComponentModel.Container();
            DisplayPictureBox = new PictureBox();
            ExitButton = new Button();
            SelectColorButton = new Button();
            DrawWaveformButton = new Button();
            ClearButton = new Button();
            DisplayContextMenuStrip = new ContextMenuStrip(components);
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            ExitStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem1 = new ToolStripMenuItem();
            SelectColorStripMenuItem = new ToolStripMenuItem();
            DrawWaveformStripMenuItem = new ToolStripMenuItem();
            ClearStripMenuItem = new ToolStripMenuItem();
            HelpStripMenuItem = new ToolStripMenuItem();
            AboutStripMenuItem = new ToolStripMenuItem();
            PenColorDialog = new ColorDialog();
            DisplayToolTip = new ToolTip(components);
            TopMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            ExitMainStripItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            SelectColorMainStripItem = new ToolStripMenuItem();
            DrawWaveformMainStripItem = new ToolStripMenuItem();
            ClearMainStripItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            AboutMainStripItem = new ToolStripMenuItem();
            MouseRadioButton = new RadioButton();
            ExternalRadioButton = new RadioButton();
            PortsComboBox = new ComboBox();
            PICTimer = new System.Windows.Forms.Timer(components);
            PicStatuslabel = new Label();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            DisplayContextMenuStrip.SuspendLayout();
            TopMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DisplayPictureBox.BackColor = Color.Silver;
            DisplayPictureBox.Location = new Point(15, 40);
            DisplayPictureBox.Margin = new Padding(4);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(970, 428);
            DisplayPictureBox.TabIndex = 0;
            DisplayPictureBox.TabStop = false;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExitButton.Location = new Point(868, 475);
            ExitButton.Margin = new Padding(4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(118, 72);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SelectColorButton
            // 
            SelectColorButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SelectColorButton.Location = new Point(492, 475);
            SelectColorButton.Margin = new Padding(4);
            SelectColorButton.Name = "SelectColorButton";
            SelectColorButton.Size = new Size(118, 72);
            SelectColorButton.TabIndex = 3;
            SelectColorButton.Text = "Select Color";
            SelectColorButton.UseVisualStyleBackColor = true;
            SelectColorButton.Click += SelectColorButton_Click;
            // 
            // DrawWaveformButton
            // 
            DrawWaveformButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DrawWaveformButton.Location = new Point(618, 475);
            DrawWaveformButton.Margin = new Padding(4);
            DrawWaveformButton.Name = "DrawWaveformButton";
            DrawWaveformButton.Size = new Size(118, 72);
            DrawWaveformButton.TabIndex = 2;
            DrawWaveformButton.Text = "Draw Waveform";
            DrawWaveformButton.UseVisualStyleBackColor = true;
            DrawWaveformButton.Click += DrawWavefomButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearButton.Location = new Point(742, 475);
            ClearButton.Margin = new Padding(4);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(118, 72);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // DisplayContextMenuStrip
            // 
            DisplayContextMenuStrip.ImageScalingSize = new Size(20, 20);
            DisplayContextMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem1, editToolStripMenuItem1, HelpStripMenuItem });
            DisplayContextMenuStrip.Name = "DisplayContextMenuStrip";
            DisplayContextMenuStrip.Size = new Size(122, 100);
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { ExitStripMenuItem });
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(121, 32);
            fileToolStripMenuItem1.Text = "File";
            // 
            // ExitStripMenuItem
            // 
            ExitStripMenuItem.Name = "ExitStripMenuItem";
            ExitStripMenuItem.Size = new Size(141, 34);
            ExitStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem1
            // 
            editToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { SelectColorStripMenuItem, DrawWaveformStripMenuItem, ClearStripMenuItem });
            editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            editToolStripMenuItem1.Size = new Size(121, 32);
            editToolStripMenuItem1.Text = "Edit";
            // 
            // SelectColorStripMenuItem
            // 
            SelectColorStripMenuItem.Name = "SelectColorStripMenuItem";
            SelectColorStripMenuItem.Size = new Size(242, 34);
            SelectColorStripMenuItem.Text = "Select Color";
            // 
            // DrawWaveformStripMenuItem
            // 
            DrawWaveformStripMenuItem.Name = "DrawWaveformStripMenuItem";
            DrawWaveformStripMenuItem.Size = new Size(242, 34);
            DrawWaveformStripMenuItem.Text = "Draw Waveform";
            // 
            // ClearStripMenuItem
            // 
            ClearStripMenuItem.Name = "ClearStripMenuItem";
            ClearStripMenuItem.Size = new Size(242, 34);
            ClearStripMenuItem.Text = "Clear";
            // 
            // HelpStripMenuItem
            // 
            HelpStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutStripMenuItem });
            HelpStripMenuItem.Name = "HelpStripMenuItem";
            HelpStripMenuItem.Size = new Size(121, 32);
            HelpStripMenuItem.Text = "Help";
            // 
            // AboutStripMenuItem
            // 
            AboutStripMenuItem.Name = "AboutStripMenuItem";
            AboutStripMenuItem.Size = new Size(164, 34);
            AboutStripMenuItem.Text = "About";
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.ImageScalingSize = new Size(20, 20);
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            TopMenuStrip.Location = new Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Padding = new Padding(8, 2, 0, 2);
            TopMenuStrip.Size = new Size(1000, 33);
            TopMenuStrip.TabIndex = 7;
            TopMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ExitMainStripItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // ExitMainStripItem
            // 
            ExitMainStripItem.Name = "ExitMainStripItem";
            ExitMainStripItem.Size = new Size(141, 34);
            ExitMainStripItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SelectColorMainStripItem, DrawWaveformMainStripItem, ClearMainStripItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "Edit";
            // 
            // SelectColorMainStripItem
            // 
            SelectColorMainStripItem.Name = "SelectColorMainStripItem";
            SelectColorMainStripItem.Size = new Size(242, 34);
            SelectColorMainStripItem.Text = "Select Color";
            // 
            // DrawWaveformMainStripItem
            // 
            DrawWaveformMainStripItem.Name = "DrawWaveformMainStripItem";
            DrawWaveformMainStripItem.Size = new Size(242, 34);
            DrawWaveformMainStripItem.Text = "Draw Waveform";
            // 
            // ClearMainStripItem
            // 
            ClearMainStripItem.Name = "ClearMainStripItem";
            ClearMainStripItem.Size = new Size(242, 34);
            ClearMainStripItem.Text = "Clear";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutMainStripItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // AboutMainStripItem
            // 
            AboutMainStripItem.Name = "AboutMainStripItem";
            AboutMainStripItem.Size = new Size(164, 34);
            AboutMainStripItem.Text = "About";
            AboutMainStripItem.Click += AboutMainStripItem_Click;
            // 
            // MouseRadioButton
            // 
            MouseRadioButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            MouseRadioButton.AutoSize = true;
            MouseRadioButton.Location = new Point(292, 518);
            MouseRadioButton.Margin = new Padding(4);
            MouseRadioButton.Name = "MouseRadioButton";
            MouseRadioButton.Size = new Size(179, 29);
            MouseRadioButton.TabIndex = 5;
            MouseRadioButton.TabStop = true;
            MouseRadioButton.Text = "Draw With Mouse";
            MouseRadioButton.UseVisualStyleBackColor = true;
            // 
            // ExternalRadioButton
            // 
            ExternalRadioButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExternalRadioButton.AutoSize = true;
            ExternalRadioButton.Location = new Point(292, 480);
            ExternalRadioButton.Margin = new Padding(4);
            ExternalRadioButton.Name = "ExternalRadioButton";
            ExternalRadioButton.Size = new Size(157, 29);
            ExternalRadioButton.TabIndex = 4;
            ExternalRadioButton.TabStop = true;
            ExternalRadioButton.Text = "Draw Externally";
            ExternalRadioButton.UseVisualStyleBackColor = true;
            // 
            // PortsComboBox
            // 
            PortsComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PortsComboBox.FormattingEnabled = true;
            PortsComboBox.Location = new Point(15, 475);
            PortsComboBox.Margin = new Padding(4);
            PortsComboBox.Name = "PortsComboBox";
            PortsComboBox.Size = new Size(236, 33);
            PortsComboBox.TabIndex = 6;
            // 
            // PICTimer
            // 
            PICTimer.Interval = 50;
            // 
            // PicStatuslabel
            // 
            PicStatuslabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PicStatuslabel.AutoSize = true;
            PicStatuslabel.Location = new Point(15, 520);
            PicStatuslabel.Margin = new Padding(4, 0, 4, 0);
            PicStatuslabel.Name = "PicStatuslabel";
            PicStatuslabel.Size = new Size(155, 25);
            PicStatuslabel.TabIndex = 11;
            PicStatuslabel.Text = "Connection Status";
            // 
            // BetterEtchOSketchForm
            // 
            AcceptButton = DrawWaveformButton;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ClearButton;
            ClientSize = new Size(1000, 562);
            Controls.Add(PicStatuslabel);
            Controls.Add(PortsComboBox);
            Controls.Add(ExternalRadioButton);
            Controls.Add(MouseRadioButton);
            Controls.Add(TopMenuStrip);
            Controls.Add(ClearButton);
            Controls.Add(DrawWaveformButton);
            Controls.Add(SelectColorButton);
            Controls.Add(ExitButton);
            Controls.Add(DisplayPictureBox);
            MainMenuStrip = TopMenuStrip;
            Margin = new Padding(4);
            MinimumSize = new Size(1022, 618);
            Name = "BetterEtchOSketchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Better Etch-O-Sketch";
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            DisplayContextMenuStrip.ResumeLayout(false);
            TopMenuStrip.ResumeLayout(false);
            TopMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void AboutMainStripItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox DisplayPictureBox;
        private Button ExitButton;
        private Button SelectColorButton;
        private Button DrawWaveformButton;
        private Button ClearButton;
        private ContextMenuStrip DisplayContextMenuStrip;
        private ColorDialog PenColorDialog;
        private ToolTip DisplayToolTip;
        private MenuStrip TopMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem ExitMainStripItem;
        private ToolStripMenuItem SelectColorMainStripItem;
        private ToolStripMenuItem DrawWaveformMainStripItem;
        private ToolStripMenuItem ClearMainStripItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem AboutMainStripItem;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem ExitStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem SelectColorStripMenuItem;
        private ToolStripMenuItem DrawWaveformStripMenuItem;
        private ToolStripMenuItem ClearStripMenuItem;
        private ToolStripMenuItem HelpStripMenuItem;
        private ToolStripMenuItem AboutStripMenuItem;
        private RadioButton MouseRadioButton;
        private RadioButton ExternalRadioButton;
        private ComboBox PortsComboBox;
        private System.Windows.Forms.Timer PICTimer;
        private Label PicStatuslabel;
        

        
    }
}
