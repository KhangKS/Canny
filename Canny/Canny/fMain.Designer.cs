
namespace Canny
{
    partial class fMain
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
            this.components = new System.ComponentModel.Container();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.lblthongbao = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMenuItem_GioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItem_TacGia = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sbentrai = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BTNXULY = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblduongdananh = new System.Windows.Forms.Label();
            this.tieudesss = new System.Windows.Forms.Label();
            this.imgAnhGoc = new System.Windows.Forms.PictureBox();
            this.rtbox_thongtinanhbandau = new System.Windows.Forms.RichTextBox();
            this.SLIPBENPHAI = new System.Windows.Forms.SplitContainer();
            this.imgSauXuLy = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbox_thongtinanhsaukhixuly = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StatusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sbentrai)).BeginInit();
            this.sbentrai.Panel1.SuspendLayout();
            this.sbentrai.Panel2.SuspendLayout();
            this.sbentrai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAnhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SLIPBENPHAI)).BeginInit();
            this.SLIPBENPHAI.Panel1.SuspendLayout();
            this.SLIPBENPHAI.Panel2.SuspendLayout();
            this.SLIPBENPHAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSauXuLy)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblthongbao});
            this.StatusStrip.Location = new System.Drawing.Point(0, 758);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StatusStrip.Size = new System.Drawing.Size(1155, 26);
            this.StatusStrip.TabIndex = 0;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // lblthongbao
            // 
            this.lblthongbao.ForeColor = System.Drawing.Color.Red;
            this.lblthongbao.LinkColor = System.Drawing.Color.Red;
            this.lblthongbao.Name = "lblthongbao";
            this.lblthongbao.Size = new System.Drawing.Size(75, 20);
            this.lblthongbao.Text = "Trạng thái";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenuItem_GioiThieu,
            this.TSMenuItem_TacGia,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1155, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMenuItem_GioiThieu
            // 
            this.TSMenuItem_GioiThieu.Name = "TSMenuItem_GioiThieu";
            this.TSMenuItem_GioiThieu.Size = new System.Drawing.Size(111, 27);
            this.TSMenuItem_GioiThieu.Text = "GIỚI THIỆU";
            this.TSMenuItem_GioiThieu.Click += new System.EventHandler(this.TSMenuItem_GioiThieu_Click);
            // 
            // TSMenuItem_TacGia
            // 
            this.TSMenuItem_TacGia.Name = "TSMenuItem_TacGia";
            this.TSMenuItem_TacGia.Size = new System.Drawing.Size(87, 27);
            this.TSMenuItem_TacGia.Text = "TÁC GIẢ";
            this.TSMenuItem_TacGia.Click += new System.EventHandler(this.TSMenuItem_TacGia_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(77, 27);
            this.thoátToolStripMenuItem.Text = "THOÁT";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // sbentrai
            // 
            this.sbentrai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sbentrai.Location = new System.Drawing.Point(0, 31);
            this.sbentrai.Margin = new System.Windows.Forms.Padding(4);
            this.sbentrai.Name = "sbentrai";
            // 
            // sbentrai.Panel1
            // 
            this.sbentrai.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.sbentrai.Panel1.Controls.Add(this.splitContainer2);
            // 
            // sbentrai.Panel2
            // 
            this.sbentrai.Panel2.Controls.Add(this.SLIPBENPHAI);
            this.sbentrai.Size = new System.Drawing.Size(1155, 727);
            this.sbentrai.SplitterDistance = 506;
            this.sbentrai.SplitterWidth = 5;
            this.sbentrai.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer2.Panel1.Controls.Add(this.panel5);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            this.splitContainer2.Panel1.Controls.Add(this.imgAnhGoc);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitContainer2.Panel2.Controls.Add(this.rtbox_thongtinanhbandau);
            this.splitContainer2.Size = new System.Drawing.Size(506, 727);
            this.splitContainer2.SplitterDistance = 398;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.BTNXULY);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 359);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(506, 39);
            this.panel5.TabIndex = 2;
            // 
            // BTNXULY
            // 
            this.BTNXULY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNXULY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNXULY.ForeColor = System.Drawing.Color.White;
            this.BTNXULY.Image = global::Canny.Properties.Resources.processes1;
            this.BTNXULY.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNXULY.Location = new System.Drawing.Point(97, 1);
            this.BTNXULY.Margin = new System.Windows.Forms.Padding(4);
            this.BTNXULY.Name = "BTNXULY";
            this.BTNXULY.Size = new System.Drawing.Size(318, 35);
            this.BTNXULY.TabIndex = 5;
            this.BTNXULY.Text = "XỬ LÝ CANNY";
            this.BTNXULY.UseVisualStyleBackColor = false;
            this.BTNXULY.Click += new System.EventHandler(this.BTNXULY_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.lblduongdananh);
            this.panel1.Controls.Add(this.tieudesss);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 60);
            this.panel1.TabIndex = 1;
            // 
            // lblduongdananh
            // 
            this.lblduongdananh.AutoSize = true;
            this.lblduongdananh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblduongdananh.Location = new System.Drawing.Point(35, 32);
            this.lblduongdananh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblduongdananh.Name = "lblduongdananh";
            this.lblduongdananh.Size = new System.Drawing.Size(394, 20);
            this.lblduongdananh.TabIndex = 1;
            this.lblduongdananh.Text = "(Chọn ảnh định dạng *.jpg; *.jpeg; *.gif; *.bmp; *.png)";
            // 
            // tieudesss
            // 
            this.tieudesss.AutoSize = true;
            this.tieudesss.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tieudesss.ForeColor = System.Drawing.Color.White;
            this.tieudesss.Location = new System.Drawing.Point(185, 3);
            this.tieudesss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tieudesss.Name = "tieudesss";
            this.tieudesss.Size = new System.Drawing.Size(173, 29);
            this.tieudesss.TabIndex = 0;
            this.tieudesss.Text = "ẢNH BAN ĐẦU";
            // 
            // imgAnhGoc
            // 
            this.imgAnhGoc.BackColor = System.Drawing.Color.White;
            this.imgAnhGoc.Location = new System.Drawing.Point(4, 60);
            this.imgAnhGoc.Margin = new System.Windows.Forms.Padding(4);
            this.imgAnhGoc.Name = "imgAnhGoc";
            this.imgAnhGoc.Size = new System.Drawing.Size(354, 291);
            this.imgAnhGoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAnhGoc.TabIndex = 0;
            this.imgAnhGoc.TabStop = false;
            this.imgAnhGoc.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rtbox_thongtinanhbandau
            // 
            this.rtbox_thongtinanhbandau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbox_thongtinanhbandau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbox_thongtinanhbandau.ForeColor = System.Drawing.Color.Red;
            this.rtbox_thongtinanhbandau.Location = new System.Drawing.Point(0, 0);
            this.rtbox_thongtinanhbandau.Margin = new System.Windows.Forms.Padding(4);
            this.rtbox_thongtinanhbandau.Name = "rtbox_thongtinanhbandau";
            this.rtbox_thongtinanhbandau.Size = new System.Drawing.Size(506, 324);
            this.rtbox_thongtinanhbandau.TabIndex = 1;
            this.rtbox_thongtinanhbandau.Text = "THÔNG SỐ ẢNH BAN ĐẦU: ";
            // 
            // SLIPBENPHAI
            // 
            this.SLIPBENPHAI.BackColor = System.Drawing.Color.LightSalmon;
            this.SLIPBENPHAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SLIPBENPHAI.Location = new System.Drawing.Point(0, 0);
            this.SLIPBENPHAI.Margin = new System.Windows.Forms.Padding(4);
            this.SLIPBENPHAI.Name = "SLIPBENPHAI";
            this.SLIPBENPHAI.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SLIPBENPHAI.Panel1
            // 
            this.SLIPBENPHAI.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SLIPBENPHAI.Panel1.Controls.Add(this.imgSauXuLy);
            this.SLIPBENPHAI.Panel1.Controls.Add(this.panel3);
            // 
            // SLIPBENPHAI.Panel2
            // 
            this.SLIPBENPHAI.Panel2.Controls.Add(this.rtbox_thongtinanhsaukhixuly);
            this.SLIPBENPHAI.Size = new System.Drawing.Size(644, 727);
            this.SLIPBENPHAI.SplitterDistance = 393;
            this.SLIPBENPHAI.SplitterWidth = 5;
            this.SLIPBENPHAI.TabIndex = 0;
            // 
            // imgSauXuLy
            // 
            this.imgSauXuLy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgSauXuLy.BackColor = System.Drawing.Color.White;
            this.imgSauXuLy.Location = new System.Drawing.Point(4, 60);
            this.imgSauXuLy.Margin = new System.Windows.Forms.Padding(4);
            this.imgSauXuLy.Name = "imgSauXuLy";
            this.imgSauXuLy.Size = new System.Drawing.Size(354, 277);
            this.imgSauXuLy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSauXuLy.TabIndex = 5;
            this.imgSauXuLy.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(644, 60);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(223, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "ẢNH SAU KHI XỬ LÝ";
            // 
            // rtbox_thongtinanhsaukhixuly
            // 
            this.rtbox_thongtinanhsaukhixuly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbox_thongtinanhsaukhixuly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbox_thongtinanhsaukhixuly.ForeColor = System.Drawing.Color.Red;
            this.rtbox_thongtinanhsaukhixuly.Location = new System.Drawing.Point(0, 0);
            this.rtbox_thongtinanhsaukhixuly.Margin = new System.Windows.Forms.Padding(4);
            this.rtbox_thongtinanhsaukhixuly.Name = "rtbox_thongtinanhsaukhixuly";
            this.rtbox_thongtinanhsaukhixuly.Size = new System.Drawing.Size(644, 329);
            this.rtbox_thongtinanhsaukhixuly.TabIndex = 3;
            this.rtbox_thongtinanhsaukhixuly.Text = "THÔNG SỐ ẢNH SAU KHI XỬ LÝ: ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 784);
            this.Controls.Add(this.sbentrai);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XỬ LÝ ẢNH VỚI- THUẬT TOÁN CANNY";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fMain_Load);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.sbentrai.Panel1.ResumeLayout(false);
            this.sbentrai.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sbentrai)).EndInit();
            this.sbentrai.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAnhGoc)).EndInit();
            this.SLIPBENPHAI.Panel1.ResumeLayout(false);
            this.SLIPBENPHAI.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SLIPBENPHAI)).EndInit();
            this.SLIPBENPHAI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgSauXuLy)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblthongbao;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItem_GioiThieu;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItem_TacGia;
        private System.Windows.Forms.SplitContainer sbentrai;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tieudesss;
        private System.Windows.Forms.PictureBox imgAnhGoc;
        private System.Windows.Forms.SplitContainer SLIPBENPHAI;
        private System.Windows.Forms.Label lblduongdananh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbox_thongtinanhsaukhixuly;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BTNXULY;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox imgSauXuLy;
        private System.Windows.Forms.RichTextBox rtbox_thongtinanhbandau;
    }
}