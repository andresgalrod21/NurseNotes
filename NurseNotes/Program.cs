using Microsoft.EntityFrameworkCore;
using NurseNotes.Context;
using NurseNotes.Model;
using NurseNotes.Repositorio;
using NurseNotes.Services;
//using static NurseNotes.Repositorio.IUsersRepository;
//using static NurseNotes.Services.ISpecialitiesService;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var constring = builder.Configuration.GetConnectionString("Connection");
builder.Services.AddDbContext<TestDbNurseNotes>(options => options.UseSqlServer(constring));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region AppRepository
builder.Services.AddScoped<IDiagnosisRepository, IDiagnosisRepository>();
builder.Services.AddScoped<IFoliosRepository, IFoliosRepository>();
builder.Services.AddScoped<IGroupsRepository, IGroupsRepository>();
builder.Services.AddScoped<IHeadqueartersRepository, IHeadqueartersRepository>();
builder.Services.AddScoped<IIncomesRepository, IIncomesRepository>();
builder.Services.AddScoped<IMedicationsRepository, IMedicationsRepository>();
builder.Services.AddScoped<INurseNoteRepository, INurseNoteRepository>();
builder.Services.AddScoped<IPatientRecordsRepository, IPatientRecordsRepository>();
builder.Services.AddScoped<IPatientsRepository, IPatientsRepository>();
builder.Services.AddScoped<IPermitionsRepository, IPermitionsRepository>();
builder.Services.AddScoped<IPerXGroupsRepository, IPerXGroupsRepository>();
builder.Services.AddScoped<ISignsRepository, ISignsRepository>();
builder.Services.AddScoped<ISpecialitiesRepository, ISpecialitiesRepository>();
builder.Services.AddScoped<IStaffRepository, IStaffRepository>();
builder.Services.AddScoped<ISuppliesPatientsRepository, ISuppliesPatientsRepository>();
builder.Services.AddScoped<ITipDocsRepository, ITipDocsRepository>();
builder.Services.AddScoped<IUsersLogsRepository, IUsersLogsRepository>();
builder.Services.AddScoped<IUsersRepository, IUsersRepository>();
#endregion                

#region AppService
builder.Services.AddScoped<IDiagnosisService, IDiagnosisService>();
builder.Services.AddScoped<IFoliosService, IFoliosService>();
builder.Services.AddScoped<IGroupsService, IGroupsService>();
builder.Services.AddScoped<IHeadqueartersService, IHeadqueartersService>();
builder.Services.AddScoped<IIncomesService, IIncomesService>();
builder.Services.AddScoped<IMedicationsService, IMedicationsService>();
builder.Services.AddScoped<INurseNoteService, INurseNoteService>(); 
builder.Services.AddScoped<IPatientRecordsService, IPatientRecordsService>();
builder.Services.AddScoped<IPatientsService, IPatientsService>();
builder.Services.AddScoped<IPermitionsService, IPermitionsService>();
builder.Services.AddScoped<IPerXGroupsRepository, IPerXGroupsRepository>();
builder.Services.AddScoped<ISignsService, ISignsService>();
builder.Services.AddScoped<ISpecialitiesService, ISpecialitiesService>();
builder.Services.AddScoped<IStaffService, IStaffService>();
builder.Services.AddScoped<ISuppliesPatientsService, ISuppliesPatientsService>();
builder.Services.AddScoped<ITipDocsService, ITipDocsService>();
builder.Services.AddScoped<IUsersLogsService, IUsersLogsService>();
builder.Services.AddScoped<IUsersService, IUsersService>();
#endregion                

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
