using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NurseNotes.Context;
using NurseNotes.Model;
using NurseNotes.Repositorio;
using NurseNotes.Services;

var builder = WebApplication.CreateBuilder(args);

// Configura la cadena de conexión a la base de datos
var constring = builder.Configuration.GetConnectionString("Connection");
builder.Services.AddDbContext<TestDbNurseNotes>(options => options.UseSqlServer(constring));

// Configuración de CORS para permitir acceso desde el frontend
builder.Services.AddCors(options =>
{
    options.AddPolicy("corsPolicy", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Registro de Repositorios
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
builder.Services.AddScoped<IScoresRepository, ScoresRepository>();
#endregion                

// Registro de Servicios
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
builder.Services.AddScoped<IScoresService, ScoresService>();

// Servicio de Autenticación
builder.Services.AddScoped<IAuthService, AuthService>();
#endregion                

// Agrega controladores y Swagger para documentación de la API
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configuración de CORS
app.UseCors("corsPolicy");

// Configuración del pipeline de peticiones HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Comentado temporalmente si tienes problemas de redirección en localhost
// app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();

app.Run();
