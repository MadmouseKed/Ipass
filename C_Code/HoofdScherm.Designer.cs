
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
            this.DisPanelTest = new System.Windows.Forms.Panel();
            this.bttnCreateArray = new System.Windows.Forms.Button();
            this.bttnShowArray = new System.Windows.Forms.Button();
            this.txtboxDimensieX = new System.Windows.Forms.TextBox();
            this.labelDimensieX = new System.Windows.Forms.Label();
            this.labelDimensieY = new System.Windows.Forms.Label();
            this.txtboxDimensieY = new System.Windows.Forms.TextBox();
            this.txtboxShowArray = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtboxStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisPanelTest
            // 
            this.DisPanelTest.Location = new System.Drawing.Point(1574, 74);
            this.DisPanelTest.Name = "DisPanelTest";
            this.DisPanelTest.Size = new System.Drawing.Size(800, 800);
            this.DisPanelTest.TabIndex = 0;
            // 
            // bttnCreateArray
            // 
            this.bttnCreateArray.Location = new System.Drawing.Point(617, 353);
            this.bttnCreateArray.Name = "bttnCreateArray";
            this.bttnCreateArray.Size = new System.Drawing.Size(150, 46);
            this.bttnCreateArray.TabIndex = 1;
            this.bttnCreateArray.Text = "Creër array";
            this.bttnCreateArray.UseVisualStyleBackColor = true;
            this.bttnCreateArray.Click += new System.EventHandler(this.bttnCreateArray_Click);
            // 
            // bttnShowArray
            // 
            this.bttnShowArray.Location = new System.Drawing.Point(617, 405);
            this.bttnShowArray.Name = "bttnShowArray";
            this.bttnShowArray.Size = new System.Drawing.Size(150, 46);
            this.bttnShowArray.TabIndex = 2;
            this.bttnShowArray.Text = "Toon Array";
            this.bttnShowArray.UseVisualStyleBackColor = true;
            this.bttnShowArray.Click += new System.EventHandler(this.bttnShowArray_Click);
            // 
            // txtboxDimensieX
            // 
            this.txtboxDimensieX.Location = new System.Drawing.Point(617, 245);
            this.txtboxDimensieX.Name = "txtboxDimensieX";
            this.txtboxDimensieX.Size = new System.Drawing.Size(200, 39);
            this.txtboxDimensieX.TabIndex = 3;
            this.txtboxDimensieX.Text = "1";
            // 
            // labelDimensieX
            // 
            this.labelDimensieX.AutoSize = true;
            this.labelDimensieX.Location = new System.Drawing.Point(459, 245);
            this.labelDimensieX.Name = "labelDimensieX";
            this.labelDimensieX.Size = new System.Drawing.Size(152, 32);
            this.labelDimensieX.TabIndex = 4;
            this.labelDimensieX.Text = "Dimensie - X";
            // 
            // labelDimensieY
            // 
            this.labelDimensieY.AutoSize = true;
            this.labelDimensieY.Location = new System.Drawing.Point(459, 290);
            this.labelDimensieY.Name = "labelDimensieY";
            this.labelDimensieY.Size = new System.Drawing.Size(151, 32);
            this.labelDimensieY.TabIndex = 6;
            this.labelDimensieY.Text = "Dimensie - Y";
            // 
            // txtboxDimensieY
            // 
            this.txtboxDimensieY.Location = new System.Drawing.Point(617, 290);
            this.txtboxDimensieY.Name = "txtboxDimensieY";
            this.txtboxDimensieY.Size = new System.Drawing.Size(200, 39);
            this.txtboxDimensieY.TabIndex = 5;
            this.txtboxDimensieY.Text = "1";
            // 
            // txtboxShowArray
            // 
            this.txtboxShowArray.Location = new System.Drawing.Point(773, 409);
            this.txtboxShowArray.Multiline = true;
            this.txtboxShowArray.Name = "txtboxShowArray";
            this.txtboxShowArray.ReadOnly = true;
            this.txtboxShowArray.Size = new System.Drawing.Size(400, 326);
            this.txtboxShowArray.TabIndex = 7;
            this.txtboxShowArray.Text = "hoi";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Location = new System.Drawing.Point(909, 851);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(300, 200);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 8;
            // 
            // txtboxStatus
            // 
            this.txtboxStatus.Location = new System.Drawing.Point(773, 357);
            this.txtboxStatus.Name = "txtboxStatus";
            this.txtboxStatus.ReadOnly = true;
            this.txtboxStatus.Size = new System.Drawing.Size(400, 39);
            this.txtboxStatus.TabIndex = 9;
            this.txtboxStatus.Text = "None";
            // 
            // HoofdScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2447, 1303);
            this.Controls.Add(this.txtboxStatus);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.txtboxShowArray);
            this.Controls.Add(this.labelDimensieY);
            this.Controls.Add(this.txtboxDimensieY);
            this.Controls.Add(this.labelDimensieX);
            this.Controls.Add(this.txtboxDimensieX);
            this.Controls.Add(this.bttnShowArray);
            this.Controls.Add(this.bttnCreateArray);
            this.Controls.Add(this.DisPanelTest);
            this.Name = "HoofdScherm";
            this.Text = "Scherm1";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DisPanelTest;
        private System.Windows.Forms.Button bttnCreateArray;
        private System.Windows.Forms.Button bttnShowArray;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Label labelDimensieY;
        private System.Windows.Forms.TextBox txtboxDimensieY;
        private System.Windows.Forms.Label labelDimensieX;
        private System.Windows.Forms.TextBox txtboxDimensieX;
        private System.Diagnostics.Process process2;
        private System.Windows.Forms.TextBox txtboxShowArray;
        private System.Diagnostics.Process process3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtboxStatus;
    }
}

