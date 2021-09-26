using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace flight_booking_website
{
    public partial class _default : System.Web.UI.Page
    {
        //GOBAL VALUES-------------------------------------
        double[,] total_price;
        double airline_and_seating_cost;
        double[,] extra_tax;
        double tax_amount;
        double final_price;


        protected void Page_Load(object sender, EventArgs e)
        {
            //AIRLINE + SEATING CLASS (ARRAY DEFINING)-------
            total_price = new double[4, 3];
            total_price[0, 0] = 200.75;
            total_price[0, 1] = 250.50;
            total_price[0, 2] = 300.10;
            total_price[1, 0] = 250.99;
            total_price[1, 1] = 270.75;
            total_price[2, 0] = 70.99;
            total_price[3, 0] = 50.99;
           
            //EXTRA TAX AMOUNT (ARRAY DEFINEING)(SEATING CLASS + AIRLINE)-----------
            extra_tax = new double[4, 3];
            extra_tax[0, 0] = 9.50;
            extra_tax[0, 1] = 19.99;
            extra_tax[0, 2] = 39.99;
            extra_tax[1, 0] = 14.99;
            extra_tax[1, 1] = 24.50;
            extra_tax[2, 0] = 9.50;
            extra_tax[3, 0] = 9.50;

            //CALENDER DATE (DEPARTURE & ARRIVAL) ------------------
            if (!Page.IsPostBack)
            {
                cal_dep.SelectedDate = DateTime.Now.Date;
                cal_ari.SelectedDate = DateTime.Now.Date.AddDays(1);
            }

            //WEBSITE DATE & TIME--------------------------------
            label_time.Text = DateTime.Now.ToLongTimeString();
            label_date.Text = DateTime.Now.ToLongDateString();
        }

        protected void button_name_Click(object sender, EventArgs e)
        {
            //CUSTOMER NAME-----------------------------------------------------------
           string first_name = (textbox_f_name.Text);
           string last_name = (textbox_l_name.Text);
           label_thank_you_name.Text = "Thank you " + first_name + " " + last_name;
            label_f_name.Text = first_name;
            label_l_name.Text = last_name;
           
        }

        protected void button_airline_Click(object sender, EventArgs e)
        {
            //CUSTOMER AIRLINE-----------------------------------------------------------------------------------
            string airline = "";
            airline = (rb_BCF.Checked) ? airline = "British Airways (City Flyer)" : airline;
            airline = (rb_ezy.Checked) ? airline = "Easy Jet" : airline;
            airline = (rb_tui.Checked) ? airline = "TUI" : airline;
            airline = (rb_ba.Checked) ? airline = "British Airways" : airline;
            label_thankyou_airline.Text = String.Format("thank you for selecting {0}", airline);
            label_airline.Text = airline;

        }

        protected void button_seating_Click(object sender, EventArgs e)
        {
            //CUSTOMER AIRLINE CHOICE WITH COST + SEATING CLASS WITH COST


            //SEAT CLASS----------------------------------------------------------------
            string seating = "";
            seating = (rb_class_eco.Checked) ? seating = "Economy" : seating;
            seating = (rb_class_business.Checked) ? seating = "Bussiness" : seating;
            seating = (rb_class_first.Checked) ? seating = "First" : seating;
            label_seating.Text = seating;
            label_seating_class.Text = "You have selected " + seating;

            //AIRLINE PRICE----------------------------------------------------------
            int airline_cost;
            if (rb_ba.Checked) airline_cost = 0;
            else if (rb_BCF.Checked) airline_cost = 1;
            else if (rb_ezy.Checked) airline_cost = 2;
            else airline_cost = 3;
            
            //SEATING PRICE------------------------------------------------------
            int seating_cost;
            if (rb_class_eco.Checked) seating_cost = 0;
            else if (rb_class_business.Checked) seating_cost = 1;
            else seating_cost = 2;

            //AIRLINE + SEATING COST--------------------------------------------------
            airline_and_seating_cost = total_price[airline_cost, seating_cost];
            ticket_cost.Text = String.Format("{0}", airline_and_seating_cost);
            ticket_cost_c_sign.Text = "£";
        }

        protected void button_confirm_Click(object sender, EventArgs e)
        {
            // CALANDER STATEMENTS--------------------------------------------------------------------------------------
            TimeSpan total_time_ammount = cal_ari.SelectedDate.Subtract(cal_dep.SelectedDate);

            label_flight_dates.Text = String.Format("Have selected " + total_time_ammount.TotalDays + " days");
            if (total_time_ammount.TotalDays < 1 )
            {
                label_flight_dates.Text = "Error, Please select more than one day";
            }
           else if (total_time_ammount.TotalDays > 100)
           {
                label_flight_dates.Text = "Error, no more than 100 days from depature to return is required";
           }
           
            

            //FLIGHT DATES------------------------------------------------------------------------
            label_flight_O_date.Text = cal_dep.SelectedDate.ToLongDateString();
            label_flight_R_date.Text = cal_ari.SelectedDate.ToLongDateString();


            //AIRLINE TAX------------------------------------------------------------------------------------------------------
            int airline_tax;
            if (rb_ba.Checked) airline_tax = 0;
            else if (rb_BCF.Checked) airline_tax = 1;
            else if (rb_ezy.Checked) airline_tax = 2;
            else airline_tax = 3;
           
            //SEAT TAX------------------------------------------------
            int seat_tax;
            if (rb_class_eco.Checked) seat_tax = 0;
            else if (rb_class_business.Checked) seat_tax = 1;
            else seat_tax = 2;
            tax_amount = extra_tax[airline_tax, seat_tax];


            //TOTAL COST (LABEL)------------------------------------------------------------------------------
            final_price = tax_amount + double.Parse(ticket_cost.Text);
            final_price = (total_time_ammount.TotalDays > 25) ? final_price + 30.99 : final_price;
            label_final_cost.Text = String.Format("{0:C}", final_price);


        }
    }
}