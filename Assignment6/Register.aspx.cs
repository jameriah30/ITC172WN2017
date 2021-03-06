﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CAServiceReference.CAServiceClient cas = new CAServiceReference.CAServiceClient();
        CAServiceReference.PersonLite pl = new CAServiceReference.PersonLite();
        pl.LastName = LastNameTextBox.Text;
        pl.FirstName = FirstnameTextBox.Text;
        pl.Email = EmailTextBox.Text;
        pl.Apartment = ApartmentTextBox.Text;
        pl.Street = StreetTextBox.Text;
        pl.City = CityTextBox.Text;
        pl.State = StateTextBox.Text;
        pl.Zipcode = ZipCodeTextBox1.Text;
        pl.HomePhone = HomePhoneTextBox.Text;
        pl.WorkPhone = WorkPhoneTextBox.Text;
        pl.Password = PasswordTextBox.Text;
        bool result = cas.RegisterPerson(pl);
        if(result)
        {
            ResultLabel.Text = "You are Registered";
        }
        else
        {
            ResultLabel.Text = " Something went Wrong";
        }

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {

    }
}