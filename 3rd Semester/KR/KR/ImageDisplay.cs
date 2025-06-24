using System.Drawing;
using System.Windows.Forms;

namespace KR
{
    internal static class ImageDisplay
    {
        public static void ShowForm(Image image, string formText)
        {
            Form displayForm = new Form
            {
                Text = formText,
                BackgroundImage = image,
                BackgroundImageLayout = ImageLayout.Zoom,
                StartPosition = FormStartPosition.CenterScreen,
                ShowIcon = false
            };
            if(image.Size.Width > Screen.PrimaryScreen.Bounds.Width ||
                image.Size.Height > Screen.PrimaryScreen.Bounds.Height)
                displayForm.WindowState = FormWindowState.Maximized;
            else
                displayForm.Size = image.Size + new Size(0, 30);
            displayForm.Show();
        }
    }
}
