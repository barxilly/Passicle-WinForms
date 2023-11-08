using System.Security.Cryptography;
using System.Text;

namespace Passicle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {
            // Play nose from resources
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.nose);
            player.Play();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            string s = service.Text.ToLower().Replace(" ", "");
            string k = key.Text.ToLower().Replace(" ", "");
            // Encrypt the password using the key
            p = Encrypt(s, k);
            // Show show and copy buttons
            show.Visible = true;
            copy.Visible = true;
            // Show the generated password but replace the characters with asterisks
            generated.Text = new string('*', p.Length);
        }

        private string Encrypt(string text, string key)
        {
            string result = "";
            string accepted1 = "]ezdESiKJGPIX(*@m374=+Z6faRN\"2&y^9VqY8A1B`%hs.v}#L0pQD:o;C-x,!ul)bHU{wW/tF'r~Ong?c[_MjT$k5";
            string accepted2 = "3h*4c&P(H?dY}t=%!GXjT@{/pF1r7glOqf:SEubA5LB#vW[w)-R.V,U`zy\"e;ZN0]$6^mJ2'sxM9k+_~a8KinICoDQ";
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                int index = accepted1.IndexOf(currentChar);
                char kChar = key[index % key.Length];
                int kIndex = accepted1.IndexOf(kChar);
                int newIndex = (index + kIndex + i) % accepted1.Length;
                char newChar;
                if (i % 2 == 0)
                {
                    newChar = accepted1[newIndex];
                } else
                {
                    newChar = accepted2[newIndex];
                }
                result += newChar.ToString();
            }
            result += accepted1[key.Length];
            result += accepted1[text.Length];
            result += accepted1[(key.Length + text.Length)];
            result += accepted1[result.Length];
            return result;
        }

        private void copy_Click(object sender, EventArgs e)
        {
            // Copy the password to the clipboard
            Clipboard.SetText(p);
        }

        private void show_Click(object sender, EventArgs e)
        {
            if (!showing)
            {
                // Show the password
                generated.Text = p;
                show.Text = "Hide";
                showing = true;
            }
            else
            {
                // Hide the password
                generated.Text = new string('*', p.Length);
                show.Text = "Show";
                showing = false;
            }
        }
    }
}