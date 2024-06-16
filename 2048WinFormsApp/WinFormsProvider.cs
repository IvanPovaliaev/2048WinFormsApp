using System.Drawing;
using System.Windows.Forms;

namespace _2048WinFormsApp
{
    public static class WinFormsProvider
    {
        public static void HideFormShowDialog(Form childForm)
        {
            StaticData.MainForm.Hide();
            childForm.ShowDialog();
            StaticData.MainForm.Show();
        }
        public static void SetFormSize(this Form form,int width, int height)
        {
            form.Size = new Size(width, height);
            form.MaximumSize = new Size(width, height);
            form.MinimumSize = new Size(width, height);
        }
    }
}
