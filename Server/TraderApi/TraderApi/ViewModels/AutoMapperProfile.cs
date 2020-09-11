using AutoMapper;
using DAL.Entities;

namespace TraderApi.ViewModels
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<StockDetail, StockDetailViewModel>().ReverseMap();
            CreateMap<StockTransaction, StockTransactionViewModel>().ReverseMap();
            CreateMap<UserDetail, UserDetailViewModel>().ReverseMap();
        }
    }
}
