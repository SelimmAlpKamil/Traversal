using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelCoreProject.CQRS.Commands.DestinatonCommand;
using TravelCoreProject.CQRS.Handlers.DestinationHandlers;
using TravelCoreProject.CQRS.Queries.DestinatonQueries;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class DestinatonCQRSController : Controller
    {
        private readonly GetAllDestinatonQueriesHandlers _getAllDestinatonQueriesHandlers;

        private readonly GetByIdDestinatonHandlers _getByIdDestinatonHandlers;

        private readonly CreateDestinationHandlers _createDestinationHandlers;

        private readonly DeleteDestinatonHandler _deleteDestinatonHandler;

        private readonly UpdateDestinationHandlers _updateDestinationHandlers;

        public DestinatonCQRSController(GetAllDestinatonQueriesHandlers getAllDestinatonQueriesHandlers, GetByIdDestinatonHandlers getByIdDestinatonHandlers, CreateDestinationHandlers createDestinationHandlers, DeleteDestinatonHandler deleteDestinatonHandler, UpdateDestinationHandlers updateDestinationHandlers)
        {
            _getAllDestinatonQueriesHandlers = getAllDestinatonQueriesHandlers;
            _getByIdDestinatonHandlers = getByIdDestinatonHandlers;
            _createDestinationHandlers = createDestinationHandlers;
            _deleteDestinatonHandler = deleteDestinatonHandler;
            _updateDestinationHandlers = updateDestinationHandlers;
        }

        public IActionResult Index()
        {
            var valuesList = _getAllDestinatonQueriesHandlers.Handler();

            return View(valuesList);
        }

        [HttpGet]
        public IActionResult GetByIDList(int id)
        {
            var value = _getByIdDestinatonHandlers.Handler(new GetByIdDestinatonQueries(id));

            return View(value);
        }
        [HttpPost]
        public IActionResult GetByIDList(UpdateDestinationCommand commnet)
        {
            _updateDestinationHandlers.Handler(commnet);

            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult AddDestinaton()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDestinaton(CreateDestinationCommand p)
        {
             _createDestinationHandlers.Handler(p);

            return RedirectToAction("index");
        }


        public IActionResult DeleteDestinaton(int id)
        {
           _deleteDestinatonHandler.Handler(new DeleteDestinatonCommand(id));

            return RedirectToAction("index");
        }


    }
}

