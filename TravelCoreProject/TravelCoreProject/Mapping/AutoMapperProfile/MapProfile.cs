using AutoMapper;
using DTOLayer.AnnouncementDTOs;
using DTOLayer.AppUserDTOs;
using EntityLayer.Concreate;

namespace TravelCoreProject.Mapping.AutoMapperProfile
{
    public class MapProfile :Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncementAddDTOs, Announcement>();
            CreateMap<Announcement, AnnouncementAddDTOs>();

            CreateMap<LoginRegisterAppModelAddDTOs, AppUser>();
            CreateMap<AppUser, LoginRegisterAppModelAddDTOs>();

            CreateMap<UserRegisterAppModelAddDTOs,AppUser>();
            CreateMap<AppUser, UserRegisterAppModelAddDTOs>();

            CreateMap<AnnouncementListDTOs, Announcement>();
            CreateMap<Announcement, AnnouncementListDTOs>();

            CreateMap<AnnouncementAddDTOs, Announcement>();
            CreateMap<Announcement, AnnouncementAddDTOs>();

            CreateMap<AnnouncementUppdateDTOs, Announcement>();
            CreateMap<Announcement, AnnouncementUppdateDTOs>();

        }
    }
}
