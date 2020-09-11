using AutoMapper;
using BLL.Interfaces;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using TraderApi.Controllers;
using TraderApi.ViewModels;

namespace TraderApi.Tests
{
    [TestClass]
    public class StockControllerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task GetAllStocks_ShouldReturnStocks()
        {
            var mock = new Mock<IStockManager>();
            var stockDetailsMock = GetMockData();
            mock.Setup(p => p.GetStocksAsync())
                .ReturnsAsync(stockDetailsMock);
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfile());
            });
            var mapper = mockMapper.CreateMapper();
            StockController stockController = new StockController(mapper, mock.Object);
            var actionResult = await stockController.Get().ConfigureAwait(false);
            var result = actionResult as ObjectResult;
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(1, (result.Value as IList<StockDetailViewModel>).Count);
        }

        [Test]
        public async Task GetStockById_TakeStockId_ShouldReturnStockById()
        {
            var mock = new Mock<IStockManager>();
            var stockDetailsMock = GetMockData();
            mock.Setup(p => p.GetStockByIdAsync(It.IsAny<int>()))
                .ReturnsAsync(stockDetailsMock.First());
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfile());
            });
            var mapper = mockMapper.CreateMapper();
            StockController stockController = new StockController(mapper, mock.Object);
            var actionResult = await stockController.Get(1).ConfigureAwait(false);
            var result = actionResult as ObjectResult;
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result.Value);
        }

        [TearDown]
        public void TearDownMethod()
        {

        }

        private IList<StockDetail> GetMockData()
        {
            return new List<StockDetail>() {
                new StockDetail()
                {
                    StockID = 1,
                    StockName = "Test",
                    StockQuantity = 100
                }
            };
        }
    }
}
