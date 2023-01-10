using GraphQL.Instrumentation;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphTestProject
{
    public class TypeSchema : Schema
    {
        public TypeSchema(IServiceProvider provider) : base(provider)
        {
            Query = (AppQuery)provider.GetService(typeof(AppQuery)) ?? throw new InvalidOperationException();

            
            FieldMiddleware.Use(new InstrumentFieldsMiddleware());
        }
    }
}
