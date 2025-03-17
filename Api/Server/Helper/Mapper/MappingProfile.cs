namespace Server.Helper.Mapper
{
    using AutoMapper;
    using Domain.Model.Entity;
    using Persistence.ViewModel.Response;

    public class MappingProfile : Profile
    {
        #region Constractor

        public MappingProfile()
        {
            MapModelToView();
            MapViewToModel();
        }

        #endregion

        #region Private function

        private void MapModelToView()
        {
            CreateMap<User, UserDetailsVM>()
                .ForMember(udv => udv.Id, mf => mf.MapFrom(u => u.Id))
                .ForMember(udv => udv.Email, mf => mf.MapFrom(u => u.Email))
                .ForMember(udv => udv.Name, mf => mf.MapFrom(u => u.Name))
                .ForMember(udv => udv.UpdatedBy, mf => mf.MapFrom(u => u.UpdatedBy))
                .ForMember(udv => udv.UpdatedOn, mf => mf.MapFrom(u => u.UpdatedOn))
                .ForMember(udv => udv.CreatedOn, mf => mf.MapFrom(u => u.CreatedOn))
                .ForMember(udv => udv.CreatedBy, mf => mf.MapFrom(u => u.CreatedBy));
        }


        private void MapViewToModel()
        {
            CreateMap<UserDetailsVM, User>()
                .ForMember(udv => udv.Id, mf => mf.MapFrom(u => u.Id))
                .ForMember(udv => udv.Email, mf => mf.MapFrom(u => u.Email))
                .ForMember(udv => udv.Name, mf => mf.MapFrom(u => u.Name))
                .ForMember(udv => udv.UpdatedBy, mf => mf.MapFrom(u => u.UpdatedBy))
                .ForMember(udv => udv.UpdatedOn, mf => mf.MapFrom(u => u.UpdatedOn))
                .ForMember(udv => udv.CreatedOn, mf => mf.MapFrom(u => u.CreatedOn))
                .ForMember(udv => udv.CreatedBy, mf => mf.MapFrom(u => u.CreatedBy));
        }

        #endregion

    }
}
