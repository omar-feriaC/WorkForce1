using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkForce1API.Utils;
using static WorkForce1API.Utils.ClsResponseModel;

namespace WorkForce1API.TestCase
{
    public class API_Test
    {

        public IntakeResponse SetupAPI(string EndPoint, string JsonFile)
        {
            IntakeResponse iresponse;
            var json = File.ReadAllText($@"{clsConstants.JsonPath}{JsonFile}");
            ClsRest rest = new ClsRest(clsConstants.BaseURL);
            rest.AddHeader("Authorization", clsConstants.Token);
            HTTP_RESPONSE resp = rest.POST(EndPoint, json.ToString());
            return iresponse = JsonConvert.DeserializeObject<IntakeResponse>(resp.MessageBody);
        }


        [Test]
        public void TC1_GetTask()
        {
            var response = SetupAPI("GetTasks", "ZZ.json");
        }

        [Test]
        public void TC2_GetTask()
        {
            var response = SetupAPI("GetTasks", "ZZ.json");
        }

        [Test]
        public void TC3_GetTask()
        {
            var response = SetupAPI("GetTasks", "ZZ.json");
        }

    }
}
