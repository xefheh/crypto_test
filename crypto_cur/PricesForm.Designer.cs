namespace crypto_cur
{
    partial class PricesForm
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
            _cryptoControl = new TabControl();
            _binancePage = new TabPage();
            groupBox1 = new GroupBox();
            label1 = new Label();
            _binanceBtcusdt = new TextBox();
            _kucoinPage = new TabPage();
            groupBox2 = new GroupBox();
            label2 = new Label();
            _kucoinBtcusdt = new TextBox();
            _byBitPage = new TabPage();
            groupBox3 = new GroupBox();
            label3 = new Label();
            _byBitBtcusdt = new TextBox();
            _cryptoControl.SuspendLayout();
            _binancePage.SuspendLayout();
            groupBox1.SuspendLayout();
            _kucoinPage.SuspendLayout();
            groupBox2.SuspendLayout();
            _byBitPage.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // _cryptoControl
            // 
            _cryptoControl.Controls.Add(_binancePage);
            _cryptoControl.Controls.Add(_kucoinPage);
            _cryptoControl.Controls.Add(_byBitPage);
            _cryptoControl.Dock = DockStyle.Fill;
            _cryptoControl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _cryptoControl.Location = new Point(0, 0);
            _cryptoControl.Name = "_cryptoControl";
            _cryptoControl.SelectedIndex = 0;
            _cryptoControl.Size = new Size(422, 234);
            _cryptoControl.TabIndex = 6;
            // 
            // _binancePage
            // 
            _binancePage.Controls.Add(groupBox1);
            _binancePage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _binancePage.Location = new Point(4, 30);
            _binancePage.Name = "_binancePage";
            _binancePage.Padding = new Padding(3);
            _binancePage.Size = new Size(414, 200);
            _binancePage.TabIndex = 0;
            _binancePage.Text = "Binance";
            _binancePage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(_binanceBtcusdt);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(8, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 91);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Котировки";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(117, 32);
            label1.TabIndex = 1;
            label1.Text = "BTCUSDT:";
            // 
            // _binanceBtcusdt
            // 
            _binanceBtcusdt.Location = new Point(123, 38);
            _binanceBtcusdt.Name = "_binanceBtcusdt";
            _binanceBtcusdt.Size = new Size(190, 27);
            _binanceBtcusdt.TabIndex = 3;
            // 
            // _kucoinPage
            // 
            _kucoinPage.Controls.Add(groupBox2);
            _kucoinPage.Location = new Point(4, 30);
            _kucoinPage.Name = "_kucoinPage";
            _kucoinPage.Padding = new Padding(3);
            _kucoinPage.Size = new Size(414, 200);
            _kucoinPage.TabIndex = 1;
            _kucoinPage.Text = "Kucoin";
            _kucoinPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(_kucoinBtcusdt);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(8, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(398, 91);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Котировки";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 32);
            label2.Name = "label2";
            label2.Size = new Size(117, 32);
            label2.TabIndex = 1;
            label2.Text = "BTCUSDT:";
            // 
            // _kucoinBtcusdt
            // 
            _kucoinBtcusdt.Location = new Point(123, 38);
            _kucoinBtcusdt.Name = "_kucoinBtcusdt";
            _kucoinBtcusdt.Size = new Size(190, 27);
            _kucoinBtcusdt.TabIndex = 3;
            // 
            // _byBitPage
            // 
            _byBitPage.Controls.Add(groupBox3);
            _byBitPage.Location = new Point(4, 30);
            _byBitPage.Name = "_byBitPage";
            _byBitPage.Padding = new Padding(3);
            _byBitPage.Size = new Size(414, 200);
            _byBitPage.TabIndex = 2;
            _byBitPage.Text = "ByBit";
            _byBitPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(_byBitBtcusdt);
            groupBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(8, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(398, 91);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Котировки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 32);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 1;
            label3.Text = "BTCUSDT:";
            // 
            // _byBitBtcusdt
            // 
            _byBitBtcusdt.Location = new Point(123, 38);
            _byBitBtcusdt.Name = "_byBitBtcusdt";
            _byBitBtcusdt.Size = new Size(190, 27);
            _byBitBtcusdt.TabIndex = 3;
            // 
            // PricesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 234);
            Controls.Add(_cryptoControl);
            Name = "PricesForm";
            Text = "Приложение Котировки";
            _cryptoControl.ResumeLayout(false);
            _binancePage.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            _kucoinPage.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            _byBitPage.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl _cryptoControl;
        private TabPage _binancePage;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox _binanceBtcusdt;
        private TabPage _kucoinPage;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox _kucoinBtcusdt;
        private TabPage _byBitPage;
        private GroupBox groupBox3;
        private Label label3;
        private TextBox _byBitBtcusdt;
    }
}