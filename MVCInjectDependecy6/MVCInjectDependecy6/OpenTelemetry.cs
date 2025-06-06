using System;

namespace MVCInjectDependecy6
{
    public interface ITransient
    { 
    }

    public interface IScoped
    {
    }

    public interface ISinglenton    
    {
    }

    public class OpenTelemetry : ITransient, ISinglenton, IScoped
    {
        public readonly int Value;
        public OpenTelemetry() { 
            Value = new Random().Next(56);

        }

    }
}
