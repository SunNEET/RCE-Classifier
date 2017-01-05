namespace NN_Final
{
    partial class NN_Final
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NN_Final));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_ComputerRCE = new System.Windows.Forms.Button();
            this.button_RandomGenerate = new System.Windows.Forms.Button();
            this.button_CLR_Input = new System.Windows.Forms.Button();
            this.dataGridView_PosList = new System.Windows.Forms.DataGridView();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButton_ClassA = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButton_ClassB = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton_ClassC = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_InputZone = new System.Windows.Forms.PictureBox();
            this.richTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.label_trOutLog = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PosList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_InputZone)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.pictureBox_InputZone);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 606);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_ComputerRCE);
            this.groupBox1.Controls.Add(this.button_RandomGenerate);
            this.groupBox1.Controls.Add(this.button_CLR_Input);
            this.groupBox1.Controls.Add(this.dataGridView_PosList);
            this.groupBox1.Controls.Add(this.radioButton_ClassA);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.radioButton_ClassB);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.radioButton_ClassC);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(709, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 600);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RCE Classifier";
            // 
            // button_ComputerRCE
            // 
            this.button_ComputerRCE.Location = new System.Drawing.Point(17, 105);
            this.button_ComputerRCE.Name = "button_ComputerRCE";
            this.button_ComputerRCE.Size = new System.Drawing.Size(151, 35);
            this.button_ComputerRCE.TabIndex = 9;
            this.button_ComputerRCE.Text = "Compute";
            this.button_ComputerRCE.UseVisualStyleBackColor = true;
            this.button_ComputerRCE.Click += new System.EventHandler(this.button_ComputerRCE_Click);
            // 
            // button_RandomGenerate
            // 
            this.button_RandomGenerate.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_RandomGenerate.Location = new System.Drawing.Point(85, 25);
            this.button_RandomGenerate.Name = "button_RandomGenerate";
            this.button_RandomGenerate.Size = new System.Drawing.Size(83, 35);
            this.button_RandomGenerate.TabIndex = 10;
            this.button_RandomGenerate.Text = "RANDOM";
            this.button_RandomGenerate.UseVisualStyleBackColor = true;
            this.button_RandomGenerate.Click += new System.EventHandler(this.button_RandomGenerate_Click);
            // 
            // button_CLR_Input
            // 
            this.button_CLR_Input.Location = new System.Drawing.Point(85, 66);
            this.button_CLR_Input.Name = "button_CLR_Input";
            this.button_CLR_Input.Size = new System.Drawing.Size(83, 35);
            this.button_CLR_Input.TabIndex = 9;
            this.button_CLR_Input.Text = "CLR";
            this.button_CLR_Input.UseVisualStyleBackColor = true;
            this.button_CLR_Input.Click += new System.EventHandler(this.button_CLR_Input_Click);
            // 
            // dataGridView_PosList
            // 
            this.dataGridView_PosList.AllowUserToAddRows = false;
            this.dataGridView_PosList.AllowUserToDeleteRows = false;
            this.dataGridView_PosList.AllowUserToResizeColumns = false;
            this.dataGridView_PosList.AllowUserToResizeRows = false;
            this.dataGridView_PosList.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dataGridView_PosList.CausesValidation = false;
            this.dataGridView_PosList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_PosList.ColumnHeadersVisible = false;
            this.dataGridView_PosList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ID,
            this.Column_Pos});
            this.dataGridView_PosList.Location = new System.Drawing.Point(18, 146);
            this.dataGridView_PosList.MultiSelect = false;
            this.dataGridView_PosList.Name = "dataGridView_PosList";
            this.dataGridView_PosList.ReadOnly = true;
            this.dataGridView_PosList.RowTemplate.Height = 24;
            this.dataGridView_PosList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_PosList.Size = new System.Drawing.Size(150, 440);
            this.dataGridView_PosList.TabIndex = 8;
            // 
            // Column_ID
            // 
            this.Column_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_ID.HeaderText = "ID";
            this.Column_ID.Name = "Column_ID";
            this.Column_ID.ReadOnly = true;
            this.Column_ID.Width = 27;
            // 
            // Column_Pos
            // 
            this.Column_Pos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_Pos.HeaderText = "Position";
            this.Column_Pos.Name = "Column_Pos";
            this.Column_Pos.ReadOnly = true;
            this.Column_Pos.Width = 80;
            // 
            // radioButton_ClassA
            // 
            this.radioButton_ClassA.AutoSize = true;
            this.radioButton_ClassA.Checked = true;
            this.radioButton_ClassA.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton_ClassA.Location = new System.Drawing.Point(17, 26);
            this.radioButton_ClassA.Name = "radioButton_ClassA";
            this.radioButton_ClassA.Size = new System.Drawing.Size(38, 20);
            this.radioButton_ClassA.TabIndex = 1;
            this.radioButton_ClassA.TabStop = true;
            this.radioButton_ClassA.Text = "A";
            this.radioButton_ClassA.UseVisualStyleBackColor = true;
            this.radioButton_ClassA.Click += new System.EventHandler(this.radioButton_Class_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Location = new System.Drawing.Point(56, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 20);
            this.panel4.TabIndex = 7;
            // 
            // radioButton_ClassB
            // 
            this.radioButton_ClassB.AutoSize = true;
            this.radioButton_ClassB.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton_ClassB.Location = new System.Drawing.Point(17, 52);
            this.radioButton_ClassB.Name = "radioButton_ClassB";
            this.radioButton_ClassB.Size = new System.Drawing.Size(37, 20);
            this.radioButton_ClassB.TabIndex = 3;
            this.radioButton_ClassB.Text = "B";
            this.radioButton_ClassB.UseVisualStyleBackColor = true;
            this.radioButton_ClassB.Click += new System.EventHandler(this.radioButton_Class_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Location = new System.Drawing.Point(56, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 20);
            this.panel3.TabIndex = 6;
            // 
            // radioButton_ClassC
            // 
            this.radioButton_ClassC.AutoSize = true;
            this.radioButton_ClassC.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton_ClassC.Location = new System.Drawing.Point(17, 78);
            this.radioButton_ClassC.Name = "radioButton_ClassC";
            this.radioButton_ClassC.Size = new System.Drawing.Size(37, 20);
            this.radioButton_ClassC.TabIndex = 4;
            this.radioButton_ClassC.Text = "C";
            this.radioButton_ClassC.UseVisualStyleBackColor = true;
            this.radioButton_ClassC.Click += new System.EventHandler(this.radioButton_Class_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(56, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 20);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox_InputZone
            // 
            this.pictureBox_InputZone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox_InputZone.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_InputZone.Name = "pictureBox_InputZone";
            this.pictureBox_InputZone.Size = new System.Drawing.Size(700, 600);
            this.pictureBox_InputZone.TabIndex = 0;
            this.pictureBox_InputZone.TabStop = false;
            this.pictureBox_InputZone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_InputZone_MouseClick);
            // 
            // richTextBox_Log
            // 
            this.richTextBox_Log.Location = new System.Drawing.Point(902, 32);
            this.richTextBox_Log.Name = "richTextBox_Log";
            this.richTextBox_Log.ReadOnly = true;
            this.richTextBox_Log.Size = new System.Drawing.Size(351, 160);
            this.richTextBox_Log.TabIndex = 190;
            this.richTextBox_Log.Text = "";
            // 
            // label_trOutLog
            // 
            this.label_trOutLog.AutoSize = true;
            this.label_trOutLog.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_trOutLog.Location = new System.Drawing.Point(900, 9);
            this.label_trOutLog.Name = "label_trOutLog";
            this.label_trOutLog.Size = new System.Drawing.Size(36, 16);
            this.label_trOutLog.TabIndex = 192;
            this.label_trOutLog.Text = "Log";
            // 
            // NN_Final
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(899, 611);
            this.Controls.Add(this.label_trOutLog);
            this.Controls.Add(this.richTextBox_Log);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NN_Final";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RCE NN_final";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PosList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_InputZone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_InputZone;
        private System.Windows.Forms.RadioButton radioButton_ClassA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioButton_ClassB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton_ClassC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_PosList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Pos;
        private System.Windows.Forms.Button button_ComputerRCE;
        private System.Windows.Forms.Label label_trOutLog;
        public System.Windows.Forms.RichTextBox richTextBox_Log;
        private System.Windows.Forms.Button button_RandomGenerate;
        private System.Windows.Forms.Button button_CLR_Input;
    }
}

