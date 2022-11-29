using System.Windows.Forms.VisualStyles;
using WS.VisualizationUI.Model;

namespace WS.VisualizationUI
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serialNum = new System.Windows.Forms.TextBox();
            this.createGlassBtn = new System.Windows.Forms.Button();
            this.visualGlassBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pointDef = new System.Windows.Forms.RadioButton();
            this.edgeDef = new System.Windows.Forms.RadioButton();
            this.areaDef = new System.Windows.Forms.RadioButton();
            this.addDefBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.packNum = new System.Windows.Forms.TextBox();
            this.sendPackNumBtn = new System.Windows.Forms.Button();
            this.sendCodeBtn = new System.Windows.Forms.Button();
            this.deleteLastDeformBtn = new System.Windows.Forms.Button();
            this.code = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.byLabel = new System.Windows.Forms.Label();
            this.bxLabel = new System.Windows.Forms.Label();
            this.SignalRInfoLable = new System.Windows.Forms.Label();
            this.axCoordination = new System.Windows.Forms.NumericUpDown();
            this.ayCoordination = new System.Windows.Forms.NumericUpDown();
            this.bxCoordination = new System.Windows.Forms.NumericUpDown();
            this.byCoordination = new System.Windows.Forms.NumericUpDown();
            this.SignalRBut = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axCoordination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayCoordination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bxCoordination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.byCoordination)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create deformation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Package number";
            // 
            // serialNum
            // 
            this.serialNum.Location = new System.Drawing.Point(145, 35);
            this.serialNum.Name = "serialNum";
            this.serialNum.Size = new System.Drawing.Size(148, 23);
            this.serialNum.TabIndex = 3;
            // 
            // createGlassBtn
            // 
            this.createGlassBtn.Location = new System.Drawing.Point(374, 43);
            this.createGlassBtn.Name = "createGlassBtn";
            this.createGlassBtn.Size = new System.Drawing.Size(148, 23);
            this.createGlassBtn.TabIndex = 0;
            this.createGlassBtn.Text = "Create glass";
            this.createGlassBtn.UseVisualStyleBackColor = true;
            this.createGlassBtn.Click += new System.EventHandler(this.createGlassBtn_Click);
            // 
            // visualGlassBtn
            // 
            this.visualGlassBtn.Location = new System.Drawing.Point(662, 39);
            this.visualGlassBtn.Name = "visualGlassBtn";
            this.visualGlassBtn.Size = new System.Drawing.Size(148, 23);
            this.visualGlassBtn.TabIndex = 0;
            this.visualGlassBtn.Text = "Visual glass";
            this.visualGlassBtn.UseVisualStyleBackColor = true;
            this.visualGlassBtn.Click += new System.EventHandler(this.visualGlassBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Send code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Code";
            // 
            // pointDef
            // 
            this.pointDef.Location = new System.Drawing.Point(43, 124);
            this.pointDef.Name = "pointDef";
            this.pointDef.Size = new System.Drawing.Size(138, 24);
            this.pointDef.TabIndex = 4;
            this.pointDef.Text = "Point deformation";
            this.pointDef.CheckedChanged += new System.EventHandler(this.pointDef_CheckedChanged);
            // 
            // edgeDef
            // 
            this.edgeDef.Location = new System.Drawing.Point(43, 154);
            this.edgeDef.Name = "edgeDef";
            this.edgeDef.Size = new System.Drawing.Size(122, 24);
            this.edgeDef.TabIndex = 5;
            this.edgeDef.Text = "Edge deformation";
            this.edgeDef.CheckedChanged += new System.EventHandler(this.edgeDef_CheckedChanged);
            // 
            // areaDef
            // 
            this.areaDef.Location = new System.Drawing.Point(43, 184);
            this.areaDef.Name = "areaDef";
            this.areaDef.Size = new System.Drawing.Size(141, 24);
            this.areaDef.TabIndex = 6;
            this.areaDef.Text = "Area deformaion";
            this.areaDef.CheckedChanged += new System.EventHandler(this.areaDef_CheckedChanged);
            // 
            // addDefBtn
            // 
            this.addDefBtn.Location = new System.Drawing.Point(934, 131);
            this.addDefBtn.Name = "addDefBtn";
            this.addDefBtn.Size = new System.Drawing.Size(148, 23);
            this.addDefBtn.TabIndex = 0;
            this.addDefBtn.Text = "Add deformation";
            this.addDefBtn.UseVisualStyleBackColor = true;
            this.addDefBtn.Click += new System.EventHandler(this.addDefBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Send package number";
            // 
            // packNum
            // 
            this.packNum.Location = new System.Drawing.Point(145, 294);
            this.packNum.Name = "packNum";
            this.packNum.Size = new System.Drawing.Size(148, 23);
            this.packNum.TabIndex = 3;
            // 
            // sendPackNumBtn
            // 
            this.sendPackNumBtn.Location = new System.Drawing.Point(374, 297);
            this.sendPackNumBtn.Name = "sendPackNumBtn";
            this.sendPackNumBtn.Size = new System.Drawing.Size(148, 23);
            this.sendPackNumBtn.TabIndex = 0;
            this.sendPackNumBtn.Text = "Send";
            this.sendPackNumBtn.UseVisualStyleBackColor = true;
            this.sendPackNumBtn.Click += new System.EventHandler(this.sendPackNumBtn_Click);
            // 
            // sendCodeBtn
            // 
            this.sendCodeBtn.Location = new System.Drawing.Point(374, 377);
            this.sendCodeBtn.Name = "sendCodeBtn";
            this.sendCodeBtn.Size = new System.Drawing.Size(148, 23);
            this.sendCodeBtn.TabIndex = 0;
            this.sendCodeBtn.Text = "Send";
            this.sendCodeBtn.UseVisualStyleBackColor = true;
            this.sendCodeBtn.Click += new System.EventHandler(this.sendCodeBtn_Click);
            // 
            // deleteLastDeformBtn
            // 
            this.deleteLastDeformBtn.Location = new System.Drawing.Point(934, 211);
            this.deleteLastDeformBtn.Name = "deleteLastDeformBtn";
            this.deleteLastDeformBtn.Size = new System.Drawing.Size(148, 23);
            this.deleteLastDeformBtn.TabIndex = 0;
            this.deleteLastDeformBtn.Text = "Delete last deformation";
            this.deleteLastDeformBtn.UseVisualStyleBackColor = true;
            this.deleteLastDeformBtn.Click += new System.EventHandler(this.deleteLastDeformBtn_Click);
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(145, 369);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(148, 23);
            this.code.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(276, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "AY coordination";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(275, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "AX coordination";
            // 
            // byLabel
            // 
            this.byLabel.AutoSize = true;
            this.byLabel.Location = new System.Drawing.Point(554, 169);
            this.byLabel.Name = "byLabel";
            this.byLabel.Size = new System.Drawing.Size(92, 15);
            this.byLabel.TabIndex = 1;
            this.byLabel.Text = "BY coordination";
            // 
            // bxLabel
            // 
            this.bxLabel.AutoSize = true;
            this.bxLabel.Location = new System.Drawing.Point(554, 135);
            this.bxLabel.Name = "bxLabel";
            this.bxLabel.Size = new System.Drawing.Size(92, 15);
            this.bxLabel.TabIndex = 1;
            this.bxLabel.Text = "BX coordination";
            // 
            // SignalRInfoLable
            // 
            this.SignalRInfoLable.AutoSize = true;
            this.SignalRInfoLable.Location = new System.Drawing.Point(931, 424);
            this.SignalRInfoLable.Name = "SignalRInfoLable";
            this.SignalRInfoLable.Size = new System.Drawing.Size(111, 15);
            this.SignalRInfoLable.TabIndex = 1;
            this.SignalRInfoLable.Text = "SignalR Connection";
            // 
            // axCoordination
            // 
            this.axCoordination.Location = new System.Drawing.Point(374, 127);
            this.axCoordination.Maximum = new decimal(new int[] {
            3210,
            0,
            0,
            0});
            this.axCoordination.Name = "axCoordination";
            this.axCoordination.Size = new System.Drawing.Size(148, 23);
            this.axCoordination.TabIndex = 2;
            // 
            // ayCoordination
            // 
            this.ayCoordination.Location = new System.Drawing.Point(374, 167);
            this.ayCoordination.Maximum = new decimal(new int[] {
            3210,
            0,
            0,
            0});
            this.ayCoordination.Name = "ayCoordination";
            this.ayCoordination.Size = new System.Drawing.Size(148, 23);
            this.ayCoordination.TabIndex = 2;
            // 
            // bxCoordination
            // 
            this.bxCoordination.Location = new System.Drawing.Point(662, 127);
            this.bxCoordination.Maximum = new decimal(new int[] {
            3210,
            0,
            0,
            0});
            this.bxCoordination.Name = "bxCoordination";
            this.bxCoordination.Size = new System.Drawing.Size(148, 23);
            this.bxCoordination.TabIndex = 2;
            // 
            // byCoordination
            // 
            this.byCoordination.Location = new System.Drawing.Point(662, 167);
            this.byCoordination.Maximum = new decimal(new int[] {
            3210,
            0,
            0,
            0});
            this.byCoordination.Name = "byCoordination";
            this.byCoordination.Size = new System.Drawing.Size(148, 23);
            this.byCoordination.TabIndex = 2;
            // 
            // SignalRBut
            // 
            this.SignalRBut.BackColor = System.Drawing.Color.Red;
            this.SignalRBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SignalRBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignalRBut.ForeColor = System.Drawing.Color.Transparent;
            this.SignalRBut.Location = new System.Drawing.Point(1049, 418);
            this.SignalRBut.Name = "SignalRBut";
            this.SignalRBut.Size = new System.Drawing.Size(33, 27);
            this.SignalRBut.TabIndex = 7;
            this.SignalRBut.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Serial number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Send glass";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 457);
            this.Controls.Add(this.SignalRBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serialNum);
            this.Controls.Add(this.createGlassBtn);
            this.Controls.Add(this.visualGlassBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pointDef);
            this.Controls.Add(this.edgeDef);
            this.Controls.Add(this.areaDef);
            this.Controls.Add(this.addDefBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.packNum);
            this.Controls.Add(this.sendPackNumBtn);
            this.Controls.Add(this.sendCodeBtn);
            this.Controls.Add(this.code);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.byLabel);
            this.Controls.Add(this.bxLabel);
            this.Controls.Add(this.axCoordination);
            this.Controls.Add(this.ayCoordination);
            this.Controls.Add(this.bxCoordination);
            this.Controls.Add(this.byCoordination);
            this.Controls.Add(this.deleteLastDeformBtn);
            this.Controls.Add(this.SignalRInfoLable);
            this.Name = "Form1";
            this.Text = "VisualizationUI";
            ((System.ComponentModel.ISupportInitialize)(this.axCoordination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayCoordination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bxCoordination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.byCoordination)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label3;
        private TextBox serialNum;
        private Button createGlassBtn;
        private Button visualGlassBtn;
        private NumericUpDown axCoordination;
        private Label label4;
        private Label label5;
        private NumericUpDown ayCoordination;
        private RadioButton pointDef;
        private RadioButton edgeDef;
        private RadioButton areaDef;
        private Button addDefBtn;
        private Label label9;
        private TextBox packNum;
        private Button sendPackNumBtn;
        private Button sendCodeBtn;
        private TextBox code;
        private Label label10;
        private Label label11;
        private Label byLabel;
        private NumericUpDown byCoordination;
        private Label bxLabel;
        private NumericUpDown bxCoordination;
        private Button deleteLastDeformBtn;
        private Label SignalRInfoLable;
        private Button SignalRBut;
        private Label label8;
        private Label label7;
    }
}