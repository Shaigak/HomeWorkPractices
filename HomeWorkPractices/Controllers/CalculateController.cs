using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPractices.Controllers
{
    public class CalculateController
    {

        private readonly ICalculateService _service;

        public CalculateController()
        {
            _service = new CalculateSevice();
        }
    
    public void MultiplyArrayItem()=> Console.WriteLine(_service.MultiplyArrayItems(GetArr()));            

    public void SquareOfSumArrayItems() => Console.WriteLine(_service.SquareOfSumArrayItems(GetArr()));
       
    private int[] GetArr()=> new[] { 1, 2, 3, 5, 6, 7 };

    }
}
