namespace TI_Lab2;

partial class Form1
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        OpenButton = new System.Windows.Forms.ToolStripMenuItem();
        SaveButton = new System.Windows.Forms.ToolStripMenuItem();
        RegTextBox = new System.Windows.Forms.TextBox();
        ResultButton = new System.Windows.Forms.Button();
        CipherTextBox = new System.Windows.Forms.TextBox();
        PlainTextBox = new System.Windows.Forms.TextBox();
        KeyTextBox = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        BitCountLabel = new System.Windows.Forms.Label();
        OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
        SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
        ClearButton = new System.Windows.Forms.Button();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { файлToolStripMenuItem });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(1424, 40);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // файлToolStripMenuItem
        // 
        файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { OpenButton, SaveButton });
        файлToolStripMenuItem.Name = "файлToolStripMenuItem";
        файлToolStripMenuItem.Size = new System.Drawing.Size(90, 36);
        файлToolStripMenuItem.Text = "&Файл";
        // 
        // OpenButton
        // 
        OpenButton.Image = ((System.Drawing.Image)resources.GetObject("OpenButton.Image"));
        OpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        OpenButton.Name = "OpenButton";
        OpenButton.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
        OpenButton.Size = new System.Drawing.Size(343, 44);
        OpenButton.Text = "&Открыть";
        OpenButton.Click += OpenFileClick;
        // 
        // SaveButton
        // 
        SaveButton.Image = ((System.Drawing.Image)resources.GetObject("SaveButton.Image"));
        SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        SaveButton.Name = "SaveButton";
        SaveButton.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
        SaveButton.Size = new System.Drawing.Size(343, 44);
        SaveButton.Text = "Со&хранить";
        SaveButton.Click += SaveButtonClick;
        // 
        // RegTextBox
        // 
        RegTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
        RegTextBox.Location = new System.Drawing.Point(76, 158);
        RegTextBox.Multiline = true;
        RegTextBox.Name = "RegTextBox";
        RegTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        RegTextBox.Size = new System.Drawing.Size(845, 61);
        RegTextBox.TabIndex = 1;
        RegTextBox.TextChanged += RegTextBoxChanged;
        // 
        // ResultButton
        // 
        ResultButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        ResultButton.Location = new System.Drawing.Point(994, 146);
        ResultButton.Name = "ResultButton";
        ResultButton.Size = new System.Drawing.Size(287, 73);
        ResultButton.TabIndex = 2;
        ResultButton.Text = "Преобразовать";
        ResultButton.UseVisualStyleBackColor = true;
        ResultButton.Click += ResultButtonClick;
        // 
        // CipherTextBox
        // 
        CipherTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
        CipherTextBox.Location = new System.Drawing.Point(745, 533);
        CipherTextBox.Multiline = true;
        CipherTextBox.Name = "CipherTextBox";
        CipherTextBox.ReadOnly = true;
        CipherTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        CipherTextBox.Size = new System.Drawing.Size(607, 445);
        CipherTextBox.TabIndex = 3;
        // 
        // PlainTextBox
        // 
        PlainTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
        PlainTextBox.Location = new System.Drawing.Point(76, 533);
        PlainTextBox.Multiline = true;
        PlainTextBox.Name = "PlainTextBox";
        PlainTextBox.ReadOnly = true;
        PlainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        PlainTextBox.Size = new System.Drawing.Size(594, 445);
        PlainTextBox.TabIndex = 4;
        // 
        // KeyTextBox
        // 
        KeyTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
        KeyTextBox.Location = new System.Drawing.Point(76, 352);
        KeyTextBox.Multiline = true;
        KeyTextBox.Name = "KeyTextBox";
        KeyTextBox.ReadOnly = true;
        KeyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        KeyTextBox.Size = new System.Drawing.Size(845, 61);
        KeyTextBox.TabIndex = 5;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(76, 62);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(536, 69);
        label1.TabIndex = 6;
        label1.Text = "Состояние регистра(36):";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        label2.Location = new System.Drawing.Point(76, 280);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(536, 69);
        label2.TabIndex = 7;
        label2.Text = "Ключ:";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        label3.Location = new System.Drawing.Point(76, 451);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(536, 69);
        label3.TabIndex = 8;
        label3.Text = "Исходный текст:";
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        label4.Location = new System.Drawing.Point(745, 451);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(536, 69);
        label4.TabIndex = 9;
        label4.Text = "Зашифрованный текст:";
        // 
        // BitCountLabel
        // 
        BitCountLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
        BitCountLabel.Location = new System.Drawing.Point(76, 222);
        BitCountLabel.Name = "BitCountLabel";
        BitCountLabel.Size = new System.Drawing.Size(822, 47);
        BitCountLabel.TabIndex = 10;
        // 
        // ClearButton
        // 
        ClearButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        ClearButton.Location = new System.Drawing.Point(994, 304);
        ClearButton.Name = "ClearButton";
        ClearButton.Size = new System.Drawing.Size(287, 73);
        ClearButton.TabIndex = 11;
        ClearButton.Text = "Очистить поля";
        ClearButton.UseVisualStyleBackColor = true;
        ClearButton.Click += ClearButtonClick;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1424, 1048);
        Controls.Add(ClearButton);
        Controls.Add(BitCountLabel);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(KeyTextBox);
        Controls.Add(PlainTextBox);
        Controls.Add(CipherTextBox);
        Controls.Add(ResultButton);
        Controls.Add(RegTextBox);
        Controls.Add(menuStrip1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MainMenuStrip = menuStrip1;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "LFSR";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button ClearButton;

    private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    private System.Windows.Forms.SaveFileDialog SaveFileDialog;

    private System.Windows.Forms.Label BitCountLabel;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Button ResultButton;
    private System.Windows.Forms.TextBox CipherTextBox;
    private System.Windows.Forms.TextBox PlainTextBox;
    private System.Windows.Forms.TextBox KeyTextBox;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox RegTextBox;

    private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem OpenButton;
    private System.Windows.Forms.ToolStripMenuItem SaveButton;

    private System.Windows.Forms.MenuStrip menuStrip1;

    #endregion
}