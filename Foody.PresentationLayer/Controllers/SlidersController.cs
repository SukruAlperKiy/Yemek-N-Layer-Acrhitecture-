using AutoMapper;
using Foody.BusinessLayer.Abstract;
using Foody.DtoLayer.Dtos.SliderDtos;
using Foody_EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers
{
    public class SlidersController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IMapper _mapper;

        public SlidersController(ISliderService sliderService123, IMapper mapper123)
        {
            _sliderService = sliderService123;
            _mapper = mapper123;
        }

        public IActionResult SliderList()
        {
            var values123 = _sliderService.TGetAll();
            return View(_mapper.Map<List<ResultSliderDto>>(values123));
        }

        [HttpGet]
        public IActionResult CreateSlider()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CreateSlider(CreateSliderDto createSliderDto)
        {
            var value999 = _mapper.Map<Slider>(createSliderDto);
            _sliderService.TInsert(value999);
            return RedirectToAction("SliderList");
        }

        public IActionResult DeleteSlider(int id)
        {
            _sliderService.TDelete(id);
            return RedirectToAction("SliderList");

        }

        [HttpGet]
        public IActionResult UpdateSlider(int id)
        {
            var value777 = _sliderService.TGetById(id);
            return View(_mapper.Map<GetByIdSliderDto>(value777));
        }

        [HttpPost]
        public IActionResult UpdateSlider(UpdateSliderDto updateSliderDto)
        {
            var value000 = _mapper.Map<Slider>(updateSliderDto);
            _sliderService.TUpdate(value000);
            return RedirectToAction("SliderList");
        }
    }
}
