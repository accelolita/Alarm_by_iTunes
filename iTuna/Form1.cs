using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTunesLib;
using System.Runtime.InteropServices;
using System.Threading;

namespace iTuna
{
    public partial class Form1 : Form
    {
        private iTunesApp iTunes;
        System.Threading.Timer GUITimer;
        TimerCallback GUITimerCallback;


        public Form1()
        {
            InitializeComponent();

            //iTunes comオブジェクト
            iTunes = new iTunesApp();
            //iTunesの終了イベント
            iTunes.OnAboutToPromptUserToQuitEvent += new _IiTunesEvents_OnAboutToPromptUserToQuitEventEventHandler(iTunes_OnAboutToPromptUserToQuitEvent);
            //ヴォリューム変更イベント  これが匿名メソッド
            //iTunes.OnSoundVolumeChangedEvent += delegate (int vol){
            //    BeginInvoke((MethodInvoker)delegate { nudVolume.Value = vol; });
            //};
            //GUIへの反映（1秒おき）
            GUITimerCallback = new TimerCallback(updateGUI);
            GUITimer = new System.Threading.Timer(GUITimerCallback, null, 0, 500);
            dtpAlarm.Value = DateTime.Today.AddHours(8);
            //ボリュームコントロール
            nudVolume.Value = iTunes.SoundVolume;
            nudVolume.ValueChanged += delegate { iTunes.SoundVolume = (int)nudVolume.Value; };
            nudVolume.Scroll += delegate { iTunes.SoundVolume = (int)nudVolume.Value; };
            //ボタン
            btnPlayPause.Click += delegate { iTunes.PlayPause(); };
            btnNext.Click += delegate { iTunes.NextTrack(); };
            btnPrev.Click += delegate { iTunes.PreviousTrack(); };
            btnTop.Click += delegate { this.TopMost = !this.TopMost; };
        }

        private void updateGUI(object state)
        {

            var ntime = DateTime.Now;
            IITTrack track = iTunes.CurrentTrack; 
            
            this.BeginInvoke((MethodInvoker)delegate {
                try
                {
                    if (track != null)
                    {
                        lbTitle.Text = track.Name;
                        lbalbum.Text = track.Album;
                        lbArtist.Text = track.Artist;
                    }

                    lbnowtime.Text = ntime.ToShortDateString()+" "+ntime.ToLongTimeString();
                }
                catch (InvalidComObjectException)
                {
                    Console.WriteLine("取得失敗");
                }
            });
            //チェックかつ設定ティック以上
            if (chbAlarm.Checked && ntime.Ticks>dtpAlarm.Value.Ticks)
            {
                this.BeginInvoke((MethodInvoker)delegate {
                    chbAlarm.Checked = false;
                    dtpAlarm.Value=dtpAlarm.Value.AddDays(1);
                });
                iTunes.Play();

            }
            
            
        }


        //iTunes COM SDKを解放
        void ReleaseCOM()
        {
            //iTunes.OnPlayerPlayEvent -= iTunes_OnPlayerPlayEvent;
            iTunes.OnAboutToPromptUserToQuitEvent -= iTunes_OnAboutToPromptUserToQuitEvent;

            Marshal.ReleaseComObject(iTunes);
            iTunes = null;
        }
        //iTunes終了時に呼ばれる？メソッド
        private void iTunes_OnAboutToPromptUserToQuitEvent()
        {
            GUITimer.Dispose();
            ReleaseCOM();
            this.Invoke((MethodInvoker)delegate ()
            {
                this.Close();
            });
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (iTunes != null) ReleaseCOM();
            GUITimer.Dispose();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // フォームを表示する
            this.Visible = true;
            // 現在の状態が最小化の状態であれば通常の状態に戻す
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            // フォームをアクティブにする
            this.Activate();
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                // フォームが最小化の状態であればフォームを非表示にする
                this.Hide();
                // トレイリストのアイコンを表示する
                notifyIcon1.Visible = true;
            }
        }


    }
}
