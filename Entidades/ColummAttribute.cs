using System;

namespace Entidades.Entidades
{
    internal class ColummAttribute : Attribute
    {
        private string v;

        public ColummAttribute(string v)
        {
            this.v = v;
        }
    }
}