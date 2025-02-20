using Microsoft.AspNetCore.Mvc;
using PhoneBook.Domain.Contrasts.People;
using PhoneBook.Domain.Contrasts.Tags;
using PhoneBook.Domain.Entities.People;
using PhoneBook_Project.Models.People;

namespace PhoneBook_Project.Controllers
{
    public class PeopleController : Controller
    {
        private readonly ITagRepository _tagRepository;
        private readonly IPersonRespository _personRespository;

        public PeopleController(ITagRepository tagRepository, IPersonRespository personRespository)
        {
            _tagRepository = tagRepository;
            _personRespository = personRespository;
        }

        public IActionResult Index()
        {
            var people = _personRespository.GetAll().ToList();
            return View(people);
        }

        public IActionResult Add()
        {
            AddNewPersonDisplayViewModel viewModel = new AddNewPersonDisplayViewModel();
            viewModel.TagsForDisplay = _tagRepository.GetAll().ToList();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Add(AddNewPersonGetViewModel person)
        {
            if (ModelState.IsValid)
            {
                var personModel = new Person
                {
                    Address = person.Address,
                    Email = person.Email,
                    FirstName = person.FirstName,
                    LastName = person.LastName,
                    PersonTags = new List<PersonTag>(person.SelectedTag.Select(c => new PersonTag
                    {
                        TagId = c
                    }).ToList())
                };
                _personRespository.Add(personModel);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
