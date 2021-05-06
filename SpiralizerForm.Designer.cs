
namespace Spiralize
{
  partial class SpiralizerForm
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
      this.imageOutput = new System.Windows.Forms.PictureBox();
      this.inputRotation = new System.Windows.Forms.TextBox();
      this.inputMaxRadius = new System.Windows.Forms.TextBox();
      this.inputVolume = new System.Windows.Forms.TextBox();
      this.inputStep = new System.Windows.Forms.TextBox();
      this.inputFrequency = new System.Windows.Forms.TextBox();
      this.labelRotation = new System.Windows.Forms.Label();
      this.labelRadius = new System.Windows.Forms.Label();
      this.labelVolume = new System.Windows.Forms.Label();
      this.labelSampling = new System.Windows.Forms.Label();
      this.labelFrequency = new System.Windows.Forms.Label();
      this.LabelSource = new System.Windows.Forms.Button();
      this.inputSource = new System.Windows.Forms.TextBox();
      this.imageSource = new System.Windows.Forms.PictureBox();
      this.buttonDelete = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.imageOutput)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.imageSource)).BeginInit();
      this.SuspendLayout();
      // 
      // imageOutput
      // 
      this.imageOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.imageOutput.Location = new System.Drawing.Point(322, 12);
      this.imageOutput.Name = "imageOutput";
      this.imageOutput.Size = new System.Drawing.Size(450, 450);
      this.imageOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.imageOutput.TabIndex = 0;
      this.imageOutput.TabStop = false;
      // 
      // inputRotation
      // 
      this.inputRotation.Location = new System.Drawing.Point(191, 12);
      this.inputRotation.Name = "inputRotation";
      this.inputRotation.Size = new System.Drawing.Size(125, 27);
      this.inputRotation.TabIndex = 1;
      this.inputRotation.Text = "5";
      this.inputRotation.TextChanged += new System.EventHandler(this.InputsChanged);
      this.inputRotation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitValidation);
      // 
      // inputMaxRadius
      // 
      this.inputMaxRadius.Location = new System.Drawing.Point(191, 45);
      this.inputMaxRadius.Name = "inputMaxRadius";
      this.inputMaxRadius.Size = new System.Drawing.Size(125, 27);
      this.inputMaxRadius.TabIndex = 2;
      this.inputMaxRadius.Text = "300";
      this.inputMaxRadius.TextChanged += new System.EventHandler(this.InputsChanged);
      this.inputMaxRadius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitValidation);
      // 
      // inputVolume
      // 
      this.inputVolume.Location = new System.Drawing.Point(191, 78);
      this.inputVolume.Name = "inputVolume";
      this.inputVolume.Size = new System.Drawing.Size(125, 27);
      this.inputVolume.TabIndex = 3;
      this.inputVolume.Text = "100";
      this.inputVolume.TextChanged += new System.EventHandler(this.InputsChanged);
      this.inputVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitValidation);
      // 
      // inputStep
      // 
      this.inputStep.Location = new System.Drawing.Point(191, 144);
      this.inputStep.Name = "inputStep";
      this.inputStep.Size = new System.Drawing.Size(125, 27);
      this.inputStep.TabIndex = 5;
      this.inputStep.Text = "1";
      this.inputStep.TextChanged += new System.EventHandler(this.InputsChanged);
      this.inputStep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitValidation);
      // 
      // inputFrequency
      // 
      this.inputFrequency.Location = new System.Drawing.Point(191, 111);
      this.inputFrequency.Name = "inputFrequency";
      this.inputFrequency.Size = new System.Drawing.Size(125, 27);
      this.inputFrequency.TabIndex = 4;
      this.inputFrequency.Text = "1";
      this.inputFrequency.TextChanged += new System.EventHandler(this.InputsChanged);
      this.inputFrequency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitValidation);
      // 
      // labelRotation
      // 
      this.labelRotation.AutoSize = true;
      this.labelRotation.Location = new System.Drawing.Point(106, 15);
      this.labelRotation.Name = "labelRotation";
      this.labelRotation.Size = new System.Drawing.Size(79, 20);
      this.labelRotation.TabIndex = 6;
      this.labelRotation.Text = "Rotations :";
      this.labelRotation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelInputMouseDown);
      this.labelRotation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelInputMouseMove);
      this.labelRotation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelInputMouseUp);
      // 
      // labelRadius
      // 
      this.labelRadius.AutoSize = true;
      this.labelRadius.Location = new System.Drawing.Point(97, 48);
      this.labelRadius.Name = "labelRadius";
      this.labelRadius.Size = new System.Drawing.Size(88, 20);
      this.labelRadius.TabIndex = 7;
      this.labelRadius.Text = "Max radius :";
      this.labelRadius.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelInputMouseDown);
      this.labelRadius.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelInputMouseMove);
      this.labelRadius.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelInputMouseUp);
      // 
      // labelVolume
      // 
      this.labelVolume.AutoSize = true;
      this.labelVolume.Location = new System.Drawing.Point(8, 81);
      this.labelVolume.Name = "labelVolume";
      this.labelVolume.Size = new System.Drawing.Size(177, 20);
      this.labelVolume.TabIndex = 8;
      this.labelVolume.Text = "Disortion Amplitude (%) :";
      this.labelVolume.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelInputMouseDown);
      this.labelVolume.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelInputMouseMove);
      this.labelVolume.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelInputMouseUp);
      // 
      // labelSampling
      // 
      this.labelSampling.AutoSize = true;
      this.labelSampling.Location = new System.Drawing.Point(74, 147);
      this.labelSampling.Name = "labelSampling";
      this.labelSampling.Size = new System.Drawing.Size(111, 20);
      this.labelSampling.TabIndex = 10;
      this.labelSampling.Text = "Sampling step :";
      this.labelSampling.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelInputMouseDown);
      this.labelSampling.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelInputMouseMove);
      this.labelSampling.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelInputMouseUp);
      // 
      // labelFrequency
      // 
      this.labelFrequency.AutoSize = true;
      this.labelFrequency.Location = new System.Drawing.Point(34, 114);
      this.labelFrequency.Name = "labelFrequency";
      this.labelFrequency.Size = new System.Drawing.Size(151, 20);
      this.labelFrequency.TabIndex = 9;
      this.labelFrequency.Text = "Distortion frequency :";
      this.labelFrequency.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelInputMouseDown);
      this.labelFrequency.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelInputMouseMove);
      this.labelFrequency.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelInputMouseUp);
      // 
      // LabelSource
      // 
      this.LabelSource.Location = new System.Drawing.Point(8, 177);
      this.LabelSource.Name = "LabelSource";
      this.LabelSource.Size = new System.Drawing.Size(94, 29);
      this.LabelSource.TabIndex = 11;
      this.LabelSource.Text = "Source :";
      this.LabelSource.UseVisualStyleBackColor = true;
      this.LabelSource.Click += new System.EventHandler(this.InputSourceClick);
      // 
      // inputSource
      // 
      this.inputSource.Location = new System.Drawing.Point(108, 178);
      this.inputSource.Name = "inputSource";
      this.inputSource.ReadOnly = true;
      this.inputSource.Size = new System.Drawing.Size(177, 27);
      this.inputSource.TabIndex = 12;
      // 
      // imageSource
      // 
      this.imageSource.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.imageSource.Location = new System.Drawing.Point(34, 211);
      this.imageSource.Name = "imageSource";
      this.imageSource.Size = new System.Drawing.Size(251, 251);
      this.imageSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.imageSource.TabIndex = 13;
      this.imageSource.TabStop = false;
      // 
      // buttonDelete
      // 
      this.buttonDelete.Location = new System.Drawing.Point(289, 177);
      this.buttonDelete.Name = "buttonDelete";
      this.buttonDelete.Size = new System.Drawing.Size(25, 29);
      this.buttonDelete.TabIndex = 14;
      this.buttonDelete.Text = "D";
      this.buttonDelete.UseVisualStyleBackColor = true;
      this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
      // 
      // SpiralizerForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(782, 470);
      this.Controls.Add(this.buttonDelete);
      this.Controls.Add(this.imageSource);
      this.Controls.Add(this.inputSource);
      this.Controls.Add(this.LabelSource);
      this.Controls.Add(this.labelFrequency);
      this.Controls.Add(this.labelSampling);
      this.Controls.Add(this.labelVolume);
      this.Controls.Add(this.labelRadius);
      this.Controls.Add(this.labelRotation);
      this.Controls.Add(this.inputFrequency);
      this.Controls.Add(this.inputStep);
      this.Controls.Add(this.inputVolume);
      this.Controls.Add(this.inputMaxRadius);
      this.Controls.Add(this.inputRotation);
      this.Controls.Add(this.imageOutput);
      this.Name = "SpiralizerForm";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.imageOutput)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.imageSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox imageOutput;
    private System.Windows.Forms.TextBox inputRotation;
    private System.Windows.Forms.TextBox inputMaxRadius;
    private System.Windows.Forms.TextBox inputVolume;
    private System.Windows.Forms.TextBox inputStep;
    private System.Windows.Forms.TextBox inputFrequency;
    private System.Windows.Forms.Label labelRotation;
    private System.Windows.Forms.Label labelRadius;
    private System.Windows.Forms.Label labelVolume;
    private System.Windows.Forms.Label labelSampling;
    private System.Windows.Forms.Label labelFrequency;
    private System.Windows.Forms.Button LabelSource;
    private System.Windows.Forms.TextBox inputSource;
    private System.Windows.Forms.PictureBox imageSource;
    private System.Windows.Forms.Button buttonDelete;
  }
}

