using System.Net;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Database;
using WebApplication1.Figures;
using WebApplication1.RequestModels;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FigureController : ControllerBase
    {
     
        private readonly FigureDbContext  _context;

        public FigureController(FigureDbContext context)
        {
            _context = context;
        }

        List<Figure> figlist = MenuActions.ReadFromFile();

        [HttpGet]
        public IEnumerable<Figure> Get()
        {
            return figlist;
        }


        [HttpGet(("{id}"))]
        public IActionResult GetByID(int id)
        {
            var figure = figlist.Find(s => s.Id == id);
            if (figure == null) return NotFound();
            return Ok(figure);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var figure = figlist.Find(s => s.Id == id);
            if (figure == null) return NotFound();
            figlist.Remove(figure);
            MenuActions.SaveToFile("figure.json",figlist);
            return Ok(figure);
        }


        [HttpPost("CreateCircle")] 
        public IActionResult PostCircle(double centerX,double centerY,double coordinateX,double coordinateY)
        {
            Circle crc1 = new Circle(new List<Point>()
              {
             new Point(centerX,centerY),
             new Point(coordinateX,coordinateY)
              });
            figlist.Add(crc1);
            MenuActions.SaveToFile("figure.json", figlist);
            return Ok();
        }

        [HttpPost("CreateTriangle")]
        public IActionResult PostSquare(TriangleRequestModel requestModel)
        {
            Triangle trngl1 = new Triangle(new List<Point>()
            {
            new Point(requestModel.firstCoordinateX,requestModel.firstCoordinateY),
            new Point(requestModel.secondCoordinateX,requestModel.secondCoordinateY),
            new Point(requestModel.thirdCoordinateX,requestModel.thirdCoordinateY)
            });
            figlist.Add(trngl1);
            MenuActions.SaveToFile("figure.json", figlist);
            return Ok();
        }

        [HttpPost("CreateSquare")] 
        public IActionResult PostSquare(SquareRequestModel requestModel)
        {
            Square sq1 = new Square(new List<Point>()
            {
            new Point(requestModel.firstCoordinateX,requestModel.firstCoordinateY),
            new Point(requestModel.secondCoordinateX,requestModel.secondCoordinateY),
            new Point(requestModel.thirdCoordinateX,requestModel.thirdCoordinateY),
            new Point(requestModel.fourthCoordinateX,requestModel.fourthCoordinateY)
            });
            figlist.Add(sq1);
            MenuActions.SaveToFile("figure.json", figlist);
            return Ok();
        }

        [HttpPost("CreateRectangle")]
        public IActionResult PostRectangle(RectangleRequestModel requestModel)
        {
            Rectangle rect1 = new Rectangle(new List<Point>()
            {
             new Point(requestModel.firstCoordinateX,requestModel.firstCoordinateY),
            new Point(requestModel.secondCoordinateX,requestModel.secondCoordinateY),
            new Point(requestModel.thirdCoordinateX,requestModel.thirdCoordinateY),
            new Point(requestModel.fourthCoordinateX,requestModel.fourthCoordinateY)
            });
            figlist.Add(rect1);
            MenuActions.SaveToFile("figure.json", figlist);
            return Ok();
        }


        [HttpPatch("RotateFigure/{id}")] 
        public IActionResult RotateFigure(int id,double rotationDegree)
        {
            if (id == null || id == 0)
                return BadRequest();

            var figure = figlist.Find(s => s.Id == id);
            if (figure == null)
                return NotFound();
            else
            {
                figlist[id-1].RotateFigure(rotationDegree);
            }
            MenuActions.SaveToFile("figure.json", figlist);
            return Ok();
        }

        [HttpPatch("ScaleFigure/{id}")]
        public IActionResult ScaleFigure(int id, double scaleMultiplier)
        {
            if (id == null || id == 0)
                return BadRequest();

            var figure = figlist.Find(s => s.Id == id);
            if (figure == null)
                return NotFound();
            else
            {
                figlist[id - 1].ScaleFigure(scaleMultiplier);
            }
            MenuActions.SaveToFile("figure.json", figlist);
            return Ok();
        }

        [HttpPatch("MoveFigure/{id}")]
        public IActionResult MoveFigure(int id, double coordinateX, double coordinateY)
        {
            if (id == null || id == 0)
                return BadRequest();

            var figure = figlist.Find(s => s.Id == id);
            if (figure == null)
                return NotFound();
            else
            {
                figlist[id - 1].MoveFigure(coordinateX, coordinateY);
            }
            MenuActions.SaveToFile("figure.json", figlist);
            return Ok();
        }

    }
}