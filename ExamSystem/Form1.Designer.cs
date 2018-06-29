namespace ExamSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.blankPanel = new System.Windows.Forms.Panel();
            this.textBlank4 = new System.Windows.Forms.TextBox();
            this.textBlank3 = new System.Windows.Forms.TextBox();
            this.textBlank2 = new System.Windows.Forms.TextBox();
            this.textBlank1 = new System.Windows.Forms.TextBox();
            this.blankQuestion = new System.Windows.Forms.Label();
            this.choicePanel = new System.Windows.Forms.Panel();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.choiceQuestion = new System.Windows.Forms.Label();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.tableQuestions = new System.Windows.Forms.TableLayoutPanel();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.blankPanel.SuspendLayout();
            this.choicePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnNext);
            this.splitContainer1.Panel1.Controls.Add(this.btnPrevious);
            this.splitContainer1.Panel1.Controls.Add(this.blankPanel);
            this.splitContainer1.Panel1.Controls.Add(this.choicePanel);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.scoreLabel);
            this.splitContainer1.Panel2.Controls.Add(this.tableQuestions);
            this.splitContainer1.Panel2.Controls.Add(this.btnSubmit);
            this.splitContainer1.Size = new System.Drawing.Size(820, 521);
            this.splitContainer1.SplitterDistance = 518;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.Location = new System.Drawing.Point(165, 320);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(110, 40);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "下一题";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_2);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrevious.Location = new System.Drawing.Point(18, 320);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(110, 40);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "上一题";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click_1);
            // 
            // blankPanel
            // 
            this.blankPanel.Controls.Add(this.textBlank4);
            this.blankPanel.Controls.Add(this.textBlank3);
            this.blankPanel.Controls.Add(this.textBlank2);
            this.blankPanel.Controls.Add(this.textBlank1);
            this.blankPanel.Controls.Add(this.blankQuestion);
            this.blankPanel.Location = new System.Drawing.Point(3, 12);
            this.blankPanel.Name = "blankPanel";
            this.blankPanel.Size = new System.Drawing.Size(516, 288);
            this.blankPanel.TabIndex = 16;
            // 
            // textBlank4
            // 
            this.textBlank4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBlank4.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.textBlank4.Location = new System.Drawing.Point(15, 224);
            this.textBlank4.Name = "textBlank4";
            this.textBlank4.Size = new System.Drawing.Size(200, 30);
            this.textBlank4.TabIndex = 15;
            this.textBlank4.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBlank4.Leave += new System.EventHandler(this.textBlank4_Leave);
            // 
            // textBlank3
            // 
            this.textBlank3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBlank3.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.textBlank3.Location = new System.Drawing.Point(15, 180);
            this.textBlank3.Name = "textBlank3";
            this.textBlank3.Size = new System.Drawing.Size(200, 30);
            this.textBlank3.TabIndex = 14;
            this.textBlank3.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.textBlank3.Leave += new System.EventHandler(this.textBlank3_Leave);
            // 
            // textBlank2
            // 
            this.textBlank2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBlank2.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.textBlank2.Location = new System.Drawing.Point(15, 140);
            this.textBlank2.Name = "textBlank2";
            this.textBlank2.Size = new System.Drawing.Size(200, 30);
            this.textBlank2.TabIndex = 13;
            this.textBlank2.Leave += new System.EventHandler(this.textBlank2_Leave);
            // 
            // textBlank1
            // 
            this.textBlank1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBlank1.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.textBlank1.Location = new System.Drawing.Point(15, 97);
            this.textBlank1.Name = "textBlank1";
            this.textBlank1.Size = new System.Drawing.Size(200, 30);
            this.textBlank1.TabIndex = 12;
            this.textBlank1.Leave += new System.EventHandler(this.textBlank1_Leave);
            // 
            // blankQuestion
            // 
            this.blankQuestion.AutoSize = true;
            this.blankQuestion.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blankQuestion.Location = new System.Drawing.Point(3, 19);
            this.blankQuestion.MaximumSize = new System.Drawing.Size(500, 0);
            this.blankQuestion.Name = "blankQuestion";
            this.blankQuestion.Size = new System.Drawing.Size(488, 56);
            this.blankQuestion.TabIndex = 2;
            this.blankQuestion.Text = "下面哪个权限可以保证属性只能在类内部使用";
            // 
            // choicePanel
            // 
            this.choicePanel.Controls.Add(this.rbD);
            this.choicePanel.Controls.Add(this.choiceQuestion);
            this.choicePanel.Controls.Add(this.rbC);
            this.choicePanel.Controls.Add(this.rbA);
            this.choicePanel.Controls.Add(this.rbB);
            this.choicePanel.Location = new System.Drawing.Point(3, 12);
            this.choicePanel.Name = "choicePanel";
            this.choicePanel.Size = new System.Drawing.Size(516, 288);
            this.choicePanel.TabIndex = 7;
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbD.Location = new System.Drawing.Point(15, 220);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(115, 28);
            this.rbD.TabIndex = 11;
            this.rbD.TabStop = true;
            this.rbD.Text = "private";
            this.rbD.UseVisualStyleBackColor = true;
            this.rbD.CheckedChanged += new System.EventHandler(this.rbD_CheckedChanged);
            // 
            // choiceQuestion
            // 
            this.choiceQuestion.AutoSize = true;
            this.choiceQuestion.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.choiceQuestion.Location = new System.Drawing.Point(3, 19);
            this.choiceQuestion.MaximumSize = new System.Drawing.Size(500, 0);
            this.choiceQuestion.Name = "choiceQuestion";
            this.choiceQuestion.Size = new System.Drawing.Size(488, 56);
            this.choiceQuestion.TabIndex = 2;
            this.choiceQuestion.Text = "下面哪个权限可以保证属性只能在类内部使用";
            this.choiceQuestion.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbC.Location = new System.Drawing.Point(15, 180);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(79, 28);
            this.rbC.TabIndex = 10;
            this.rbC.TabStop = true;
            this.rbC.Text = "默认";
            this.rbC.UseVisualStyleBackColor = true;
            this.rbC.CheckedChanged += new System.EventHandler(this.rbC_CheckedChanged);
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbA.Location = new System.Drawing.Point(15, 100);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(103, 28);
            this.rbA.TabIndex = 8;
            this.rbA.TabStop = true;
            this.rbA.Text = "public";
            this.rbA.UseVisualStyleBackColor = true;
            this.rbA.CheckedChanged += new System.EventHandler(this.rbA_CheckedChanged_1);
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbB.Location = new System.Drawing.Point(15, 140);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(115, 28);
            this.rbB.TabIndex = 9;
            this.rbB.TabStop = true;
            this.rbB.Text = "protect";
            this.rbB.UseVisualStyleBackColor = true;
            this.rbB.CheckedChanged += new System.EventHandler(this.rbB_CheckedChanged);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.scoreLabel.Location = new System.Drawing.Point(11, 379);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(99, 28);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "成绩：";
            this.scoreLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // tableQuestions
            // 
            this.tableQuestions.ColumnCount = 5;
            this.tableQuestions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableQuestions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableQuestions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableQuestions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableQuestions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableQuestions.Location = new System.Drawing.Point(16, 31);
            this.tableQuestions.Name = "tableQuestions";
            this.tableQuestions.RowCount = 5;
            this.tableQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableQuestions.Size = new System.Drawing.Size(263, 199);
            this.tableQuestions.TabIndex = 2;
            this.tableQuestions.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit.Location = new System.Drawing.Point(16, 320);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(113, 40);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "提交答案";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 521);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Delta考试系统 By ZekeTian";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.blankPanel.ResumeLayout(false);
            this.blankPanel.PerformLayout();
            this.choicePanel.ResumeLayout(false);
            this.choicePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TableLayoutPanel tableQuestions;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Panel choicePanel;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.Label choiceQuestion;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.Panel blankPanel;
        private System.Windows.Forms.TextBox textBlank4;
        private System.Windows.Forms.TextBox textBlank3;
        private System.Windows.Forms.TextBox textBlank2;
        private System.Windows.Forms.TextBox textBlank1;
        private System.Windows.Forms.Label blankQuestion;
    }
}

