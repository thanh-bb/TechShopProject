//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using NetTopologySuite.Features;
//using NetTopologySuite.Index.HPRtree;
//using NetTopologySuite.IO;
//using TechShop.API.Data;
//using TechShop.API.Extensions;
//using TechShop.API.Repositories;
//using TechShop.API.Repositories.Contracts;

//namespace TechShop.API.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class MapController : ControllerBase
//    {
//        private readonly MapDbContext _context;

//        public MapController(MapDbContext context)
//        {
//            _context = context;
//        }

//        [HttpGet("GetData")]
//        public IActionResult GetData(string q)
//        {
//            IQueryable<Dulieumau> data;
//            if (q == "ALL")
//            {
//                data = _context.Dulieumaus;
//            }
//            else
//            {
//                data = _context.Dulieumaus.Where(e => e.Id.ToString() == q);
//            }

//            var featureCollection = new FeatureCollection();

//            foreach (var item in data)
//            {
//                var attr = new AttributesTable();
//                attr.Add("name", item.Name);
//                attr.Add("id", item.Id);
//                var fearure = new Feature(item.TheGeom, attr);
//                featureCollection.Add(fearure);
//            }

//            var w = new GeoJsonWriter();
//            return Ok(w.Write(featureCollection));
//        }


//        //private readonly IMapRepository _mapRepository;

//        //public MapController(IMapRepository mapRepository)
//        //{
//        //    _mapRepository = mapRepository;
//        //}

//        //[HttpGet]
//        //public async Task<IActionResult> GetData()
//        //{
//        //    var post = await _mapRepository.GetData();

//        //    return Ok(post);

//        //}
//    }
//}
