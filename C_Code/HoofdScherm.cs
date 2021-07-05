using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Code
{
    public partial class HoofdScherm : Form
    {   //Storage maybe make more elegant later?
        private MapGen.Arr HoofdSchermArray;
        private Random Seed;

        private MapGen.Arr InitialArray;
        private MapGen.PerlinNoise PerlinNoise;
        private MapGen.SmootheMap SmootheMap;

        /// <summary>
        /// Do not worry about the components, they were generated with visual studio's designer. They are arcane
        /// wizardry, but they all work.
        /// </summary>
        public HoofdScherm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This button does the heavy lifting. It basicly runs all teh processes necessery and informs the user of
        /// what is going on with the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnRunEngine_Click(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            txtboxProgressReport.Text = "Begining progress... \n";
            txtboxProgressReport.Text += "Initializing Array... \n";
            InitialArray = new MapGen.Arr(Int32.Parse(txtboxDimensieX.Text), Int32.Parse(txtboxDimensieY.Text));
            txtboxProgressReport.Text += "Done! \n" +
                "Generating PerlinNoise Array... \n";
            PerlinNoise = new MapGen.PerlinNoise(Int32.Parse(txtboxSeed.Text),Int32.Parse(txtboxDepth.Text), InitialArray, Int32.Parse(txtboxDimensieX.Text), Int32.Parse(txtboxDimensieY.Text));
            txtboxProgressReport.Text += "Done! \n" +
                "Generating SmootheMap Array... \n";
            SmootheMap = new MapGen.SmootheMap(PerlinNoise, Int32.Parse(txtboxSmootheness.Text), Single.Parse(txtboxStrictness.Text), Single.Parse(txtboxStrictness2.Text), Int32.Parse(txtboxDimensieX.Text), Int32.Parse(txtboxDimensieY.Text), Int32.Parse(txtboxDepth.Text));
            txtboxProgressReport.Text += "Done! \n";
            watch.Stop();
            txtboxProgressReport.Text += "The whole run took " + watch.ElapsedMilliseconds +"ms";
        }

        /// <summary>
        /// This code show sthe generated Perlin Noise Map. It's not necessery but looks cool (Handy for debugging too)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnShowPerlinMap_Click(object sender, EventArgs e)
        {
            /*Application.Run(new MapScreen(20, PerlinNoise.getPerNoiseMap()));*/
            Form Mappy = new MapScreen(Int32.Parse(txtboxPerlinMapPixelSize.Text), PerlinNoise.getPerNoiseMap());
            Mappy.Show();
        }

        /// <summary>
        /// This code runs the test, since I am too dummy to make the default test code work q.q
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnRunTest_Click(object sender, EventArgs e)
        {
            UnitTests testResult = new UnitTests();
        }// This button calls the unit tests.

        /// <summary>
        /// This code is for showing the smoothemap result to the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnShowSmootheMap_Click(object sender, EventArgs e)
        {
            Form Mappy = new MapScreen(Int32.Parse(txtboxMapPixelSize.Text), SmootheMap.GetValuesMap());
            Mappy.Show();
        }
    }
}
