using AutoMapper;
using TakeAway.Catalog.Dtos.CategoryDtos;
using TakeAway.Catalog.Dtos.FeatureDtos;
using TakeAway.Catalog.Dtos.ProductDtos;
using TakeAway.Catalog.Dtos.SliderDtos;
using TakeAway.Catalog.Entities;

namespace TakeAway.Catalog.Mapping
{
	public class GeneralMapping:Profile
	{
		public GeneralMapping() 
		{
			CreateMap<Category, CreateCategoryDto>().ReverseMap();
			CreateMap<Category, ResultCategoryDto>().ReverseMap();
			CreateMap<Category, UpdateCategoryDto>().ReverseMap();
			CreateMap<Category, GetByIdCategoryDto>().ReverseMap();

			CreateMap<Category, CreateProductDto>().ReverseMap();
			CreateMap<Category, ResultProductDto>().ReverseMap();
			CreateMap<Category, UpdateProductDto>().ReverseMap();
			CreateMap<Category, GetByIdProductDto>().ReverseMap();

			CreateMap<Category, CreateFeatureDto>().ReverseMap();
			CreateMap<Category, ResultFeatureDto>().ReverseMap();
			CreateMap<Category, UpdateFeatureDto>().ReverseMap();
			CreateMap<Category, GetByIdFeatureDto>().ReverseMap();

			CreateMap<Category, CreateSliderDto>().ReverseMap();
			CreateMap<Category, ResultSliderDto>().ReverseMap();
			CreateMap<Category, UpdateSliderDto>().ReverseMap();
			CreateMap<Category, GetByIdSliderDto>().ReverseMap();
		}
	}
}
