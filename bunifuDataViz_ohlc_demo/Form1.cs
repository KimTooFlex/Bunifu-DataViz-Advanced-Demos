using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
namespace bunifuDataViz_ohlc_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

         

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                bunifuDataViz1.colorSet.Add(lbl.ForeColor);
            }
            else
            {
                bunifuDataViz1.colorSet.Clear();
                //my thememater
                bunifuDataViz1.colorSet.Add(Color.FromArgb(233, 30, 99));
                bunifuDataViz1.colorSet.Add(Color.FromArgb(156, 39, 176));
                bunifuDataViz1.colorSet.Add(Color.FromArgb(103, 58, 183));
                bunifuDataViz1.colorSet.Add(Color.FromArgb(63, 81, 181));
                bunifuDataViz1.colorSet.Add(Color.FromArgb(33, 150, 243));
                bunifuDataViz1.colorSet.Add(Color.FromArgb(3, 169, 244));
                bunifuDataViz1.colorSet.Add(Color.FromArgb(0, 188, 212));
                bunifuDataViz1.colorSet.Add(Color.FromArgb(0, 150, 136));
                bunifuDataViz1.colorSet.Add(Color.FromArgb(76, 175, 80));
                bunifuDataViz1.colorSet.Add(Color.FromArgb(205, 220, 57));
                bunifuDataViz1.colorSet.Add(Color.FromArgb(255, 152, 0));
                bunifuDataViz1.colorSet.Add(Color.FromArgb(121, 85, 72));
                bunifuDataViz1.colorSet.Add(Color.FromArgb(158, 158, 158));
            }

            bunifuDataViz1.Refresh();
        }
        private void bunifuDataViz1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void lbl_TabIndexChanged(object sender, EventArgs e)
        {
            bunifuDataViz1.Refresh();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            render_bubble_chart_Click(render_bubble_chart, new EventArgs());
        }




        /// <summary>
        /// //////////////// // ALL ADVANED CHARTS HERE
        /// </summary>


        Random r = new Random();

        /// <summary>
        /// Handles the Click event of the render_bubble_chart control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void render_bubble_chart_Click(object sender, EventArgs e)
        {
            lbl.Text = "Bunifu " + ((Button)sender).Text;
            lbl.ForeColor = ((Button)sender).BackColor;
            //Canvas data
            Bunifu.DataViz.Canvas canvas = new Bunifu.DataViz.Canvas();
            Bunifu.DataViz.DataPoint datapoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_bubble);
            //add sample data to datapoint
            for (int i = 1; i <= 30; i++)
            {
                datapoint.addxyzname(r.Next(0,100),r.Next(0,100),r.Next(10,100),"Bubble"+i); //x y z, name
            }
            //add datapoint to cnavas
            canvas.addData(datapoint);
            //render canvas
            bunifuDataViz1.Render(canvas);
        }









        /// <summary>
        /// Handles the Click event of the render_candle_stick control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void render_candle_stick_Click(object sender, EventArgs e)
        {
            lbl.Text = "Bunifu " + ((Button)sender).Text;
            lbl.ForeColor = ((Button)sender).BackColor;
            // data Canvas

            Bunifu.DataViz.Canvas canvas = new Bunifu.DataViz.Canvas();
            Bunifu.DataViz.DataPoint datapoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_candlestick);

            //add sample data to datapoint


            // Y: [Open, High ,Low, Close]
            //:[19.97, 20.47, 16.23, 17.99]

            //x= date

            //Use "new Date" tag to format any date to chart compatible
            datapoint.addxy("new Date (2002,11,10)", new JArray(19.97, 20.47, 16.23, 17.99).ToString());
            datapoint.addxy("new Date (2002, 11, 9)", new JArray(16.68, 19.65, 15.95, 19.25).ToString());
            datapoint.addxy("new Date (2002, 11, 8)", new JArray(14.20, 17.86, 11.30, 16.88).ToString());
            datapoint.addxy("new Date (2002, 11, 7)", new JArray(16.45, 16.61, 13.29, 14.28).ToString());
            datapoint.addxy("new Date (2002, 11, 6)", new JArray(16.50, 19.20, 15.23, 16.45).ToString());
            datapoint.addxy("new Date (2002, 11, 5)", new JArray(19.00, 19.00, 13.70, 16.50).ToString());
            datapoint.addxy("new Date (2002, 11, 4)", new JArray(20.75, 20.99, 17.50, 19.00).ToString());
            datapoint.addxy("new Date (2002, 11, 3)", new JArray(21.38, 23.08, 19.50, 20.85).ToString());
            datapoint.addxy("new Date (2002, 11, 2)", new JArray(26.65, 26.70, 20.07, 21.44).ToString());
            datapoint.addxy("new Date (2002, 11, 1)", new JArray(26.30, 30.50, 25.00, 26.70).ToString());

            //add datapoint to cnavas
            canvas.addData(datapoint);  //rem you can add several datapointsof different chart Type to one canvas 

            //render canvas
            bunifuDataViz1.Render(canvas);
        }

        /// <summary>
        /// Handles the Click event of the render_ohlc control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void render_ohlc_Click(object sender, EventArgs e)
        {
            lbl.Text = "Bunifu " + ((Button)sender).Text;
            lbl.ForeColor = ((Button)sender).BackColor;
            // data Canvas

            Bunifu.DataViz.Canvas canvas = new Bunifu.DataViz.Canvas();
            Bunifu.DataViz.DataPoint datapoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_ohlc);

            //add sample data to datapoint


            // Y: [Open, High ,Low, Close]
            //:[19.97, 20.47, 16.23, 17.99]

            //x= date
             
            //Use "new Date" tag to format any date to chart compatible
                datapoint.addxy("new Date (2002,11,10)", new JArray(19.97, 20.47, 16.23, 17.99).ToString());
                datapoint.addxy("new Date (2002, 11, 9)", new JArray(16.68, 19.65, 15.95, 19.25).ToString());
                datapoint.addxy("new Date (2002, 11, 8)", new JArray(14.20, 17.86, 11.30, 16.88).ToString());
                datapoint.addxy("new Date (2002, 11, 7)", new JArray(16.45, 16.61, 13.29, 14.28).ToString());
                datapoint.addxy("new Date (2002, 11, 6)", new JArray(16.50, 19.20, 15.23, 16.45).ToString());
                datapoint.addxy("new Date (2002, 11, 5)", new JArray(19.00, 19.00, 13.70, 16.50).ToString());
                datapoint.addxy("new Date (2002, 11, 4)", new JArray(20.75, 20.99, 17.50, 19.00).ToString());
                datapoint.addxy("new Date (2002, 11, 3)", new JArray(21.38, 23.08, 19.50, 20.85).ToString());
                datapoint.addxy("new Date (2002, 11, 2)", new JArray(26.65, 26.70, 20.07, 21.44).ToString());
                datapoint.addxy("new Date (2002, 11, 1)", new JArray(26.30, 30.50, 25.00, 26.70).ToString());
 
            //add datapoint to cnavas
            canvas.addData(datapoint);  //rem you can add several datapointsof different chart Type to one canvas 

            //render canvas
            bunifuDataViz1.Render(canvas);
        }

        /// <summary>
        /// Handles the Click event of the render_rangebar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void render_rangebar_Click(object sender, EventArgs e)
        {

            lbl.Text = "Bunifu " + ((Button)sender).Text;
            lbl.ForeColor = ((Button)sender).BackColor;
            // data Canvas

            Bunifu.DataViz.Canvas canvas = new Bunifu.DataViz.Canvas();
            Bunifu.DataViz.DataPoint datapoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_rangeBar);

            //add sample data to datapoint


            // Y: [Low, High]
        
            //x= date

            //Use "new Date" tag to format any date to chart compatible
            datapoint.addxy("new Date (2002,11,10)", new JArray(16.23, 17.99).ToString());
            datapoint.addxy("new Date (2002, 11, 9)", new JArray(15.95, 19.25).ToString());
            datapoint.addxy("new Date (2002, 11, 8)", new JArray(  11.30, 16.88).ToString());
            datapoint.addxy("new Date (2002, 11, 7)", new JArray( 13.29, 14.28).ToString());
            datapoint.addxy("new Date (2002, 11, 6)", new JArray(  15.23, 16.45).ToString());
            datapoint.addxy("new Date (2002, 11, 5)", new JArray(  13.70, 16.50).ToString());
            datapoint.addxy("new Date (2002, 11, 4)", new JArray( 17.50, 19.00).ToString());
            datapoint.addxy("new Date (2002, 11, 3)", new JArray(  19.50, 20.85).ToString());
            datapoint.addxy("new Date (2002, 11, 2)", new JArray(  20.07, 21.44).ToString());
            datapoint.addxy("new Date (2002, 11, 1)", new JArray(  25.00, 26.70).ToString());

            //add datapoint to cnavas
            canvas.addData(datapoint);  //rem you can add several datapointsof different chart Type to one canvas 

            //render canvas
            bunifuDataViz1.Render(canvas);
        }

        /// <summary>
        /// Handles the Click event of the render_range_column control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void render_range_column_Click(object sender, EventArgs e)
        {
            lbl.Text = "Bunifu " + ((Button)sender).Text;
            lbl.ForeColor = ((Button)sender).BackColor;
            // data Canvas

            Bunifu.DataViz.Canvas canvas = new Bunifu.DataViz.Canvas();
            Bunifu.DataViz.DataPoint datapoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_rangeColumn);

            //add sample data to datapoint


            // Y: [Low, High]

            //x= date

            //Use "new Date" tag to format any date to chart compatible
            datapoint.addxy("new Date (2002,11,10)", new JArray(16.23, 17.99).ToString());
            datapoint.addxy("new Date (2002, 11, 9)", new JArray(15.95, 19.25).ToString());
            datapoint.addxy("new Date (2002, 11, 8)", new JArray(11.30, 16.88).ToString());
            datapoint.addxy("new Date (2002, 11, 7)", new JArray(13.29, 14.28).ToString());
            datapoint.addxy("new Date (2002, 11, 6)", new JArray(15.23, 16.45).ToString());
            datapoint.addxy("new Date (2002, 11, 5)", new JArray(13.70, 16.50).ToString());
            datapoint.addxy("new Date (2002, 11, 4)", new JArray(17.50, 19.00).ToString());
            datapoint.addxy("new Date (2002, 11, 3)", new JArray(19.50, 20.85).ToString());
            datapoint.addxy("new Date (2002, 11, 2)", new JArray(20.07, 21.44).ToString());
            datapoint.addxy("new Date (2002, 11, 1)", new JArray(25.00, 26.70).ToString());

            //add datapoint to cnavas
            canvas.addData(datapoint);  //rem you can add several datapointsof different chart Type to one canvas 

            //render canvas
            bunifuDataViz1.Render(canvas);
        }




        /// <summary>
        /// Handles the Click event of the render_range_area control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void render_range_area_Click(object sender, EventArgs e)
        {

            lbl.Text = "Bunifu " + ((Button)sender).Text;
            lbl.ForeColor = ((Button)sender).BackColor;
            // data Canvas

            Bunifu.DataViz.Canvas canvas = new Bunifu.DataViz.Canvas();
            Bunifu.DataViz.DataPoint datapoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_rangeArea);

            //add sample data to datapoint


            // Y: [Low, High]

            //x= date

            //Use "new Date" tag to format any date to chart compatible
            datapoint.addxy("new Date (2002,11,10)", new JArray(16.23, 17.99).ToString());
            datapoint.addxy("new Date (2002, 11, 9)", new JArray(15.95, 19.25).ToString());
            datapoint.addxy("new Date (2002, 11, 8)", new JArray(11.30, 16.88).ToString());
            datapoint.addxy("new Date (2002, 11, 7)", new JArray(13.29, 14.28).ToString());
            datapoint.addxy("new Date (2002, 11, 6)", new JArray(15.23, 16.45).ToString());
            datapoint.addxy("new Date (2002, 11, 5)", new JArray(13.70, 16.50).ToString());
            datapoint.addxy("new Date (2002, 11, 4)", new JArray(17.50, 19.00).ToString());
            datapoint.addxy("new Date (2002, 11, 3)", new JArray(19.50, 20.85).ToString());
            datapoint.addxy("new Date (2002, 11, 2)", new JArray(20.07, 21.44).ToString());
            datapoint.addxy("new Date (2002, 11, 1)", new JArray(25.00, 26.70).ToString());

            //add datapoint to cnavas
            canvas.addData(datapoint);  //rem you can add several datapointsof different chart Type to one canvas 

            //render canvas
            bunifuDataViz1.Render(canvas);
        }

        /// <summary>
        /// Handles the Click event of the render_range_spline_area control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void render_range_spline_area_Click(object sender, EventArgs e)
        {

            lbl.Text = "Bunifu " + ((Button)sender).Text;
            lbl.ForeColor = ((Button)sender).BackColor;
            // data Canvas

            Bunifu.DataViz.Canvas canvas = new Bunifu.DataViz.Canvas();
            Bunifu.DataViz.DataPoint datapoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_rangeSplineArea);

            //add sample data to datapoint


            // Y: [Low, High]

            //x= date

            //Use "new Date" tag to format any date to chart compatible
            datapoint.addxy("new Date (2002,11,10)", new JArray(16.23, 17.99).ToString());
            datapoint.addxy("new Date (2002, 11, 9)", new JArray(15.95, 19.25).ToString());
            datapoint.addxy("new Date (2002, 11, 8)", new JArray(11.30, 16.88).ToString());
            datapoint.addxy("new Date (2002, 11, 7)", new JArray(13.29, 14.28).ToString());
            datapoint.addxy("new Date (2002, 11, 6)", new JArray(15.23, 16.45).ToString());
            datapoint.addxy("new Date (2002, 11, 5)", new JArray(13.70, 16.50).ToString());
            datapoint.addxy("new Date (2002, 11, 4)", new JArray(17.50, 19.00).ToString());
            datapoint.addxy("new Date (2002, 11, 3)", new JArray(19.50, 20.85).ToString());
            datapoint.addxy("new Date (2002, 11, 2)", new JArray(20.07, 21.44).ToString());
            datapoint.addxy("new Date (2002, 11, 1)", new JArray(25.00, 26.70).ToString());

            //add datapoint to cnavas
            canvas.addData(datapoint);  //rem you can add several datapointsof different chart Type to one canvas 

            //render canvas
            bunifuDataViz1.Render(canvas);
        }

        /// <summary>
        /// Handles the Click event of the render_scatter_chart control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void render_scatter_chart_Click(object sender, EventArgs e)
        {
            lbl.Text = "Bunifu " + ((Button)sender).Text;
            lbl.ForeColor = ((Button)sender).BackColor;
            // data Canvas

            Bunifu.DataViz.Canvas canvas = new Bunifu.DataViz.Canvas();
            Bunifu.DataViz.DataPoint datapoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_scatter);

            //add sample data to datapoint

            for (int i = 1; i <= 30; i++)
            {

                datapoint.addxyzname(r.Next(0, 100), r.Next(0, 100), r.Next(10, 100), "Bubble" + i); //x y z, name
            }
            //add datapoint to cnavas
            canvas.addData(datapoint);  //rem you can add several datapointsof different chart Type to one canvas 

            //render canvas
            bunifuDataViz1.Render(canvas);
        }


        /// <summary>
        /// Handles the Click event of the render_stacked_area control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void render_stacked_area_Click(object sender, EventArgs e)
        {

            lbl.Text = "Bunifu " + ((Button)sender).Text;
            lbl.ForeColor = ((Button)sender).BackColor;
            // data Canvas

            Bunifu.DataViz.Canvas canvas = new Bunifu.DataViz.Canvas();

            Bunifu.DataViz.DataPoint datapoint1 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_stackedArea);
            datapoint1.addxy("new Date (2002,11,10)", r.Next(1000,2000));
            datapoint1.addxy("new Date (2002, 11, 9)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 8)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 7)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 6)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 5)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 4)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 3)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 2)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 1)", r.Next(1000, 2000));

            //add datapoint to cnavas
            canvas.addData(datapoint1);  //rem you can add several datapointsof different chart Type to one canvas 

            Bunifu.DataViz.DataPoint datapoint2 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_stackedArea);
            datapoint2.addxy("new Date (2002,11,10)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 9)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 8)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 7)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 6)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 5)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 4)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 3)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 2)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 1)", r.Next(1000, 2000));

            //add datapoint to cnavas
            canvas.addData(datapoint2);  //rem you can add several datapointsof different chart Type to one canvas 

            //render canvas
            bunifuDataViz1.Render(canvas);
        }


        /// <summary>
        /// Handles the Click event of the render_stacked_area_i100 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void render_stacked_area_i100_Click(object sender, EventArgs e)
        {

            lbl.Text = "Bunifu " + ((Button)sender).Text;
            lbl.ForeColor = ((Button)sender).BackColor;
            // data Canvas

            Bunifu.DataViz.Canvas canvas = new Bunifu.DataViz.Canvas();

            Bunifu.DataViz.DataPoint datapoint1 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_stackedArea100);
         
            datapoint1.addLabely("Winter", r.Next(1000, 2000));
            datapoint1.addLabely("Monsoon", r.Next(1000, 2000));
            datapoint1.addLabely("Winter", r.Next(1000, 2000));
            datapoint1.addLabely("Automn", r.Next(1000, 2000));
            datapoint1.addLabely("Summer", r.Next(1000, 2000));
            datapoint1.addLabely("Spring", r.Next(1000, 2000));
            //add datapoint to cnavas
            canvas.addData(datapoint1);  //rem you can add several datapointsof different chart Type to one canvas 

            Bunifu.DataViz.DataPoint datapoint2 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_stackedArea100);
            datapoint2.addLabely("Winter", r.Next(1000, 2000));
            datapoint2.addLabely("Monsoon", r.Next(1000, 2000));
            datapoint2.addLabely("Winter", r.Next(1000, 2000));
            datapoint2.addLabely("Automn", r.Next(1000, 2000));
            datapoint2.addLabely("Summer", r.Next(1000, 2000));
            datapoint2.addLabely("Spring", r.Next(1000, 2000));

            //add datapoint to cnavas
            canvas.addData(datapoint2);  //rem you can add several datapointsof different chart Type to one canvas 

            //render canvas
            bunifuDataViz1.Render(canvas);
        }

        /// <summary>
        /// Handles the Click event of the render_stacked_bar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void render_stacked_bar_Click(object sender, EventArgs e)
        {

            lbl.Text = "Bunifu " + ((Button)sender).Text;
            lbl.ForeColor = ((Button)sender).BackColor;
            // data Canvas

            Bunifu.DataViz.Canvas canvas = new Bunifu.DataViz.Canvas();

            Bunifu.DataViz.DataPoint datapoint1 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_stackedBar);
            datapoint1.addxy("new Date (2002,11,10)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 9)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 8)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 7)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 6)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 5)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 4)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 3)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 2)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 1)", r.Next(1000, 2000));

            //add datapoint to cnavas
            canvas.addData(datapoint1);  //rem you can add several datapointsof different chart Type to one canvas 

            Bunifu.DataViz.DataPoint datapoint2 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_stackedBar);
            datapoint2.addxy("new Date (2002,11,10)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 9)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 8)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 7)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 6)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 5)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 4)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 3)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 2)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 1)", r.Next(1000, 2000));

            //add datapoint to cnavas
            canvas.addData(datapoint2);  //rem you can add several datapointsof different chart Type to one canvas 

            //render canvas
            bunifuDataViz1.Render(canvas);
        }

        private void render_stacked_bar_100_Click(object sender, EventArgs e)
        {

            lbl.Text = "Bunifu " + ((Button)sender).Text;
            lbl.ForeColor = ((Button)sender).BackColor;
            // data Canvas

            Bunifu.DataViz.Canvas canvas = new Bunifu.DataViz.Canvas();

            Bunifu.DataViz.DataPoint datapoint1 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_stackedBar100);

            datapoint1.addLabely("Winter", r.Next(1000, 2000));
            datapoint1.addLabely("Monsoon", r.Next(1000, 2000));
            datapoint1.addLabely("Winter", r.Next(1000, 2000));
            datapoint1.addLabely("Automn", r.Next(1000, 2000));
            datapoint1.addLabely("Summer", r.Next(1000, 2000));
            datapoint1.addLabely("Spring", r.Next(1000, 2000));
            //add datapoint to cnavas
            canvas.addData(datapoint1);  //rem you can add several datapointsof different chart Type to one canvas 

            Bunifu.DataViz.DataPoint datapoint2 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_stackedBar100);
            datapoint2.addLabely("Winter", r.Next(1000, 2000));
            datapoint2.addLabely("Monsoon", r.Next(1000, 2000));
            datapoint2.addLabely("Winter", r.Next(1000, 2000));
            datapoint2.addLabely("Automn", r.Next(1000, 2000));
            datapoint2.addLabely("Summer", r.Next(1000, 2000));
            datapoint2.addLabely("Spring", r.Next(1000, 2000));

            //add datapoint to cnavas
            canvas.addData(datapoint2);  //rem you can add several datapointsof different chart Type to one canvas 

            //render canvas
            bunifuDataViz1.Render(canvas);
        }

        private void render_stacked_column_100_Click(object sender, EventArgs e)
        {

            lbl.Text = "Bunifu " + ((Button)sender).Text;
            lbl.ForeColor = ((Button)sender).BackColor;
            // data Canvas

            Bunifu.DataViz.Canvas canvas = new Bunifu.DataViz.Canvas();

            Bunifu.DataViz.DataPoint datapoint1 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_stackedColumn100);
            datapoint1.addxy("new Date (2002,11,10)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 9)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 8)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 7)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 6)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 5)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 4)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 3)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 2)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 1)", r.Next(1000, 2000));

            //add datapoint to cnavas
            canvas.addData(datapoint1);  //rem you can add several datapointsof different chart Type to one canvas 

            Bunifu.DataViz.DataPoint datapoint2 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_stackedColumn100);
            datapoint2.addxy("new Date (2002,11,10)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 9)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 8)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 7)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 6)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 5)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 4)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 3)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 2)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 1)", r.Next(1000, 2000));

            //add datapoint to cnavas
            canvas.addData(datapoint2);  //rem you can add several datapointsof different chart Type to one canvas 

            //render canvas
            bunifuDataViz1.Render(canvas);
        }

        private void render_stacked_column_Click(object sender, EventArgs e)
        {


            lbl.Text = "Bunifu " + ((Button)sender).Text;
            lbl.ForeColor = ((Button)sender).BackColor;
            // data Canvas

            Bunifu.DataViz.Canvas canvas = new Bunifu.DataViz.Canvas();

            Bunifu.DataViz.DataPoint datapoint1 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_stackedColumn);
            datapoint1.addxy("new Date (2002,11,10)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 9)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 8)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 7)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 6)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 5)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 4)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 3)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 2)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 1)", r.Next(1000, 2000));

            //add datapoint to cnavas
            canvas.addData(datapoint1);  //rem you can add several datapointsof different chart Type to one canvas 

            Bunifu.DataViz.DataPoint datapoint2 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_stackedColumn);
            datapoint2.addxy("new Date (2002,11,10)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 9)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 8)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 7)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 6)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 5)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 4)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 3)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 2)", r.Next(1000, 2000));
            datapoint2.addxy("new Date (2002, 11, 1)", r.Next(1000, 2000));

            //add datapoint to cnavas
            canvas.addData(datapoint2);  //rem you can add several datapointsof different chart Type to one canvas 

            //render canvas
            bunifuDataViz1.Render(canvas);
        }

        /// <summary>
        /// Renders the stepline click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void render_stepline_Click(object sender, EventArgs e)
        {


            lbl.Text = "Bunifu " + ((Button)sender).Text;
            lbl.ForeColor = ((Button)sender).BackColor;
            // data Canvas

            Bunifu.DataViz.Canvas canvas = new Bunifu.DataViz.Canvas();

            Bunifu.DataViz.DataPoint datapoint1 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_stepLine);
            datapoint1.addxy("new Date (2002,11,10)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 9)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 8)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 7)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 6)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 5)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 4)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 3)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 2)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 1)", r.Next(1000, 2000));

            //add datapoint to cnavas
            canvas.addData(datapoint1);  //rem you can add several datapointsof different chart Type to one canvas 
             
            //render canvas
            bunifuDataViz1.Render(canvas);
        }

        /// <summary>
        /// Button1s the click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {


            lbl.Text = "Bunifu " + ((Button)sender).Text;
            lbl.ForeColor = ((Button)sender).BackColor;
            // data Canvas

            Bunifu.DataViz.Canvas canvas = new Bunifu.DataViz.Canvas();

            Bunifu.DataViz.DataPoint datapoint1 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_stepArea);
            datapoint1.addxy("new Date (2002,11,10)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 9)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 8)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 7)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 6)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 5)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 4)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 3)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 2)", r.Next(1000, 2000));
            datapoint1.addxy("new Date (2002, 11, 1)", r.Next(1000, 2000));

            //add datapoint to cnavas
            canvas.addData(datapoint1);  //rem you can add several datapointsof different chart Type to one canvas 

            //render canvas
            bunifuDataViz1.Render(canvas);
        }
    }
}
