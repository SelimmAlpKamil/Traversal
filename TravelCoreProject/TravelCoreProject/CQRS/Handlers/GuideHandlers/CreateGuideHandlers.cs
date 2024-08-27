using DataAccessLayer.Concreate;
using EntityLayer.Concreate;
using MediatR;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using TravelCoreProject.CQRS.Commands.GuideCommand;

namespace TravelCoreProject.CQRS.Handlers.GuideHandlers
{
    public class CreateGuideHandlers : IRequestHandler<CreateGuideCommand>
    {
        private readonly Context _context;

        public CreateGuideHandlers(Context context)
        {
            _context = context;
        }

        public  async Task<Unit> Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
            _context.Guides.Add(new Guide
            {
                GuideName = request.GuideName,
                GuideDescripton = request.GuideDescripton,
                GuideImage = request.GuideImage,
                GuideInstagramURL = request.GuideInstagramURL,
                GuideStatus = true,
                GuideXURL = request.GuideXURL,

            });
            _context.SaveChanges();


            return Unit.Value;
        }
    }
}
