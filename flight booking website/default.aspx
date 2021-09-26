<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="flight_booking_website._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>FlightsToMalaga.com </h1>
        <p>
            The home of flights to Malaga</p>
        <p>
            &nbsp;<strong>
            <asp:Label ID="label_date" runat="server"></asp:Label>
&nbsp;
        </strong></p>
        <p>
            <strong>&nbsp;<asp:Label ID="label_time" runat="server"></asp:Label>
        </strong></p>
        <p>
            &nbsp;</p>
        <p>
            <strong>Please enter you name </strong>
        </p>
        <p>
            First Name -
            <asp:TextBox ID="textbox_f_name" runat="server"></asp:TextBox>
        </p>
        <p>
            Last Name -
            <asp:TextBox ID="textbox_l_name" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="button_name" runat="server" Text="Confirm" OnClick="button_name_Click" />
        </p>
        <p>
            <asp:Label ID="label_thank_you_name" runat="server"></asp:Label>
        </p>
        <p>
            <strong></strong></p>
        <p class="auto-style2">
            <strong>Please select your choice of airline
        </strong>
        </p>
        <p>
            <asp:RadioButton ID="rb_ba" runat="server" GroupName="airlines" Text="British Airways" />
        </p>
        <p>
            <asp:RadioButton ID="rb_BCF" runat="server" GroupName="airlines" Text="British Airways (City Flyer)" />
        </p>
        <p>
            <asp:RadioButton ID="rb_ezy" runat="server" Text="EazyJet" GroupName="airlines" />
        </p>
        <p>
            <asp:RadioButton ID="rb_tui" runat="server" GroupName="airlines" Text="TUI" />
        </p>
        <p>
            <asp:Button ID="button_airline" runat="server" Text="Confirm" OnClick="button_airline_Click" />
        </p>
        <p>
            <asp:Label ID="label_thankyou_airline" runat="server"></asp:Label>
        </p>
        <h4>
            &nbsp;</h4>
        <h4>
            What seating class would you like?</h4>
        <p>
            <asp:RadioButton ID="rb_class_eco" runat="server" Text="Economy" GroupName="seating" />
        &nbsp;<asp:RadioButton ID="rb_class_business" runat="server" Text="Bussiness" GroupName="seating" />
        &nbsp;<asp:RadioButton ID="rb_class_first" runat="server" Text="First" GroupName="seating" />
        </p>
        <p>
            <asp:Button ID="button_seating" runat="server" Text="Confirm" OnClick="button_seating_Click" />
        </p>
        <p>
            <asp:Label ID="label_seating_class" runat="server"></asp:Label>
        </p>
        <h2>
            &nbsp;</h2>
        <h2>
            Departure Date</h2>
        <p>
            &nbsp;</p>
        <p>
            <asp:Calendar ID="cal_dep" runat="server"></asp:Calendar>
        </p>
        <p>
            &nbsp;</p>
        <h2>
            Arrival date</h2>
        <asp:Calendar ID="cal_ari" runat="server"></asp:Calendar>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="button_confirm" runat="server" OnClick="button_confirm_Click" Text="confirm dates " Width="354px" />
        </p>
        <p>
            <asp:Label ID="label_flight_dates" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <h3>
            Total
            Summary</h3>
        <p>
            First Name -
            <asp:Label ID="label_f_name" runat="server"></asp:Label>
        </p>
        <p>
            Last Name -
            <asp:Label ID="label_l_name" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Airline -
            <asp:Label ID="label_airline" runat="server"></asp:Label>
&nbsp;</p>
        <p>
            Seating class -
            <asp:Label ID="label_seating" runat="server"></asp:Label>
&nbsp;</p>
        <p>
            Ticket Cost =
            <asp:Label ID="ticket_cost_c_sign" runat="server"></asp:Label>
            <asp:Label ID="ticket_cost" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Flight out date&nbsp; - <asp:Label ID="label_flight_O_date" runat="server"></asp:Label>
        </p>
        <p>
            Flight return date&nbsp; - <asp:Label ID="label_flight_R_date" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            TOTAL COST (VAT inc) -
            <asp:Label ID="label_final_cost" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
