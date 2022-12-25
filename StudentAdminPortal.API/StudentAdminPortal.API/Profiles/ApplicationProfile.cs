using AutoMapper;

namespace StudentAdminPortal.API.Profiles
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Models.Student,StudentAdminPortal.ViewModels.Student>().ReverseMap();
            CreateMap<Models.Gender, StudentAdminPortal.ViewModels.Gender>().ReverseMap();
            CreateMap<Models.Address, StudentAdminPortal.ViewModels.Address>().ReverseMap();
        }
    }
}
