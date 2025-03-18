using System.Media;
using System.Numerics;
using Engine;

namespace C__Simple_RPG
{
    public partial class SimpleRpg : Form
    {
        private Player _player;
        public SimpleRpg()
        {
            InitializeComponent();
            _player = new Engine.Player(10, 10, 20, 0, 1);
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();

            Location lokacja = new Location(1, "Home", "This is your house");

        }

        private void SimpleRpg_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnEast_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
