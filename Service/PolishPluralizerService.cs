using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.Service
{
    internal class PolishPluralizerService
    {
        private string singularNominative;
        private string pluralNominative;
        private string pluralGenitive;

        public PolishPluralizerService(
            string singularNominative,
            string pluralNominative,
            string pluralGenitive)
        {
            this.singularNominative = singularNominative;
            this.pluralNominative = pluralNominative;
            this.pluralGenitive = pluralGenitive;
        }

        public string Pluralize(int count)
        {
            if (count == 1)
            {
                return this.singularNominative;
            }
            else if (count % 10 >= 2 && count % 10 <= 4 && (count % 100 < 10 || count % 100 >= 20))
            {
                return this.pluralNominative;
            }
            else
            {
                return this.pluralGenitive;
            }
        }
    }
}
