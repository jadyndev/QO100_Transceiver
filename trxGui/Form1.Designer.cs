﻿
namespace trxGui
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer_draw = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_qrg = new System.Windows.Forms.Panel();
            this.panel_rit = new System.Windows.Forms.Panel();
            this.panel_xit = new System.Windows.Forms.Panel();
            this.panel_copyRtoT = new System.Windows.Forms.Panel();
            this.panel_copyTtoR = new System.Windows.Forms.Panel();
            this.panel_agc = new System.Windows.Forms.Panel();
            this.panel_txmute = new System.Windows.Forms.Panel();
            this.panel_comp = new System.Windows.Forms.Panel();
            this.panel_info = new System.Windows.Forms.Panel();
            this.panel_setup = new System.Windows.Forms.Panel();
            this.panel_rxfilter = new System.Windows.Forms.Panel();
            this.panel_txfilter = new System.Windows.Forms.Panel();
            this.panel_rfloop = new System.Windows.Forms.Panel();
            this.panel_audioloop = new System.Windows.Forms.Panel();
            this.panel_pavucontrol = new System.Windows.Forms.Panel();
            this.panel_rxline = new trxGui.DoubleBufferedPanel();
            this.panel_bigspec = new trxGui.DoubleBufferedPanel();
            this.panel_bigwf = new trxGui.DoubleBufferedPanel();
            this.panel_bandplan = new trxGui.DoubleBufferedPanel();
            this.panel_smallwf = new trxGui.DoubleBufferedPanel();
            this.panel_smallspec = new trxGui.DoubleBufferedPanel();
            this.panel_smallqrg = new trxGui.DoubleBufferedPanel();
            this.SuspendLayout();
            // 
            // timer_draw
            // 
            this.timer_draw.Interval = 60;
            this.timer_draw.Tick += new System.EventHandler(this.timer_draw_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(610, 724);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 33);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // panel_qrg
            // 
            this.panel_qrg.BackColor = System.Drawing.Color.Gray;
            this.panel_qrg.Location = new System.Drawing.Point(12, 3);
            this.panel_qrg.Name = "panel_qrg";
            this.panel_qrg.Size = new System.Drawing.Size(1120, 41);
            this.panel_qrg.TabIndex = 5;
            this.panel_qrg.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_qrg_Paint);
            // 
            // panel_rit
            // 
            this.panel_rit.BackColor = System.Drawing.Color.White;
            this.panel_rit.Location = new System.Drawing.Point(14, 709);
            this.panel_rit.Name = "panel_rit";
            this.panel_rit.Size = new System.Drawing.Size(48, 48);
            this.panel_rit.TabIndex = 15;
            this.panel_rit.Click += new System.EventHandler(this.panel_rit_Click);
            this.panel_rit.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_rit_Paint);
            // 
            // panel_xit
            // 
            this.panel_xit.BackColor = System.Drawing.Color.White;
            this.panel_xit.Location = new System.Drawing.Point(68, 709);
            this.panel_xit.Name = "panel_xit";
            this.panel_xit.Size = new System.Drawing.Size(48, 48);
            this.panel_xit.TabIndex = 15;
            this.panel_xit.Click += new System.EventHandler(this.panel_xit_Click);
            this.panel_xit.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_xit_Paint);
            // 
            // panel_copyRtoT
            // 
            this.panel_copyRtoT.BackColor = System.Drawing.Color.White;
            this.panel_copyRtoT.Location = new System.Drawing.Point(122, 710);
            this.panel_copyRtoT.Name = "panel_copyRtoT";
            this.panel_copyRtoT.Size = new System.Drawing.Size(48, 48);
            this.panel_copyRtoT.TabIndex = 16;
            this.panel_copyRtoT.Click += new System.EventHandler(this.panel_copyRtoT_Click);
            this.panel_copyRtoT.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_copyRtoT_Paint);
            // 
            // panel_copyTtoR
            // 
            this.panel_copyTtoR.BackColor = System.Drawing.Color.White;
            this.panel_copyTtoR.Location = new System.Drawing.Point(176, 709);
            this.panel_copyTtoR.Name = "panel_copyTtoR";
            this.panel_copyTtoR.Size = new System.Drawing.Size(48, 48);
            this.panel_copyTtoR.TabIndex = 16;
            this.panel_copyTtoR.Click += new System.EventHandler(this.panel_copyTtoR_Click);
            this.panel_copyTtoR.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_copyTtoR_Paint);
            // 
            // panel_agc
            // 
            this.panel_agc.BackColor = System.Drawing.Color.White;
            this.panel_agc.Location = new System.Drawing.Point(230, 710);
            this.panel_agc.Name = "panel_agc";
            this.panel_agc.Size = new System.Drawing.Size(48, 48);
            this.panel_agc.TabIndex = 17;
            this.panel_agc.Click += new System.EventHandler(this.panel_agc_Click);
            this.panel_agc.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_agc_Paint);
            // 
            // panel_txmute
            // 
            this.panel_txmute.BackColor = System.Drawing.Color.White;
            this.panel_txmute.Location = new System.Drawing.Point(284, 709);
            this.panel_txmute.Name = "panel_txmute";
            this.panel_txmute.Size = new System.Drawing.Size(48, 48);
            this.panel_txmute.TabIndex = 17;
            this.panel_txmute.Click += new System.EventHandler(this.panel_txmute_Click);
            this.panel_txmute.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_txmute_Paint);
            // 
            // panel_comp
            // 
            this.panel_comp.BackColor = System.Drawing.Color.White;
            this.panel_comp.Location = new System.Drawing.Point(338, 710);
            this.panel_comp.Name = "panel_comp";
            this.panel_comp.Size = new System.Drawing.Size(48, 48);
            this.panel_comp.TabIndex = 18;
            this.panel_comp.Click += new System.EventHandler(this.panel_comp_Click);
            this.panel_comp.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_comp_Paint);
            // 
            // panel_info
            // 
            this.panel_info.BackColor = System.Drawing.Color.White;
            this.panel_info.BackgroundImage = global::trxGui.Properties.Resources.info;
            this.panel_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_info.Location = new System.Drawing.Point(1084, 710);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(48, 48);
            this.panel_info.TabIndex = 15;
            this.panel_info.Click += new System.EventHandler(this.bt_info_click);
            // 
            // panel_setup
            // 
            this.panel_setup.BackColor = System.Drawing.Color.White;
            this.panel_setup.BackgroundImage = global::trxGui.Properties.Resources.setup;
            this.panel_setup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_setup.Location = new System.Drawing.Point(1030, 710);
            this.panel_setup.Name = "panel_setup";
            this.panel_setup.Size = new System.Drawing.Size(48, 48);
            this.panel_setup.TabIndex = 14;
            this.panel_setup.Click += new System.EventHandler(this.butto_setup_click);
            // 
            // panel_rxfilter
            // 
            this.panel_rxfilter.BackColor = System.Drawing.Color.White;
            this.panel_rxfilter.Location = new System.Drawing.Point(392, 710);
            this.panel_rxfilter.Name = "panel_rxfilter";
            this.panel_rxfilter.Size = new System.Drawing.Size(48, 48);
            this.panel_rxfilter.TabIndex = 19;
            this.panel_rxfilter.Click += new System.EventHandler(this.panel_rxfilter_Click);
            this.panel_rxfilter.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_rxfilter_Paint);
            // 
            // panel_txfilter
            // 
            this.panel_txfilter.BackColor = System.Drawing.Color.White;
            this.panel_txfilter.Location = new System.Drawing.Point(446, 710);
            this.panel_txfilter.Name = "panel_txfilter";
            this.panel_txfilter.Size = new System.Drawing.Size(48, 48);
            this.panel_txfilter.TabIndex = 19;
            this.panel_txfilter.Click += new System.EventHandler(this.panel_txfilter_Click);
            this.panel_txfilter.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_txfilter_Paint);
            // 
            // panel_rfloop
            // 
            this.panel_rfloop.BackColor = System.Drawing.Color.White;
            this.panel_rfloop.Location = new System.Drawing.Point(554, 710);
            this.panel_rfloop.Name = "panel_rfloop";
            this.panel_rfloop.Size = new System.Drawing.Size(48, 48);
            this.panel_rfloop.TabIndex = 20;
            this.panel_rfloop.Click += new System.EventHandler(this.panel_rfloop_Click);
            this.panel_rfloop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_rfloop_Paint);
            // 
            // panel_audioloop
            // 
            this.panel_audioloop.BackColor = System.Drawing.Color.White;
            this.panel_audioloop.Location = new System.Drawing.Point(500, 710);
            this.panel_audioloop.Name = "panel_audioloop";
            this.panel_audioloop.Size = new System.Drawing.Size(48, 48);
            this.panel_audioloop.TabIndex = 21;
            this.panel_audioloop.Click += new System.EventHandler(this.panel_audioloop_Click);
            this.panel_audioloop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_audioloop_Paint);
            // 
            // panel_pavucontrol
            // 
            this.panel_pavucontrol.BackColor = System.Drawing.Color.White;
            this.panel_pavucontrol.BackgroundImage = global::trxGui.Properties.Resources.mixer;
            this.panel_pavucontrol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_pavucontrol.Location = new System.Drawing.Point(976, 710);
            this.panel_pavucontrol.Name = "panel_pavucontrol";
            this.panel_pavucontrol.Size = new System.Drawing.Size(48, 48);
            this.panel_pavucontrol.TabIndex = 21;
            this.panel_pavucontrol.Click += new System.EventHandler(this.panel_pavucontrol_Click);
            // 
            // panel_rxline
            // 
            this.panel_rxline.BackColor = System.Drawing.Color.Gray;
            this.panel_rxline.Location = new System.Drawing.Point(12, 366);
            this.panel_rxline.Name = "panel_rxline";
            this.panel_rxline.Size = new System.Drawing.Size(1120, 12);
            this.panel_rxline.TabIndex = 3;
            this.panel_rxline.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_rxline_Paint);
            // 
            // panel_bigspec
            // 
            this.panel_bigspec.BackColor = System.Drawing.Color.LightGray;
            this.panel_bigspec.Location = new System.Drawing.Point(12, 50);
            this.panel_bigspec.Name = "panel_bigspec";
            this.panel_bigspec.Size = new System.Drawing.Size(1120, 150);
            this.panel_bigspec.TabIndex = 0;
            this.panel_bigspec.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_bigspec_Paint);
            this.panel_bigspec.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_bigwf_MouseClick);
            this.panel_bigspec.MouseLeave += new System.EventHandler(this.panel_bigspec_MouseLeave);
            this.panel_bigspec.MouseHover += new System.EventHandler(this.panel_bigspec_MouseHover);
            this.panel_bigspec.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_bigspec_MouseMove);
            // 
            // panel_bigwf
            // 
            this.panel_bigwf.BackColor = System.Drawing.Color.Black;
            this.panel_bigwf.Location = new System.Drawing.Point(12, 213);
            this.panel_bigwf.Name = "panel_bigwf";
            this.panel_bigwf.Size = new System.Drawing.Size(1120, 150);
            this.panel_bigwf.TabIndex = 1;
            this.panel_bigwf.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_bigwf_Paint);
            this.panel_bigwf.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_bigwf_MouseClick);
            this.panel_bigwf.MouseLeave += new System.EventHandler(this.panel_bigwf_MouseLeave);
            this.panel_bigwf.MouseHover += new System.EventHandler(this.panel_bigwf_MouseHover);
            this.panel_bigwf.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_bigwf_MouseMove);
            // 
            // panel_bandplan
            // 
            this.panel_bandplan.BackColor = System.Drawing.Color.Silver;
            this.panel_bandplan.Location = new System.Drawing.Point(14, 200);
            this.panel_bandplan.Name = "panel_bandplan";
            this.panel_bandplan.Size = new System.Drawing.Size(1120, 12);
            this.panel_bandplan.TabIndex = 1;
            this.panel_bandplan.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_bandplan_Paint);
            // 
            // panel_smallwf
            // 
            this.panel_smallwf.BackColor = System.Drawing.Color.Black;
            this.panel_smallwf.Location = new System.Drawing.Point(12, 554);
            this.panel_smallwf.Name = "panel_smallwf";
            this.panel_smallwf.Size = new System.Drawing.Size(1120, 150);
            this.panel_smallwf.TabIndex = 1;
            this.panel_smallwf.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_smallwf_Paint);
            this.panel_smallwf.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_smallwf_MouseClick);
            this.panel_smallwf.MouseLeave += new System.EventHandler(this.panel_smallwf_MouseLeave);
            this.panel_smallwf.MouseHover += new System.EventHandler(this.panel_smallwf_MouseHover);
            this.panel_smallwf.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_smallwf_MouseMove);
            // 
            // panel_smallspec
            // 
            this.panel_smallspec.BackColor = System.Drawing.Color.LightGray;
            this.panel_smallspec.Location = new System.Drawing.Point(12, 384);
            this.panel_smallspec.Name = "panel_smallspec";
            this.panel_smallspec.Size = new System.Drawing.Size(1120, 150);
            this.panel_smallspec.TabIndex = 1;
            this.panel_smallspec.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_smallspec_Paint);
            this.panel_smallspec.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_smallwf_MouseClick);
            this.panel_smallspec.MouseLeave += new System.EventHandler(this.panel_smallspec_MouseLeave);
            this.panel_smallspec.MouseHover += new System.EventHandler(this.panel_smallspec_MouseHover);
            this.panel_smallspec.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_smallspec_MouseMove);
            // 
            // panel_smallqrg
            // 
            this.panel_smallqrg.BackColor = System.Drawing.Color.Silver;
            this.panel_smallqrg.Location = new System.Drawing.Point(14, 536);
            this.panel_smallqrg.Name = "panel_smallqrg";
            this.panel_smallqrg.Size = new System.Drawing.Size(1120, 12);
            this.panel_smallqrg.TabIndex = 2;
            this.panel_smallqrg.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_smallqrg_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1147, 775);
            this.Controls.Add(this.panel_rxline);
            this.Controls.Add(this.panel_pavucontrol);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_rfloop);
            this.Controls.Add(this.panel_txfilter);
            this.Controls.Add(this.panel_audioloop);
            this.Controls.Add(this.panel_rxfilter);
            this.Controls.Add(this.panel_comp);
            this.Controls.Add(this.panel_txmute);
            this.Controls.Add(this.panel_agc);
            this.Controls.Add(this.panel_copyTtoR);
            this.Controls.Add(this.panel_copyRtoT);
            this.Controls.Add(this.panel_xit);
            this.Controls.Add(this.panel_rit);
            this.Controls.Add(this.panel_info);
            this.Controls.Add(this.panel_setup);
            this.Controls.Add(this.panel_qrg);
            this.Controls.Add(this.panel_bigspec);
            this.Controls.Add(this.panel_bigwf);
            this.Controls.Add(this.panel_bandplan);
            this.Controls.Add(this.panel_smallwf);
            this.Controls.Add(this.panel_smallspec);
            this.Controls.Add(this.panel_smallqrg);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "QO100 Linux - Pluto Transceiver (by DJ0ABR) V1.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer_draw;
        private DoubleBufferedPanel panel_smallqrg;
        private DoubleBufferedPanel panel_bandplan;
        private DoubleBufferedPanel panel_smallwf;
        private DoubleBufferedPanel panel_smallspec;
        private DoubleBufferedPanel panel_bigwf;
        private DoubleBufferedPanel panel_bigspec;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_qrg;
        private System.Windows.Forms.Panel panel_setup;
        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.Panel panel_rit;
        private System.Windows.Forms.Panel panel_xit;
        private System.Windows.Forms.Panel panel_copyRtoT;
        private System.Windows.Forms.Panel panel_copyTtoR;
        private System.Windows.Forms.Panel panel_agc;
        private System.Windows.Forms.Panel panel_txmute;
        private System.Windows.Forms.Panel panel_comp;
        private System.Windows.Forms.Panel panel_rxfilter;
        private System.Windows.Forms.Panel panel_txfilter;
        private System.Windows.Forms.Panel panel_rfloop;
        private System.Windows.Forms.Panel panel_audioloop;
        private System.Windows.Forms.Panel panel_pavucontrol;
        private DoubleBufferedPanel panel_rxline;
    }
}

