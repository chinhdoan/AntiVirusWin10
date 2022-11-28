
namespace AntiVirus
{
    partial class Result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.panel1 = new System.Windows.Forms.Panel();
            this.quitButtonImg = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.ThreadList = new System.Windows.Forms.ListBox();
            this.threadCountLbl = new Bunifu.UI.WinForms.BunifuLabel();
            this.countScanLbl = new Bunifu.UI.WinForms.BunifuLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusLbl = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.homeButtonImg = new Bunifu.UI.WinForms.BunifuImageButton();
            this.notificateButtonImg = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.bunifuGroupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.quitButtonImg);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 100);
            this.panel1.TabIndex = 1;
            // 
            // quitButtonImg
            // 
            this.quitButtonImg.ActiveImage = null;
            this.quitButtonImg.AllowAnimations = true;
            this.quitButtonImg.AllowBuffering = false;
            this.quitButtonImg.AllowToggling = false;
            this.quitButtonImg.AllowZooming = true;
            this.quitButtonImg.AllowZoomingOnFocus = false;
            this.quitButtonImg.BackColor = System.Drawing.Color.Transparent;
            this.quitButtonImg.DialogResult = System.Windows.Forms.DialogResult.None;
            this.quitButtonImg.ErrorImage = ((System.Drawing.Image)(resources.GetObject("quitButtonImg.ErrorImage")));
            this.quitButtonImg.FadeWhenInactive = false;
            this.quitButtonImg.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.quitButtonImg.Image = ((System.Drawing.Image)(resources.GetObject("quitButtonImg.Image")));
            this.quitButtonImg.ImageActive = null;
            this.quitButtonImg.ImageLocation = null;
            this.quitButtonImg.ImageMargin = 5;
            this.quitButtonImg.ImageSize = new System.Drawing.Size(25, 25);
            this.quitButtonImg.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.quitButtonImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("quitButtonImg.InitialImage")));
            this.quitButtonImg.Location = new System.Drawing.Point(749, 3);
            this.quitButtonImg.Name = "quitButtonImg";
            this.quitButtonImg.Rotation = 0;
            this.quitButtonImg.ShowActiveImage = true;
            this.quitButtonImg.ShowCursorChanges = true;
            this.quitButtonImg.ShowImageBorders = true;
            this.quitButtonImg.ShowSizeMarkers = false;
            this.quitButtonImg.Size = new System.Drawing.Size(30, 30);
            this.quitButtonImg.TabIndex = 0;
            this.quitButtonImg.ToolTipText = "";
            this.quitButtonImg.WaitOnLoad = false;
            this.quitButtonImg.Zoom = 5;
            this.quitButtonImg.ZoomSpeed = 10;
            this.quitButtonImg.Click += new System.EventHandler(this.quitButtonImg_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bunifuLabel1);
            this.panel3.Controls.Add(this.bunifuImageButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(782, 100);
            this.panel3.TabIndex = 4;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuLabel1.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(10, 10);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(148, 80);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Anti Virus |";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 5;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(35, 35);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(164, 13);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 5;
            this.bunifuImageButton1.ZoomSpeed = 10;
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuGroupBox1.BorderRadius = 1;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.ThreadList);
            this.bunifuGroupBox1.Controls.Add(this.threadCountLbl);
            this.bunifuGroupBox1.Controls.Add(this.countScanLbl);
            this.bunifuGroupBox1.Controls.Add(this.label2);
            this.bunifuGroupBox1.Controls.Add(this.label1);
            this.bunifuGroupBox1.Controls.Add(this.statusLbl);
            this.bunifuGroupBox1.Controls.Add(this.panel2);
            this.bunifuGroupBox1.Controls.Add(this.label5);
            this.bunifuGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(0, 100);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(782, 353);
            this.bunifuGroupBox1.TabIndex = 6;
            this.bunifuGroupBox1.TabStop = false;
            this.bunifuGroupBox1.Text = "Scan Results";
            // 
            // ThreadList
            // 
            this.ThreadList.BackColor = System.Drawing.Color.GhostWhite;
            this.ThreadList.FormattingEnabled = true;
            this.ThreadList.HorizontalScrollbar = true;
            this.ThreadList.ItemHeight = 20;
            this.ThreadList.Location = new System.Drawing.Point(226, 26);
            this.ThreadList.Name = "ThreadList";
            this.ThreadList.Size = new System.Drawing.Size(544, 264);
            this.ThreadList.TabIndex = 21;
            // 
            // threadCountLbl
            // 
            this.threadCountLbl.AllowParentOverrides = false;
            this.threadCountLbl.AutoEllipsis = false;
            this.threadCountLbl.CursorType = null;
            this.threadCountLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.threadCountLbl.Location = new System.Drawing.Point(148, 66);
            this.threadCountLbl.Name = "threadCountLbl";
            this.threadCountLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.threadCountLbl.Size = new System.Drawing.Size(8, 20);
            this.threadCountLbl.TabIndex = 19;
            this.threadCountLbl.Text = "0";
            this.threadCountLbl.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.threadCountLbl.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // countScanLbl
            // 
            this.countScanLbl.AllowParentOverrides = false;
            this.countScanLbl.AutoEllipsis = false;
            this.countScanLbl.CursorType = null;
            this.countScanLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.countScanLbl.Location = new System.Drawing.Point(126, 32);
            this.countScanLbl.Name = "countScanLbl";
            this.countScanLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.countScanLbl.Size = new System.Drawing.Size(42, 20);
            this.countScanLbl.TabIndex = 18;
            this.countScanLbl.Text = "empty";
            this.countScanLbl.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.countScanLbl.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "N/A: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total Scan:";
            // 
            // statusLbl
            // 
            this.statusLbl.AllowParentOverrides = false;
            this.statusLbl.AutoEllipsis = false;
            this.statusLbl.CursorType = null;
            this.statusLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusLbl.Location = new System.Drawing.Point(78, 100);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusLbl.Size = new System.Drawing.Size(42, 20);
            this.statusLbl.TabIndex = 20;
            this.statusLbl.Text = "empty";
            this.statusLbl.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.statusLbl.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.homeButtonImg);
            this.panel2.Controls.Add(this.notificateButtonImg);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 43);
            this.panel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(623, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lưu ý! Kết quả trên chỉ là tham khảo. Cần cân nhắc việc xóa thư mục để tránh bị l" +
    "ỗi đáng tiếc!";
            // 
            // homeButtonImg
            // 
            this.homeButtonImg.ActiveImage = null;
            this.homeButtonImg.AllowAnimations = true;
            this.homeButtonImg.AllowBuffering = false;
            this.homeButtonImg.AllowToggling = false;
            this.homeButtonImg.AllowZooming = true;
            this.homeButtonImg.AllowZoomingOnFocus = false;
            this.homeButtonImg.BackColor = System.Drawing.Color.Transparent;
            this.homeButtonImg.DialogResult = System.Windows.Forms.DialogResult.None;
            this.homeButtonImg.ErrorImage = ((System.Drawing.Image)(resources.GetObject("homeButtonImg.ErrorImage")));
            this.homeButtonImg.FadeWhenInactive = false;
            this.homeButtonImg.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.homeButtonImg.Image = ((System.Drawing.Image)(resources.GetObject("homeButtonImg.Image")));
            this.homeButtonImg.ImageActive = null;
            this.homeButtonImg.ImageLocation = null;
            this.homeButtonImg.ImageMargin = 5;
            this.homeButtonImg.ImageSize = new System.Drawing.Size(30, 30);
            this.homeButtonImg.ImageZoomSize = new System.Drawing.Size(35, 35);
            this.homeButtonImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("homeButtonImg.InitialImage")));
            this.homeButtonImg.Location = new System.Drawing.Point(732, 3);
            this.homeButtonImg.Name = "homeButtonImg";
            this.homeButtonImg.Rotation = 0;
            this.homeButtonImg.ShowActiveImage = true;
            this.homeButtonImg.ShowCursorChanges = true;
            this.homeButtonImg.ShowImageBorders = true;
            this.homeButtonImg.ShowSizeMarkers = false;
            this.homeButtonImg.Size = new System.Drawing.Size(35, 35);
            this.homeButtonImg.TabIndex = 10;
            this.homeButtonImg.ToolTipText = "";
            this.homeButtonImg.WaitOnLoad = false;
            this.homeButtonImg.Zoom = 5;
            this.homeButtonImg.ZoomSpeed = 10;
            this.homeButtonImg.Click += new System.EventHandler(this.homeButtonImg_Click);
            // 
            // notificateButtonImg
            // 
            this.notificateButtonImg.ActiveImage = null;
            this.notificateButtonImg.AllowAnimations = true;
            this.notificateButtonImg.AllowBuffering = false;
            this.notificateButtonImg.AllowToggling = false;
            this.notificateButtonImg.AllowZooming = true;
            this.notificateButtonImg.AllowZoomingOnFocus = false;
            this.notificateButtonImg.BackColor = System.Drawing.Color.Transparent;
            this.notificateButtonImg.DialogResult = System.Windows.Forms.DialogResult.None;
            this.notificateButtonImg.ErrorImage = ((System.Drawing.Image)(resources.GetObject("notificateButtonImg.ErrorImage")));
            this.notificateButtonImg.FadeWhenInactive = false;
            this.notificateButtonImg.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.notificateButtonImg.Image = ((System.Drawing.Image)(resources.GetObject("notificateButtonImg.Image")));
            this.notificateButtonImg.ImageActive = null;
            this.notificateButtonImg.ImageLocation = null;
            this.notificateButtonImg.ImageMargin = 5;
            this.notificateButtonImg.ImageSize = new System.Drawing.Size(25, 25);
            this.notificateButtonImg.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.notificateButtonImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("notificateButtonImg.InitialImage")));
            this.notificateButtonImg.Location = new System.Drawing.Point(7, 7);
            this.notificateButtonImg.Name = "notificateButtonImg";
            this.notificateButtonImg.Rotation = 0;
            this.notificateButtonImg.ShowActiveImage = true;
            this.notificateButtonImg.ShowCursorChanges = true;
            this.notificateButtonImg.ShowImageBorders = true;
            this.notificateButtonImg.ShowSizeMarkers = false;
            this.notificateButtonImg.Size = new System.Drawing.Size(30, 30);
            this.notificateButtonImg.TabIndex = 8;
            this.notificateButtonImg.ToolTipText = "";
            this.notificateButtonImg.WaitOnLoad = false;
            this.notificateButtonImg.Zoom = 5;
            this.notificateButtonImg.ZoomSpeed = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 34);
            this.label5.TabIndex = 15;
            this.label5.Text = "Thread found: ";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.bunifuGroupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.bunifuGroupBox1.ResumeLayout(false);
            this.bunifuGroupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuImageButton quitButtonImg;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuLabel statusLbl;
        private Bunifu.UI.WinForms.BunifuLabel threadCountLbl;
        private Bunifu.UI.WinForms.BunifuImageButton homeButtonImg;
        private Bunifu.UI.WinForms.BunifuLabel countScanLbl;
        private System.Windows.Forms.ListBox ThreadList;
        private Bunifu.UI.WinForms.BunifuImageButton notificateButtonImg;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label3;
    }
}