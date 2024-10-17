using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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

builder.Services.AddCors(options =>
{
    options.AddPolicy("corsPolicy", policy =>
    {
        policy.AllowAnyOrigin();
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
    });
});

#region AppRepository
builder.Services.AddScoped<IDiagnosisRepository, DiagnosisRepository>();
builder.Services.AddScoped<IFoliosRepository, FoliosRepository>();
builder.Services.AddScoped<IGroupsRepository, GroupsRepository>();
builder.Services.AddScoped<IHeadqueartersRepository, HeadqueartersRepository>();
builder.Services.AddScoped<IIncomesRepository, IncomesRepository>();
builder.Services.AddScoped<IMedicationsRepository, MedicationsRepository>();
builder.Services.AddScoped<INurseNoteRepository, NurseNoteRepository>();
builder.Services.AddScoped<IPatientRecordsRepository, PatientRecordsRepository>();
builder.Services.AddScoped<IPatientsRepository, PatientsRepository>();
builder.Services.AddScoped<IPermitionsRepository, PermitionsRepository>();
builder.Services.AddScoped<IPerXGroupsRepository, PerXGroupsRepository>();
builder.Services.AddScoped<ISignsRepository, SignsRepository>(); 
builder.Services.AddScoped<ISpecialitiesRepository, SpecialitiesRepository>();
builder.Services.AddScoped<IStaffRepository, StaffRepository>();
builder.Services.AddScoped<ISuppliesPatientsRepository, SuppliesPatientsRepository>();
builder.Services.AddScoped<ITipDocsRepository, TipDocsRepository>();
builder.Services.AddScoped<IUsersLogsRepository, UsersLogsRepository>();
builder.Services.AddScoped<IUsersRepository, UsersRepository>();
#endregion                

#region AppService
builder.Services.AddScoped<IDiagnosisService, DiagnosisService>();
builder.Services.AddScoped<IFoliosService, FoliosService>();
builder.Services.AddScoped<IGroupsService, GroupsService>();
builder.Services.AddScoped<IHeadqueartersService, HeadqueartersService>();
builder.Services.AddScoped<IIncomesService, IncomesService>();
builder.Services.AddScoped<IMedicationsService, MedicationsService>();
builder.Services.AddScoped<INurseNoteService, NurseNoteService>();
builder.Services.AddScoped<IPatientRecordsService, PatientRecordsService>();
builder.Services.AddScoped<IPatientsService, PatientsService>();
builder.Services.AddScoped<IPermitionsService, PermitionsService>();
builder.Services.AddScoped<IPerXGroupsService, PerXGroupsService>();
builder.Services.AddScoped<ISignsService, SignsService>();
builder.Services.AddScoped<ISpecialitiesService, SpecialitiesService>();
builder.Services.AddScoped<IStaffService, StaffService>();
builder.Services.AddScoped<ISuppliesPatientsService, SuppliesPatientsService>();
builder.Services.AddScoped<ITipDocsService, TipDocsService>();
builder.Services.AddScoped<IUsersLogsService, UsersLogsService>();
builder.Services.AddScoped<IUsersService, UsersService>();
#endregion                

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
