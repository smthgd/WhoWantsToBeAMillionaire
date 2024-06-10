namespace WhoWantsToBeAMillionaire
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnswerA = new System.Windows.Forms.Button();
            this.btnAnswerC = new System.Windows.Forms.Button();
            this.btnAnswerD = new System.Windows.Forms.Button();
            this.btnAnswerB = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lstLevel = new System.Windows.Forms.ListBox();
            this.btnFiftyFifty = new System.Windows.Forms.Button();
            this.btnFriendCall = new System.Windows.Forms.Button();
            this.btnErrorMargin = new System.Windows.Forms.Button();
            this.btnAudienceHelp = new System.Windows.Forms.Button();
            this.btnQuestionReplace = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.topPlayersListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WhoWantsToBeAMillionaire.Properties.Resources.maxresdefault;
            this.pictureBox1.Location = new System.Drawing.Point(325, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 409);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAnswerA
            // 
            this.btnAnswerA.Location = new System.Drawing.Point(325, 525);
            this.btnAnswerA.Name = "btnAnswerA";
            this.btnAnswerA.Size = new System.Drawing.Size(260, 100);
            this.btnAnswerA.TabIndex = 1;
            this.btnAnswerA.Tag = "1";
            this.btnAnswerA.Text = "button1";
            this.btnAnswerA.UseVisualStyleBackColor = true;
            this.btnAnswerA.Click += new System.EventHandler(this.btnAnswerA_Click);
            // 
            // btnAnswerC
            // 
            this.btnAnswerC.Location = new System.Drawing.Point(715, 525);
            this.btnAnswerC.Name = "btnAnswerC";
            this.btnAnswerC.Size = new System.Drawing.Size(260, 100);
            this.btnAnswerC.TabIndex = 2;
            this.btnAnswerC.Tag = "3";
            this.btnAnswerC.Text = "button3";
            this.btnAnswerC.UseVisualStyleBackColor = true;
            this.btnAnswerC.Click += new System.EventHandler(this.btnAnswerC_Click);
            // 
            // btnAnswerD
            // 
            this.btnAnswerD.Location = new System.Drawing.Point(715, 683);
            this.btnAnswerD.Name = "btnAnswerD";
            this.btnAnswerD.Size = new System.Drawing.Size(260, 100);
            this.btnAnswerD.TabIndex = 3;
            this.btnAnswerD.Tag = "4";
            this.btnAnswerD.Text = "button4";
            this.btnAnswerD.UseVisualStyleBackColor = true;
            this.btnAnswerD.Click += new System.EventHandler(this.btnAnswerD_Click);
            // 
            // btnAnswerB
            // 
            this.btnAnswerB.Location = new System.Drawing.Point(325, 683);
            this.btnAnswerB.Name = "btnAnswerB";
            this.btnAnswerB.Size = new System.Drawing.Size(260, 100);
            this.btnAnswerB.TabIndex = 4;
            this.btnAnswerB.Tag = "2";
            this.btnAnswerB.Text = "button2";
            this.btnAnswerB.UseVisualStyleBackColor = true;
            this.btnAnswerB.Click += new System.EventHandler(this.btnAnswerB_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuestion.Location = new System.Drawing.Point(325, 440);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(650, 66);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstLevel
            // 
            this.lstLevel.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstLevel.FormattingEnabled = true;
            this.lstLevel.ItemHeight = 35;
            this.lstLevel.Items.AddRange(new object[] {
            "3 000 000",
            "1 500 000",
            "800 000",
            "400 000",
            "200 000",
            "100 000",
            "50 000",
            "25 000",
            "15 000",
            "10 000",
            "5 000",
            "3 000",
            "2 000",
            "1 000",
            "500"});
            this.lstLevel.Location = new System.Drawing.Point(1022, 12);
            this.lstLevel.Name = "lstLevel";
            this.lstLevel.Size = new System.Drawing.Size(150, 529);
            this.lstLevel.TabIndex = 6;
            this.lstLevel.SelectedIndexChanged += new System.EventHandler(this.lstLevel_SelectedIndexChanged);
            // 
            // btnFiftyFifty
            // 
            this.btnFiftyFifty.Font = new System.Drawing.Font("Segoe UI Black", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFiftyFifty.Location = new System.Drawing.Point(12, 12);
            this.btnFiftyFifty.Name = "btnFiftyFifty";
            this.btnFiftyFifty.Size = new System.Drawing.Size(48, 48);
            this.btnFiftyFifty.TabIndex = 7;
            this.btnFiftyFifty.Text = "50/50";
            this.btnFiftyFifty.UseVisualStyleBackColor = true;
            this.btnFiftyFifty.Click += new System.EventHandler(this.bntFiftyFifty_Click);
            // 
            // btnFriendCall
            // 
            this.btnFriendCall.Image = global::WhoWantsToBeAMillionaire.Properties.Resources.free_icon_phone_call_126509;
            this.btnFriendCall.Location = new System.Drawing.Point(66, 12);
            this.btnFriendCall.Name = "btnFriendCall";
            this.btnFriendCall.Size = new System.Drawing.Size(48, 48);
            this.btnFriendCall.TabIndex = 8;
            this.btnFriendCall.UseVisualStyleBackColor = true;
            this.btnFriendCall.Click += new System.EventHandler(this.btnFriendCall_Click);
            // 
            // btnErrorMargin
            // 
            this.btnErrorMargin.Image = global::WhoWantsToBeAMillionaire.Properties.Resources.free_icon_error_1442605;
            this.btnErrorMargin.Location = new System.Drawing.Point(120, 12);
            this.btnErrorMargin.Name = "btnErrorMargin";
            this.btnErrorMargin.Size = new System.Drawing.Size(48, 48);
            this.btnErrorMargin.TabIndex = 9;
            this.btnErrorMargin.UseVisualStyleBackColor = true;
            this.btnErrorMargin.Click += new System.EventHandler(this.btnErrorMargin_Click);
            // 
            // btnAudienceHelp
            // 
            this.btnAudienceHelp.Image = global::WhoWantsToBeAMillionaire.Properties.Resources.free_icon_audience_1040056;
            this.btnAudienceHelp.Location = new System.Drawing.Point(174, 12);
            this.btnAudienceHelp.Name = "btnAudienceHelp";
            this.btnAudienceHelp.Size = new System.Drawing.Size(48, 48);
            this.btnAudienceHelp.TabIndex = 10;
            this.btnAudienceHelp.UseVisualStyleBackColor = true;
            this.btnAudienceHelp.Click += new System.EventHandler(this.btnAudienceHelp_Click);
            // 
            // btnQuestionReplace
            // 
            this.btnQuestionReplace.Image = global::WhoWantsToBeAMillionaire.Properties.Resources.free_icon_question_1828940;
            this.btnQuestionReplace.Location = new System.Drawing.Point(228, 12);
            this.btnQuestionReplace.Name = "btnQuestionReplace";
            this.btnQuestionReplace.Size = new System.Drawing.Size(48, 48);
            this.btnQuestionReplace.TabIndex = 11;
            this.btnQuestionReplace.UseVisualStyleBackColor = true;
            this.btnQuestionReplace.Click += new System.EventHandler(this.btnQuestionReplace_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 264);
            this.panel1.TabIndex = 12;
            // 
            // topPlayersListBox
            // 
            this.topPlayersListBox.FormattingEnabled = true;
            this.topPlayersListBox.ItemHeight = 25;
            this.topPlayersListBox.Location = new System.Drawing.Point(12, 377);
            this.topPlayersListBox.Name = "topPlayersListBox";
            this.topPlayersListBox.Size = new System.Drawing.Size(264, 354);
            this.topPlayersListBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 819);
            this.Controls.Add(this.topPlayersListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQuestionReplace);
            this.Controls.Add(this.btnAudienceHelp);
            this.Controls.Add(this.btnErrorMargin);
            this.Controls.Add(this.btnFriendCall);
            this.Controls.Add(this.btnFiftyFifty);
            this.Controls.Add(this.lstLevel);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnAnswerB);
            this.Controls.Add(this.btnAnswerD);
            this.Controls.Add(this.btnAnswerC);
            this.Controls.Add(this.btnAnswerA);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnAnswerA;
        private Button btnAnswerC;
        private Button btnAnswerD;
        private Button btnAnswerB;
        private Label lblQuestion;
        private ListBox lstLevel;
        private Button btnFiftyFifty;
        private Button btnFriendCall;
        private Button btnErrorMargin;
        private Button btnAudienceHelp;
        private Button btnQuestionReplace;
        private Panel panel1;
        private ListBox topPlayersListBox;
    }
}