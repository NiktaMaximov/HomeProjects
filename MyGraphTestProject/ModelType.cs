using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphTestProject
{
    public class ModelType: ObjectGraphType<Model>
    {
        public ModelType()
        {
            Name = "Model";

            Field(tm => tm.ID).Description("ID");
            Field(tm => tm.TotalPhotos).Description("Общее количество фотографий");
        }
    }
}
