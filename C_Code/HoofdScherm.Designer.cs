
namespace C_Code
{
    partial class HoofdScherm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtboxDimensieX = new System.Windows.Forms.TextBox();
            this.labelDimensieX = new System.Windows.Forms.Label();
            this.labelDimensieY = new System.Windows.Forms.Label();
            this.txtboxDimensieY = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtboxSeed = new System.Windows.Forms.TextBox();
            this.bttnRunEngine = new System.Windows.Forms.Button();
            this.bttnShowPerlinMap = new System.Windows.Forms.Button();
            this.txtboxSmootheness = new System.Windows.Forms.TextBox();
            this.labelSmootheness = new System.Windows.Forms.Label();
            this.labelDepth = new System.Windows.Forms.Label();
            this.txtboxDepth = new System.Windows.Forms.TextBox();
            this.bttnRunTest = new System.Windows.Forms.Button();
            this.bttnShowSmootheMap = new System.Windows.Forms.Button();
            this.labelSeed = new System.Windows.Forms.Label();
            this.labelPerNoiseOptions = new System.Windows.Forms.Label();
            this.labelGenericMapOptions = new System.Windows.Forms.Label();
            this.labelSmootheMapOptions = new System.Windows.Forms.Label();
            this.labelStrictness = new System.Windows.Forms.Label();
            this.txtboxStrictness = new System.Windows.Forms.TextBox();
            this.txtboxProgressReport = new System.Windows.Forms.TextBox();
            this.labelShowMapOptions = new System.Windows.Forms.Label();
            this.labelPerlinMapPixelSize = new System.Windows.Forms.Label();
            this.txtboxPerlinMapPixelSize = new System.Windows.Forms.TextBox();
            this.labelMapPixelSize = new System.Windows.Forms.Label();
            this.txtboxMapPixelSize = new System.Windows.Forms.TextBox();
            this.labelStrictness2 = new System.Windows.Forms.Label();
            this.txtboxStrictness2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtboxDimensieX
            // 
            this.txtboxDimensieX.Location = new System.Drawing.Point(171, 51);
            this.txtboxDimensieX.Name = "txtboxDimensieX";
            this.txtboxDimensieX.Size = new System.Drawing.Size(200, 39);
            this.txtboxDimensieX.TabIndex = 3;
            this.txtboxDimensieX.Text = "24";
            // 
            // labelDimensieX
            // 
            this.labelDimensieX.AutoSize = true;
            this.labelDimensieX.Location = new System.Drawing.Point(13, 51);
            this.labelDimensieX.Name = "labelDimensieX";
            this.labelDimensieX.Size = new System.Drawing.Size(152, 32);
            this.labelDimensieX.TabIndex = 4;
            this.labelDimensieX.Text = "Dimensie - X";
            // 
            // labelDimensieY
            // 
            this.labelDimensieY.AutoSize = true;
            this.labelDimensieY.Location = new System.Drawing.Point(13, 96);
            this.labelDimensieY.Name = "labelDimensieY";
            this.labelDimensieY.Size = new System.Drawing.Size(151, 32);
            this.labelDimensieY.TabIndex = 6;
            this.labelDimensieY.Text = "Dimensie - Y";
            // 
            // txtboxDimensieY
            // 
            this.txtboxDimensieY.Location = new System.Drawing.Point(171, 96);
            this.txtboxDimensieY.Name = "txtboxDimensieY";
            this.txtboxDimensieY.Size = new System.Drawing.Size(200, 39);
            this.txtboxDimensieY.TabIndex = 5;
            this.txtboxDimensieY.Text = "24";
            // 
            // txtboxSeed
            // 
            this.txtboxSeed.Location = new System.Drawing.Point(462, 51);
            this.txtboxSeed.Name = "txtboxSeed";
            this.txtboxSeed.Size = new System.Drawing.Size(200, 39);
            this.txtboxSeed.TabIndex = 11;
            this.txtboxSeed.Text = "1294";
            // 
            // bttnRunEngine
            // 
            this.bttnRunEngine.Location = new System.Drawing.Point(171, 141);
            this.bttnRunEngine.Name = "bttnRunEngine";
            this.bttnRunEngine.Size = new System.Drawing.Size(150, 46);
            this.bttnRunEngine.TabIndex = 12;
            this.bttnRunEngine.Text = "Run Engine";
            this.bttnRunEngine.UseVisualStyleBackColor = true;
            this.bttnRunEngine.Click += new System.EventHandler(this.bttnRunEngine_Click);
            // 
            // bttnShowPerlinMap
            // 
            this.bttnShowPerlinMap.Location = new System.Drawing.Point(327, 141);
            this.bttnShowPerlinMap.Name = "bttnShowPerlinMap";
            this.bttnShowPerlinMap.Size = new System.Drawing.Size(201, 46);
            this.bttnShowPerlinMap.TabIndex = 13;
            this.bttnShowPerlinMap.Text = "Show PerlinMap";
            this.bttnShowPerlinMap.UseVisualStyleBackColor = true;
            this.bttnShowPerlinMap.Click += new System.EventHandler(this.bttnShowPerlinMap_Click);
            // 
            // txtboxSmootheness
            // 
            this.txtboxSmootheness.Location = new System.Drawing.Point(196, 290);
            this.txtboxSmootheness.Name = "txtboxSmootheness";
            this.txtboxSmootheness.Size = new System.Drawing.Size(200, 39);
            this.txtboxSmootheness.TabIndex = 14;
            this.txtboxSmootheness.Text = "4";
            // 
            // labelSmootheness
            // 
            this.labelSmootheness.AutoSize = true;
            this.labelSmootheness.Location = new System.Drawing.Point(12, 293);
            this.labelSmootheness.Name = "labelSmootheness";
            this.labelSmootheness.Size = new System.Drawing.Size(178, 32);
            this.labelSmootheness.TabIndex = 15;
            this.labelSmootheness.Text = "Smoothen runs";
            // 
            // labelDepth
            // 
            this.labelDepth.AutoSize = true;
            this.labelDepth.Location = new System.Drawing.Point(373, 99);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(80, 32);
            this.labelDepth.TabIndex = 17;
            this.labelDepth.Text = "Depth";
            // 
            // txtboxDepth
            // 
            this.txtboxDepth.Location = new System.Drawing.Point(462, 96);
            this.txtboxDepth.Name = "txtboxDepth";
            this.txtboxDepth.Size = new System.Drawing.Size(200, 39);
            this.txtboxDepth.TabIndex = 16;
            this.txtboxDepth.Text = "64";
            // 
            // bttnRunTest
            // 
            this.bttnRunTest.Location = new System.Drawing.Point(15, 141);
            this.bttnRunTest.Name = "bttnRunTest";
            this.bttnRunTest.Size = new System.Drawing.Size(150, 46);
            this.bttnRunTest.TabIndex = 18;
            this.bttnRunTest.Text = "Run Test";
            this.bttnRunTest.UseVisualStyleBackColor = true;
            this.bttnRunTest.Click += new System.EventHandler(this.bttnRunTest_Click);
            // 
            // bttnShowSmootheMap
            // 
            this.bttnShowSmootheMap.Location = new System.Drawing.Point(15, 193);
            this.bttnShowSmootheMap.Name = "bttnShowSmootheMap";
            this.bttnShowSmootheMap.Size = new System.Drawing.Size(247, 46);
            this.bttnShowSmootheMap.TabIndex = 19;
            this.bttnShowSmootheMap.Text = "Show Smoothemap";
            this.bttnShowSmootheMap.UseVisualStyleBackColor = true;
            this.bttnShowSmootheMap.Click += new System.EventHandler(this.bttnShowSmootheMap_Click);
            // 
            // labelSeed
            // 
            this.labelSeed.AutoSize = true;
            this.labelSeed.Location = new System.Drawing.Point(389, 51);
            this.labelSeed.Name = "labelSeed";
            this.labelSeed.Size = new System.Drawing.Size(67, 32);
            this.labelSeed.TabIndex = 20;
            this.labelSeed.Text = "Seed";
            // 
            // labelPerNoiseOptions
            // 
            this.labelPerNoiseOptions.AutoSize = true;
            this.labelPerNoiseOptions.Location = new System.Drawing.Point(389, 9);
            this.labelPerNoiseOptions.Name = "labelPerNoiseOptions";
            this.labelPerNoiseOptions.Size = new System.Drawing.Size(232, 32);
            this.labelPerNoiseOptions.TabIndex = 21;
            this.labelPerNoiseOptions.Text = "Perlin Noise Options";
            // 
            // labelGenericMapOptions
            // 
            this.labelGenericMapOptions.AutoSize = true;
            this.labelGenericMapOptions.Location = new System.Drawing.Point(54, 9);
            this.labelGenericMapOptions.Name = "labelGenericMapOptions";
            this.labelGenericMapOptions.Size = new System.Drawing.Size(241, 32);
            this.labelGenericMapOptions.TabIndex = 22;
            this.labelGenericMapOptions.Text = "Generic Map Options";
            // 
            // labelSmootheMapOptions
            // 
            this.labelSmootheMapOptions.AutoSize = true;
            this.labelSmootheMapOptions.Location = new System.Drawing.Point(63, 248);
            this.labelSmootheMapOptions.Name = "labelSmootheMapOptions";
            this.labelSmootheMapOptions.Size = new System.Drawing.Size(257, 32);
            this.labelSmootheMapOptions.TabIndex = 23;
            this.labelSmootheMapOptions.Text = "Smoothe Map Options";
            // 
            // labelStrictness
            // 
            this.labelStrictness.AutoSize = true;
            this.labelStrictness.Location = new System.Drawing.Point(12, 338);
            this.labelStrictness.Name = "labelStrictness";
            this.labelStrictness.Size = new System.Drawing.Size(114, 32);
            this.labelStrictness.TabIndex = 25;
            this.labelStrictness.Text = "Strictness";
            // 
            // txtboxStrictness
            // 
            this.txtboxStrictness.Location = new System.Drawing.Point(196, 335);
            this.txtboxStrictness.Name = "txtboxStrictness";
            this.txtboxStrictness.Size = new System.Drawing.Size(200, 39);
            this.txtboxStrictness.TabIndex = 24;
            this.txtboxStrictness.Text = "0,12";
            // 
            // txtboxProgressReport
            // 
            this.txtboxProgressReport.Location = new System.Drawing.Point(402, 290);
            this.txtboxProgressReport.Multiline = true;
            this.txtboxProgressReport.Name = "txtboxProgressReport";
            this.txtboxProgressReport.ReadOnly = true;
            this.txtboxProgressReport.Size = new System.Drawing.Size(260, 327);
            this.txtboxProgressReport.TabIndex = 26;
            this.txtboxProgressReport.Text = "Progress Report";
            // 
            // labelShowMapOptions
            // 
            this.labelShowMapOptions.AutoSize = true;
            this.labelShowMapOptions.Location = new System.Drawing.Point(34, 483);
            this.labelShowMapOptions.Name = "labelShowMapOptions";
            this.labelShowMapOptions.Size = new System.Drawing.Size(218, 32);
            this.labelShowMapOptions.TabIndex = 27;
            this.labelShowMapOptions.Text = "Show Map Options";
            // 
            // labelPerlinMapPixelSize
            // 
            this.labelPerlinMapPixelSize.AutoSize = true;
            this.labelPerlinMapPixelSize.Location = new System.Drawing.Point(8, 524);
            this.labelPerlinMapPixelSize.Name = "labelPerlinMapPixelSize";
            this.labelPerlinMapPixelSize.Size = new System.Drawing.Size(179, 32);
            this.labelPerlinMapPixelSize.TabIndex = 29;
            this.labelPerlinMapPixelSize.Text = "Perlin Pixel Size";
            // 
            // txtboxPerlinMapPixelSize
            // 
            this.txtboxPerlinMapPixelSize.Location = new System.Drawing.Point(192, 521);
            this.txtboxPerlinMapPixelSize.Name = "txtboxPerlinMapPixelSize";
            this.txtboxPerlinMapPixelSize.Size = new System.Drawing.Size(200, 39);
            this.txtboxPerlinMapPixelSize.TabIndex = 28;
            this.txtboxPerlinMapPixelSize.Text = "2";
            // 
            // labelMapPixelSize
            // 
            this.labelMapPixelSize.AutoSize = true;
            this.labelMapPixelSize.Location = new System.Drawing.Point(8, 569);
            this.labelMapPixelSize.Name = "labelMapPixelSize";
            this.labelMapPixelSize.Size = new System.Drawing.Size(168, 32);
            this.labelMapPixelSize.TabIndex = 31;
            this.labelMapPixelSize.Text = "Map Pixel Size";
            // 
            // txtboxMapPixelSize
            // 
            this.txtboxMapPixelSize.Location = new System.Drawing.Point(192, 566);
            this.txtboxMapPixelSize.Name = "txtboxMapPixelSize";
            this.txtboxMapPixelSize.Size = new System.Drawing.Size(200, 39);
            this.txtboxMapPixelSize.TabIndex = 30;
            this.txtboxMapPixelSize.Text = "20";
            // 
            // labelStrictness2
            // 
            this.labelStrictness2.AutoSize = true;
            this.labelStrictness2.Location = new System.Drawing.Point(12, 385);
            this.labelStrictness2.Name = "labelStrictness2";
            this.labelStrictness2.Size = new System.Drawing.Size(114, 32);
            this.labelStrictness2.TabIndex = 32;
            this.labelStrictness2.Text = "Strictness";
            // 
            // txtboxStrictness2
            // 
            this.txtboxStrictness2.Location = new System.Drawing.Point(196, 378);
            this.txtboxStrictness2.Name = "txtboxStrictness2";
            this.txtboxStrictness2.Size = new System.Drawing.Size(200, 39);
            this.txtboxStrictness2.TabIndex = 33;
            this.txtboxStrictness2.Text = "0,5";
            // 
            // HoofdScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 637);
            this.Controls.Add(this.txtboxStrictness2);
            this.Controls.Add(this.labelStrictness2);
            this.Controls.Add(this.labelMapPixelSize);
            this.Controls.Add(this.txtboxMapPixelSize);
            this.Controls.Add(this.labelPerlinMapPixelSize);
            this.Controls.Add(this.txtboxPerlinMapPixelSize);
            this.Controls.Add(this.labelShowMapOptions);
            this.Controls.Add(this.txtboxProgressReport);
            this.Controls.Add(this.labelStrictness);
            this.Controls.Add(this.txtboxStrictness);
            this.Controls.Add(this.labelSmootheMapOptions);
            this.Controls.Add(this.labelGenericMapOptions);
            this.Controls.Add(this.labelPerNoiseOptions);
            this.Controls.Add(this.labelSeed);
            this.Controls.Add(this.bttnShowSmootheMap);
            this.Controls.Add(this.bttnRunTest);
            this.Controls.Add(this.labelDepth);
            this.Controls.Add(this.txtboxDepth);
            this.Controls.Add(this.labelSmootheness);
            this.Controls.Add(this.txtboxSmootheness);
            this.Controls.Add(this.bttnShowPerlinMap);
            this.Controls.Add(this.bttnRunEngine);
            this.Controls.Add(this.txtboxSeed);
            this.Controls.Add(this.labelDimensieY);
            this.Controls.Add(this.txtboxDimensieY);
            this.Controls.Add(this.labelDimensieX);
            this.Controls.Add(this.txtboxDimensieX);
            this.Name = "HoofdScherm";
            this.Text = "Scherm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDimensieY;
        private System.Windows.Forms.TextBox txtboxDimensieY;
        private System.Windows.Forms.Label labelDimensieX;
        private System.Windows.Forms.TextBox txtboxDimensieX;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtboxSeed;
        private System.Windows.Forms.Button bttnRunEngine;
        private System.Windows.Forms.Button bttnShowPerlinMap;
        private System.Windows.Forms.TextBox txtboxSmootheness;
        private System.Windows.Forms.Label labelSmootheness;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.TextBox txtboxDepth;
        private System.Windows.Forms.Button bttnRunTest;
        private System.Windows.Forms.Button bttnShowSmootheMap;
        private System.Windows.Forms.Label labelSeed;
        private System.Windows.Forms.Label labelPerNoiseOptions;
        private System.Windows.Forms.Label labelGenericMapOptions;
        private System.Windows.Forms.Label labelSmootheMapOptions;
        private System.Windows.Forms.Label labelStrictness;
        private System.Windows.Forms.TextBox txtboxStrictness;
        private System.Windows.Forms.TextBox txtboxProgressReport;
        private System.Windows.Forms.Label labelShowMapOptions;
        private System.Windows.Forms.Label labelPerlinMapPixelSize;
        private System.Windows.Forms.TextBox txtboxPerlinMapPixelSize;
        private System.Windows.Forms.Label labelMapPixelSize;
        private System.Windows.Forms.TextBox txtboxMapPixelSize;
        private System.Windows.Forms.Label labelStrictness2;
        private System.Windows.Forms.TextBox txtboxStrictness2;
    }
}

