namespace bunifuDataViz_ohlc_demo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.render_stepline = new System.Windows.Forms.Button();
            this.render_stacked_column_100 = new System.Windows.Forms.Button();
            this.render_stacked_column = new System.Windows.Forms.Button();
            this.render_stacked_bar_100 = new System.Windows.Forms.Button();
            this.render_stacked_bar = new System.Windows.Forms.Button();
            this.render_stacked_area_i100 = new System.Windows.Forms.Button();
            this.render_stacked_area = new System.Windows.Forms.Button();
            this.render_scatter_chart = new System.Windows.Forms.Button();
            this.render_range_area = new System.Windows.Forms.Button();
            this.render_range_column = new System.Windows.Forms.Button();
            this.render_rangebar = new System.Windows.Forms.Button();
            this.render_ohlc = new System.Windows.Forms.Button();
            this.render_candle_stick = new System.Windows.Forms.Button();
            this.render_bubble_chart = new System.Windows.Forms.Button();
            this.bunifuDataViz1 = new Bunifu.DataViz.BunifuDataViz();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.render_range_spline_area = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.render_range_spline_area);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.render_stepline);
            this.panel1.Controls.Add(this.render_stacked_column_100);
            this.panel1.Controls.Add(this.render_stacked_column);
            this.panel1.Controls.Add(this.render_stacked_bar_100);
            this.panel1.Controls.Add(this.render_stacked_bar);
            this.panel1.Controls.Add(this.render_stacked_area_i100);
            this.panel1.Controls.Add(this.render_stacked_area);
            this.panel1.Controls.Add(this.render_scatter_chart);
            this.panel1.Controls.Add(this.render_range_area);
            this.panel1.Controls.Add(this.render_range_column);
            this.panel1.Controls.Add(this.render_rangebar);
            this.panel1.Controls.Add(this.render_ohlc);
            this.panel1.Controls.Add(this.render_candle_stick);
            this.panel1.Controls.Add(this.render_bubble_chart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 792);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // render_stepline
            // 
            this.render_stepline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(54)))), ((int)(((byte)(143)))));
            this.render_stepline.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.render_stepline.ForeColor = System.Drawing.Color.White;
            this.render_stepline.Location = new System.Drawing.Point(15, 656);
            this.render_stepline.Name = "render_stepline";
            this.render_stepline.Size = new System.Drawing.Size(167, 33);
            this.render_stepline.TabIndex = 14;
            this.render_stepline.Text = "Step line";
            this.render_stepline.UseVisualStyleBackColor = false;
            this.render_stepline.Click += new System.EventHandler(this.render_stepline_Click);
            // 
            // render_stacked_column_100
            // 
            this.render_stacked_column_100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(46)))), ((int)(((byte)(143)))));
            this.render_stacked_column_100.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.render_stacked_column_100.ForeColor = System.Drawing.Color.White;
            this.render_stacked_column_100.Location = new System.Drawing.Point(15, 619);
            this.render_stacked_column_100.Name = "render_stacked_column_100";
            this.render_stacked_column_100.Size = new System.Drawing.Size(167, 33);
            this.render_stacked_column_100.TabIndex = 13;
            this.render_stacked_column_100.Text = "Stacked column 100";
            this.render_stacked_column_100.UseVisualStyleBackColor = false;
            this.render_stacked_column_100.Click += new System.EventHandler(this.render_stacked_column_100_Click);
            // 
            // render_stacked_column
            // 
            this.render_stacked_column.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.render_stacked_column.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.render_stacked_column.ForeColor = System.Drawing.Color.White;
            this.render_stacked_column.Location = new System.Drawing.Point(15, 582);
            this.render_stacked_column.Name = "render_stacked_column";
            this.render_stacked_column.Size = new System.Drawing.Size(167, 33);
            this.render_stacked_column.TabIndex = 12;
            this.render_stacked_column.Text = "Stacked column";
            this.render_stacked_column.UseVisualStyleBackColor = false;
            this.render_stacked_column.Click += new System.EventHandler(this.render_stacked_column_Click);
            // 
            // render_stacked_bar_100
            // 
            this.render_stacked_bar_100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.render_stacked_bar_100.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.render_stacked_bar_100.ForeColor = System.Drawing.Color.White;
            this.render_stacked_bar_100.Location = new System.Drawing.Point(15, 545);
            this.render_stacked_bar_100.Name = "render_stacked_bar_100";
            this.render_stacked_bar_100.Size = new System.Drawing.Size(167, 33);
            this.render_stacked_bar_100.TabIndex = 11;
            this.render_stacked_bar_100.Text = "Stacked bar 100";
            this.render_stacked_bar_100.UseVisualStyleBackColor = false;
            this.render_stacked_bar_100.Click += new System.EventHandler(this.render_stacked_bar_100_Click);
            // 
            // render_stacked_bar
            // 
            this.render_stacked_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(54)))), ((int)(((byte)(143)))));
            this.render_stacked_bar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.render_stacked_bar.ForeColor = System.Drawing.Color.White;
            this.render_stacked_bar.Location = new System.Drawing.Point(15, 508);
            this.render_stacked_bar.Name = "render_stacked_bar";
            this.render_stacked_bar.Size = new System.Drawing.Size(167, 33);
            this.render_stacked_bar.TabIndex = 10;
            this.render_stacked_bar.Text = "Stacked bar";
            this.render_stacked_bar.UseVisualStyleBackColor = false;
            this.render_stacked_bar.Click += new System.EventHandler(this.render_stacked_bar_Click);
            // 
            // render_stacked_area_i100
            // 
            this.render_stacked_area_i100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(46)))), ((int)(((byte)(143)))));
            this.render_stacked_area_i100.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.render_stacked_area_i100.ForeColor = System.Drawing.Color.White;
            this.render_stacked_area_i100.Location = new System.Drawing.Point(15, 471);
            this.render_stacked_area_i100.Name = "render_stacked_area_i100";
            this.render_stacked_area_i100.Size = new System.Drawing.Size(167, 33);
            this.render_stacked_area_i100.TabIndex = 9;
            this.render_stacked_area_i100.Text = "Stacked area 100";
            this.render_stacked_area_i100.UseVisualStyleBackColor = false;
            this.render_stacked_area_i100.Click += new System.EventHandler(this.render_stacked_area_i100_Click);
            // 
            // render_stacked_area
            // 
            this.render_stacked_area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.render_stacked_area.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.render_stacked_area.ForeColor = System.Drawing.Color.White;
            this.render_stacked_area.Location = new System.Drawing.Point(15, 434);
            this.render_stacked_area.Name = "render_stacked_area";
            this.render_stacked_area.Size = new System.Drawing.Size(167, 33);
            this.render_stacked_area.TabIndex = 8;
            this.render_stacked_area.Text = "Stacked area";
            this.render_stacked_area.UseVisualStyleBackColor = false;
            this.render_stacked_area.Click += new System.EventHandler(this.render_stacked_area_Click);
            // 
            // render_scatter_chart
            // 
            this.render_scatter_chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.render_scatter_chart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.render_scatter_chart.ForeColor = System.Drawing.Color.White;
            this.render_scatter_chart.Location = new System.Drawing.Point(15, 397);
            this.render_scatter_chart.Name = "render_scatter_chart";
            this.render_scatter_chart.Size = new System.Drawing.Size(167, 33);
            this.render_scatter_chart.TabIndex = 7;
            this.render_scatter_chart.Text = "Scatter";
            this.render_scatter_chart.UseVisualStyleBackColor = false;
            this.render_scatter_chart.Click += new System.EventHandler(this.render_scatter_chart_Click);
            // 
            // render_range_area
            // 
            this.render_range_area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.render_range_area.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.render_range_area.ForeColor = System.Drawing.Color.White;
            this.render_range_area.Location = new System.Drawing.Point(15, 322);
            this.render_range_area.Name = "render_range_area";
            this.render_range_area.Size = new System.Drawing.Size(167, 33);
            this.render_range_area.TabIndex = 5;
            this.render_range_area.Text = "Range area";
            this.render_range_area.UseVisualStyleBackColor = false;
            this.render_range_area.Click += new System.EventHandler(this.render_range_area_Click);
            // 
            // render_range_column
            // 
            this.render_range_column.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.render_range_column.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.render_range_column.ForeColor = System.Drawing.Color.White;
            this.render_range_column.Location = new System.Drawing.Point(15, 285);
            this.render_range_column.Name = "render_range_column";
            this.render_range_column.Size = new System.Drawing.Size(167, 33);
            this.render_range_column.TabIndex = 4;
            this.render_range_column.Text = "Range column";
            this.render_range_column.UseVisualStyleBackColor = false;
            this.render_range_column.Click += new System.EventHandler(this.render_range_column_Click);
            // 
            // render_rangebar
            // 
            this.render_rangebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.render_rangebar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.render_rangebar.ForeColor = System.Drawing.Color.White;
            this.render_rangebar.Location = new System.Drawing.Point(15, 248);
            this.render_rangebar.Name = "render_rangebar";
            this.render_rangebar.Size = new System.Drawing.Size(167, 33);
            this.render_rangebar.TabIndex = 3;
            this.render_rangebar.Text = "Range Bar";
            this.render_rangebar.UseVisualStyleBackColor = false;
            this.render_rangebar.Click += new System.EventHandler(this.render_rangebar_Click);
            // 
            // render_ohlc
            // 
            this.render_ohlc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.render_ohlc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.render_ohlc.ForeColor = System.Drawing.Color.White;
            this.render_ohlc.Location = new System.Drawing.Point(15, 211);
            this.render_ohlc.Name = "render_ohlc";
            this.render_ohlc.Size = new System.Drawing.Size(167, 33);
            this.render_ohlc.TabIndex = 2;
            this.render_ohlc.Text = "OHLC";
            this.render_ohlc.UseVisualStyleBackColor = false;
            this.render_ohlc.Click += new System.EventHandler(this.render_ohlc_Click);
            // 
            // render_candle_stick
            // 
            this.render_candle_stick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.render_candle_stick.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.render_candle_stick.ForeColor = System.Drawing.Color.White;
            this.render_candle_stick.Location = new System.Drawing.Point(15, 174);
            this.render_candle_stick.Name = "render_candle_stick";
            this.render_candle_stick.Size = new System.Drawing.Size(167, 33);
            this.render_candle_stick.TabIndex = 1;
            this.render_candle_stick.Text = "Candle sticks";
            this.render_candle_stick.UseVisualStyleBackColor = false;
            this.render_candle_stick.Click += new System.EventHandler(this.render_candle_stick_Click);
            // 
            // render_bubble_chart
            // 
            this.render_bubble_chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.render_bubble_chart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.render_bubble_chart.ForeColor = System.Drawing.Color.White;
            this.render_bubble_chart.Location = new System.Drawing.Point(15, 137);
            this.render_bubble_chart.Name = "render_bubble_chart";
            this.render_bubble_chart.Size = new System.Drawing.Size(167, 33);
            this.render_bubble_chart.TabIndex = 0;
            this.render_bubble_chart.Text = "Bubble Chart";
            this.render_bubble_chart.UseVisualStyleBackColor = false;
            this.render_bubble_chart.Click += new System.EventHandler(this.render_bubble_chart_Click);
            // 
            // bunifuDataViz1
            // 
            this.bunifuDataViz1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuDataViz1.animationEnabled = false;
            this.bunifuDataViz1.AxisLineColor = System.Drawing.Color.LightGray;
            this.bunifuDataViz1.AxisXFontColor = System.Drawing.Color.Gray;
            this.bunifuDataViz1.AxisXGridColor = System.Drawing.Color.Gray;
            this.bunifuDataViz1.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuDataViz1.AxisYFontColor = System.Drawing.Color.Gray;
            this.bunifuDataViz1.AxisYGridColor = System.Drawing.Color.Gray;
            this.bunifuDataViz1.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuDataViz1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuDataViz1.Location = new System.Drawing.Point(266, 174);
            this.bunifuDataViz1.Name = "bunifuDataViz1";
            this.bunifuDataViz1.Size = new System.Drawing.Size(824, 411);
            this.bunifuDataViz1.TabIndex = 1;
            this.bunifuDataViz1.Theme = Bunifu.DataViz.BunifuDataViz._theme.theme3;
            this.bunifuDataViz1.Title = "";
            this.bunifuDataViz1.Load += new System.EventHandler(this.bunifuDataViz1_Load);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox1.Location = new System.Drawing.Point(249, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Apply Theme";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // render_range_spline_area
            // 
            this.render_range_spline_area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.render_range_spline_area.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.render_range_spline_area.ForeColor = System.Drawing.Color.White;
            this.render_range_spline_area.Location = new System.Drawing.Point(15, 358);
            this.render_range_spline_area.Name = "render_range_spline_area";
            this.render_range_spline_area.Size = new System.Drawing.Size(167, 33);
            this.render_range_spline_area.TabIndex = 17;
            this.render_range_spline_area.Text = "Range spline area";
            this.render_range_spline_area.UseVisualStyleBackColor = false;
            this.render_range_spline_area.Click += new System.EventHandler(this.render_range_spline_area_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl.Location = new System.Drawing.Point(281, 95);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(74, 25);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "label1";
            this.lbl.TabIndexChanged += new System.EventHandler(this.lbl_TabIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(54)))), ((int)(((byte)(143)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 695);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Step Area";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1200, 792);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.bunifuDataViz1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bunifu DataViz Advanced";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.DataViz.BunifuDataViz bunifuDataViz1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button render_stepline;
        private System.Windows.Forms.Button render_stacked_column_100;
        private System.Windows.Forms.Button render_stacked_column;
        private System.Windows.Forms.Button render_stacked_bar_100;
        private System.Windows.Forms.Button render_stacked_bar;
        private System.Windows.Forms.Button render_stacked_area_i100;
        private System.Windows.Forms.Button render_stacked_area;
        private System.Windows.Forms.Button render_scatter_chart;
        private System.Windows.Forms.Button render_range_area;
        private System.Windows.Forms.Button render_range_column;
        private System.Windows.Forms.Button render_rangebar;
        private System.Windows.Forms.Button render_ohlc;
        private System.Windows.Forms.Button render_candle_stick;
        private System.Windows.Forms.Button render_bubble_chart;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button render_range_spline_area;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

