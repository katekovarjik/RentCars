﻿using eUseControl.BussinesLogic.Interfaces;
using eUseControl.BussinesLogic.MainBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eUseControl.BussinesLogic
{
    public class BussinesLogic
    {
        public ISession GetSessionBL() 
        {
            return new SessionBL();
        }

    }
}