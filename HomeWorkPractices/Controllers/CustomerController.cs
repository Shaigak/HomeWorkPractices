using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPractices.Controllers
{
    public class CustomerController
    {
        private readonly ICustomerService _service;
        public CustomerController()
        {
            _service = new CustomerService();
        }

        public void GetCustomerCountByFiltered()=> Console.WriteLine(_service.GetCustomerCountByFiltered());

        public void GetCustomerAverageByAges()=> Console.WriteLine(_service.GetCustomerAverageByAges());

        public void GetCustomersByFiltered()
        {
            int startAge = 22;
            int endAge = 30;
            _service.GetCustomersByFiltered(startAge, endAge);
            var result=_service.GetCustomersByFiltered(startAge, endAge);

            int shaigAge=0;
            int pervinAge=0;

            foreach (var item in result)
            {
                string name = null;
                if(item!=null)
                {
                    //Console.WriteLine($"{item.Id} {item.Name} {item.Surname} {item.Age} {item.Position}");
                    if (item.Name == "Shaiq")
                    {
                        shaigAge=item.Age;
                    }else if (item.Name == "Pervin")
                    {
                        pervinAge=item.Age;
                    }                   
                }      
            }
            Console.WriteLine(shaigAge >= pervinAge);
        }
    }
}
