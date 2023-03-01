using Contracts;
using Service.Contracts;

namespace Service;

public sealed class EmployeeService : IEmployeeService
{
    private readonly IRepositoryManager _repository;
    public ILoggerManager Logger { get; }
    public EmployeeService(IRepositoryManager repository, ILoggerManager logger)
    {
        Logger = logger;
        _repository = repository;
    }
}
