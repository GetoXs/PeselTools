using System;

namespace PeselTools
{
    public interface IPesel
    {
        string Value { get; }

        DateTime BirthDate { get; }

        PeselSex Sex { get; }
    }

    public enum PeselSex
    {
        Male = 1,
        Female = 2
    }
}