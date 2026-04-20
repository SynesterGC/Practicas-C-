using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using Biblioteca2nd;

namespace Biblioteca2nd
{
    public interface IBorrowed
    {
        bool Lend(User borrower);
        void Return(User borrower);
    }
}


