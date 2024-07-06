using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PersonApp.Core.DTO;
using PersonApp.Core.Entities.Abstract;
using PersonApp.Core.Entities.Concrete;
using PersonApp.DataAccess.Services.Interface;

namespace PersonApp.UI.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonRepository _personRepo;
        private readonly IMapper _mapper;

        public PersonController(IPersonRepository personRepo, IMapper mapper)
        {
            _personRepo = personRepo;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var people = await _personRepo.GetFilteredListAsync(
                select: x => _mapper.Map<PersonDTO>(x),
                where: x => x.Status != Status.Passive,
                orderBy: x => x.OrderByDescending(z => z.CreatedDate)
            );
            return View(people);
        }

        public async Task<IActionResult> Details(int id)
        {
            var person = await _personRepo.GetByIdAsync(id);

            var dto = _mapper.Map<PersonDTO>(person);

            if (dto is not null)
                return View(dto);

            return NotFound("Bu id'ye sahip kişi yok!");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(PersonDTO model)
        {
            if (model == null)
            {
                ModelState.AddModelError("", "Bir şeyler ters gitti!");
                return View(model);
            }

            if (await _personRepo.AnyAsync(x => x.Email == model.Email))
            {
                ModelState.AddModelError("", "Bu email adresi kullanılmaktadır. Başka bir email adresi seçiniz!");
                return View(model);
            }

            var person = _mapper.Map<Person>(model);

            await _personRepo.AddAsync(person);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var person = await _personRepo.GetByIdAsync(id);

            if (person == null)
            {
                return NotFound("Bu id'ye sahip kişi yok!");
            }

            var dto = _mapper.Map<PersonDTO>(person);
            return View(dto);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PersonDTO model)
        {
            if (model == null)
            {
                ModelState.AddModelError("", "Bir şeyler ters gitti!");
                return View(model);
            }

            if (await _personRepo.AnyAsync(x => x.Email == model.Email && x.Id != model.Id))
            {
                ModelState.AddModelError("", "Bu email adresi kullanılmaktadır. Başka bir email adresi seçiniz!");
                return View(model);
            }

            if (!await _personRepo.AnyAsync(x => x.Id == model.Id && x.Status != Status.Passive))
            {
                return NotFound("Bu id'ye sahip kişi bulunamadı!");
            }

            var entity = await _personRepo.GetByIdAsync(model.Id);

            var person = _mapper.Map<Person>(model);
            person.CreatedDate = entity.CreatedDate;

            await _personRepo.UpdateAsync(person);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var person = await _personRepo.GetByIdAsync(id);

            if (person == null)
            {
                return NotFound("Kişi bulunamadı!");
            }

            return View(person);
        }

        [HttpPost, ActionName("DeleteConfirmed")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var person = await _personRepo.GetByIdAsync(id);

            if (person == null)
            {
                return NotFound("Kişi bulunamadı!");
            }

            await _personRepo.DeleteAsync(person);
            return RedirectToAction(nameof(Index));
        }

    }
}
