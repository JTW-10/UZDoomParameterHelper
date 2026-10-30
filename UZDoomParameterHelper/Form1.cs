namespace UZDoomParameterHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                string parameters = "";
                string skillLevel = cmbSkill.SelectedItem?.ToString() switch
                {
                    "I'm Too Young To Die" => "1",
                    "Hey, Not Too Rough" => "2",
                    "Hurt Me Plenty" => "3",
                    "Ultra-Violence" => "4",
                    "Nightmare!" => "5",
                    _ => string.Empty
                };
                string fileName = cmbFile.SelectedItem?.ToString() switch
                {
                    "Brutal Doom (brutalv21.pk3)" => "brutalv21.pk3",
                    "Final Doomer (FinalDoomer_v3.4.pk3)" => "FinalDoomer_v3.4.pk3",
                    "Doom Deluxe (DoomDeluxe.pk3)" => "DoomDeluxe.pk3",
                    _ => string.Empty
                };

                int.TryParse(txtLevel.Text, out int levelNumber);

                if (!string.IsNullOrEmpty(skillLevel))
                {
                    parameters += $" -skill {skillLevel}";
                }

                if (!string.IsNullOrEmpty(fileName))
                {
                    parameters += $" -file {fileName}";
                }

                if (levelNumber > 0)
                {
                    parameters += $" -warp {levelNumber}";
                }

                if (chkFast.Checked)
                {
                    parameters += " -fast";
                }

                txtParameters.Text = string.IsNullOrWhiteSpace(parameters)
                    ? "You're usually meant to fill in the blanks before you hit that button."
                    : parameters.Trim();
            }
            catch
            {
                txtParameters.Text = "Something went wrong. I blame the demon invasion.";
            }
        }
    }
}
