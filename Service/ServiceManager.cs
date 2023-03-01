using Service.Contracts;

namespace Service;

public sealed class ServiceManager : IServiceManager
{
    public ServiceManager()
    {
    }

    public ICompanyService CompanyService => throw new NotImplementedException();

    public IEmployeeService EmployeeService => throw new NotImplementedException();
}
