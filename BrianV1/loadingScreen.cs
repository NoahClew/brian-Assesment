using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrianV1
{
    public partial class loadingScreen : Form
    {

        List<string> facts = new List<string>();
        Random rand = new Random();
        public loadingScreen()
        {
            InitializeComponent();
            facts.Add("Avocados are a fruit, not a vegetable. They're technically considered a single-seeded berry");
            facts.Add("The Eiffel Tower can be 15 cm taller during the summer, due to thermal expansion meaning the iron heats up, the particles gain kinetic energy and take up more space.");
            facts.Add("Australia is wider than the moon. The moon sits at 3400km in diameter, while Australia’s diameter from east to west is almost 4000km.");
            facts.Add("It's illegal to own just one guinea pig in Switzerland. It's considered animal abuse because they're social beings and get lonely.");
            facts.Add("You can hear a blue whale's heartbeat from over 2 miles away");
            facts.Add("The last letter added to the English alphabet was 'J'");
            facts.Add("Ketchup was once sold as medicine");
            facts.Add("The real name for a hashtag is an octothorpe");
            facts.Add("Queen Elizabeth II is a trained mechanic");
            facts.Add("The Spanish national anthem has no words");
            facts.Add("Nutmeg is a hallucinogen. The spice contains myristicin, a natural compound that has mind-altering effects if ingested in large doses.");
            facts.Add(" The platypus doesn’t have a stomach at all: Their esophagus goes straight to their intestines.");
            facts.Add("Mosquitoes are the deadliest animal in the world: They kill more people than any other creature, due to the diseases they carry");
            facts.Add("Skin is the body’s largest organ.");
            facts.Add("It takes 570 gallons to paint the exterior of the White House.");
            facts.Add(" Each year 16 million thunderstorms happen around the world, and at any given moment, there are about 2,000 thunderstorms in progress.");
            facts.Add("there are over 200 dead bodies of climbers on Mt. Everest because it’s so difficult to bring them down");
            facts.Add("Dead skin cells are a main ingredient in household dust");
            facts.Add(" The circulatory system is more than 60,000 miles long");
            facts.Add("The world’s first animated feature film was made in Argentina");
            facts.Add("German chocolate cake was invented in Texas");

            lblFact.Text = facts[rand.Next(0, 19)];
        }

        private void tmrLoad_Tick(object sender, EventArgs e)
        {
            tmrLoad.Stop();
            Level1 L1 = new Level1();
            L1.ShowDialog();
            
        }
    }
}
