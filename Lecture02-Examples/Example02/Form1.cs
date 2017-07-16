using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pokemonlibrary;

namespace Example02
{
    public partial class PokemonNameLable : Form
    {
        public PokemonNameLable()
        {
            InitializeComponent();
            PokemonNameLable = new PokemonNameLable
                name = "妙蛙種子",
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }
    }
}