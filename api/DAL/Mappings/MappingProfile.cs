

using api.DAL.data;
using api.DAL.dtos;
using api.DAL.helpers;
using AutoMapper;

namespace api.DAL.Mappings
{

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Cardio, CardioDetailsDTO>();
           /*  .ForMember(dest => dest.patient_gender, opt => opt.MapFrom(src => src.patient_gender.getGenderDescription()));*/

            CreateMap<CardioDetailsDTO, Cardio>()
            .ForMember(dest => dest.hemodynamics, src => src.Ignore()); 
           // .ForMember(dest => dest.patient_gender, opt => opt.MapFrom(src => src.patient_gender.getGenderCode())); 

            CreateMap<Cardio, HemoForReturnDTO>();
            CreateMap<hospitalForUpdateDTO, hospital>();
            // .ForMember(dest => dest.Id, src => src.Ignore()); 
            


            CreateMap<User, UserForReturnDto>()
            .ForMember(dest => dest.center_id, opt => opt.MapFrom(src => src.center_id.getHospitalName())); 







        }
    }


}