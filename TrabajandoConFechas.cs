 public static class Utils
    {
          
  #region Trabajando con Fechas
        public static string GetFechaActual()
        {
            return DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0').ToString() + DateTime.Now.Day.ToString().PadLeft(2, '0').ToString();
        }
        public static string GetFechaActual(Enumeracion.FormatoFecha _Format)
        {
            switch (_Format)
            {
                case Enumeracion.FormatoFecha.YYYYMMDD:
                    {
                        return DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0').ToString() + DateTime.Now.Day.ToString().PadLeft(2, '0').ToString();
                    }
                case Enumeracion.FormatoFecha.DDMMYYYY:
                    {
                        return DateTime.Now.Day.ToString().PadLeft(2, '0').ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0').ToString() +  DateTime.Now.Year.ToString();
                    }
               default:
                    {
                        return DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0').ToString() + DateTime.Now.Day.ToString().PadLeft(2, '0').ToString();
                    }
            }
            
        }
        public static string GetFechaActual(Enumeracion.FormatoFecha _Format, Enumeracion.SeparadorFecha _Separador)
        {
            string _split="";
            switch(_Separador)
            {
                case Enumeracion.SeparadorFecha.Ninguno:
                    {
                        _split="";
                        break;
                    }
                case Enumeracion.SeparadorFecha.Guion:
                    {
                        _split = "-";
                        break;
                    }
                case Enumeracion.SeparadorFecha.Slash:
                    {
                        _split = "/";
                        break;
                    }
                case Enumeracion.SeparadorFecha.UnderScore:
                    {
                        _split = "_";
                        break;
                    }
                default:
                    {
                        _split="";
                        break;
                    }
                }
            switch (_Format)
            {
                case Enumeracion.FormatoFecha.YYYYMMDD:
                    {
                        return DateTime.Now.Year.ToString() + _split + DateTime.Now.Month.ToString().PadLeft(2, '0').ToString() + _split + DateTime.Now.Day.ToString().PadLeft(2, '0').ToString();
                    }
                case Enumeracion.FormatoFecha.DDMMYYYY:
                    {
                        return DateTime.Now.Day.ToString().PadLeft(2, '0').ToString() + _split + DateTime.Now.Month.ToString().PadLeft(2, '0').ToString() + _split + DateTime.Now.Year.ToString();
                    }
                default:
                    {
                        return DateTime.Now.Year.ToString() + _split + DateTime.Now.Month.ToString().PadLeft(2, '0').ToString() + _split + DateTime.Now.Day.ToString().PadLeft(2, '0').ToString();
                    }
            }

        }
        public static string GetFechaHoraActual()
        {
            return DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0').ToString() + DateTime.Now.Day.ToString().PadLeft(2, '0').ToString() + " " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
        }
        public static string GetFullDateToString()
        {
            _ReturnStringBuilder = new StringBuilder();
            #region Dias de la Semana
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    {
                        _ReturnStringBuilder.Append("Domingo, ");
                        break;
                    }
                case DayOfWeek.Monday:
                    {
                        _ReturnStringBuilder.Append("Lunes, ");
                        break;
                    }
                case DayOfWeek.Tuesday:
                    {
                        _ReturnStringBuilder.Append("Martes, ");
                        break;
                    }
                case DayOfWeek.Wednesday:
                    {
                        _ReturnStringBuilder.Append("Miércoles, ");
                        break;
                    }
                case DayOfWeek.Thursday:
                    {
                        _ReturnStringBuilder.Append("Jueves, ");
                        break;
                    }
                case DayOfWeek.Friday:
                    {
                        _ReturnStringBuilder.Append("Viernes, ");
                        break;
                    }
                case DayOfWeek.Saturday:
                    {
                        _ReturnStringBuilder.Append("Sábado, ");
                        break;
                    }
                default: { _ReturnStringBuilder.Append(""); break; }
            }
            #endregion
            _ReturnStringBuilder.Append(DateTime.Now.Day.ToString() + " de ");
            #region Mes
            switch (DateTime.Now.Month)
            {
                case 1:
                    {
                        _ReturnStringBuilder.Append("Enero ");
                        break;
                    }
                case 2:
                    {
                        _ReturnStringBuilder.Append("Febrero ");
                        break;
                    }
                case 3:
                    {
                        _ReturnStringBuilder.Append("Marzo ");
                        break;
                    }
                case 4:
                    {
                        _ReturnStringBuilder.Append("Abril ");
                        break;
                    }
                case 5:
                    {
                        _ReturnStringBuilder.Append("Mayo ");
                        break;
                    }
                case 6:
                    {
                        _ReturnStringBuilder.Append("Junio ");
                        break;
                    }
                case 7:
                    {
                        _ReturnStringBuilder.Append("Julio ");
                        break;
                    }
                case 8:
                    {
                        _ReturnStringBuilder.Append("Agosto ");
                        break;
                    }
                case 9:
                    {
                        _ReturnStringBuilder.Append("Septiembre ");
                        break;
                    }
                case 10:
                    {
                        _ReturnStringBuilder.Append("Octubre ");
                        break;
                    }
                case 11:
                    {
                        _ReturnStringBuilder.Append("Noviembre ");
                        break;
                    }
                case 12:
                    {
                        _ReturnStringBuilder.Append("Diciembre ");
                        break;
                    }
                default: { _ReturnStringBuilder.Append(""); break; }
            }
            #endregion
            _ReturnStringBuilder.Append("de " + DateTime.Now.Year.ToString());
            return _ReturnStringBuilder.ToString();
        }
        public static string GetFullDateToString(DateTime date)
        {
            _ReturnStringBuilder = new StringBuilder();
            #region Dias de la Semana
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    {
                        _ReturnStringBuilder.Append("Domingo, ");
                        break;
                    }
                case DayOfWeek.Monday:
                    {
                        _ReturnStringBuilder.Append("Lunes, ");
                        break;
                    }
                case DayOfWeek.Tuesday:
                    {
                        _ReturnStringBuilder.Append("Martes, ");
                        break;
                    }
                case DayOfWeek.Wednesday:
                    {
                        _ReturnStringBuilder.Append("Miércoles, ");
                        break;
                    }
                case DayOfWeek.Thursday:
                    {
                        _ReturnStringBuilder.Append("Jueves, ");
                        break;
                    }
                case DayOfWeek.Friday:
                    {
                        _ReturnStringBuilder.Append("Viernes, ");
                        break;
                    }
                case DayOfWeek.Saturday:
                    {
                        _ReturnStringBuilder.Append("Sábado, ");
                        break;
                    }
                default: { _ReturnStringBuilder.Append(""); break; }
            }
            #endregion
            _ReturnStringBuilder.Append(date.Day.ToString() + " de ");
            #region Mes
            switch (date.Month)
            {
                case 1:
                    {
                        _ReturnStringBuilder.Append("Enero ");
                        break;
                    }
                case 2:
                    {
                        _ReturnStringBuilder.Append("Febrero ");
                        break;
                    }
                case 3:
                    {
                        _ReturnStringBuilder.Append("Marzo ");
                        break;
                    }
                case 4:
                    {
                        _ReturnStringBuilder.Append("Abril ");
                        break;
                    }
                case 5:
                    {
                        _ReturnStringBuilder.Append("Mayo ");
                        break;
                    }
                case 6:
                    {
                        _ReturnStringBuilder.Append("Junio ");
                        break;
                    }
                case 7:
                    {
                        _ReturnStringBuilder.Append("Julio ");
                        break;
                    }
                case 8:
                    {
                        _ReturnStringBuilder.Append("Agosto ");
                        break;
                    }
                case 9:
                    {
                        _ReturnStringBuilder.Append("Septiembre ");
                        break;
                    }
                case 10:
                    {
                        _ReturnStringBuilder.Append("Octubre ");
                        break;
                    }
                case 11:
                    {
                        _ReturnStringBuilder.Append("Noviembre ");
                        break;
                    }
                case 12:
                    {
                        _ReturnStringBuilder.Append("Diciembre ");
                        break;
                    }
                default: { _ReturnStringBuilder.Append(""); break; }
            }
            #endregion
            _ReturnStringBuilder.Append("de " + date.Year.ToString());
            return _ReturnStringBuilder.ToString();
        }
        public static string GetIntervalosEntreFechas()
        {
            StringBuilder sDatos = new StringBuilder();
            sDatos.AppendLine(":: Intervalos de Tiempos >");
            sDatos.AppendLine("Días: " + DiferenciaEntreFechas.Days.ToString());
            sDatos.AppendLine("Horas: " + DiferenciaEntreFechas.Hours.ToString());
            sDatos.AppendLine("Minutos: " + DiferenciaEntreFechas.Minutes.ToString());
            sDatos.AppendLine("Segundos: " + DiferenciaEntreFechas.Seconds.ToString());
            sDatos.AppendLine(":: Intervalos de Tiempos Totales >");
            sDatos.AppendLine("Días: " + DiferenciaEntreFechas.TotalDays.ToString());
            sDatos.AppendLine("Horas: " + DiferenciaEntreFechas.TotalHours.ToString());
            sDatos.AppendLine("Minutos: " + DiferenciaEntreFechas.TotalMinutes.ToString());
            sDatos.AppendLine("Segundos: " + DiferenciaEntreFechas.TotalSeconds.ToString());
            return sDatos.ToString();
        }
        public static DateTime GetFechaFromString(string _Year, string _Month, string _Day) 
        {
            return new DateTime(int.Parse(_Year), int.Parse(_Month), int.Parse(_Day));
        }
        public static DateTime GetFechaFromString(string _Year, string _Month, string _Day, string _Hours, string _Minute)
        {
            return new DateTime(int.Parse(_Year), int.Parse(_Month), int.Parse(_Day),int.Parse(_Hours),int.Parse(_Minute),0);
        }
        public static int GetCurrentDay()
        {
            return System.DateTime.Now.Day;
        }
        public static int GetCurrentMonth()
        {
            return System.DateTime.Now.Month;
        }
        public static int GetCurrentYear()
        {
            return System.DateTime.Now.Year;
        }
        public static int GetEdad()
        {
            int anos = 0;
            // Edad en años
            anos = (int)(DiferenciaEntreFechas.Days / 365.25);
            return anos;
        }
        public static int GetLastDayOfMonth(int _Month, int _Year)
        {
            DateTime _D1, _D2;
            _D1 = Convert.ToDateTime("01/" + _Month + "/" + _Year);// pongo el 1 porque siempre es el primer día obvio
            if (_Month == 12)
            {
                _D2 = Convert.ToDateTime("01/01/" + (_Year + 1)).AddDays(-1); //resto un día al mes y con esto obtengo el ultimo día
            }
            else
            {
                _D2 = Convert.ToDateTime("01/" + (_Month + 1) + "/" + _Year).AddDays(-1); //resto un día al mes y con esto obtengo el ultimo día
            }
            return _D2.Day;
        }
        public static string GetTimeAgo(DateTime time)
        {
            DateTime startDate = DateTime.Now;
            TimeSpan deltaMinutes = startDate.Subtract(time);
            string distance = string.Empty;
            if (deltaMinutes.TotalMinutes <= (8724 * 60))
            {
                distance = GetDistanceOfTimeInWords(deltaMinutes.TotalMinutes);
                if (deltaMinutes.Minutes < 0)
                {
                    return distance + " from  now";
                }
                else
                {
                    return distance + " ago";
                }
            }
            else
            {
                return "on " + time.ToString();
            }
        }
        private static string GetDistanceOfTimeInWords(double minutes)
        {
            if (minutes < 1)
            {
                return "less than a minute";
            }
            else if (minutes < 50)
            {
                return minutes.ToString() + " minutes";
            }
            else if (minutes < 90)
            {
                return "about one hour";
            }
            else if (minutes < 1080)
            {
                return Math.Round(new decimal((minutes / 60))).ToString() + " hours";
            }
            else if (minutes < 1440)
            {
                return "one day";
            }
            else if (minutes < 2880)
            {
                return "about one day";
            }
            else
            {
                return Math.Round(new decimal((minutes / 1440))).ToString() + " days";
            }
        }

        public static string GetTimeAgoFull(DateTime dateFrom, DateTime dateTo)
        {

            // Defaults and assume if 0 is passed in that
            // its an error rather than the epoch

            if (dateFrom <= new DateTime(1900, 1, 1))
            {
                return "A long time ago";
            }

            if (dateTo == new DateTime(1900, 1, 1))
            {
                dateTo = System.DateTime.Now;
            }

            // Calculate the difference in seconds betweeen
            // the two timestamps
            TimeSpan difference;
            difference = dateTo - dateFrom;

            string interval = "";
            // If difference is less than 60 seconds,
            // seconds is a good interval of choice


            if (difference.Seconds < 60)
            {
                interval = "s";
            }

            // If difference is between 60 seconds and
            // 60 minutes, minutes is a good interval
            if (difference.Seconds >= 60 && difference.Seconds < 60 * 60)
            {
                interval = "n";
            }

            // If difference is between 1 hour and 24 hours
            // hours is a good interval
            if (difference.Seconds >= 60 * 60 && difference.Seconds < 60 * 60 * 24)
            {
                interval = "h";
            }

            // If difference is between 1 day and 7 days
            // days is a good interval
            if (difference.Seconds >= 60 * 60 * 24 && difference.Seconds < 60 * 60 * 24 * 7)
            {
                interval = "d";
            }

            // If difference is between 1 week and 30 days
            // weeks is a good interval
            if (difference.Seconds >= 60 * 60 * 24 * 7 && difference.Seconds < 60 * 60 * 24 * 30)
            {
                interval = "ww";
            }

            // If difference is between 30 days and 365 days
            // months is a good interval, again, the same thing
            // applies, if the 29th February happens to exist
            // between your 2 dates, the function will return
            // the 'incorrect' value for a day
            if (difference.Seconds >= 60 * 60 * 24 * 30 && difference.Seconds < 60 * 60 * 24 * 365)
            {
                interval = "m";
            }

            // If difference is greater than or equal to 365
            // days, return year. This will be incorrect if
            // for example, you call the function on the 28th April
            // 2008 passing in 29th April 2007. It will return
            // 1 year ago when in actual fact (yawn!) not quite
            // a year has gone by
            if (difference.Seconds >= 60 * 60 * 24 * 365)
            {
                interval = "y";
            }

            // Based on the interval, determine the
            // number of units between the two dates
            // From this point on, you would be hard
            // pushed telling the difference between
            // this function and DateDiff. If the $datediff
            // returned is 1, be sure to return the singular
            // of the unit, e.g. 'day' rather 'days'
            decimal months_difference, datediff;
            string res = "";
            switch (interval)
            {
                case "m":
                    {

                        months_difference = Math.Floor((decimal)(difference.Seconds / 60 / 60 / 24 / 29));
                        //while (mktime(date("H", $datefrom), date("i", $datefrom),
                        //  date("s", $datefrom), date("n", $datefrom) + ($months_difference),
                        //  date("j", $dateto), date("Y", $datefrom)) < $dateto) {

                        //  $months_difference++;
                        //}
                        datediff = months_difference;

                        // We need this in here because it is possible
                        // to have an 'm' interval and a months
                        // difference of 12 because we are using 29 days
                        // in a month

                        if (datediff == 12)
                        {
                            datediff--;


                            res = (datediff == 1) ? datediff.ToString() + " month ago" : datediff.ToString() + " months ago";
                        }
                    }
                    break;

                case "y":
                    {
                        datediff = Math.Floor((decimal)difference.Seconds / 60 / 60 / 24 / 365);
                        res = (datediff == 1) ? datediff.ToString() + " year ago" : datediff.ToString() + " years ago";
                    }
                    break;

                case "d":
                    {
                        datediff = Math.Floor((decimal)difference.Seconds / 60 / 60 / 24);
                        res = (datediff == 1) ? datediff.ToString() + " day ago" : datediff.ToString() + " days ago";
                    }
                    break;

                case "ww":
                    {
                        datediff = Math.Floor((decimal)difference.Seconds / 60 / 60 / 24 / 7);
                        res = (datediff == 1) ? datediff.ToString() + " week ago" : datediff.ToString() + " weeks ago";
                    }
                    break;

                case "h":
                    {
                        datediff = Math.Floor((decimal)difference.Seconds / 60 / 60);
                        res = (datediff == 1) ? datediff.ToString() + " hour ago" : datediff.ToString() + " hours ago";
                    }
                    break;

                case "n":
                    {
                        datediff = Math.Floor((decimal)difference.Seconds / 60);
                        res = (datediff == 1) ? datediff.ToString() + " minute ago" : datediff.ToString() + " minutes ago";
                    }
                    break;

                case "s":
                    {
                        datediff = difference.Seconds;
                        res = (datediff == 1) ? datediff.ToString() + " second ago" : datediff.ToString() + " seconds ago";
                    }
                    break;
            }
            return res;
        }


        public static string GetTimeAgo(DateTime fechadesde, DateTime fechahasta,Enumeracion.Date.TimeAgo literal)
        {
            //Comprobamos si la fechahasta es mayor que la fechadesde
            if (DateTime.Compare(fechahasta, fechadesde) >= 0)
            {
                TimeSpan ts = fechahasta.Subtract(fechadesde);

                switch (literal)
                {
                    case Enumeracion.Date.TimeAgo.Antes:
                        {

                            if (ts.Days > 0)
                            {
                                if (ts.Days > 1)
                                {
                                    return (ts.Days + " días antes");
                                }
                                else
                                {
                                    return (ts.Days + " día antes");
                                }
                            }
                            else
                            {

                                if (ts.Hours > 0)
                                {
                                    if (ts.Hours > 1)
                                    {
                                        return (ts.Hours + " horas antes");
                                    }
                                    else
                                    {
                                        return (ts.Hours + " hora antes");
                                    }
                                }
                                else
                                {
                                    if (ts.Minutes > 0)
                                    {
                                        if (ts.Minutes > 1)
                                        {
                                            return (ts.Minutes + " minutos antes");
                                        }
                                        else
                                        {
                                            return (ts.Minutes + " minuto antes");
                                        }
                                    }
                                    else
                                    {
                                        if (ts.Seconds > 0)
                                        {
                                            if (ts.Seconds > 1)
                                            {
                                                return (ts.Seconds + " segundos antes");
                                            }
                                            else
                                            {
                                                return (ts.Seconds + " segundo antes");
                                            }
                                        }

                                    }

                                }
                            }
                        }
                        break;
                    case Enumeracion.Date.TimeAgo.Hace:
                        {
                            if (ts.Days > 0)
                            {
                                if (ts.Days > 1)
                                {
                                    return ("hace " + ts.Days + " días");
                                }
                                else
                                {
                                    return ("hace " + ts.Days + " día");
                                }
                            }
                            else
                            {

                                if (ts.Hours > 0)
                                {
                                    if (ts.Hours > 1)
                                    {
                                        return ("hace " + ts.Hours + " horas");
                                    }
                                    else
                                    {
                                        return ("hace "+ ts.Hours + " hora");
                                    }
                                }
                                else
                                {
                                    if (ts.Minutes > 0)
                                    {
                                        if (ts.Minutes > 1)
                                        {
                                            return ("hace " + ts.Minutes + " minutos");
                                        }
                                        else
                                        {
                                            return ("hace " + ts.Minutes + " minuto");
                                        }
                                    }
                                    else
                                    {
                                        if (ts.Seconds > 0)
                                        {
                                            if (ts.Seconds > 1)
                                            {
                                                return ("hace " + ts.Seconds + " segundos");
                                            }
                                            else
                                            {
                                                return ("hace " + ts.Seconds + " segundo");
                                            }
                                        }

                                    }

                                }
                            }
                        }
                        break;
                }
                return "Compruebe las fechas";
            }
            else
            {

                return "Compruebe las fechas";

            }
        }
        #endregion
}