using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("TestDrivenDevelopment")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("TestDrivenDevelopment")]
[assembly: AssemblyCopyright("Copyright ©  2019")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("28a8eccd-0d98-4be2-8d72-26fe7abf8ffd")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

namespace TestDrivenDevelopment
{
    public class Rooter
    {
        /*
        public double SquareRoot(double input)
        {
            if (input <= 0.0)
            {
                throw new ArgumentOutOfRangeException();
            }
            double result = input;
            double previousResult = -input;
            while (Math.Abs(previousResult - result) > result / 1000)
            {
                previousResult = result;
                result = result - (result * result - input) / (2 * result);
            }
            return result;
        }
        */
        public double SquareRoot(double input)
        {
            if (input <= 0.0)
            {
                throw new ArgumentOutOfRangeException();
            }

            double result = input;
            double previousResult = -input;
            while (Math.Abs(previousResult - result) > result / 1000)
            {
                previousResult = result;
                result = (result + input / result) / 2;
                //was: result = result - (result * result - input) / (2*result);
            }
            return result;
        }
    }
}