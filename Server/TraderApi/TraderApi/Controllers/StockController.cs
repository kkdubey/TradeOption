using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TraderApi.ViewModels;


namespace TraderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {

        private IStockManager _stockManager;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public StockController(IMapper mapper, IStockManager stockManager, ILogger<StockController> logger)
        {
            _stockManager = stockManager;
            _mapper = mapper;
            _logger = logger;
        }

        // GET: api/<UserController>
        /// <summary>
        /// Get All stocks
        /// </summary>
        /// <returns>Return list of all stocks</returns>
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<StockDetailViewModel>))]
        public async Task<IActionResult> Get()
        {
            _logger.LogInformation("Log Info");
            _logger.LogWarning("Log Warning");
            _logger.LogError("Log Error..");
            var stocks = await _stockManager.GetStocksAsync();
            return Ok(_mapper.Map<List<StockDetailViewModel>>(stocks));
        }

        // GET api/<StcokController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(StockDetailViewModel))]
        public async Task<IActionResult> Get(int id)
        {
            var stock = await _stockManager.GetStockByIdAsync(id);
            return Ok(_mapper.Map<StockDetailViewModel>(stock));
        }

        // POST api/<StcokController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StcokController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StcokController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
