﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace System.XML_Example
{
    [Serializable()]
    public class Telefone
    {

        public Telefone() { }

        public Telefone(int tipo, string numero)
        {
            Tipo = tipo;
            Numero = numero;
        }

        [XmlElement("Tipo")]
        public int Tipo { get; set; }
        [XmlElement("Numero")]
        public string Numero { get; set; }

    }
}
