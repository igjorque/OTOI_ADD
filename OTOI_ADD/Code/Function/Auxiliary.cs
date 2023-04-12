using OTOI_ADD.View.Asset.Control;

namespace OTOI_ADD.Code.Function
{
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
            string err = "";
            if (DateTime.Compare(ca_date_start.Value, DateTime.Parse("1/1/2018")) < 0)
            {
                err += "La fecha debe ser posterior a [01/01/2018]. ";
            }
            if (DateTime.Compare(ca_date_start.Value, DateTime.Today) >= 0)
            {
                err += "La fecha debe ser previa a [" + DateTime.Today.ToShortDateString() + "]. ";
            }
            ep_error.SetError(ca_date_start, err);
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
            string err = "";
            if (DateTime.Compare(end.Value, DateTime.Parse("1/1/2018")) < 0)
            {
                err += "La fecha debe ser posterior a [01/01/2018]. ";
            }
            if (DateTime.Compare(end.Value, DateTime.Today) >= 0)
            {
                err += "La fecha debe ser previa a [" + DateTime.Today.ToShortDateString() + "]. ";
            }
            if (DateTime.Compare(start.Value, end.Value) > 0)
            {
                err += "La fecha inicial no puede ser posterior a la fecha final.";
            }
            ep_error.SetError(start, err);
            ep_error.SetError(end, err);
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
            string errStr = "";
            string errEnd = "";
            // VALIDATION - START
            if (DateTime.Compare(start.Value, DateTime.Parse("1/1/2018")) < 0)
            {
                errStr += "La fecha inicial debe ser posterior a [01/01/2018]. ";
            }
            if (DateTime.Compare(start.Value, DateTime.Today) >= 0)
            {
                errStr += "La fecha inicial debe ser previa a [" + DateTime.Today.ToShortDateString() + "]. ";
            }
            // VALIDATION - END
            if (DateTime.Compare(end.Value, DateTime.Parse("1/1/2018")) < 0)
            {
                errEnd += "La fecha final debe ser posterior a [01/01/2018]. ";
            }
            if (DateTime.Compare(end.Value, DateTime.Today) >= 0)
            {
                errEnd += "La fecha final debe ser previa a [" + DateTime.Today.ToShortDateString() + "]. ";
            }
            // VALIDATION - RANGE
            if (DateTime.Compare(start.Value, end.Value) > 0)
            {
                errStr += "La fecha inicial no puede ser posterior a la fecha final.";
                errEnd += "La fecha final no puede ser anterior a la fecha inicial.";
            }
            ep_error.SetError(start, errStr);
            ep_error.SetError(end, errEnd);
        }

        /// <summary>
        /// Checks if an entered end date is valid. 
        /// Current criteria: Valid if earlier than [Today]'s month and later than [01/01/2018].
        /// </summary>
        /// <param name="mp">Month date MonthPicker control</param>
        /// <param name="ep_error">Error indicator</param>
        internal static void ValidateMonth(MonthPicker mp, ErrorProvider ep_error)
        {
            string err = "";
            if (DateTime.Compare(mp.Value, DateTime.Parse("1/1/2018")) < 0)
            {
                err += "La fecha debe ser posterior a [01/01/2018]. ";
            }
            if (mp.Value.Year == DateTime.Today.Year && mp.Value.Month == DateTime.Today.Month)
            {
                err += "El mes seleccionado debe ser previo al actual. ";
            }
            ep_error.SetError(mp, err);
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

        // ---------------------------------------------------------------------------------
        // -------------------------------- Old Functions ----------------------------------
        // ---------------------------------------------------------------------------------

        /// <summary>
        /// Converts the string representing a month to an equivalent integer.
        /// </summary>
        /// <param name="m">Month as string to be converted.</param>
        /// <returns>Month as integer.</returns>
        internal static int MonthToInt(string m)
        {
            Dictionary<string, int> month = new()
            {
                { "enero", 1 },
                { "febrero", 2 },
                { "marzo", 3 },
                { "abril", 4 },
                { "mayo", 5 },
                { "junio", 6 },
                { "julio", 7 },
                { "agosto", 8 },
                { "septiembre", 9 },
                { "octubre", 10 },
                { "noviembre", 11 },
                { "diciembre", 12 }
            };

            return month[m.ToLower()];
        }

        /// <summary>
        /// Converts the integer representing a month to an equivalent string.
        /// </summary>
        /// <param name="m">Month as integer to be converted.</param>
        /// <returns>Month as string.</returns>
        internal static int IntToMonth(int m)
        {
            Dictionary<string, int> month = new()
            {
                { "enero", 1 },
                { "febrero", 2 },
                { "marzo", 3 },
                { "abril", 4 },
                { "mayo", 5 },
                { "junio", 6 },
                { "julio", 7 },
                { "agosto", 8 },
                { "septiembre", 9 },
                { "octubre", 10 },
                { "noviembre", 11 },
                { "diciembre", 12 }
            };

            return month.ElementAt(m).Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <returns></returns>
        internal static DateTime DateStart(DateTime start)
        {
            if (DateTime.Compare(start, DateTime.Today) > 0)
            {
                start = DateTime.Today.AddDays(-1);
            }
            if (DateTime.Compare(start, new DateTime(2018, 1, 1)) < 0)
            {
                start = new DateTime(2018, 1, 1);
            }
            return start;
        }

        /// <summary>
        /// If the entered date is after [Today], returns the day before [Today].
        /// </summary>
        /// <param name="end">Entered date to compare.</param>
        /// <returns>[end] or [Today] - 1.</returns>
        internal static DateTime DateEnd(DateTime end)
        {
            if (DateTime.Compare(end, DateTime.Today) > 0)
            {
                end = DateTime.Today.AddDays(-1);
            }
            if (DateTime.Compare(end, new DateTime(2018, 1, 1)) < 0)
            {
                end = new DateTime(2018, 1, 1);
            }
            return end;
        }

        internal static Dictionary<string, object> InitFields(int FID, DateTime start, DateTime end, string file, string download, bool keep, bool process)
        {
            Dictionary<string, object> fields = new()
            {
                { "FID", FID },
                { "start", start },
                { "end", end },
                { "file", file },
                { "download", download },
                { "keep", keep },
                { "process", process }
            };
            return fields;
        }

        internal static Dictionary<string, object> InitFields(int FID, DateTime start, DateTime end, string download, bool keep, bool unzip)
        {
            Dictionary<string, object> fields = new()
            {
                { "FID", FID },
                { "start", start },
                { "end", end },
                { "download", download },
                { "keep", keep },
                { "unzip", unzip }
            };
            return fields;
        }
    }
}