using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Honor_Medal_Generator
{
    public partial class Form1 : Form
    {
        // Dictionary Library
        private Dictionary<string, string> captain_library = new Dictionary<string, string>
        {
            { "[Locked]", "" }, { "[Clean]", "00" }, { "HP", "01" }, { "MP", "02" }, { "Attack Rate", "06" }, { "Defense Rate", "07" }, { "HP Auto Heal", "25" }, { "MP Auto Heal", "26" },
            { "STR", "2D" }, { "INT", "2E" }, { "DEX", "2F" },{ "Ignore DMG Reduction", "49" }, { "Ignore Penetration", "4A" }, { "Evasion", "24" }, 
            { "Accuracy", "4F" }, { "Damage Reduction", "4E" }
        };

        private Dictionary<string, string> general_library = new Dictionary<string, string>
        {
            { "[Locked]", "" }, { "[Clean]", "00" }, { "MP", "02" }, { "Defense", "05" }, { "Attack Rate", "06" }, { "Defense Rate", "07" }, { "HP Auto Heal", "25" }, { "MP Auto Heal", "26" },
            { "All Attack UP", "71" }, { "Ignore Resist CDI", "7F" }, { "Add DMG", "27" },{ "Resist Critical DMG", "62" }, { "Resist Skill AMP", "70" }, { "Ignore Evasion", "47" },
            { "Ignore Accuracy", "48" }, { "Critical DMG", "08" }
        };

        private Dictionary<string, string> commander_library = new Dictionary<string, string>
        {
            { "[Locked]", "" }, { "[Clean]", "00" }, { "HP", "01" }, { "MP", "02" }, { "Attack Rate", "06" }, { "Defense Rate", "07" }, { "Ignore Evasion", "47" }, { "Ignore Accuracy", "48" },
            { "Ignore DMG Reduction", "49" }, { "Defense", "05" }, { "DMG Reduction", "4E" },{ "All Attack UP", "71" }, { "Resist Critical DMG", "62" }, { "Resist Down", "65" },
            { "Resist Knockback", "66" }, { "Resist Stun", "67" }, { "Resist Skill AMP", "70" }, { "All Skill AMP", "72" }, { "Accuracy", "4F" }
        };

        private Dictionary<string, string> hero_library = new Dictionary<string, string>
        {
            { "[Locked]", "" }, { "[Clean]", "00" }, { "MP", "02" }, { "Defense", "05" }, { "Attack Rate", "06" }, { "Defense Rate", "07" }, { "Ignore Evasion", "47" }, { "Ignore Accuracy", "48" },
            { "Ignore DMG Reduction", "49" }, { "Penetration", "50" }, { "Resist Skill AMP", "70" }, { "All Attack UP", "71" }, { "Ignore Resist Skill AMP", "80" }, { "Ignore Resist Critical DMG", "7F" },
            { "Ignore Resist Down", "81" }, { "Ignore Resist Knockback", "82" }, { "Ignore Resist Stun", "83" }
        };

        private Dictionary<string, string> legend_library = new Dictionary<string, string>
        {
            { "[Locked]", "" }, { "[Clean]", "00" }, { "HP", "01" }, { "Defense", "05" }, { "Attack Rate", "06" }, { "Defense Rate", "07" }, { "Ignore Evasion", "47" }, { "Accuracy", "4F" },
            { "Ignore DMG Reduction", "49" }, { "Cancel Ignore Penetration", "8B" }, { "Cancel Ignore DMG Reduction", "51" }, { "All Attack UP", "71" }, { "Ignore Resist Critical DMG", "7F" }, { "Resist Suppresion", "53" },
            { "Resist Silence", "55" }
        };

        public Form1()
        {
            InitializeComponent();

            string[] captainItems = { "[Locked]", "[Clean]", "HP", "MP", "Attack Rate", "Defense Rate", "HP Auto Heal", "MP Auto Heal", "STR", "INT", "DEX", "Ignore DMG Reduction", "Ignore Penetration", "Evasion", "Accuracy", "Damage Reduction" };
            string[] generalItems = { "[Locked]", "[Clean]", "MP", "Defense", "Attack Rate", "Defense Rate", "HP Auto Heal", "MP Auto Heal", "All Attack UP", "Ignore Resist CDI", "Add DMG", "Resist Critical DMG", "Resist Skill AMP", "Ignore Evasion", "Ignore Accuracy", "Critical DMG" };
            string[] commanderItems = { "[Locked]", "[Clean]", "HP", "MP", "Attack Rate", "Defense Rate", "Ignore Evasion", "Ignore Accuracy", "Ignore DMG Reduction", "Defense", "DMG Reduction", "All Attack UP", "Resist Critical DMG", "Resist Down", "Resist Knockback", "Resist Stun", "Resist Skill AMP", "All Skill AMP", "Accuracy" };
            string[] heroItems = { "[Locked]", "[Clean]", "MP", "Defense", "Attack Rate", "Defense Rate", "Ignore Evasion", "Ignore Accuracy", "Ignore DMG Reduction", "Penetration", "Resist Skill AMP", "All Attack UP", "Ignore Resist Skill AMP", "Ignore Resist Critical DMG", "Ignore Resist Down", "Ignore Resist Knockback", "Ignore Resist Stun" };
            string[] legendItems = { "[Locked]", "[Clean]", "HP", "Defense", "Attack Rate", "Defense Rate", "Ignore Evasion", "Accuracy", "Ignore DMG Reduction", "Cancel Ignore Penetration", "Cancel Ignore DMG Reduction", "All Attack UP", "Ignore Resist Critical DMG", "Resist Suppresion", "Resist Silence" };

            ComboBox[] captainBoxes = { comboBox1, comboBox2, comboBox3, comboBox4 };
            ComboBox[] generalBoxes = { comboBox5, comboBox6, comboBox7, comboBox8, comboBox9, comboBox10 };
            ComboBox[] commanderBoxes = { comboBox11, comboBox12, comboBox13, comboBox14, comboBox15, comboBox16, comboBox17, comboBox18 };
            ComboBox[] heroBoxes = { comboBox19, comboBox20, comboBox21, comboBox22, comboBox23, comboBox24, comboBox25, comboBox26, comboBox27, comboBox28 };
            ComboBox[] legendBoxes = { comboBox29, comboBox30, comboBox31, comboBox32, comboBox33, comboBox34, comboBox35, comboBox36, comboBox37, comboBox38, comboBox39, comboBox40 };

            foreach (ComboBox cb in captainBoxes) cb.Items.AddRange(captainItems);
            foreach (ComboBox cb in generalBoxes) cb.Items.AddRange(generalItems);
            foreach (ComboBox cb in commanderBoxes) cb.Items.AddRange(commanderItems);
            foreach (ComboBox cb in heroBoxes) cb.Items.AddRange(heroItems);
            foreach (ComboBox cb in legendBoxes) cb.Items.AddRange(legendItems);

            ComboBox[] comboBoxes = { comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6, comboBox7, comboBox8, comboBox9, comboBox10,
                                    comboBox11, comboBox12, comboBox13, comboBox14, comboBox15, comboBox16, comboBox17, comboBox18, comboBox19, comboBox20,
                                    comboBox21, comboBox22, comboBox23, comboBox24, comboBox25, comboBox26, comboBox27, comboBox28, comboBox29, comboBox30,
                                    comboBox31, comboBox32, comboBox33, comboBox34, comboBox35, comboBox36, comboBox37, comboBox38, comboBox39, comboBox40 };

            TextBox[] textBoxes = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10,
                                    textBox11, textBox12, textBox13, textBox14, textBox15, textBox16, textBox17, textBox18, textBox19, textBox20,
                                    textBox21, textBox22, textBox23, textBox24, textBox25, textBox26, textBox27, textBox28, textBox29, textBox30,
                                    textBox31, textBox32, textBox33, textBox34, textBox35, textBox36, textBox37, textBox38, textBox39, textBox40 };

            for (int i = 0; i < comboBoxes.Length; i++)
            {
                comboBoxes[i].SelectedIndex = 0;
                textBoxes[i].Text = "";
            }

            ComboBox[] comboBoxes_1 = {
            comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6, comboBox7, comboBox8, comboBox9, comboBox10,
            comboBox11, comboBox12, comboBox13, comboBox14, comboBox15, comboBox16, comboBox17, comboBox18, comboBox19, comboBox20,
            comboBox21, comboBox22, comboBox23, comboBox24, comboBox25, comboBox26, comboBox27, comboBox28, comboBox29, comboBox30,
            comboBox31, comboBox32, comboBox33, comboBox34, comboBox35, comboBox36, comboBox37, comboBox38, comboBox39, comboBox40
            };

            foreach (ComboBox cb in comboBoxes_1)
            {
                cb.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            }
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            Dictionary<int, string> prefixes = new Dictionary<int, string>
            {
                { 1, "000100000000" }, { 2, "000101000000" }, { 3, "000102000000" }, { 4, "000103000000" }, { 5, "000200000000" }, { 6, "000201000000" }, { 7, "000202000000" }, { 8, "000203000000" }, { 9, "000204000000" }, { 10, "000205000000" },
                { 11, "000300000000" }, { 12, "000301000000" }, { 13, "000302000000" }, { 14, "000303000000" }, { 15, "000304000000" }, { 16, "000305000000" }, { 17, "000306000000" }, { 18, "000307000000" },
                { 19, "000400000000" }, { 20, "000401000000" }, { 21, "000402000000" }, { 22, "000403000000" }, { 23, "000404000000" }, { 24, "000405000000" }, { 25, "000406000000" }, { 26, "000407000000" }, { 27, "000408000000" }, { 28, "000409000000" },
                { 29, "000500000000" }, { 30, "000501000000" }, { 31, "000502000000" }, { 32, "000503000000" }, { 33, "000504000000" }, { 34, "000505000000" }, { 35, "000506000000" }, { 36, "000507000000" }, { 37, "000508000000" }, { 38, "000509000000" },
                { 39, "00050A000000" }, { 40, "00050B000000" }
            };

            ComboBox[] comboBoxes = { comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6, comboBox7, comboBox8, comboBox9, comboBox10,
                        comboBox11, comboBox12, comboBox13, comboBox14, comboBox15, comboBox16, comboBox17, comboBox18, comboBox19, comboBox20, comboBox21
                        , comboBox22, comboBox23, comboBox24, comboBox25, comboBox26, comboBox27, comboBox28, comboBox29, comboBox30, comboBox31, comboBox32
                        , comboBox33, comboBox34, comboBox35, comboBox36, comboBox37, comboBox38, comboBox39, comboBox40 };

            TextBox[] textBoxes = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10,
                        textBox11, textBox12, textBox13, textBox14, textBox15, textBox16, textBox17, textBox18, textBox19, textBox20, textBox21, textBox22
                        , textBox23, textBox24, textBox25, textBox26, textBox27, textBox28, textBox29, textBox30, textBox31, textBox32, textBox33, textBox34
                        , textBox35, textBox36, textBox37, textBox38, textBox39, textBox40 };

            Dictionary<string, string>[] libraries = { captain_library, captain_library, captain_library, captain_library,
                        general_library, general_library, general_library, general_library, general_library, general_library, 
                        commander_library, commander_library, commander_library, commander_library, commander_library, commander_library, commander_library, commander_library,
                        hero_library, hero_library, hero_library, hero_library, hero_library, hero_library, hero_library, hero_library, hero_library, hero_library,
                        legend_library, legend_library, legend_library, legend_library, legend_library, legend_library, legend_library, legend_library, legend_library,
                        legend_library, legend_library, legend_library };

            for (int i = 0; i < comboBoxes.Length; i++)
            {
                textBoxes[i].Text = (comboBoxes[i].SelectedIndex == 0)
                    ? ""
                    : string.Join("", prefixes[i + 1] + (libraries[i].ContainsKey(comboBoxes[i].SelectedItem?.ToString())
                    ? libraries[i][comboBoxes[i].SelectedItem.ToString()] : "") + "00000001");
            }

            TextBox[] textBoxes2 = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10,
                                    textBox11, textBox12, textBox13, textBox14, textBox15, textBox16, textBox17, textBox18, textBox19, textBox20,
                                    textBox21, textBox22, textBox23, textBox24, textBox25, textBox26, textBox27, textBox28, textBox29, textBox30,
                                    textBox31, textBox32, textBox33, textBox34, textBox35, textBox36, textBox37, textBox38, textBox39, textBox40 };

            result_var.Text = "0x" + string.Join("", textBoxes2.Select(tb => tb.Text));


        }
    }
}
