using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using TraderApi.ViewModels;

namespace TraderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockTransactionController : ControllerBase
    {
        private IStockTransactionManager _stockTransactionManager;
        private readonly IMapper _mapper;
        public StockTransactionController(IMapper mapper, IStockTransactionManager stockTransactionManager)
        {
            _stockTransactionManager = stockTransactionManager;
            _mapper = mapper;
        }

        // GET: api/<StockTransactionController>
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<StockTransactionViewModel>))]
        public async Task<IActionResult> GetAsync()
        {
            var transactions = await _stockTransactionManager.GetStockTransactionsAsync();
            return Ok(_mapper.Map<List<StockTransactionViewModel>>(transactions));
        }

        // GET api/<StockTransactionController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(StockTransactionViewModel))]
        public async Task<IActionResult> GetAsync(int id)
        {
            var transaction = await _stockTransactionManager.GetStockTransactionByIdAsync(id);
            return Ok(_mapper.Map<StockTransactionViewModel>(transaction));
        }

        // GET api/<StockTransactionController>/getTransactionByUserId/5
        [HttpGet("getTransactionByUserId/{id}")]
        [ProducesResponseType(200, Type = typeof(StockTransactionViewModel))]
        public async Task<IActionResult> getTransactionByUserId(int id)
        {
            var transaction = await _stockTransactionManager.GetStockTransactionsByUserIdAsync(id);
            return Ok(_mapper.Map<StockTransactionViewModel>(transaction));
        }

        // POST api/<StockTransactionController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StockTransactionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StockTransactionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
