﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace XIIRPL2_02_Ticketing
{
    class koneksi
    {
        public static NpgsqlConnection conn = new NpgsqlConnection("Server:127.0.0.1;Port=5432;Database=db_ticket_XII_RPL_2_02;User id=postgres;Password=admin;");
    }
}
