using System.Windows.Forms;

namespace Sort_CSS_TAG_CLASS_ID
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
            //TopMost = true;
        }

        List<string> blocks = new List<string>();
        List<string> tags = new List<string>();
        List<string> classes = new List<string>();
        List<string> ids = new List<string>();

        Dictionary<string, string> blacks_Hash = new Dictionary<string, string>();
        private void Input_TextChanged(object sender, EventArgs e)
        {
            Splite_Input();
            /////////////////////

            tags.Sort();
            classes.Sort();
            ids.Sort();

            string output_css = "";

            for (int i = 0; i < tags.Count; i++)
            {
                output_css += blacks_Hash[tags[i]];
            }


            for (int i = 0; i < classes.Count; i++)
            {
                output_css += blacks_Hash[classes[i]];
            }


            for (int i = 0; i < ids.Count; i++)
            {
                output_css += blacks_Hash[ids[i]];
            }

            tb_Output.Text = output_css;
        }

        private void Splite_Input()
        {
            string tmp = "";
            string Input_css = tb_Input.Text;

            for (int i = 0; i < Input_css.Length; i++)
            {
                tmp += Input_css[i];

                if (Input_css[i] == '}')
                {
                    blocks.Add(tmp);
                    tmp = "";
                }
            }

            for (int i = 0; i < blocks.Count; i++)
            {
                int j = 0;

                while (blocks[i][j] == '\n' || blocks[i][j] == '\r')
                {
                    j++;
                }

                if (blocks[i][j] == '#')
                {

                }
                else if (blocks[i][j] == '.')
                {

                }
                else
                {
                    //Output_css += blocks[i];

                    string name = "";
                    while (blocks[i][j] != '{')
                    {
                        name += blocks[i][j];
                        j++;
                    }

                    blacks_Hash.Add(name, blocks[i]);

                    tags.Add(name);
                }

            }

            for (int i = 0; i < blocks.Count; i++)
            {
                int j = 0;

                while (blocks[i][j] == '\n' || blocks[i][j] == '\r')
                {
                    j++;
                }

                if (blocks[i][j] == '#')
                {

                }
                else if (blocks[i][j] == '.')
                {
                    //Output_css += blocks[i];

                    string name = "";
                    while (blocks[i][j] != '{')
                    {
                        name += blocks[i][j];
                        j++;
                    }

                    blacks_Hash.Add(name, blocks[i]);

                    classes.Add(name);
                }
                else
                {
                }

            }

            for (int i = 0; i < blocks.Count; i++)
            {
                int j = 0;

                while (blocks[i][j] == '\n' || blocks[i][j] == '\r')
                {
                    j++;
                }

                if (blocks[i][j] == '#')
                {
                    //Output_css += blocks[i];

                    string name = "";
                    while (blocks[i][j] != '{')
                    {
                        name += blocks[i][j];
                        j++;
                    }

                    blacks_Hash.Add(name, blocks[i]);

                    ids.Add(name);
                }
                else if (blocks[i][j] == '.')
                {

                }
                else
                {
                }

            }
        }

        private void changeColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backGroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = color_Controler.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.BackColor = color_Controler.Color;
                backGroundColorToolStripMenuItem.BackColor = color_Controler.Color;
                menuStrip1.BackColor = color_Controler.Color;
            }
        }

        private void textFontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = color_Controler.ShowDialog();

            if (result == DialogResult.OK)
            {

                tb_Input.ForeColor = color_Controler.Color;
                tb_Output.ForeColor = color_Controler.Color;

            }
        }

        private void textBackGroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = color_Controler.ShowDialog();

            if (result == DialogResult.OK)
            {

                tb_Input.BackColor = color_Controler.Color;
                tb_Output.BackColor = color_Controler.Color;

            }
        }

        private void MenuStrip_Click(object sender, EventArgs e)
        {
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

        }
    }
}