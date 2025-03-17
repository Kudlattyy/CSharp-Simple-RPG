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
            _player = new Engine.Player();
            _player.CurrentHitPoints = 10;
            _player.MaximumHitPoints = 10;
            _player.Gold = 20;
            _player.ExperiencePoints = 0;
            _player.Level = 1;
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

        private void SimpleRpg_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
