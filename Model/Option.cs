﻿namespace Shared_Static_Class.Models
{
    public class Option<T>
    {
        public Option(T value, string text)
        {
            Value = value;
            Text = text;
        }

        public T Value { get; set; }
        public string Text { get; set; } = string.Empty;
    }
}
