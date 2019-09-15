using System.Collections.Generic;

namespace TheWeatherman.Common.Result
{
    public interface IResult
    {
        IDictionary<string, string[]> Errors { get; }
        bool Succeeded { get; }
        
        void AddError(string errorKey, List<string> errorDescriptions);
    }
    
    public interface IResult<out T> : IResult
    {
        T Value { get; }
    }
}