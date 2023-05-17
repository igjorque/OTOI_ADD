using OTOI_ADD.View.Asset.Control;
using System.Text;

namespace OTOI_ADD.Code.Module.Function
{
    /// <summary>
    /// Auxiliary class
    /// </summary>
    internal static class Auxiliary
    {
        /// <summary>
        /// Formats a month given as a string with 2 characters.
        /// </summary>
        /// <param name="month">Month as integer to format.</param>
        /// <returns>Formatted month as a string.</returns>
        internal static string FormatMonth(int month)
        {
            string mth;
            if (month < 10)
            {
                mth = "0" + month;
            }
            else
            {
                mth = month.ToString();
            }
            return mth;
        }

        /// <summary>
        /// Formats a day given as a string with 2 characters.
        /// </summary>
        /// <param name="day">Day as integer to format.</param>
        /// <returns>Formatted day as a string.</returns>
        internal static string FormatDay(int day)
        {
            string dy;
            if (day < 10)
            {
                dy = "0" + day;
            }
            else
            {
                dy = day.ToString();
            }
            return dy;
        }

        /// <summary>
        /// Checks if an entered start date is valid.
        /// Current criteria: Valid if earlier than [Today] and later than [01/01/2018].
        /// </summary>
        /// <param name="ca_date_start">Start date DateTimePicker control</param>
        /// <param name="ep_error">Error indicator</param>
        internal static void ValidateStart(DateTimePicker ca_date_start, ErrorProvider ep_error)
        {
            // TODO: hardcoded text
            StringBuilder errBuilder = new StringBuilder();
            if (DateTime.Compare(ca_date_start.Value, DateTime.Parse("1/1/2018")) < 0)
            {
                errBuilder.Append("La fecha debe ser posterior a [01/01/2018]. ");
            }
            if (DateTime.Compare(ca_date_start.Value, DateTime.Today) >= 0)
            {
                errBuilder.Append($"La fecha debe ser previa a [{DateTime.Today.ToShortDateString()}]. ");
            }
            ep_error.SetError(ca_date_start, errBuilder.ToString());
        }

        /// <summary>
        /// Checks if an entered end date is valid. 
        /// Current criteria: Valid if earlier than [Today], later than [01/01/2018] and [start] isn't later than [end].
        /// </summary>
        /// <param name="start">Start date DateTimePicker control</param>
        /// <param name="end">End date DateTimePicker control</param>
        /// <param name="ep_error">Error indicator</param>
        internal static void ValidateEnd(DateTimePicker start, DateTimePicker end, ErrorProvider ep_error)
        {
            // TODO: hardcoded text
            StringBuilder errBuilder = new StringBuilder();
            if (DateTime.Compare(end.Value, DateTime.Parse("1/1/2018")) < 0)
            {
                errBuilder.Append("La fecha debe ser posterior a [01/01/2018]. ");
            }
            if (DateTime.Compare(end.Value, DateTime.Today) >= 0)
            {
                errBuilder.Append($"La fecha debe ser previa a [{DateTime.Today.ToShortDateString()}]. ");
            }
            if (DateTime.Compare(start.Value, end.Value) > 0)
            {
                errBuilder.Append("La fecha inicial no puede ser posterior a la fecha final.");
            }
            ep_error.SetError(start, errBuilder.ToString());
            ep_error.SetError(end, errBuilder.ToString());
        }

        /// <summary>
        /// Checks if an entered date range is valid. 
        /// Current criteria: 
        /// START - Valid if earlier than [Today] and later than [01/01/2018].
        /// END - Valid if earlier than [Today] and later than [01/01/2018].
        /// RANGE - Valid if [start] isn't later than [end].
        /// </summary>
        /// <param name="start">Start date DateTimePicker control</param>
        /// <param name="end">End date DateTimePicker control</param>
        /// <param name="ep_error">Error indicator</param>
        internal static void ValidateRange(DateTimePicker start, DateTimePicker end, ErrorProvider ep_error)
        {
            // TODO: hardcoded text
            StringBuilder errStrBuilder = new StringBuilder();
            StringBuilder errEndBuilder = new StringBuilder();
            // VALIDATION - START
            if (DateTime.Compare(start.Value, DateTime.Parse("1/1/2018")) < 0)
            {
                errStrBuilder.Append("La fecha inicial debe ser posterior a [01/01/2018]. ");
            }
            if (DateTime.Compare(start.Value, DateTime.Today) >= 0)
            {
                errStrBuilder.Append($"La fecha inicial debe ser previa a [{DateTime.Today.ToShortDateString()}]. ");
            }
            // VALIDATION - END
            if (DateTime.Compare(end.Value, DateTime.Parse("1/1/2018")) < 0)
            {
                errEndBuilder.Append("La fecha final debe ser posterior a [01/01/2018]. ");
            }
            if (DateTime.Compare(end.Value, DateTime.Today) >= 0)
            {
                errEndBuilder.Append($"La fecha final debe ser previa a [{DateTime.Today.ToShortDateString()}]. ");
            }
            // VALIDATION - RANGE
            if (DateTime.Compare(start.Value, end.Value) > 0)
            {
                errStrBuilder.Append("La fecha inicial no puede ser posterior a la fecha final.");
                errEndBuilder.Append("La fecha final no puede ser anterior a la fecha inicial.");
            }
            ep_error.SetError(start, errStrBuilder.ToString());
            ep_error.SetError(end, errEndBuilder.ToString());
        }

        /// <summary>
        /// Checks if an entered end date is valid. 
        /// Current criteria: Valid if earlier than [Today]'s month and later than [01/01/2018].
        /// </summary>
        /// <param name="mp">Month date MonthPicker control</param>
        /// <param name="ep_error">Error indicator</param>
        internal static void ValidateMonth(MonthPicker mp, ErrorProvider ep_error)
        {
            // TODO: hardcoded text
            StringBuilder errBuilder = new StringBuilder();
            if (DateTime.Compare(mp.Value, DateTime.Parse("1/1/2018")) < 0)
            {
                errBuilder.Append("La fecha debe ser posterior a [01/01/2018]. ");
            }
            if (mp.Value.Year >= DateTime.Today.Year && mp.Value.Month >= DateTime.Today.Month)
            {
                errBuilder.Append("El mes seleccionado debe ser previo al actual. ");
            }
            ep_error.SetError(mp, errBuilder.ToString());
        }

        /// <summary>
        /// Gets the number of days between two dates.
        /// </summary>
        /// <param name="str">Starting date</param>
        /// <param name="end">Ending date</param>
        /// <returns>Number of days in between</returns>
        internal static int DaysDiff(DateTime str, DateTime end)
        {
            int diff = 0;
            DateTime aux = str;
            while (DateTime.Compare(aux, end) < 0)
            {
                aux = aux.AddDays(1);
                diff++;
            }
            return diff;
        }

        // TODO: comment
        internal static DateTime MonthStart(DateTime month)
        {
            return new DateTime(month.Year, month.Month, 1);
        }
        internal static DateTime MonthEnd(DateTime month)
        {
            return new DateTime(month.Year, month.Month, DateTime.DaysInMonth(month.Year, month.Month));
        }
    }
}