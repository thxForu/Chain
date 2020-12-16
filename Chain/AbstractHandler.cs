using System;

namespace Chain
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        object Handler(object request);
    }
    
    public class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;
        
        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public virtual object Handler(object request)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handler(request);
            }
            else
            {
                return null;
            }
        }
    }
}