using GraphQL;
using GraphQLTemplate.GraphQLQueries.Queries;
using GraphQLTemplate.GraphQLQueries.Schemas;
using GraphQLTemplate.Services;
using GraphQLTemplate.Services.Interfaces;

namespace GraphQLTemplate.GraphAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // add execution components
            services.AddGraphQL(builder => builder
            .AddSystemTextJson()
            .AddSchema<CustomersSchema>()
            .AddGraphTypes(typeof(CustomersQuery).Assembly));

            // add something like repository
            services.AddTransient<ICustomerService, CustomerService>();

            // add infrastructure stuff
            services.AddHttpContextAccessor();
            //services.AddLogging(builder => builder.AddConsole());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseGraphQLGraphiQL();
        }
    }
}
