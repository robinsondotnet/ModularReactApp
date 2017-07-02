using System;
using System.Collections.Generic;
using app.utils.Providers;

public class StubServiceProvider : IServiceProvider
{
    private Dictionary<Type, object> _services;

    public void AppendService(Type type, object service)
    {
        if (_services == null)
            _services = new Dictionary<Type, object>();

        _services.Add(type, service);
    }

    public object GetService(Type serviceType)
    {
        var foundService = _services[serviceType];

        if (foundService != null) return foundService;

        if (serviceType == typeof(IResponseProvider)) return new RemoteResponseProvider();

        throw new InvalidOperationException();
    }
}