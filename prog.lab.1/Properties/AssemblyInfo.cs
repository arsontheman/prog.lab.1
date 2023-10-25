using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;

public class Polynomial
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }
    public double D { get; set; }

    public Polynomial(double a, double b, double c, double d)
    {
        A = a;
        B = b;
        C = c;
        D = d;
    }

    public double Evaluate(double x)
    {
        return A * Math.Pow(x, 3) + B * Math.Pow(x, 2) + C * x + D;
    }

    public Polynomial Add(Polynomial other)
    {
        return new Polynomial(A + other.A, B + other.B, C + other.C, D + other.D);
    }

    public Polynomial Subtract(Polynomial other)
    {
        return new Polynomial(A - other.A, B - other.B, C - other.C, D - other.D);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("{0}x^3", A);
        if (B != 0) sb.AppendFormat(" + {0}x^2", B);
        if (C != 0) sb.AppendFormat(" + {0}x", C);
        if (D != 0) sb.AppendFormat(" + {0}", D);
        return sb.ToString();
    }
}