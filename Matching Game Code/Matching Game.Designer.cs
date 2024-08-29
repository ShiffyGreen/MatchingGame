namespace Matching_Game_Code
{
    partial class Matching_Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPlayer2 = new Label();
            lblGameStatus = new Label();
            lblPlayer1Score = new Label();
            lblPlayer1 = new Label();
            lblPlayer2Score = new Label();
            tblHeader = new TableLayoutPanel();
            btnPlay = new Button();
            tblMain = new TableLayoutPanel();
            tblCards = new TableLayoutPanel();
            lbl26 = new Label();
            lbl23 = new Label();
            lbl22 = new Label();
            lbl21 = new Label();
            lbl20 = new Label();
            lbl19 = new Label();
            lbl17 = new Label();
            lbl16 = new Label();
            lbl15 = new Label();
            lbl14 = new Label();
            lbl13 = new Label();
            lbl11 = new Label();
            lbl10 = new Label();
            lbl9 = new Label();
            lbl8 = new Label();
            lbl7 = new Label();
            lbl5 = new Label();
            lbl4 = new Label();
            lbl3 = new Label();
            lbl25 = new Label();
            lbl27 = new Label();
            lbl30 = new Label();
            lbl29 = new Label();
            lbl28 = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl6 = new Label();
            lbl12 = new Label();
            lbl18 = new Label();
            lbl24 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label12 = new Label();
            label13 = new Label();
            tblHeader.SuspendLayout();
            tblMain.SuspendLayout();
            tblCards.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblPlayer2
            // 
            lblPlayer2.AutoSize = true;
            lblPlayer2.Dock = DockStyle.Fill;
            lblPlayer2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayer2.Location = new Point(312, 25);
            lblPlayer2.Name = "lblPlayer2";
            lblPlayer2.Size = new Size(96, 50);
            lblPlayer2.TabIndex = 3;
            lblPlayer2.Text = "Player 2";
            lblPlayer2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGameStatus
            // 
            lblGameStatus.AutoSize = true;
            lblGameStatus.Dock = DockStyle.Fill;
            lblGameStatus.Location = new Point(502, 25);
            lblGameStatus.Name = "lblGameStatus";
            lblGameStatus.Size = new Size(210, 50);
            lblGameStatus.TabIndex = 5;
            // 
            // lblPlayer1Score
            // 
            lblPlayer1Score.AutoSize = true;
            lblPlayer1Score.BorderStyle = BorderStyle.FixedSingle;
            lblPlayer1Score.Dock = DockStyle.Fill;
            lblPlayer1Score.Location = new Point(229, 25);
            lblPlayer1Score.Name = "lblPlayer1Score";
            lblPlayer1Score.Size = new Size(77, 50);
            lblPlayer1Score.TabIndex = 2;
            // 
            // lblPlayer1
            // 
            lblPlayer1.AutoSize = true;
            lblPlayer1.Dock = DockStyle.Fill;
            lblPlayer1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayer1.Location = new Point(121, 25);
            lblPlayer1.Name = "lblPlayer1";
            lblPlayer1.Size = new Size(102, 50);
            lblPlayer1.TabIndex = 1;
            lblPlayer1.Text = "Player 1";
            lblPlayer1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPlayer2Score
            // 
            lblPlayer2Score.AutoSize = true;
            lblPlayer2Score.BorderStyle = BorderStyle.FixedSingle;
            lblPlayer2Score.Dock = DockStyle.Fill;
            lblPlayer2Score.Location = new Point(414, 25);
            lblPlayer2Score.Name = "lblPlayer2Score";
            lblPlayer2Score.Size = new Size(82, 50);
            lblPlayer2Score.TabIndex = 4;
            // 
            // tblHeader
            // 
            tblHeader.BackColor = SystemColors.ButtonFace;
            tblHeader.ColumnCount = 6;
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.5928154F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.2634172F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.7183657F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.3540668F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.4401913F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.1435413F));
            tblHeader.Controls.Add(btnPlay, 0, 1);
            tblHeader.Controls.Add(lblPlayer1, 1, 1);
            tblHeader.Controls.Add(lblPlayer1Score, 2, 1);
            tblHeader.Controls.Add(lblPlayer2, 3, 1);
            tblHeader.Controls.Add(lblPlayer2Score, 4, 1);
            tblHeader.Controls.Add(lblGameStatus, 5, 1);
            tblHeader.Dock = DockStyle.Fill;
            tblHeader.Location = new Point(3, 3);
            tblHeader.Name = "tblHeader";
            tblHeader.RowCount = 3;
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 27.35849F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 55.6603775F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 16.3522015F));
            tblHeader.Size = new Size(715, 91);
            tblHeader.TabIndex = 1;
            // 
            // btnPlay
            // 
            btnPlay.Dock = DockStyle.Fill;
            btnPlay.Location = new Point(3, 28);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(112, 44);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(tblHeader, 0, 0);
            tblMain.Controls.Add(tblCards, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.1151085F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 83.8848953F));
            tblMain.Size = new Size(721, 606);
            tblMain.TabIndex = 28;
            // 
            // tblCards
            // 
            tblCards.BackColor = SystemColors.ButtonFace;
            tblCards.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tblCards.ColumnCount = 6;
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblCards.Controls.Add(lbl26, 0, 4);
            tblCards.Controls.Add(lbl23, 4, 3);
            tblCards.Controls.Add(lbl22, 3, 3);
            tblCards.Controls.Add(lbl21, 2, 3);
            tblCards.Controls.Add(lbl20, 1, 3);
            tblCards.Controls.Add(lbl19, 0, 3);
            tblCards.Controls.Add(lbl17, 4, 2);
            tblCards.Controls.Add(lbl16, 3, 2);
            tblCards.Controls.Add(lbl15, 2, 2);
            tblCards.Controls.Add(lbl14, 1, 2);
            tblCards.Controls.Add(lbl13, 0, 2);
            tblCards.Controls.Add(lbl11, 4, 1);
            tblCards.Controls.Add(lbl10, 3, 1);
            tblCards.Controls.Add(lbl9, 2, 1);
            tblCards.Controls.Add(lbl8, 1, 1);
            tblCards.Controls.Add(lbl7, 0, 1);
            tblCards.Controls.Add(lbl5, 4, 0);
            tblCards.Controls.Add(lbl4, 3, 0);
            tblCards.Controls.Add(lbl3, 2, 0);
            tblCards.Controls.Add(lbl25, 0, 4);
            tblCards.Controls.Add(lbl27, 0, 4);
            tblCards.Controls.Add(lbl30, 0, 4);
            tblCards.Controls.Add(lbl29, 0, 4);
            tblCards.Controls.Add(lbl28, 0, 4);
            tblCards.Controls.Add(lbl1, 0, 0);
            tblCards.Controls.Add(lbl2, 1, 0);
            tblCards.Controls.Add(lbl6, 5, 0);
            tblCards.Controls.Add(lbl12, 5, 1);
            tblCards.Controls.Add(lbl18, 5, 2);
            tblCards.Controls.Add(lbl24, 5, 3);
            tblCards.Dock = DockStyle.Fill;
            tblCards.Location = new Point(3, 100);
            tblCards.Name = "tblCards";
            tblCards.RowCount = 5;
            tblCards.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblCards.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblCards.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblCards.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblCards.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblCards.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblCards.Size = new Size(715, 503);
            tblCards.TabIndex = 2;
            // 
            // lbl26
            // 
            lbl26.AutoSize = true;
            lbl26.Dock = DockStyle.Fill;
            lbl26.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl26.Location = new Point(123, 402);
            lbl26.Name = "lbl26";
            lbl26.Size = new Size(110, 99);
            lbl26.TabIndex = 25;
            lbl26.Text = "c";
            lbl26.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl23
            // 
            lbl23.AutoSize = true;
            lbl23.Dock = DockStyle.Fill;
            lbl23.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl23.Location = new Point(477, 302);
            lbl23.Name = "lbl23";
            lbl23.Size = new Size(110, 98);
            lbl23.TabIndex = 24;
            lbl23.Text = "c";
            lbl23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl22
            // 
            lbl22.AutoSize = true;
            lbl22.Dock = DockStyle.Fill;
            lbl22.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl22.Location = new Point(359, 302);
            lbl22.Name = "lbl22";
            lbl22.Size = new Size(110, 98);
            lbl22.TabIndex = 23;
            lbl22.Text = "c";
            lbl22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl21
            // 
            lbl21.AutoSize = true;
            lbl21.Dock = DockStyle.Fill;
            lbl21.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl21.Location = new Point(241, 302);
            lbl21.Name = "lbl21";
            lbl21.Size = new Size(110, 98);
            lbl21.TabIndex = 22;
            lbl21.Text = "c";
            lbl21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl20
            // 
            lbl20.AutoSize = true;
            lbl20.Dock = DockStyle.Fill;
            lbl20.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl20.Location = new Point(123, 302);
            lbl20.Name = "lbl20";
            lbl20.Size = new Size(110, 98);
            lbl20.TabIndex = 21;
            lbl20.Text = "c";
            lbl20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl19
            // 
            lbl19.AutoSize = true;
            lbl19.Dock = DockStyle.Fill;
            lbl19.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl19.Location = new Point(5, 302);
            lbl19.Name = "lbl19";
            lbl19.Size = new Size(110, 98);
            lbl19.TabIndex = 20;
            lbl19.Text = "c";
            lbl19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl17
            // 
            lbl17.AutoSize = true;
            lbl17.Dock = DockStyle.Fill;
            lbl17.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl17.Location = new Point(477, 202);
            lbl17.Name = "lbl17";
            lbl17.Size = new Size(110, 98);
            lbl17.TabIndex = 19;
            lbl17.Text = "c";
            lbl17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl16
            // 
            lbl16.AutoSize = true;
            lbl16.Dock = DockStyle.Fill;
            lbl16.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl16.Location = new Point(359, 202);
            lbl16.Name = "lbl16";
            lbl16.Size = new Size(110, 98);
            lbl16.TabIndex = 18;
            lbl16.Text = "c";
            lbl16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl15
            // 
            lbl15.AutoSize = true;
            lbl15.Dock = DockStyle.Fill;
            lbl15.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl15.Location = new Point(241, 202);
            lbl15.Name = "lbl15";
            lbl15.Size = new Size(110, 98);
            lbl15.TabIndex = 17;
            lbl15.Text = "c";
            lbl15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl14
            // 
            lbl14.AutoSize = true;
            lbl14.Dock = DockStyle.Fill;
            lbl14.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl14.Location = new Point(123, 202);
            lbl14.Name = "lbl14";
            lbl14.Size = new Size(110, 98);
            lbl14.TabIndex = 16;
            lbl14.Text = "c";
            lbl14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl13
            // 
            lbl13.AutoSize = true;
            lbl13.Dock = DockStyle.Fill;
            lbl13.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl13.Location = new Point(5, 202);
            lbl13.Name = "lbl13";
            lbl13.Size = new Size(110, 98);
            lbl13.TabIndex = 15;
            lbl13.Text = "c";
            lbl13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl11
            // 
            lbl11.AutoSize = true;
            lbl11.Dock = DockStyle.Fill;
            lbl11.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl11.Location = new Point(477, 102);
            lbl11.Name = "lbl11";
            lbl11.Size = new Size(110, 98);
            lbl11.TabIndex = 14;
            lbl11.Text = "c";
            lbl11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl10
            // 
            lbl10.AutoSize = true;
            lbl10.Dock = DockStyle.Fill;
            lbl10.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl10.Location = new Point(359, 102);
            lbl10.Name = "lbl10";
            lbl10.Size = new Size(110, 98);
            lbl10.TabIndex = 13;
            lbl10.Text = "c";
            lbl10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl9
            // 
            lbl9.AutoSize = true;
            lbl9.Dock = DockStyle.Fill;
            lbl9.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl9.Location = new Point(241, 102);
            lbl9.Name = "lbl9";
            lbl9.Size = new Size(110, 98);
            lbl9.TabIndex = 12;
            lbl9.Text = "c";
            lbl9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl8
            // 
            lbl8.AutoSize = true;
            lbl8.Dock = DockStyle.Fill;
            lbl8.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl8.Location = new Point(123, 102);
            lbl8.Name = "lbl8";
            lbl8.Size = new Size(110, 98);
            lbl8.TabIndex = 11;
            lbl8.Text = "c";
            lbl8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Dock = DockStyle.Fill;
            lbl7.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl7.Location = new Point(5, 102);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(110, 98);
            lbl7.TabIndex = 10;
            lbl7.Text = "c";
            lbl7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Dock = DockStyle.Fill;
            lbl5.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl5.Location = new Point(477, 2);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(110, 98);
            lbl5.TabIndex = 9;
            lbl5.Text = "c";
            lbl5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Dock = DockStyle.Fill;
            lbl4.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl4.Location = new Point(359, 2);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(110, 98);
            lbl4.TabIndex = 8;
            lbl4.Text = "c";
            lbl4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Dock = DockStyle.Fill;
            lbl3.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl3.Location = new Point(241, 2);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(110, 98);
            lbl3.TabIndex = 7;
            lbl3.Text = "c";
            lbl3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl25
            // 
            lbl25.Dock = DockStyle.Fill;
            lbl25.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl25.Location = new Point(5, 402);
            lbl25.Name = "lbl25";
            lbl25.Size = new Size(110, 99);
            lbl25.TabIndex = 5;
            lbl25.Text = "c";
            lbl25.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl27
            // 
            lbl27.Dock = DockStyle.Fill;
            lbl27.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl27.Location = new Point(241, 402);
            lbl27.Name = "lbl27";
            lbl27.Size = new Size(110, 99);
            lbl27.TabIndex = 4;
            lbl27.Text = "c";
            lbl27.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl30
            // 
            lbl30.Dock = DockStyle.Fill;
            lbl30.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl30.Location = new Point(595, 402);
            lbl30.Name = "lbl30";
            lbl30.Size = new Size(115, 99);
            lbl30.TabIndex = 3;
            lbl30.Text = "c";
            lbl30.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl29
            // 
            lbl29.Dock = DockStyle.Fill;
            lbl29.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl29.Location = new Point(477, 402);
            lbl29.Name = "lbl29";
            lbl29.Size = new Size(110, 99);
            lbl29.TabIndex = 2;
            lbl29.Text = "c";
            lbl29.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl28
            // 
            lbl28.Dock = DockStyle.Fill;
            lbl28.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl28.Location = new Point(359, 402);
            lbl28.Name = "lbl28";
            lbl28.Size = new Size(110, 99);
            lbl28.TabIndex = 1;
            lbl28.Text = "c";
            lbl28.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            lbl1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.Location = new Point(5, 2);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(110, 98);
            lbl1.TabIndex = 0;
            lbl1.Text = "c";
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Dock = DockStyle.Fill;
            lbl2.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2.Location = new Point(123, 2);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(110, 98);
            lbl2.TabIndex = 6;
            lbl2.Text = "c";
            lbl2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Dock = DockStyle.Fill;
            lbl6.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl6.Location = new Point(595, 2);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(115, 98);
            lbl6.TabIndex = 26;
            lbl6.Text = "c";
            lbl6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl12
            // 
            lbl12.AutoSize = true;
            lbl12.Dock = DockStyle.Fill;
            lbl12.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl12.Location = new Point(595, 102);
            lbl12.Name = "lbl12";
            lbl12.Size = new Size(115, 98);
            lbl12.TabIndex = 27;
            lbl12.Text = "c";
            lbl12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl18
            // 
            lbl18.AutoSize = true;
            lbl18.Dock = DockStyle.Fill;
            lbl18.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl18.Location = new Point(595, 202);
            lbl18.Name = "lbl18";
            lbl18.Size = new Size(115, 98);
            lbl18.TabIndex = 28;
            lbl18.Text = "c";
            lbl18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl24
            // 
            lbl24.AutoSize = true;
            lbl24.Dock = DockStyle.Fill;
            lbl24.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbl24.Location = new Point(595, 302);
            lbl24.Name = "lbl24";
            lbl24.Size = new Size(115, 98);
            lbl24.TabIndex = 29;
            lbl24.Text = "c";
            lbl24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ButtonFace;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(label12, 0, 1);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(5, 24);
            label12.Name = "label12";
            label12.Size = new Size(30, 60);
            label12.TabIndex = 10;
            label12.Text = "label12";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(161, 2);
            label13.Name = "label13";
            label13.Size = new Size(30, 60);
            label13.TabIndex = 9;
            label13.Text = "label13";
            // 
            // Matching_Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 606);
            Controls.Add(tblMain);
            Name = "Matching_Game";
            Text = "Matching_Game";
            tblHeader.ResumeLayout(false);
            tblHeader.PerformLayout();
            tblMain.ResumeLayout(false);
            tblCards.ResumeLayout(false);
            tblCards.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblPlayer2;
        private Label lblGameStatus;
        private Label lblPlayer1Score;
        private Label lblPlayer1;
        private Label lblPlayer2Score;
        private TableLayoutPanel tblHeader;
        private Button btnPlay;
        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblCards;
        private Label lbl25;
        private Label lbl27;
        private Label lbl30;
        private Label lbl29;
        private Label lbl28;
        private Label lbl1;
        private Label lbl23;
        private Label lbl22;
        private Label lbl21;
        private Label lbl20;
        private Label lbl19;
        private Label lbl17;
        private Label lbl16;
        private Label lbl15;
        private Label lbl14;
        private Label lbl13;
        private Label lbl11;
        private Label lbl10;
        private Label lbl9;
        private Label lbl8;
        private Label lbl7;
        private Label lbl5;
        private Label lbl4;
        private Label lbl3;
        private Label lbl2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label12;
        private Label label13;
        private Label lbl26;
        private Label lbl6;
        private Label lbl12;
        private Label lbl18;
        private Label lbl24;
    }
}