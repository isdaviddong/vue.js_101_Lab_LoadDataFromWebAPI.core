using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace test01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            string JSON = @"
[
            {
                'ID': 3,
                'title': '總裁', 'name': 'Eric', 'PictureURL': 'https://i.imgur.com/uxvy97n.png', 'Phone': '0912345678',
                'Address': '新竹市大同區二三五路四號六樓',
                'Memo': '澳洲來的人', 'isValid': true
            },
            {
                'ID': 4,
                'title': '瑪農', 'name': 'David', 'PictureURL': 'https://i.imgur.com/qsQcoGh.png', 'Phone': '0987654321',
                'Address': '台北市信義區忠孝東路231號3樓',
                'Memo': '充滿活力的廉價勞工', 'isValid': true
            },
            {
                'ID': 5,
                'title': 'Boss', 'name': 'Amy', 'PictureURL': 'https://i.imgur.com/dfww1JX.png', 'Phone': '0912121121',
                'Address': '高雄市仁義區六六路3號23樓',
                'Memo': '小資女', 'isValid': true
            }
        ]
";
            var dat = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Employee>>(JSON);
            return dat;
        }
    }

    public class Employee
    {
        public int id { get; set; }
        public string title { get; set; }
        public string name { get; set; }
        public string pictureURL { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string memo { get; set; }
        public bool isValid { get; set; }
    }
}
