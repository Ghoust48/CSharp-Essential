using System;

namespace Task_002
{
    public class Converter
    {
        private double _usd;
        private double _eur;
        private double _rub;
        
        public Converter(double usd, double eur, double rub)
        {
            _usd = usd;
            _eur = eur;
            _rub = rub;
        }

        public void ToUsd(double byn)
        {
            Console.WriteLine(byn / _usd);
        }
        
        public void FromUsd(double byn)
        {
            Console.WriteLine(byn *_usd);
        }
        
        public void ToEur(double byn)
        {
            Console.WriteLine(byn / _eur);
        }
        
        public void FromEur(double byn)
        {
            Console.WriteLine(byn *_eur);
        }
        
        public void ToRub(double byn)
        {
            Console.WriteLine(byn / _rub);
        }
        
        public void FromRub(double byn)
        {
            Console.WriteLine(byn *_rub);
        }
    }
}