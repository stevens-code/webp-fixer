namespace WebPFixer
{
  partial class MainForm
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
      OpenWebPButton = new Button();
      label1 = new Label();
      PreviewPictureBox = new PictureBox();
      CopyPngButton = new Button();
      SaveAsPngButton = new Button();
      ((System.ComponentModel.ISupportInitialize)PreviewPictureBox).BeginInit();
      SuspendLayout();
      // 
      // OpenWebPButton
      // 
      OpenWebPButton.Location = new Point(12, 12);
      OpenWebPButton.Name = "OpenWebPButton";
      OpenWebPButton.Size = new Size(150, 29);
      OpenWebPButton.TabIndex = 0;
      OpenWebPButton.Text = "Open WebP...";
      OpenWebPButton.UseVisualStyleBackColor = true;
      OpenWebPButton.Click += OpenWebPButton_Click;
      // 
      // label1
      // 
      label1.Location = new Point(12, 79);
      label1.Name = "label1";
      label1.Size = new Size(306, 88);
      label1.TabIndex = 1;
      label1.Text = "Drag a WebP image onto the area below or open a WebP image and it will be converted to PNG and copied to the clipboard:";
      label1.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // PreviewPictureBox
      // 
      PreviewPictureBox.BorderStyle = BorderStyle.Fixed3D;
      PreviewPictureBox.Location = new Point(12, 170);
      PreviewPictureBox.Name = "PreviewPictureBox";
      PreviewPictureBox.Size = new Size(306, 183);
      PreviewPictureBox.TabIndex = 2;
      PreviewPictureBox.TabStop = false;
      // 
      // CopyPngButton
      // 
      CopyPngButton.Location = new Point(12, 47);
      CopyPngButton.Name = "CopyPngButton";
      CopyPngButton.Size = new Size(306, 29);
      CopyPngButton.TabIndex = 3;
      CopyPngButton.Text = "Copy Current PNG Image";
      CopyPngButton.UseVisualStyleBackColor = true;
      CopyPngButton.Click += CopyPngButton_Click;
      // 
      // SaveAsPngButton
      // 
      SaveAsPngButton.Location = new Point(168, 12);
      SaveAsPngButton.Name = "SaveAsPngButton";
      SaveAsPngButton.Size = new Size(150, 29);
      SaveAsPngButton.TabIndex = 4;
      SaveAsPngButton.Text = "Save As PNG...";
      SaveAsPngButton.UseVisualStyleBackColor = true;
      SaveAsPngButton.Click += SaveAsPngButton_Click;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(326, 365);
      Controls.Add(SaveAsPngButton);
      Controls.Add(CopyPngButton);
      Controls.Add(PreviewPictureBox);
      Controls.Add(label1);
      Controls.Add(OpenWebPButton);
      FormBorderStyle = FormBorderStyle.FixedDialog;
      MaximizeBox = false;
      Name = "MainForm";
      Text = "Fuck WebP";
      TopMost = true;
      ((System.ComponentModel.ISupportInitialize)PreviewPictureBox).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private Button OpenWebPButton;
    private Label label1;
    private PictureBox PreviewPictureBox;
    private Button CopyPngButton;
    private Button SaveAsPngButton;
  }
}