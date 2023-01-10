using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphTestProject
{
    public class Repository
    {
        private readonly List<Model> _models = new List<Model>();

        public Repository()
        {
            _models.Add(new Model
            {
                ID = "1",
                TotalPhotos = 5
            });

            _models.Add(new Model
            {
                ID = "2",
                TotalPhotos = 10
            });
        }

        public Task<Model> GetModel(string id)
        {
            return Task.FromResult(_models.FirstOrDefault(m => m.ID == id));
        }
    }
}
