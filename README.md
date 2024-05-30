# TicketMaster

TicketMaster es una aplicación de escritorio en C# diseñada para gestionar boletos, calcular su costo y la fecha de regreso. La aplicación sigue una arquitectura limpia con separación de responsabilidades en varias capas: UI, BLL, DAL y DomainModel.

## Estructura del Proyecto

```plaintext
src/
├── Application/
│   ├── Services/
│   │   └── BoletoService.cs
│   └── Interfaces/
│       └── IBoletoService.cs
├── Domain/
│   ├── Entities/
│   │   ├── Boleto.cs
│   │   ├── Turista.cs
│   │   └── Ejecutivo.cs
│   └── Enums/
│       └── TipoBoleto.cs
├── TicketMaster/
│   ├── Controllers/
│   │   └── BoletoController.cs
│   └── Views/
│       └── MainForm.cs
├── Infrastructure/
│   ├── Repositories/
│   │   └── BoletoRepository.cs
│   └── Data/
│       └── BoletoContext.cs
└── Program.cs
```

### Descripción de las Capas

1. **Application (BLL)**:
   - Contiene la lógica de negocio de la aplicación.
   - Interactúa con la capa de dominio y la capa de infraestructura para procesar las solicitudes.

2. **Domain (DomainModel)**:
   - Define las entidades del dominio, las interfaces y las excepciones específicas del dominio.
   - Representa el núcleo de la aplicación.

3. **TicketMaster (UI)**:
   - Maneja la interfaz de usuario y la presentación de datos.
   - Contiene los controladores y vistas para la interacción con el usuario.

4. **Infrastructure (DAL)**:
   - Gestiona el acceso a los datos y la persistencia.
   - Implementa los repositorios y contextos de bases de datos.

## Configuración y Ejecución

### Prerrequisitos

- [.NET SDK](https://dotnet.microsoft.com/download) instalado en tu máquina.
- Un IDE como [Visual Studio](https://visualstudio.microsoft.com/) o [Visual Studio Code](https://code.visualstudio.com/).


## Uso de la Aplicación

1. **Añadir un Boleto**:
   - Ingrese los detalles del boleto en los campos correspondientes y haga clic en "Añadir".

2. **Actualizar un Boleto**:
   - Ingrese el número del boleto, modifique los detalles y haga clic en "Actualizar".

3. **Buscar un Boleto**:
   - Ingrese el número del boleto y haga clic en "Buscar" para ver los detalles.

4. **Eliminar un Boleto**:
   - Ingrese el número del boleto y haga clic en "Eliminar".

5. **Listar Todos los Boletos**:
   - Haga clic en "Listar" para ver todos los boletos registrados.
