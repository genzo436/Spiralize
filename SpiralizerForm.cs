using Spiralize.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spiralize
{
  public partial class SpiralizerForm : Form
  {
    Spiral spiral;
    public SpiralizerForm()
    {
      InitializeComponent();
      spiral = new Spiral
      {
        rotations = Convert.ToDouble(inputRotation.Text.Replace('.', ',')),
        maxRadio = Convert.ToDouble(inputMaxRadius.Text.Replace('.', ',')),
        amplitudeVolume = Convert.ToDouble(inputVolume.Text.Replace('.', ',')),
        stepSample = Convert.ToDouble(inputStep.Text.Replace('.', ',')),
        frequency = Convert.ToDouble(inputFrequency.Text.Replace('.', ',')),
      };
    }

    void DEBUG(string line)
    {
      System.Diagnostics.Debug.WriteLine(line);
    }
    private void Form1_Load(object sender, EventArgs e)
    {
      spiral.Create();
      imageOutput.Image = spiral.Draw();
    }

    private void DigitValidation(object sender, KeyPressEventArgs e)
    {
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
          e.KeyChar != ',' && e.KeyChar != '.')
      {
        e.Handled = true;
      }

      // only allow one decimal point
      if ((e.KeyChar == ',' || e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf(',') > -1 || (sender as TextBox).Text.IndexOf('.') > -1))
      {
        e.Handled = true;
      }
    }

    private void InputsChanged(object sender, EventArgs e)
    {
      if (String.IsNullOrEmpty(((TextBox)sender).Text))
      {
        ((TextBox)sender).Text = "0";
      }
      spiral.rotations = Convert.ToDouble(inputRotation.Text.Replace('.', ','));
      spiral.maxRadio = Convert.ToDouble(inputMaxRadius.Text.Replace('.', ','));
      spiral.amplitudeVolume = Convert.ToDouble(inputVolume.Text.Replace('.', ','));
      spiral.stepSample = Convert.ToDouble(inputStep.Text.Replace('.', ','));
      spiral.frequency = Convert.ToDouble(inputFrequency.Text.Replace('.', ','));
      spiral.Create();
      imageOutput.Image = spiral.Draw();
    }

    Control target;
    double originalValue;
    Point cursorInit;
    bool changingInput;
    private void LabelInputMouseDown(object sender, MouseEventArgs e)
    {
      target = this.Controls.OfType<TextBox>()
               .Where(c => c.TabIndex == ((Label)sender).TabIndex-5).FirstOrDefault();
      changingInput = true && !((TextBox)target).ReadOnly;
      cursorInit = Cursor.Position;
      originalValue = Convert.ToDouble(target.Text.Replace('.', ','));
    }

    private void LabelInputMouseMove(object sender, MouseEventArgs e)
    {
      if (!changingInput)
      {
        return;
      }
      Point actualPosition = Cursor.Position;
      double newValue = originalValue + (actualPosition.X - cursorInit.X);
      if (newValue < 0)
      {
        newValue = 0;
      }
      target.Text = newValue.ToString().Replace(',', '.');
    }

    private void LabelInputMouseUp(object sender, MouseEventArgs e)
    {
      changingInput = false;
    }

    private void InputSourceClick(object sender, EventArgs e)
    {
      OpenFileDialog dialog = new OpenFileDialog
      {
        Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) |" +
          "*.jpg; *.jfif; *.png|All files (*.*)|*.*"
      };
      DialogResult answer = dialog.ShowDialog();
      if(answer == DialogResult.OK)
      {
        ImageDialog imageDialog = new ImageDialog(dialog.FileName);
        DialogResult imageResult = imageDialog.ShowDialog();
        if(imageResult == DialogResult.OK)
        {
          inputSource.Text = dialog.FileName;
          imageSource.Image = imageDialog.outputImage;
          spiral.sourceImage = new Bitmap(imageDialog.outputImage);
          spiral.maxRadio = imageSource.Image.Width / 2;

          inputMaxRadius.ReadOnly = true;

          spiral.Create();
          imageOutput.Image = spiral.Draw();
        }
      }
    }

    private void ButtonDeleteClick(object sender, EventArgs e)
    {
      imageSource.Image = null;
      inputMaxRadius.ReadOnly = false;
      spiral.sourceImage = null;
      spiral.Create();
      imageOutput.Image = spiral.Draw();
    }
  }
}
