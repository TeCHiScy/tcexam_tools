namespace WindowsFormsApp1
{
    partial class frmTcexamTools
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
            this.components = new System.ComponentModel.Container();
            this.lstDatabase = new System.Windows.Forms.ListView();
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.answers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.radioChoice = new System.Windows.Forms.RadioButton();
            this.radioTrueFalse = new System.Windows.Forms.RadioButton();
            this.radioText = new System.Windows.Forms.RadioButton();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtAnswers = new System.Windows.Forms.TextBox();
            this.lblAnswers = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtModule = new System.Windows.Forms.TextBox();
            this.lblModule = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDatabase
            // 
            this.lstDatabase.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.type,
            this.description,
            this.answers});
            this.lstDatabase.FullRowSelect = true;
            this.lstDatabase.GridLines = true;
            this.lstDatabase.Location = new System.Drawing.Point(12, 39);
            this.lstDatabase.MultiSelect = false;
            this.lstDatabase.Name = "lstDatabase";
            this.lstDatabase.Size = new System.Drawing.Size(684, 511);
            this.lstDatabase.TabIndex = 2;
            this.lstDatabase.UseCompatibleStateImageBehavior = false;
            this.lstDatabase.View = System.Windows.Forms.View.Details;
            this.lstDatabase.SelectedIndexChanged += new System.EventHandler(this.lstDatabase_SelectedIndexChanged);
            // 
            // type
            // 
            this.type.Text = "类型";
            this.type.Width = 71;
            // 
            // description
            // 
            this.description.Text = "题目";
            this.description.Width = 127;
            // 
            // answers
            // 
            this.answers.Text = "选项列表";
            this.answers.Width = 478;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(622, 860);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "删除";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(541, 860);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "添加";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDescription.Location = new System.Drawing.Point(12, 588);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(684, 70);
            this.txtDescription.TabIndex = 0;
            // 
            // radioChoice
            // 
            this.radioChoice.AutoSize = true;
            this.radioChoice.Checked = true;
            this.radioChoice.Location = new System.Drawing.Point(81, 666);
            this.radioChoice.Name = "radioChoice";
            this.radioChoice.Size = new System.Drawing.Size(59, 16);
            this.radioChoice.TabIndex = 5;
            this.radioChoice.TabStop = true;
            this.radioChoice.Text = "选择题";
            this.radioChoice.UseVisualStyleBackColor = true;
            this.radioChoice.CheckedChanged += new System.EventHandler(this.radioChoice_CheckedChanged);
            // 
            // radioTrueFalse
            // 
            this.radioTrueFalse.AutoSize = true;
            this.radioTrueFalse.Location = new System.Drawing.Point(146, 666);
            this.radioTrueFalse.Name = "radioTrueFalse";
            this.radioTrueFalse.Size = new System.Drawing.Size(59, 16);
            this.radioTrueFalse.TabIndex = 6;
            this.radioTrueFalse.Text = "判断题";
            this.radioTrueFalse.UseVisualStyleBackColor = true;
            this.radioTrueFalse.CheckedChanged += new System.EventHandler(this.radioTrueFalse_CheckedChanged);
            // 
            // radioText
            // 
            this.radioText.AutoSize = true;
            this.radioText.Location = new System.Drawing.Point(211, 666);
            this.radioText.Name = "radioText";
            this.radioText.Size = new System.Drawing.Size(59, 16);
            this.radioText.TabIndex = 7;
            this.radioText.Text = "填空题";
            this.radioText.UseVisualStyleBackColor = true;
            this.radioText.CheckedChanged += new System.EventHandler(this.radioText_CheckedChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(10, 668);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(53, 12);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "题目类型";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(10, 564);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(53, 12);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "题目描述";
            // 
            // txtAnswers
            // 
            this.txtAnswers.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAnswers.Location = new System.Drawing.Point(12, 719);
            this.txtAnswers.Multiline = true;
            this.txtAnswers.Name = "txtAnswers";
            this.txtAnswers.Size = new System.Drawing.Size(683, 131);
            this.txtAnswers.TabIndex = 12;
            // 
            // lblAnswers
            // 
            this.lblAnswers.AutoSize = true;
            this.lblAnswers.Location = new System.Drawing.Point(10, 695);
            this.lblAnswers.Name = "lblAnswers";
            this.lblAnswers.Size = new System.Drawing.Size(53, 12);
            this.lblAnswers.TabIndex = 13;
            this.lblAnswers.Text = "题目答案";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(94, 860);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 14;
            this.btnWrite.Text = "写入";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(13, 860);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 15;
            this.btnRead.Text = "读取";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(12, 16);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(29, 12);
            this.lblDatabase.TabIndex = 16;
            this.lblDatabase.Text = "题库";
            // 
            // txtModule
            // 
            this.txtModule.Location = new System.Drawing.Point(390, 12);
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(133, 21);
            this.txtModule.TabIndex = 17;
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(355, 16);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(29, 12);
            this.lblModule.TabIndex = 18;
            this.lblModule.Text = "模块";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(529, 16);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(29, 12);
            this.lblSubject.TabIndex = 19;
            this.lblSubject.Text = "主题";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(564, 12);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(133, 21);
            this.txtSubject.TabIndex = 20;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(460, 860);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmTcexamTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 892);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtAnswers);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.txtModule);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblAnswers);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lstDatabase);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.radioText);
            this.Controls.Add(this.radioTrueFalse);
            this.Controls.Add(this.radioChoice);
            this.Controls.Add(this.txtDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTcexamTools";
            this.Text = "txexam Tools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lstDatabase;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.RadioButton radioChoice;
        private System.Windows.Forms.RadioButton radioTrueFalse;
        private System.Windows.Forms.RadioButton radioText;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtAnswers;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAnswers;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox txtModule;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader answers;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnClear;
    }
}

