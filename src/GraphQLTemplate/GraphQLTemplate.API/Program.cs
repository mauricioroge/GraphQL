using GraphQLTemplate.GraphQLQueries.QueriesType;
using GraphQLTemplate.Services;
using GraphQLTemplate.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
services.AddTransient<ICustomerService, CustomerService>();

services.AddGraphQLServer()
    .RegisterService<ICustomerService>()
    .AddQueryType<CustomerQueryType>();


var app = builder.Build();

app.MapGraphQL();
app.Run();
