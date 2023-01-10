using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphTestProject
{
    public class AppQuery: ObjectGraphType<object>
    {
        public AppQuery(Repository repository)
        {
            Name = "Query";

            FieldAsync<ModelType>("ModelType", "Return ModelType", resolve:async context => repository.GetModel("2"));
        }
    }
}
