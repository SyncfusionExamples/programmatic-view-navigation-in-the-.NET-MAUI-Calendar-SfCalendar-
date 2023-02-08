using Microsoft.Maui.Controls;
using Syncfusion.Maui.Calendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammaticViewNavigation
{
    public class CalendarBehavior: Behavior<ContentPage>
    {
        private SfCalendar calendar;
        private Button monthViewButton, yearViewButton, decadeViewButton, centuryViewButton;

        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            this.calendar = bindable.FindByName<SfCalendar>("calendar");
            this.monthViewButton = bindable.FindByName<Button>("monthViewButton");
            this.monthViewButton.Clicked += MonthViewButton_Clicked;
            this.yearViewButton = bindable.FindByName<Button>("yearViewButton");
            this.yearViewButton.Clicked += YearViewButton_Clicked;
            this.decadeViewButton = bindable.FindByName<Button>("decadeViewButton");
            this.decadeViewButton.Clicked += DecadeViewButton_Clicked;
            this.centuryViewButton = bindable.FindByName<Button>("centuryViewButton");
            this.centuryViewButton.Clicked += CenturyViewButton_Clicked;
        }

        private void MonthViewButton_Clicked(object sender, EventArgs e)
        {
            this.calendar.View = CalendarView.Month;
        }

        private void YearViewButton_Clicked(object sender, EventArgs e)
        {
            this.calendar.View = CalendarView.Year;
        }

        private void DecadeViewButton_Clicked(object sender, EventArgs e)
        {
            this.calendar.View = CalendarView.Decade;
        }

        private void CenturyViewButton_Clicked(object sender, EventArgs e)
        {
            this.calendar.View = CalendarView.Century;
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            if (this.monthViewButton != null)
            {
                this.monthViewButton.Clicked -= MonthViewButton_Clicked;
            }

            if (this.yearViewButton != null)
            {
                this.yearViewButton.Clicked -= YearViewButton_Clicked;
            }

            if (this.decadeViewButton != null)
            {
                this.decadeViewButton.Clicked -= DecadeViewButton_Clicked;
            }

            if (this.centuryViewButton != null)
            {
                this.centuryViewButton.Clicked -= CenturyViewButton_Clicked;
            }

            this.monthViewButton = null;
            this.yearViewButton = null;
            this.decadeViewButton = null;
            this.centuryViewButton = null;
        }
    }
}
