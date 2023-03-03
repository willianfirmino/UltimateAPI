using AutoMapper;
using Contracts;
using Service.Contracts;

namespace Service;

public sealed class EmployeeService : IEmployeeService
{
    private readonly IRepositoryManager _repository;
    public ILoggerManager Logger { get; }
    private readonly IMapper _mapper;
    public EmployeeService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _mapper = mapper;
        Logger = logger;
        _repository = repository;
    }
}
