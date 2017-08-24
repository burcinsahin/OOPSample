﻿namespace OOPSample.Sample0
{
    public abstract class Person
    {
        private string _name;
        private string _surname;
        private byte _age;

        public string Name
        {
            get { return _name; }
        }

        public string Surname
        {
            get { return _surname; }
        }

        public string FullName
        {
            get { return $"{Name} {Surname}"; }
        }

        public byte Age
        {
            get { return _age; }
        }

        public Person(string name, string surname) : this(name, surname, 0)
        {
        }

        public Person(string name, string surname, byte age)
        {
            _name = name;
            _surname = surname;
            _age = age;
        }
    }
}
