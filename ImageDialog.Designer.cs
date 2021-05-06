
namespace Spiralize
{
  partial class ImageDialog
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
      this.pictureBoxInput = new System.Windows.Forms.PictureBox();
      this.buttonAccept = new System.Windows.Forms.Button();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.pictureBoxOutput = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBoxInput
      // 
      this.pictureBoxInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.pictureBoxInput.Location = new System.Drawing.Point(12, 55);
      this.pictureBoxInput.Name = "pictureBoxInput";
      this.pictureBoxInput.Size = new System.Drawing.Size(330, 330);
      this.pictureBoxInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBoxInput.TabIndex = 0;
      this.pictureBoxInput.TabStop = false;
      this.pictureBoxInput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxInputMouseDown);
      this.pictureBoxInput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBoxInputMouseMove);
      this.pictureBoxInput.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBoxInputMouseUp);
      // 
      // buttonAccept
      // 
      this.buttonAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.buttonAccept.Location = new System.Drawing.Point(248, 391);
      this.buttonAccept.Name = "buttonAccept";
      this.buttonAccept.Size = new System.Drawing.Size(94, 29);
      this.buttonAccept.TabIndex = 1;
      this.buttonAccept.Text = "Accept";
      this.buttonAccept.UseVisualStyleBackColor = true;
      // 
      // buttonCancel
      // 
      this.buttonCancel.Location = new System.Drawing.Point(358, 391);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(94, 29);
      this.buttonCancel.TabIndex = 2;
      this.buttonCancel.Text = "Cancel";
      this.buttonCancel.UseVisualStyleBackColor = true;
      // 
      // pictureBoxOutput
      // 
      this.pictureBoxOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.pictureBoxOutput.Location = new System.Drawing.Point(358, 55);
      this.pictureBoxOutput.Name = "pictureBoxOutput";
      this.pictureBoxOutput.Size = new System.Drawing.Size(330, 330);
      this.pictureBoxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBoxOutput.TabIndex = 4;
      this.pictureBoxOutput.TabStop = false;
      // 
      // ImageDialog
      // 
      this.AcceptButton = this.buttonAccept;
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.buttonCancel;
      this.ClientSize = new System.Drawing.Size(701, 426);
      this.Controls.Add(this.pictureBoxOutput);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.buttonAccept);
      this.Controls.Add(this.pictureBoxInput);
      this.Name = "ImageDialog";
      this.Text = "ImageDialog";
      this.Load += new System.EventHandler(this.ImageDialog_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBoxInput;
    private System.Windows.Forms.Button buttonAccept;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.PictureBox pictureBoxOutput;
  }
}