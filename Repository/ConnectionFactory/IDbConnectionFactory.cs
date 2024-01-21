﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ConnectionFactory
{
    public interface IDbConnectionFactory
    {
        SqlConnection GetConnection();
    }
}
