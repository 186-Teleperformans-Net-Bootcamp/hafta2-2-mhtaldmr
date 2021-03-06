# TP .Net Week 2 Part 2

This project is an example of using  Entity Framwork6.

### What I have used so far:
- Asp.Net Core Web API with `.Net6.0` framework.
- EntityFramwork6 as an ORM and Tools packages.
- MSSQL Server as an Database and SQLServer packages.

## Requirements
- Creating a SchoolDB with code-first approach.
- Each Student has only one School and one Classroom.
- Each Teacher has only one Course.
- Classrooms can have one or more Courses.
- Create the classes and make migrations.

## Installation and Usage

To get the project :
```
    git clone https://github.com/186-Teleperformans-Net-Bootcamp/hafta2-2-mhtaldmr.git
```
To reach the project folder :
```
    cd hafta2-2-mhtaldmr 
    cd MuhammetAliDemir.TP.Net.Hw2.Part2
```
To run the project:
- If you are using the Visual Studio, just press **F5** or press **Start Debugging**.

- If you are using terminal : 
```
    dotnet run
```
- For Creating the DB and sending datas : 
```
    update-database
```

## Implementations

- Adding Configuration String
```c
	"ConnectionStrings": {
    	"DefaultConnection": "Server=.\\SQLExpress; Database=SchoolDB; Trusted_Connection=Yes;"
  	}
```

- Adding the SQL server to program.cs
```c
	var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
	builder.Services.AddDbContext<SchoolDBContext>(options => options.UseSqlServer(connectionString));	
```

- Adding a base class which has Id and Name.
```c
	public abstract class BaseEntity
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Column(Order =1)]
        public string Name { get; set; }
    }
```

- Creating Classroom and also using it to connect Students and Courses.
```c
	 public class Classroom : BaseEntity
    {
        public List<Course> Courses { get; set; }
        public List<Student> Students { get; set; }
    }
```

---