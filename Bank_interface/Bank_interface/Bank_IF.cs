﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_interface
{
    interface Bank_IF
    {
        bool Deposit(decimal amount);
        bool Withdraw(decimal amount);
    }
}
