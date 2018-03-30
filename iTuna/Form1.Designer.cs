namespace iTuna
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbArtist = new System.Windows.Forms.Label();
            this.lbalbum = new System.Windows.Forms.Label();
            this.lbnowtime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpAlarm = new System.Windows.Forms.DateTimePicker();
            this.chbAlarm = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnTop = new System.Windows.Forms.Button();
            this.nudVolume = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPlayPause.Location = new System.Drawing.Point(256, 270);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(170, 53);
            this.btnPlayPause.TabIndex = 0;
            this.btnPlayPause.Text = "Play / Pause";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNext.Location = new System.Drawing.Point(493, 270);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(170, 53);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPrev.Location = new System.Drawing.Point(15, 270);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(170, 53);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(254, 184);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(30, 15);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "title";
            // 
            // lbArtist
            // 
            this.lbArtist.AutoSize = true;
            this.lbArtist.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArtist.Location = new System.Drawing.Point(254, 232);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(38, 15);
            this.lbArtist.TabIndex = 1;
            this.lbArtist.Text = "artist";
            // 
            // lbalbum
            // 
            this.lbalbum.AutoSize = true;
            this.lbalbum.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbalbum.Location = new System.Drawing.Point(254, 209);
            this.lbalbum.Name = "lbalbum";
            this.lbalbum.Size = new System.Drawing.Size(43, 15);
            this.lbalbum.TabIndex = 2;
            this.lbalbum.Text = "album";
            // 
            // lbnowtime
            // 
            this.lbnowtime.AutoSize = true;
            this.lbnowtime.Font = new System.Drawing.Font("Meiryo UI", 36F);
            this.lbnowtime.Location = new System.Drawing.Point(12, 9);
            this.lbnowtime.Name = "lbnowtime";
            this.lbnowtime.Size = new System.Drawing.Size(144, 61);
            this.lbnowtime.TabIndex = 3;
            this.lbnowtime.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Album";
            // 
            // dtpAlarm
            // 
            this.dtpAlarm.CustomFormat = "yyyy年MM月dd日 dddd HH時mm分ss秒";
            this.dtpAlarm.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpAlarm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAlarm.Location = new System.Drawing.Point(131, 102);
            this.dtpAlarm.Name = "dtpAlarm";
            this.dtpAlarm.ShowUpDown = true;
            this.dtpAlarm.Size = new System.Drawing.Size(532, 42);
            this.dtpAlarm.TabIndex = 4;
            this.dtpAlarm.Value = new System.DateTime(2018, 3, 28, 8, 0, 0, 0);
            // 
            // chbAlarm
            // 
            this.chbAlarm.AutoSize = true;
            this.chbAlarm.Location = new System.Drawing.Point(110, 102);
            this.chbAlarm.Name = "chbAlarm";
            this.chbAlarm.Size = new System.Drawing.Size(15, 14);
            this.chbAlarm.TabIndex = 5;
            this.chbAlarm.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // btnTop
            // 
            this.btnTop.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnTop.Location = new System.Drawing.Point(588, 12);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(75, 23);
            this.btnTop.TabIndex = 6;
            this.btnTop.Text = "トップ";
            this.btnTop.UseVisualStyleBackColor = true;
            // 
            // nudVolume
            // 
            this.nudVolume.Location = new System.Drawing.Point(610, 228);
            this.nudVolume.Name = "nudVolume";
            this.nudVolume.Size = new System.Drawing.Size(53, 19);
            this.nudVolume.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 345);
            this.Controls.Add(this.nudVolume);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.chbAlarm);
            this.Controls.Add(this.dtpAlarm);
            this.Controls.Add(this.lbnowtime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbalbum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbArtist);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPlayPause);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "iTuna";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ClientSizeChanged += new System.EventHandler(this.Form1_ClientSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.nudVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbArtist;
        private System.Windows.Forms.Label lbalbum;
        private System.Windows.Forms.Label lbnowtime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpAlarm;
        private System.Windows.Forms.CheckBox chbAlarm;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.NumericUpDown nudVolume;
    }
}

