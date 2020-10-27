﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GestionCovid.Entities.Common
{
    public class InvalidRoleException : ArgumentException
    {
        public InvalidRoleException(string msg = null, ArgumentException inner = null) : base("El rol ingresado no existe", inner)
        {

        }
    }
}
