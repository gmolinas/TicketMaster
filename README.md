# TicketMaster

TicketMaster es una aplicación de escritorio en C# diseñada para gestionar boletos, calcular su costo y la fecha de regreso. La aplicación sigue una arquitectura limpia con separación de responsabilidades en varias capas: UI, BLL, DAL y DomainModel.

## Estructura del Proyecto

```plaintext
src/
├── Application/
│   ├── Common/
│   │    └── Interfaces
│   │            └── Interfaces generales ...
│   └── Interfaces/
│        └── UseCase
│              └── casos de uso ...
├── Domain/
│   ├── Entities/
│   │    ├── Boleto.cs
│   │    ├── Turista.cs
│   │    └── Ejecutivo.cs
│   ├── Enums/
│   │    └── TipoBoleto.cs
│   ├── Dtos/
│   └── Common/
│       
├── TicketMaster/
│   ├── Controllers/
│   │    └── BoletoController.cs
│   └── Views/
│        └── FormPrincipal.cs
│ 
├── Infrastructure/
│   ├── Repositories/
│   │    ├── MemoryDataRepository
│   │    ├── RepositoryFactory
│   │    └── SqlDataRepository.cs
│   └── Extensions/
│        └── ServiceCollectionExtensions.cs
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



## Uso de la Aplicación

1. **Añadir un Boleto**:
   - Ingrese los detalles del boleto en los campos correspondientes y haga clic en "Añadir".

2. **Actualizar un Boleto**:
   - Ingrese el número del boleto, modifique los detalles y haga clic en "Actualizar".

3. **Buscar un Boleto**:
   - Ingrese el número del boleto y haga clic en "Buscar" para ver los detalles.

4. **Eliminar un Boleto**:
   - Ingrese el número del boleto y haga clic en "Eliminar".


### Patrones de Diseño Utilizados

1. **Patrón Abstract Factory**:
   - **Dónde**: En la clase `BoletoRepositoryFactory`.
   - **Descripción**: Este patrón se utiliza para crear familias de objetos relacionados sin especificar sus clases concretas. La fábrica abstrae el proceso de creación del repositorio, permitiendo cambiar el backend sin cambiar el código del cliente.

2. **Patrón Repository**:
   - **Dónde**: En las interfaces y clases `IBoletoRepository` e `InMemoryBoletoRepository`.
   - **Descripción**: Este patrón se utiliza para encapsular el acceso a los datos, proporcionando una interfaz para realizar operaciones sobre los datos (CRUD: Crear, Leer, Actualizar, Eliminar). Esto aísla la lógica de negocio de la lógica de acceso a datos.

3. **Patrón Factory Method**:
   - **Dónde**: En los constructores de las clases `Turista` y `Ejecutivo` que heredan de `Boleto`.
   - **Descripción**: Este patrón se utiliza para delegar la creación de objetos a las subclases. Las clases `Turista` y `Ejecutivo` implementan su propia lógica de construcción.

4. **Patrón Strategy**:
   - **Dónde**: En los métodos `CalcularRegreso` y `CostoBoleto` de las clases `Turista` y `Ejecutivo`.
   - **Descripción**: Este patrón permite definir una familia de algoritmos, encapsular cada uno de ellos y hacerlos intercambiables. Tanto `Turista` como `Ejecutivo` tienen diferentes implementaciones para calcular el costo del boleto y la fecha de regreso.

5. **Patrón Template Method**:
   - **Dónde**: Implícitamente en la clase abstracta `Boleto` con métodos que deben ser implementados por las subclases (`CalcularRegreso` y `CostoBoleto`).
   - **Descripción**: Este patrón define el esqueleto de un algoritmo en una operación, delegando algunos pasos a las subclases. Permite que las subclases redefinan ciertos pasos de un algoritmo sin cambiar su estructura.

6. **Patrón Singleton** (Potencialmente):
   - **Dónde**: Podría aplicarse a la clase `InMemoryBoletoRepository` si se quisiera asegurar que solo exista una instancia del repositorio en memoria.
   - **Descripción**: Este patrón asegura que una clase tenga solo una instancia y proporciona un punto de acceso global a ella.
