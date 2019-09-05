using System.Collections.Generic;
using ZooKeeperServer.Models;

namespace ZooKeeperServer.Services
{
    public class LabellingService : ILabellingService
    {
        public LabellingService()
        {
        }

        public IEnumerable<Label> LabelImage(string base64Image)
        {
            return new List<Label>();
        }
    }
}