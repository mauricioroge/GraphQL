using GraphQL;
using GraphQLTemplate.GraphQLQueries.Queries;
using GraphQLTemplate.GraphQLQueries.Schemas;
using GraphQLTemplate.Services;
using GraphQLTemplate.Services.Interfaces;

namespace GraphQLTemplate.API
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
            .AddErrorInfoProvider((opts, serviceProvider) =>
            {

                opts.ExposeExceptionDetails = true;
            })
            .AddSchema<CustomersSchema>()
            .AddGraphTypes(typeof(CustomersQuery).Assembly));
            
            // add something like repository
            services.AddTransient<ICustomerService, CustomerService>();

            // add infrastructure stuff
            services.AddHttpContextAccessor();
            services.AddLogging(builder => builder.AddConsole());

            // add options configuration
            //services.Configure<GraphQLSettings>(Configuration);
            //services.Configure<GraphQLSettings>(settings => settings.BuildUserContext = ctx => new GraphQLUserContext { User = ctx.User });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //    app.UseDeveloperExceptionPage();

            //app.UseMiddleware<GraphQLMiddleware>();
            //app.UseGraphQLPlayground();
            app.UseGraphQLGraphiQL();
            //app.UseGraphQLAltair();
            //app.UseGraphQLVoyager();
        }
    }
}
