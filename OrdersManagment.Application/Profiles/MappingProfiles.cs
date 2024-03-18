using AutoMapper;
using OrdersManagment.Application.DTOs.Customer;
using OrdersManagment.Application.DTOs.Employees;
using OrdersManagment.Application.DTOs.Supplier;
using OrdersManagment.Domain;


namespace OrdersManagment.Application.Profiles
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Employee, GetEmployeesListDto>();
            CreateMap<Employee, GetEmployeeByIdDto>();
            CreateMap<CreateEmployeeDto, Employee>();

            CreateMap<Customer, GetCustomersListDto>();
            CreateMap<Employee, GetCustomerByIdDto>();
            CreateMap<CreateCustomerDto, Customer>();

            CreateMap<Supplier, GetSupplierListDto>();
            CreateMap<Supplier, GetSupplierByIdDto>();
            CreateMap<CreateSupplierDto, Supplier>();
        }
       
    }
}
