﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GestionCovid.Entities.Common
{
    public class ObjectNotFoundException : ArgumentException
    {
        public ObjectNotFoundException(string msg = null, ArgumentException inner = null) : base("La entidad no existe", inner)
        {

        }

    }
}
