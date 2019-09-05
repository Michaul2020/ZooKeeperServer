using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ZooKeeperServer.Models;
// using ZooKeeperServer.Services;

namespace ZooKeeperServer.Controllers
{
    [Route("/api/[controller]")]
    public class LabelsController : ControllerBase
    {
        // ILabellingService _labellingService;
        public LabelsController(/*LabellingService labellingService*/)
        {
            // _labellingService = labellingService;
        }

        [HttpPost]
        public IEnumerable<Label> LabelImage(string base64Image)
        {
            Label DummyLabel1 = new Label { Name = "Cat", Probability = (float)0.5 };
            Label DummyLabel2 = new Label { Name = "Dog", Probability = (float)0.98 };
            Label DummyLabel3 = new Label { Name = "Abomination", Probability = (float)0.35 };

            IList<Label> labels = new List<Label>();
            labels.Add(DummyLabel1);
            labels.Add(DummyLabel2);
            labels.Add(DummyLabel3);

            return labels;

            // return _labellingService.LabelImage(base64Image);
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}